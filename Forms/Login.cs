using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using sequorTesteSelecao.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sequorTesteSelecao.Forms
{
    public partial class Login : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string apiUrl = "https://localhost:7067/api/Orders/GetProduction?email=" + email;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                      
                        string responseData = await response.Content.ReadAsStringAsync();
                        var productionResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductionResponse>(responseData);

                  
                        ListaProducoes listaProducoesForm = new ListaProducoes(productionResponse.Productions);
                        listaProducoesForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        string errorData = await response.Content.ReadAsStringAsync();
                        var errorResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(errorData);

                        MessageBox.Show($"Erro {errorResponse.Status}: {errorResponse.Description}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro na requisição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }



        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Certifique-se de liberar os recursos do HttpClient quando o formulário for fechado
            httpClient.Dispose();
        }


        public class ErrorResponse
        {
            public string Status { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
        }

        public class ProductionResponse
        {
            public string Status { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public List<Production> Productions { get; set; }
        }

        public class Production
        {
            public string Order { get; set; }
            public DateTime Date { get; set; }
            public double Quantity { get; set; }
            public string MaterialCode { get; set; }
            public double CycleTime { get; set; }
        }

    }
}
