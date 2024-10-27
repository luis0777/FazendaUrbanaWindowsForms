using System;
using System.Data.SqlClient;

namespace ProjetoFazendaUrbana.conexao
{
    public class ConexaoSql
    {
        private SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HUTS0O2;initial catalog=BD_FAZENDA;integrated security=true;");

        // Método para abrir a conexão
        public SqlConnection Open()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
                cn.Open();
            return cn;
        }

        // Método para fechar a conexão
        public void Close()
        {
            if (cn.State == System.Data.ConnectionState.Open)
                cn.Close();
        }

        // Método para criar um comando
        public SqlCommand CriarComando(string query)
        {
            SqlCommand cm = new SqlCommand(query, cn);
            return cm;
        }

        // Exemplo de execução de comando (SELECT)
        public SqlDataReader ExecutarConsulta(string query)
        {
            SqlCommand cm = CriarComando(query);
            return cm.ExecuteReader();
        }
    }
}