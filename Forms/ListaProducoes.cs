using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sequorTesteSelecao.Forms.Login;



namespace sequorTesteSelecao.Forms
{
    public partial class ListaProducoes : Form
    {
        private List<Production> productions;
        public ListaProducoes(List<Production> productions)
        {
            InitializeComponent();
            this.productions = productions;
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridViewProducoes.DataSource = productions;

            dataGridViewProducoes.Columns["order"].HeaderText = "Id da Ordem";
            dataGridViewProducoes.Columns["date"].HeaderText = "Data";
            dataGridViewProducoes.Columns["quantity"].HeaderText = "Quantidade";
            dataGridViewProducoes.Columns["materialCode"].HeaderText = "Código do material";
            dataGridViewProducoes.Columns["cycleTime"].HeaderText = "Ciclo";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

       
    }
}
