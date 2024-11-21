using System;
using System.Data;
using System.Data.SQLite;

namespace SMASystem
{
    public class Contexto
    {
        private readonly string _connectionString;

        public Contexto()
        {
            string databasePath = AppDomain.CurrentDomain.BaseDirectory + "SuperMarket.db";
            _connectionString = $"Data Source={databasePath};Version=3;";
        }

        public void ExecutarComando(string query, Action<System.Data.SQLite.SQLiteCommand> configurarComando)
        {
            using (var conexao = CriarConexao())
            using (var comando = new System.Data.SQLite.SQLiteCommand(query, conexao))
            {
                configurarComando(comando);
                comando.ExecuteNonQuery();
            }
        }

        private SQLiteConnection CriarConexao()
        {
            var conexao = new SQLiteConnection(_connectionString);
            conexao.Open();
            return conexao;
        }
        public DataTable Consultar(string query, Action<SQLiteCommand> configurarComando)
        {
            using (var conexao = CriarConexao())
            using (var comando = new SQLiteCommand(query, conexao))
            {
                configurarComando?.Invoke(comando);
                using (var adapter = new SQLiteDataAdapter(comando))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

    }

}
