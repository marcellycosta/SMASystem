using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMASystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();

            // Exibe o FormProduto de forma não modal (permite que Form1 continue acessível)
            Form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FrmBuscarProdutos().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FrmVenda().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmControlEst().Show();
        }
    }
}
