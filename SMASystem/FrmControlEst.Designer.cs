
namespace SMASystem
{
    partial class FrmControlEst
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            TxtProduto = new TextBox();
            label2 = new Label();
            TxtQtde = new TextBox();
            TxtPreco = new TextBox();
            label3 = new Label();
            dataGridViewProdutos = new DataGridView();
            contextoBindingSource = new BindingSource(components);
            Btnsalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contextoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Produto";
            // 
            // TxtProduto
            // 
            TxtProduto.Location = new Point(26, 50);
            TxtProduto.Name = "TxtProduto";
            TxtProduto.Size = new Size(222, 23);
            TxtProduto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 32);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Quantidade";
            // 
            // TxtQtde
            // 
            TxtQtde.Location = new Point(299, 50);
            TxtQtde.Name = "TxtQtde";
            TxtQtde.Size = new Size(100, 23);
            TxtQtde.TabIndex = 4;
            // 
            // TxtPreco
            // 
            TxtPreco.Location = new Point(452, 50);
            TxtPreco.Name = "TxtPreco";
            TxtPreco.Size = new Size(100, 23);
            TxtPreco.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(452, 32);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Preço";
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AllowUserToOrderColumns = true;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(26, 109);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.Size = new Size(526, 302);
            dataGridViewProdutos.TabIndex = 9;
            dataGridViewProdutos.CellClick += dataGridViewProdutos_CellClick;
            dataGridViewProdutos.CellContentClick += dataGridViewProdutos_CellContentClick;
            // 
            // contextoBindingSource
            // 
            contextoBindingSource.DataSource = typeof(Contexto);
            // 
            // Btnsalvar
            // 
            Btnsalvar.Location = new Point(617, 329);
            Btnsalvar.Name = "Btnsalvar";
            Btnsalvar.Size = new Size(138, 82);
            Btnsalvar.TabIndex = 10;
            Btnsalvar.Text = "Btnsalvar";
            Btnsalvar.UseVisualStyleBackColor = true;
            Btnsalvar.Click += BtnSalvar_Click1;
            // 
            // FrmControlEst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btnsalvar);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(label3);
            Controls.Add(TxtPreco);
            Controls.Add(TxtQtde);
            Controls.Add(label2);
            Controls.Add(TxtProduto);
            Controls.Add(label1);
            Name = "FrmControlEst";
            Text = "FrmControlEst";
            Load += FrmControlEst_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)contextoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label label1;
        private TextBox TxtProduto;
        private Label label2;
        private TextBox TxtQtde;
        private TextBox TxtPreco;
        private Label label3;
        private DataGridView dataGridViewProdutos;
        private BindingSource contextoBindingSource;
        private Button Btnsalvar;
        private TextBox TxtCodBarra;
    }
}