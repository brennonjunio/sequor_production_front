using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private async void button2_Click(object sender, EventArgs e)
        {
            var listarOrder = await GetOrder();

            dataGridViewOrderns.DataSource = listarOrder;

            configureGrade();
        }

        private void configureGrade()
        {
            dataGridViewOrderns.ForeColor = Color.Black;

            dataGridViewOrderns.ColumnHeadersDefaultCellStyle.Font = new Font(
                "Arial",
                9,
                FontStyle.Bold
            );
            dataGridViewOrderns.RowHeadersWidth = 25;

            dataGridViewOrderns.Columns["order"].HeaderText = "Id da Ordem";
            dataGridViewOrderns.Columns["quantity"].HeaderText = "Quantidade";
            dataGridViewOrderns.Columns["productCode"].HeaderText = "Código do Produto";
            dataGridViewOrderns.Columns["productDescription"].HeaderText = "Descrição";
            dataGridViewOrderns.Columns["image"].HeaderText = "Imagem";
            dataGridViewOrderns.Columns["cycleTime"].HeaderText = "Ciclo";

            // Adicionar uma coluna para exibir os materiais
            DataGridViewTextBoxColumn materialsColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Materiais",
                Name = "materials",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            dataGridViewOrderns.Columns.Add(materialsColumn);

            // Preencher os dados da grade
            foreach (DataGridViewRow row in dataGridViewOrderns.Rows)
            {
                OrderModel order = (OrderModel)row.DataBoundItem;
                string materialsString = string.Join(
                    ", ",
                    order.Materials.Select(m => $"{m.MaterialCode}: {m.MaterialDescription}  ")
                );
                row.Cells["materials"].Value = materialsString;
            }
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
                    List<OrderModel> orders = JsonConvert.DeserializeObject<List<OrderModel>>(
                        dataToken.ToString()
                    );
                    return orders;
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

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderns.Rows.Count > 0)
            {
                var id = Convert.ToString(dataGridViewOrderns.CurrentRow.Cells["order"].Value);

                if (id != null)
                {
                    ModalOrdens modalOrdens = new ModalOrdens(id);
                    modalOrdens.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(
                    "Primeiro Selecione uma Ordem",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void catchData() { }
    }
}
