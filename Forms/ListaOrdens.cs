using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using sequorTesteSelecao.Models;


namespace sequorTesteSelecao.Forms
{
    public partial class ListaOrdens : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly string apiUrl = "https://localhost:7067/api/Orders/GetOrders";
        public ListaOrdens()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {

            var listarOrder = await GetOrder();

            dataGridViewOrderns.DataSource = listarOrder;

            configureGrade();
        }


        private void configureGrade()
        {
            dataGridViewOrderns.ForeColor = Color.Black;

            dataGridViewOrderns.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridViewOrderns.RowHeadersWidth = 25;

            dataGridViewOrderns.Columns["order"].HeaderText = "Id da Ordem";
            dataGridViewOrderns.Columns["quantity"].HeaderText = "Quantidade";
            dataGridViewOrderns.Columns["productCode"].HeaderText = "Código do Produto";
            dataGridViewOrderns.Columns["productDescription"].HeaderText = "Descrição";
            dataGridViewOrderns.Columns["image"].HeaderText = "Imagem";
            dataGridViewOrderns.Columns["cycleTime"].HeaderText = "Ciclo";

        }


        public async Task<List<OrderModel>> GetOrder()
        {
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject jsonResponse = JObject.Parse(responseBody);


            if (jsonResponse.TryGetValue("orders", out JToken dataToken))
            {
                if (dataToken != null)
                {
                    List<OrderModel> order = JsonConvert.DeserializeObject<List<OrderModel>>(dataToken.ToString());
                    return order;
                }
                else
                {
                    // Handle the case where "orders" key exists but the value is null
                    return new List<OrderModel>();
                }
            }
            else
            {
                // Handle the case where "orders" key is not found
                return null;
            }
        }

        private void BtnProducao_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderns.Rows.Count > 0 && dataGridViewOrderns.SelectedRows.Count > 0)
            {
                // Obter os valores da linha selecionada

                DataGridViewRow selectedRow = dataGridViewOrderns.SelectedRows[0];
                string order = selectedRow.Cells["order"].Value.ToString();
                string quantity = selectedRow.Cells["quantity"].Value.ToString();

                // Criar uma instância da RequestProduction com os valores obtidos
                RequestProduction requestProd = new RequestProduction(order, quantity);
                requestProd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Primeiro Selecione uma Ordem", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
