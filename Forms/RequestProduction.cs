using System.Text;
using Newtonsoft.Json.Linq;
using Timer = System.Windows.Forms.Timer;

namespace sequorTesteSelecao.Forms
{
    public partial class ModalOrdens : Form
    {
        private string _id;
        private static DateTime startTime;
        private Timer timer;
        private string tempo;

        private readonly string apiUrl = "https://localhost:7067/api/Orders/SetProduction";

        public ModalOrdens(string id)
        {
            InitializeComponent();
            _id = id;
            startTime = DateTime.Now;

            startTime = DateTime.Now;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            getDados();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private async void button1_Click(object sender, EventArgs e)
        {
            var requestData = new
            {
                email = textBoxEmail.Text,
                order = textBoxOrdemId.Text,
                productionDate = textBoxDataProducao.Text,
                productionTime = textBoxTempoProducao.Text,
                quantity = textBoxQuantidade.Text,
                materialCode = textBoxCodigoMaterial.Text,
                cycleTime = tempo
            };

            string resposta = await EnviarRequisicaoPost(apiUrl, requestData);
            Console.WriteLine(resposta);

            string description = ObterDescricaoDaResposta(resposta);

            if (JObject.Parse(resposta)["type"]?.ToString() == "E")
            {
                MessageBox.Show($"{description}");
            }
            else
            {
                MessageBox.Show($"{description}");
                this.Hide();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            labelTempo.Text = $"Tempo de Ciclo: {elapsedTime.ToString(@"hh\:mm\:ss")}";

            double elapsedSeconds = elapsedTime.TotalSeconds;

            tempo = $"{elapsedTime.TotalSeconds:F2}".Replace(',', '.');
        }

        private void textBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e teclas de controle (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void getDados()
        {
            ListaOrdens listaOrdens = new();
            var listaCompleta = await listaOrdens.GetOrder();

            var ordemFiltrada = listaCompleta.FirstOrDefault(item => item.Order == _id);

            if (ordemFiltrada != null)
            {
                textBoxQuantidade.Text = ordemFiltrada.Quantity.ToString();
                textBoxOrdemId.Text = ordemFiltrada.Order.ToString();

                // Limpa os itens existentes no CheckedListBox
                checkedMaterials.Items.Clear();

                // Adiciona os materiais ao CheckedListBox
                foreach (var material in ordemFiltrada.Materials)
                {
                    // Adiciona o item exibido no CheckedListBox
                    checkedMaterials.Items.Add(
                        $"{material.MaterialDescription} ({material.MaterialCode})"
                    );
                }

                // Evento para tratar a mudança de seleção no CheckedListBox
                checkedMaterials.ItemCheck += (sender, e) =>
                {
                    // Desativa todos os outros itens
                    for (int i = 0; i < checkedMaterials.Items.Count; i++)
                    {
                        if (i != e.Index)
                        {
                            checkedMaterials.SetItemChecked(i, false);
                        }
                    }

                    // Preenche o textBoxCodigoMaterial com o código do material selecionado
                    if (e.NewValue == CheckState.Checked)
                    {
                        string selectedMaterial = checkedMaterials.Items[e.Index].ToString();
                        string codigoMaterial = selectedMaterial.Substring(
                            selectedMaterial.LastIndexOf("(") + 1,
                            selectedMaterial.Length - selectedMaterial.LastIndexOf("(") - 2
                        );

                        // Preenche o textBoxCodigoMaterial com o código do material selecionado
                        textBoxCodigoMaterial.Text = codigoMaterial;
                    }
                    else
                    {
                        // Se desmarcar, limpa o textBoxCodigoMaterial
                        textBoxCodigoMaterial.Text = string.Empty;
                    }
                };
            }
            else
            {
                MessageBox.Show("Order Não encontrada");
            }
        }

        private async Task<string> EnviarRequisicaoPost(string apiUrl, object data)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                    StringContent content = new StringContent(
                        jsonData,
                        Encoding.UTF8,
                        "application/json"
                    );

                    HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                return $"Erro na requisição: {ex}";
            }
        }

        private string ObterDescricaoDaResposta(string response)
        {
            try
            {
                JObject jsonResponse = JObject.Parse(response);

                jsonResponse.TryGetValue("description", out JToken descriptionToken);

                return (string)descriptionToken;
            }
            catch (Exception ex)
            {
                return $"Erro ao obter descrição da resposta: {ex}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxCodigoMaterial_TextChanged(object sender, EventArgs e) { }
    }
}
