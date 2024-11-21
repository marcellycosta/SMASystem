using System.Data;
using System.Windows.Forms;

namespace SMASystem
{
    public partial class FrmAtualizarFunc : Form
    {
        private readonly Contexto _contexto;
        private int _idPessoa; // Variável para armazenar o IdPessoa do funcionário selecionado

        public FrmAtualizarFunc()
        {
            InitializeComponent();
            _contexto = new Contexto(); // Inicializa o contexto
        }

        // Método para carregar todos os funcionários no DataGridView
        private void CarregarTodosFunc()
        {
            string query = "SELECT \"IdPessoa\", \"Nome\", \"Cargo\", \"Salario\" FROM Funcionario";

            try
            {
                // Busca todos os funcionários no banco de dados
                DataTable funcionarios = _contexto.Consultar(query, null);

                // Exibe os resultados no DataGridView
                dataGridView1.DataSource = funcionarios;

                // Configuração opcional para ajustar os títulos das colunas
                dataGridView1.Columns["IdPessoa"].HeaderText = "ID";
                dataGridView1.Columns["Nome"].HeaderText = "Nome";
                dataGridView1.Columns["Cargo"].HeaderText = "Cargo";
                dataGridView1.Columns["Salario"].HeaderText = "Salário (R$)";

                // Oculta a coluna IdPessoa, caso não queira mostrá-la ao usuário
                dataGridView1.Columns["IdPessoa"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar funcionários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento chamado ao clicar em uma linha do DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula clicada é válida
            if (e.RowIndex >= 0)
            {
                // Obtém os valores da linha selecionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                _idPessoa = Convert.ToInt32(row.Cells["IdPessoa"].Value); // Armazena o ID do funcionário selecionado
                TxtNome.Text = row.Cells["Nome"].Value.ToString(); // Preenche o nome do funcionário
                TxtCargo.Text = row.Cells["Cargo"].Value.ToString(); // Preenche o cargo
                TxtSalario.Text = row.Cells["Salario"].Value.ToString(); // Preenche o salário
            }
        }

        // Evento do botão "Salvar Alterações"
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string novoNome = TxtNome.Text; // Novo nome do funcionário
            string novoCargo = TxtCargo.Text; // Novo cargo
            string salarioText = TxtSalario.Text; // Novo salário

            // Valida os campos
            if (_idPessoa <= 0 ||
                string.IsNullOrEmpty(novoNome) ||
                string.IsNullOrEmpty(novoCargo) ||
                string.IsNullOrEmpty(salarioText))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(salarioText, out decimal novoSalario) || novoSalario < 0)
            {
                MessageBox.Show("Por favor, insira um salário válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query para atualizar o funcionário
            string query = "UPDATE Funcionario SET \"Nome\" = @NovoNome, \"Cargo\" = @NovoCargo, \"Salario\" = @NovoSalario WHERE \"IdPessoa\" = @IdPessoa";

            try
            {
                // Executa a query no banco de dados
                _contexto.ExecutarComando(query, command =>
                {
                    command.Parameters.AddWithValue("@NovoNome", novoNome);
                    command.Parameters.AddWithValue("@NovoCargo", novoCargo);
                    command.Parameters.AddWithValue("@NovoSalario", novoSalario);
                    command.Parameters.AddWithValue("@IdPessoa", _idPessoa); // ID do funcionário como critério
                });

                MessageBox.Show("Funcionário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarTodosFunc(); // Recarrega a lista para refletir as alterações

                // Limpa os campos após a atualização
                TxtNome.Clear();
                TxtCargo.Clear();
                TxtSalario.Clear();
                _idPessoa = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento chamado ao carregar o formulário
        private void FrmAtualizarFunc_Load(object sender, EventArgs e)
        {
            CarregarTodosFunc();
        }
    }
}

