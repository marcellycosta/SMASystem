using System.Data;

namespace SMASystem
{
    public partial class FrmControlEst : Form
    {
        private readonly Contexto _contexto;
        private string _nomeOriginal; // Variável para armazenar o nome original do produto selecionado

        public FrmControlEst()
        {
            InitializeComponent();
            _contexto = new Contexto(); // Inicializa o contexto
        }

        // Método para carregar todos os produtos no DataGridView
        private void CarregarTodosProdutos()
        {
            string query = "SELECT \"Nome\", \"QtdEstoque\", \"Preço\" FROM Produto";

            try
            {
                // Busca todos os produtos no banco de dados
                DataTable Produto = _contexto.Consultar(query, null);

                // Exibe os resultados no DataGridView
                dataGridViewProdutos.DataSource = Produto;

                // Configuração opcional para ajustar os títulos das colunas
                dataGridViewProdutos.Columns["Nome"].HeaderText = "Produto";
                dataGridViewProdutos.Columns["QtdEstoque"].HeaderText = "Quantidade";
                dataGridViewProdutos.Columns["Preço"].HeaderText = "Preço (R$)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento chamado ao clicar em uma linha do DataGridView
        private void dataGridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula clicada é válida
            if (e.RowIndex >= 0)
            {
                // Obtém os valores da linha selecionada
                DataGridViewRow row = dataGridViewProdutos.Rows[e.RowIndex];

                TxtProduto.Text = row.Cells["Nome"].Value.ToString(); // Preenche o nome do produto
                TxtQtde.Text = row.Cells["QtdEstoque"].Value.ToString(); // Preenche a quantidade
                TxtPreco.Text = row.Cells["Preço"].Value.ToString(); // Preenche o preço

                // Armazena o nome original do produto selecionado
                _nomeOriginal = row.Cells["Nome"].Value.ToString();
            }
        }

        // Evento do botão "Salvar Alterações"
        private void BtnSalvar_Click1(object sender, EventArgs e)
        {
            string novoNome = TxtProduto.Text; // Novo nome do produto
            string quantidadeText = TxtQtde.Text; // Quantidade
            string precoText = TxtPreco.Text; // Preço

            // Valida os campos
            if (string.IsNullOrEmpty(_nomeOriginal) ||
                string.IsNullOrEmpty(novoNome) ||
                string.IsNullOrEmpty(quantidadeText) ||
                string.IsNullOrEmpty(precoText))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(quantidadeText, out int quantidade) || quantidade < 0)
            {
                MessageBox.Show("Por favor, insira uma quantidade válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(precoText, out decimal preco) || preco < 0)
            {
                MessageBox.Show("Por favor, insira um preço válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query para atualizar o produto
            string query = "UPDATE Produto SET \"Nome\" = @NovoNome, \"QtdEstoque\" = @QtdEstoque, \"Preço\" = @Preco WHERE \"Nome\" = @NomeOriginal";

            try
            {
                // Executa a query no banco de dados
                _contexto.ExecutarComando(query, command =>
                {
                    command.Parameters.AddWithValue("@NovoNome", novoNome);
                    command.Parameters.AddWithValue("@QtdEstoque", quantidade);
                    command.Parameters.AddWithValue("@Preco", preco);
                    command.Parameters.AddWithValue("@NomeOriginal", _nomeOriginal); // Nome original usado como critério
                });

                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarTodosProdutos(); // Recarrega a lista para refletir as alterações

                // Limpa os campos após a atualização
                TxtProduto.Clear();
                TxtQtde.Clear();
                TxtPreco.Clear();
                _nomeOriginal = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carrega os produtos ao abrir o formulário
        private void FrmControlEst_Load_1(object sender, EventArgs e)
        {
            CarregarTodosProdutos();
        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
