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

            string description = ObterDescricaoDaResposta(resposta);

            MessageBox.Show($"{description}");
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
                textBoxCodigoMaterial.Text = ordemFiltrada.Materials.ToString();

                string materiaisString = string.Join(
                    ", ",
                    ordemFiltrada.Materials.Select(
                        m => $"{m.MaterialCode}: {m.MaterialDescription}"
                    )
                );
                textBoxCodigoMaterial.Text = materiaisString;
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

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
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

                if (jsonResponse.TryGetValue("description", out JToken descriptionToken))
                {
                    return (string)descriptionToken;
                }
                else
                {
                    return "Descrição não encontrada na resposta.";
                }
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
    }
}
