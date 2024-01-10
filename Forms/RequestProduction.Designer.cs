namespace sequorTesteSelecao.Forms
{
    partial class ModalOrdens
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOrdemId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDataProducao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTempoProducao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodigoMaterial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(44, 67);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(146, 23);
            this.textBoxEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ordem:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxOrdemId
            // 
            this.textBoxOrdemId.Location = new System.Drawing.Point(230, 67);
            this.textBoxOrdemId.Name = "textBoxOrdemId";
            this.textBoxOrdemId.Size = new System.Drawing.Size(146, 23);
            this.textBoxOrdemId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data da Produção:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxDataProducao
            // 
            this.textBoxDataProducao.Location = new System.Drawing.Point(401, 67);
            this.textBoxDataProducao.Name = "textBoxDataProducao";
            this.textBoxDataProducao.Size = new System.Drawing.Size(146, 23);
            this.textBoxDataProducao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora Inicial";
            // 
            // textBoxTempoProducao
            // 
            this.textBoxTempoProducao.Location = new System.Drawing.Point(591, 67);
            this.textBoxTempoProducao.Name = "textBoxTempoProducao";
            this.textBoxTempoProducao.Size = new System.Drawing.Size(146, 23);
            this.textBoxTempoProducao.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade:";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(45, 163);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(145, 23);
            this.textBoxQuantidade.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código do Material:";
            // 
            // textBoxCodigoMaterial
            // 
            this.textBoxCodigoMaterial.Location = new System.Drawing.Point(230, 164);
            this.textBoxCodigoMaterial.Name = "textBoxCodigoMaterial";
            this.textBoxCodigoMaterial.Size = new System.Drawing.Size(142, 23);
            this.textBoxCodigoMaterial.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Location = new System.Drawing.Point(12, 426);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(0, 15);
            this.labelTempo.TabIndex = 17;
            // 
            // ModalOrdens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCodigoMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTempoProducao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDataProducao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOrdemId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Name = "ModalOrdens";
            this.Text = "Modal de Ordens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxEmail;
        private Label label2;
        private TextBox textBoxOrdemId;
        private Label label3;
        private TextBox textBoxDataProducao;
        private Label label4;
        private TextBox textBoxTempoProducao;
        private Label label5;
        private TextBox textBoxQuantidade;
        private Label label6;
        private TextBox textBoxCodigoMaterial;
        private Button button1;
        private Button button2;
        private Label label8;
        private Label labelTempo;
    }
}