namespace SMASystem
{
    partial class FrmAtualizarFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtualizarFunc));
            dataGridView1 = new DataGridView();
            TxtNome = new TextBox();
            TxtCargo = new TextBox();
            TxtSalario = new TextBox();
            BtnSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(271, 415);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(300, 51);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(214, 23);
            TxtNome.TabIndex = 1;
            // 
            // TxtCargo
            // 
            TxtCargo.Location = new Point(303, 114);
            TxtCargo.Name = "TxtCargo";
            TxtCargo.Size = new Size(211, 23);
            TxtCargo.TabIndex = 2;
            // 
            // TxtSalario
            // 
            TxtSalario.Location = new Point(305, 177);
            TxtSalario.Name = "TxtSalario";
            TxtSalario.Size = new Size(214, 23);
            TxtSalario.TabIndex = 3;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = SystemColors.GradientInactiveCaption;
            BtnSalvar.Font = new Font("Segoe UI", 11.25F);
            BtnSalvar.Location = new Point(303, 230);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(213, 62);
            BtnSalvar.TabIndex = 4;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(303, 28);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 5;
            label1.Text = "Nome Completo ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(305, 91);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 5;
            label2.Text = "Função";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(303, 154);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Salário";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(330, 315);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(489, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // FrmAtualizarFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(531, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSalvar);
            Controls.Add(TxtSalario);
            Controls.Add(TxtCargo);
            Controls.Add(TxtNome);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "FrmAtualizarFunc";
            Text = "FrmAtualizarFunc";
            Load += FrmAtualizarFunc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox TxtNome;
        private TextBox TxtCargo;
        private TextBox TxtSalario;
        private Button BtnSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}