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
    public partial class FrmBuscarProdutos : Form
    {
        private readonly Contexto _contexto;

        public FrmBuscarProdutos()
        {
            InitializeComponent();
            _contexto = new Contexto(); // Inicializa o contexto
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Captura o valor do campo de texto
            string nomeProduto = txtNomeProduto.Text.Trim();

            // Define a query base
            string query;

            // Verifica se o campo de texto está vazio
            if (string.IsNullOrEmpty(nomeProduto))
            {
                // Consulta para trazer todos os produtos
                query = "SELECT \"CódBarra\", \"Nome\", \"QtdEstoque\", \"Preço\" FROM Produto";
            }
            else
            {
                // Consulta para trazer produtos que contenham o nome digitado
                query = "SELECT \"CódBarra\", \"Nome\", \"QtdEstoque\", \"Preço\" FROM Produto WHERE \"Nome\" LIKE @Nome OR \"CódBarra\" LIKE @Nome";
            }

            try
            {
                // Busca os dados no banco
                DataTable produtos = _contexto.Consultar(query, command =>
                {
                    if (!string.IsNullOrEmpty(nomeProduto))
                    {
                        command.Parameters.AddWithValue("@Nome", $"%{nomeProduto}%"); // Adiciona o parâmetro para a consulta LIKE
                    }
                });

                // Exibe os resultados no DataGridView
                dataGridView1.DataSource = produtos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
