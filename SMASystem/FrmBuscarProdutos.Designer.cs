namespace SMASystem
{
    partial class FrmBuscarProdutos
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtNomeProduto = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(626, 338);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar pelo nome do produto:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(37, 27);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(222, 23);
            txtNomeProduto.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(277, 27);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmBuscarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtNomeProduto);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmBuscarProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBuscarProdutos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtNomeProduto;
        private Button btnBuscar;
    }
}