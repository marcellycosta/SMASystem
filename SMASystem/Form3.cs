using System;
using System.Windows.Forms;

namespace SMASystem
{
    public partial class Form3 : Form
    {
        private readonly Contexto _contexto;

        public Form3()
        {
            InitializeComponent();
            _contexto = new Contexto(); // Inicializa o contexto
        }


        private void LimparCampos()
        {
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            txtCodigoBarra.Clear();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            // Captura os dados do formulário
            string nomeProduto = txtNomeProduto.Text;
            string quantidadeTexto = txtQuantidade.Text;
            string precoTexto = txtPreco.Text;
            string codigoBarra = txtCodigoBarra.Text;

            // Validação básica
            if (string.IsNullOrEmpty(nomeProduto) ||
                string.IsNullOrEmpty(quantidadeTexto) ||
                string.IsNullOrEmpty(precoTexto) ||
                string.IsNullOrEmpty(codigoBarra))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(quantidadeTexto, out int quantidade) || !decimal.TryParse(precoTexto, out decimal preco))
            {
                MessageBox.Show("Quantidade e preço devem ser numéricos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query para inserção
            string query = "INSERT INTO Produto (\"Nome\", \"QtdEstoque\", \"Preço\", \"CódBarra\") VALUES (@Nome, @Quantidade, @Preco, @CodigoBarra)";

            try
            {
                // Executa o comando no banco de dados
                _contexto.ExecutarComando(query, command =>
                {
                    command.Parameters.AddWithValue("@Nome", nomeProduto);
                    command.Parameters.AddWithValue("@Quantidade", quantidade);
                    command.Parameters.AddWithValue("@Preco", preco);
                    command.Parameters.AddWithValue("@CodigoBarra", codigoBarra);
                });

                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
