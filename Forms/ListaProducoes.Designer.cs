namespace sequorTesteSelecao.Forms
{
    partial class ListaProducoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProducoes = new DataGridView();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducoes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducoes
            // 
            dataGridViewProducoes.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewProducoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducoes.Location = new Point(123, 219);
            dataGridViewProducoes.Name = "dataGridViewProducoes";
            dataGridViewProducoes.RowTemplate.Height = 25;
            dataGridViewProducoes.Size = new Size(545, 182);
            dataGridViewProducoes.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // ListaProducoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(dataGridViewProducoes);
            Name = "ListaProducoes";
            Text = "Lista de Produções";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducoes;
        private Button btnVoltar;
        private Button btnLancar;
    }
}