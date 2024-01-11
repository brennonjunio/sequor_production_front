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
            label1 = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            textBoxOrdemId = new TextBox();
            label3 = new Label();
            textBoxDataProducao = new TextBox();
            label4 = new Label();
            textBoxTempoProducao = new TextBox();
            label5 = new Label();
            textBoxQuantidade = new TextBox();
            label6 = new Label();
            textBoxCodigoMaterial = new TextBox();
            button1 = new Button();
            button2 = new Button();
            labelTempo = new Label();
            checkedMaterials = new CheckedListBox();
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 134);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Ordem:";
            label2.Click += label2_Click;
            // 
            // textBoxOrdemId
            // 
            textBoxOrdemId.Location = new Point(234, 163);
            textBoxOrdemId.Name = "textBoxOrdemId";
            textBoxOrdemId.Size = new Size(146, 23);
            textBoxOrdemId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 38);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Data da Produção:";
            label3.Click += label3_Click;
            // 
            // textBoxDataProducao
            // 
            textBoxDataProducao.Location = new Point(234, 67);
            textBoxDataProducao.Name = "textBoxDataProducao";
            textBoxDataProducao.Size = new Size(146, 23);
            textBoxDataProducao.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 42);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Hora Inicial";
            // 
            // textBoxTempoProducao
            // 
            textBoxTempoProducao.Location = new Point(468, 67);
            textBoxTempoProducao.Name = "textBoxTempoProducao";
            textBoxTempoProducao.Size = new Size(146, 23);
            textBoxTempoProducao.TabIndex = 7;
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
            label6.Location = new Point(472, 246);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 10;
            label6.Text = "Código do Material:";
            // 
            // textBoxCodigoMaterial
            // 
            textBoxCodigoMaterial.Location = new Point(468, 278);
            textBoxCodigoMaterial.Name = "textBoxCodigoMaterial";
            textBoxCodigoMaterial.Size = new Size(146, 23);
            textBoxCodigoMaterial.TabIndex = 11;
            textBoxCodigoMaterial.TextChanged += textBoxCodigoMaterial_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(642, 397);
            button1.Name = "button1";
            button1.Size = new Size(146, 44);
            button1.TabIndex = 14;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(468, 397);
            button2.Name = "button2";
            button2.Size = new Size(146, 44);
            button2.TabIndex = 15;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelTempo
            // 
            labelTempo.AutoSize = true;
            labelTempo.Location = new Point(12, 426);
            labelTempo.Name = "labelTempo";
            labelTempo.Size = new Size(0, 15);
            labelTempo.TabIndex = 17;
            // 
            // checkedMaterials
            // 
            checkedMaterials.FormattingEnabled = true;
            checkedMaterials.Location = new Point(468, 132);
            checkedMaterials.Name = "checkedMaterials";
            checkedMaterials.Size = new Size(146, 94);
            checkedMaterials.TabIndex = 18;
            // 
            // ModalOrdens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedMaterials);
            Controls.Add(labelTempo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxCodigoMaterial);
            Controls.Add(label6);
            Controls.Add(textBoxQuantidade);
            Controls.Add(label5);
            Controls.Add(textBoxTempoProducao);
            Controls.Add(label4);
            Controls.Add(textBoxDataProducao);
            Controls.Add(label3);
            Controls.Add(textBoxOrdemId);
            Controls.Add(label2);
            Controls.Add(textBoxEmail);
            Controls.Add(label1);
            Name = "ModalOrdens";
            Text = "Modal de Ordens";
            ResumeLayout(false);
            PerformLayout();
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
        private CheckedListBox checkedMaterials;
    }
}