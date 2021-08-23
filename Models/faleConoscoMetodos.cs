using System;
using MySqlConnector;
using MvcSmsResistencia.Models;

namespace MvcSmsResistencia.Models
{
    public class faleConoscoMetodos
    {
        private const string bancoDados = "Database=SmsResistencias;Data Source=localhost;User Id=root";

        public void FaleConosco(FaleConosco mensagem)
        {
            //abrindo conexão com sgbd
            MySqlConnection conexao = new MySqlConnection(bancoDados);
            conexao.Open();

            //Criando comando Sql Para Inserir (Insert)
            string sql = "INSERT INTO FaleConosco(nome, empresa, email, telefone, conheceu, mensagem) VALUES (@Nome, @Empresa, @Email, @Telefone, @Conheceu, @Mensagem)";

            //Tratando comando sql com query e conexao
           MySqlCommand comando = new MySqlCommand(sql, conexao);

            //tratando injection
            comando.Parameters.AddWithValue("@Nome",mensagem.Nome);
            comando.Parameters.AddWithValue("@Empresa", mensagem.Empresa);
            comando.Parameters.AddWithValue("@Email", mensagem.Email);
            comando.Parameters.AddWithValue("@Telefone", mensagem.Telefone);
            comando.Parameters.AddWithValue("@Conheceu", mensagem.Conheceu);
            comando.Parameters.AddWithValue("@Mensagem", mensagem.Mensagem);

            //execultando comando sql
            comando.ExecuteNonQuery();

            //fechando conexao
            conexao.Close();
        }
    }
}