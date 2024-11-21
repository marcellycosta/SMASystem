namespace SMASystem
{
    partial class FrmVenda
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
            dtGridTotalProduto = new DataGridView();
            label2 = new Label();
            txtNome = new TextBox();
            txtQuantidade = new TextBox();
            label4 = new Label();
            button1 = new Button();
            btnAdicionarCarrinho = new Button();
            lblDbNomeProduto = new Label();
            lblDbPrecoProduto = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGridTotalProduto).BeginInit();
            SuspendLayout();
            // 
            // dtGridTotalProduto
            // 
            dtGridTotalProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridTotalProduto.Location = new Point(21, 102);
            dtGridTotalProduto.Name = "dtGridTotalProduto";
            dtGridTotalProduto.Size = new Size(478, 323);
            dtGridTotalProduto.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 22);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome/Cód.Barras:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(202, 23);
            txtNome.TabIndex = 3;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(240, 40);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(202, 23);
            txtQuantidade.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 22);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 7;
            label4.Text = "Quantidade:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(572, 327);
            button1.Name = "button1";
            button1.Size = new Size(190, 111);
            button1.TabIndex = 8;
            button1.Text = "Vender!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAdicionarCarrinho
            // 
            btnAdicionarCarrinho.Location = new Point(21, 69);
            btnAdicionarCarrinho.Name = "btnAdicionarCarrinho";
            btnAdicionarCarrinho.Size = new Size(75, 23);
            btnAdicionarCarrinho.TabIndex = 9;
            btnAdicionarCarrinho.Text = "Adicionar";
            btnAdicionarCarrinho.UseVisualStyleBackColor = true;
            btnAdicionarCarrinho.Click += btnAdicionarCarrinho_Click;
            // 
            // lblDbNomeProduto
            // 
            lblDbNomeProduto.AutoSize = true;
            lblDbNomeProduto.Location = new Point(597, 43);
            lblDbNomeProduto.Name = "lblDbNomeProduto";
            lblDbNomeProduto.Size = new Size(111, 15);
            lblDbNomeProduto.TabIndex = 10;
            lblDbNomeProduto.Text = "lblDbNomeProduto";
            // 
            // lblDbPrecoProduto
            // 
            lblDbPrecoProduto.AutoSize = true;
            lblDbPrecoProduto.Location = new Point(597, 77);
            lblDbPrecoProduto.Name = "lblDbPrecoProduto";
            lblDbPrecoProduto.Size = new Size(108, 15);
            lblDbPrecoProduto.TabIndex = 11;
            lblDbPrecoProduto.Text = "lblDbPrecoProduto";
            // 
            // FrmVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDbPrecoProduto);
            Controls.Add(lblDbNomeProduto);
            Controls.Add(btnAdicionarCarrinho);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(dtGridTotalProduto);
            Name = "FrmVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVenda";
            ((System.ComponentModel.ISupportInitialize)dtGridTotalProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGridTotalProduto;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtQuantidade;
        private Label label4;
        private Button button1;
        private Button btnAdicionarCarrinho;
        private Label lblDbNomeProduto;
        private Label lblDbPrecoProduto;
    }
}