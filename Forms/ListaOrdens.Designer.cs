namespace sequorTesteSelecao.Forms
{
    partial class ListaOrdens
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
            dataGridViewOrderns = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            BtnProducao = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderns).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOrderns
            // 
            dataGridViewOrderns.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewOrderns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderns.Location = new Point(73, 83);
            dataGridViewOrderns.Name = "dataGridViewOrderns";
            dataGridViewOrderns.RowTemplate.Height = 25;
            dataGridViewOrderns.Size = new Size(627, 296);
            dataGridViewOrderns.TabIndex = 0;
            dataGridViewOrderns.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 2);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 1;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(713, 2);
            button2.Name = "button2";
            button2.Size = new Size(75, 43);
            button2.TabIndex = 2;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BtnProducao
            // 
            BtnProducao.Location = new Point(317, 2);
            BtnProducao.Name = "BtnProducao";
            BtnProducao.Size = new Size(149, 43);
            BtnProducao.TabIndex = 3;
            BtnProducao.Text = "Iniciar Produção";
            BtnProducao.UseVisualStyleBackColor = true;
            BtnProducao.Click += BtnProducao_Click;
            // 
            // ListaOrdens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnProducao);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewOrderns);
            Name = "ListaOrdens";
            Text = "Lista de ordens";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderns).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOrderns;
        private Button button1;
        private Button button2;
        private Button BtnProducao;
    }
}