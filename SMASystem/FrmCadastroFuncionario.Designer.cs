namespace SMASystem
{
    partial class FrmCadastroFuncionario
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
            label2 = new Label();
            label3 = new Label();
            TxtNome = new TextBox();
            TxtFuncao = new TextBox();
            TxtSalario = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Função";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 204);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Salário";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(12, 85);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(349, 23);
            TxtNome.TabIndex = 1;
            // 
            // TxtFuncao
            // 
            TxtFuncao.Location = new Point(12, 149);
            TxtFuncao.Name = "TxtFuncao";
            TxtFuncao.Size = new Size(349, 23);
            TxtFuncao.TabIndex = 1;
            // 
            // TxtSalario
            // 
            TxtSalario.Location = new Point(12, 222);
            TxtSalario.Name = "TxtSalario";
            TxtSalario.Size = new Size(349, 23);
            TxtSalario.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(221, 356);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(167, 63);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "button1";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 450);
            Controls.Add(btnSalvar);
            Controls.Add(TxtSalario);
            Controls.Add(TxtFuncao);
            Controls.Add(TxtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCadastroFuncionario";
            Text = "FrmCadastroFuncionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtNome;
        private TextBox TxtFuncao;
        private TextBox TxtSalario;
        private Button btnSalvar;
    }
}