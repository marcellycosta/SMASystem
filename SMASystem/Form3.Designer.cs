namespace SMASystem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            txtNomeProduto = new TextBox();
            txtQuantidade = new TextBox();
            txtCodigoBarra = new TextBox();
            txtPreco = new TextBox();
            btnSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(26, 81);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(559, 23);
            txtNomeProduto.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(26, 166);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 1;
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.Location = new Point(358, 166);
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(197, 23);
            txtCodigoBarra.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(191, 166);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ActiveCaption;
            btnSalvar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.MidnightBlue;
            btnSalvar.Location = new Point(606, 203);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(99, 26);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 58);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 5;
            label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(26, 143);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 6;
            label2.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(191, 143);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Preço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(358, 143);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 8;
            label4.Text = "Código de Barras:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(198, 25);
            label5.TabIndex = 9;
            label5.Text = "Cadastro de Produtos";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(725, 243);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreco);
            Controls.Add(txtCodigoBarra);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNomeProduto);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Supermarket Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeProduto;
        private TextBox txtQuantidade;
        private TextBox txtCodigoBarra;
        private TextBox txtPreco;
        private Button btnSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}