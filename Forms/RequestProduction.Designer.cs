namespace sequorTesteSelecao.Forms
{
    partial class RequestProduction
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
            label1 = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            textBoxOrdem = new TextBox();
            label3 = new Label();
            textBoxData = new TextBox();
            label4 = new Label();
            textBoxTempo = new TextBox();
            label5 = new Label();
            textBoxQuantidade = new NumericUpDown();
            label6 = new Label();
            textBoxMaterial = new TextBox();
            label7 = new Label();
            textBoxCycle = new NumericUpDown();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(44, 67);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(146, 23);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 38);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Ordem:";
            label2.Click += label2_Click;
            // 
            // textBoxOrdem
            // 
            textBoxOrdem.Location = new Point(230, 67);
            textBoxOrdem.Name = "textBoxOrdem";
            textBoxOrdem.Size = new Size(146, 23);
            textBoxOrdem.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 38);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Data da Produção:";
            label3.Click += label3_Click;
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(401, 67);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(146, 23);
            textBoxData.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(591, 42);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Hora Inicio";
            // 
            // textBoxTempo
            // 
            textBoxTempo.Location = new Point(591, 67);
            textBoxTempo.Name = "textBoxTempo";
            textBoxTempo.Size = new Size(146, 23);
            textBoxTempo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 132);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 8;
            label5.Text = "Quantidade:";
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(45, 163);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(145, 23);
            textBoxQuantidade.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(234, 132);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 10;
            label6.Text = "Código do Material:";
            // 
            // textBoxMaterial
            // 
            textBoxMaterial.Location = new Point(234, 163);
            textBoxMaterial.Name = "textBoxMaterial";
            textBoxMaterial.Size = new Size(142, 23);
            textBoxMaterial.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(401, 132);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 12;
            label7.Text = "Ciclo de Tempo:";
            // 
            // textBoxCycle
            // 
            textBoxCycle.Location = new Point(401, 164);
            textBoxCycle.Name = "textBoxCycle";
            textBoxCycle.Size = new Size(146, 23);
            textBoxCycle.TabIndex = 13;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(703, 405);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(608, 405);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // RequestProduction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(textBoxCycle);
            Controls.Add(label7);
            Controls.Add(textBoxMaterial);
            Controls.Add(label6);
            Controls.Add(textBoxQuantidade);
            Controls.Add(label5);
            Controls.Add(textBoxTempo);
            Controls.Add(label4);
            Controls.Add(textBoxData);
            Controls.Add(label3);
            Controls.Add(textBoxOrdem);
            Controls.Add(label2);
            Controls.Add(textBoxEmail);
            Controls.Add(label1);
            Name = "RequestProduction";
            Text = "Modal de Ordens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxEmail;
        private Label label2;
        private TextBox textBoxOrdem;
        private Label label3;
        private TextBox textBoxData;
        private Label label4;
        private TextBox textBoxTempo;
        private Label label5;
        private NumericUpDown textBoxQuantidade;
        private Label label6;
        private TextBox textBoxMaterial;
        private Label label7;
        private NumericUpDown textBoxCycle;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}