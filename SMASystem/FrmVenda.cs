using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMASystem
{
    public partial class FrmVenda : Form
    {
        private readonly Contexto _contexto;

        public FrmVenda()
        {
            InitializeComponent();
            _contexto = new Contexto();
        }

        private void lblPreco_Click(object sender, EventArgs e)
        {
            // Não é necessário modificar este método.
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Impede o som de "beep" ao pressionar Enter
                e.Handled = true;

                // Captura o valor do campo de texto
                string nomeProduto = txtNome.Text.Trim();

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
                    // Consulta para trazer produtos que contenham o nome ou o código de barras digitado
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

                    // Atualiza as labels com o primeiro produto encontrado (se houver)
                    if (produtos.Rows.Count > 0)
                    {
                        DataRow row = produtos.Rows[0];
                        lblDbNomeProduto.Text = row["Nome"].ToString();
                        lblDbPrecoProduto.Text = $"R$ {Convert.ToDecimal(row["Preço"]):F2}";
                    }
                    else
                    {
                        lblDbNomeProduto.Text = "Produto não encontrado";
                        lblDbPrecoProduto.Text = "Preço indisponível";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            // Garante que o DataGridView tenha as colunas definidas
            if (dtGridTotalProduto.Columns.Count == 0)
            {
                // Adiciona as colunas ao DataGridView
                dtGridTotalProduto.Columns.Add("NomeProduto", "Nome do Produto");
                dtGridTotalProduto.Columns.Add("Quantidade", "Quantidade");
                dtGridTotalProduto.Columns.Add("ValorTotal", "Valor Total");
            }

            // Captura os valores das labels e do input de quantidade
            string nomeProduto = lblDbNomeProduto.Text;
            string precoTexto = lblDbPrecoProduto.Text.Replace("R$", "").Trim();
            string quantidadeTexto = txtQuantidade.Text;

            // Validação básica
            if (string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(precoTexto) || string.IsNullOrEmpty(quantidadeTexto))
            {
                MessageBox.Show("Por favor, preencha os campos e selecione um produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(precoTexto, out decimal preco) || !int.TryParse(quantidadeTexto, out int quantidade))
            {
                MessageBox.Show("Quantidade deve ser um número inteiro e preço deve ser válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se há estoque suficiente no banco de dados
            string queryEstoque = "SELECT \"QtdEstoque\" FROM Produto WHERE \"Nome\" = @Nome";
            try
            {
                int estoqueDisponivel = 0;

                // Consulta o estoque disponível
                DataTable estoqueTable = _contexto.Consultar(queryEstoque, command =>
                {
                    command.Parameters.AddWithValue("@Nome", nomeProduto);
                });

                if (estoqueTable.Rows.Count > 0)
                {
                    estoqueDisponivel = Convert.ToInt32(estoqueTable.Rows[0]["QtdEstoque"]);
                }

                // Verifica se o estoque é suficiente
                if (quantidade > estoqueDisponivel)
                {
                    MessageBox.Show("Estoque insuficiente para este produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calcula o valor total
                decimal valorTotal = preco * quantidade;

                // Adiciona os dados ao DataGridView
                dtGridTotalProduto.Rows.Add(nomeProduto, quantidade, $"R$ {valorTotal:F2}");

                // Atualiza o estoque no banco de dados
                string queryAtualizarEstoque = "UPDATE Produto SET \"QtdEstoque\" = \"QtdEstoque\" - @Quantidade WHERE \"Nome\" = @Nome";
                _contexto.ExecutarComando(queryAtualizarEstoque, command =>
                {
                    command.Parameters.AddWithValue("@Quantidade", quantidade);
                    command.Parameters.AddWithValue("@Nome", nomeProduto);
                });

                MessageBox.Show("Produto adicionado ao carrinho com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            // Adiciona as colunas ao DataGridView
            dtGridTotalProduto.Columns.Add("NomeProduto", "Nome do Produto");
            dtGridTotalProduto.Columns.Add("Quantidade", "Quantidade");
            dtGridTotalProduto.Columns.Add("ValorTotal", "Valor Total");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtGridTotalProduto.Rows.Count == 0)
            {
                MessageBox.Show("Não há itens no carrinho para vender!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal precoTotalVenda = 0;

                // Calcula o preço total da venda a partir do DataGridView
                foreach (DataGridViewRow row in dtGridTotalProduto.Rows)
                {
                    if (row.Cells["Quantidade"].Value != null && row.Cells["ValorTotal"].Value != null)
                    {
                        precoTotalVenda += Convert.ToDecimal(row.Cells["ValorTotal"].Value.ToString().Replace("R$", "").Trim());
                    }
                }

                // Insere a venda na tabela VENDA e obtém o ID da venda
                string queryVenda = "INSERT INTO VENDA (PrecoTotal) VALUES (@PrecoTotal); SELECT last_insert_rowid() AS Id;";
                int vendaId = 0;

                DataTable vendaResult = _contexto.Consultar(queryVenda, command =>
                {
                    command.Parameters.AddWithValue("@PrecoTotal", precoTotalVenda);
                });

                if (vendaResult.Rows.Count > 0)
                {
                    vendaId = Convert.ToInt32(vendaResult.Rows[0]["Id"]);
                }

                // Insere os itens na tabela ItemVenda e atualiza o estoque
                foreach (DataGridViewRow row in dtGridTotalProduto.Rows)
                {
                    if (row.Cells["NomeProduto"].Value == null || row.Cells["Quantidade"].Value == null || row.Cells["ValorTotal"].Value == null)
                        continue;

                    string nomeProduto = row.Cells["NomeProduto"].Value.ToString();
                    int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                    decimal valorTotal = Convert.ToDecimal(row.Cells["ValorTotal"].Value.ToString().Replace("R$", "").Trim());

                    // Insere o item na tabela ItemVenda
                    string queryItemVenda = "INSERT INTO ItemVenda (Quantidade, ValorTotal, NomeProduto, VendaId) VALUES (@Quantidade, @ValorTotal, @NomeProduto, @VendaId)";
                    _contexto.ExecutarComando(queryItemVenda, command =>
                    {
                        command.Parameters.AddWithValue("@Quantidade", quantidade);
                        command.Parameters.AddWithValue("@ValorTotal", valorTotal);
                        command.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                        command.Parameters.AddWithValue("@VendaId", vendaId);
                    });

                    // Atualiza o estoque do produto
                    string queryAtualizarEstoque = "UPDATE Produto SET QtdEstoque = QtdEstoque - @Quantidade WHERE Nome = @NomeProduto";
                    _contexto.ExecutarComando(queryAtualizarEstoque, command =>
                    {
                        command.Parameters.AddWithValue("@Quantidade", quantidade);
                        command.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                    });
                }

                // Limpa o DataGridView e exibe mensagem de sucesso
                dtGridTotalProduto.Rows.Clear();
                MessageBox.Show("Venda realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar a venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
