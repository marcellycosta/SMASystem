using System;
using System.Windows.Forms;

namespace SMASystem
{
    public partial class FrmCadastroFuncionario : Form
    {
        private readonly Contexto _contexto;

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
            _contexto = new Contexto(); // Inicializa o contexto
        }

        private void LimparCampos()
        {
            TxtNome.Clear();
            TxtFuncao.Clear();
            TxtSalario.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Captura os dados do formulário
            string nomePessoa = TxtNome.Text;
            string funcao = TxtFuncao.Text;
            string salariot = TxtSalario.Text;

            // Validação básica
            if (string.IsNullOrEmpty(nomePessoa) ||
                string.IsNullOrEmpty(funcao) ||
                string.IsNullOrEmpty(salariot))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se o salário é um número válido
            if (!decimal.TryParse(salariot, out decimal salario))
            {
                MessageBox.Show("Por favor, insira um valor de salário válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query para inserção na tabela de funcionários
            string query = "INSERT INTO Funcionario (\"Nome\", \"Cargo\", \"Salario\") VALUES (@Nome, @Funcao, @Salario)";

            try
            {
                // Executa o comando no banco de dados
                _contexto.ExecutarComando(query, command =>
                {
                    command.Parameters.AddWithValue("@Nome", nomePessoa);
                    command.Parameters.AddWithValue("@Funcao", funcao);
                    command.Parameters.AddWithValue("@Salario", salario);
                });

                MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}

