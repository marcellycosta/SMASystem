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
    public partial class FrmGestaoFunc : Form
    {
        public FrmGestaoFunc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmCadastroFuncionario().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmAtualizarFunc().Show();
        }
    }
}
