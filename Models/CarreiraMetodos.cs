using System;
using MySqlConnector;
using MvcSmsResistencia.Models;

namespace MvcSmsResistencia.Models
{
    public class CarreiraMetodos
    {
        private const string bancoDados = "Database=SmsResistencias;Data Source=localhost;User Id=root";
      public void Carreira(Carreira curriculo)
      {
          //abrindo conexao sgbd 
          MySqlConnection conexao = new MySqlConnection(bancoDados);
          conexao.Open();

          //criando comando sql (insert)
          string sql = "INSERT INTO Carreira(nome, telefone, email, endereco, cep, cidade, estado, formacao, area, sobre) VALUES (@Nome, @Telefone, @Email, @Endereco, @Cep, @Cidade, @Estado, @Formacao, @Area, @Experiencia)";

        //tratando comando  sql 
          MySqlCommand comando = new MySqlCommand(sql, conexao);

          //trantando injection 
          comando.Parameters.AddWithValue("@Nome", curriculo.Nome);
          comando.Parameters.AddWithValue("@Telefone", curriculo.Telefone);
          comando.Parameters.AddWithValue("@Email", curriculo.Email);
          comando.Parameters.AddWithValue("@Endereco", curriculo.Endereco);
          comando.Parameters.AddWithValue("@Cep", curriculo.Cep);
          comando.Parameters.AddWithValue("@Cidade", curriculo.Cidade);
          comando.Parameters.AddWithValue("@Estado", curriculo.Estado);
          comando.Parameters.AddWithValue("@Formacao", curriculo.Formacao);
          comando.Parameters.AddWithValue("Area", curriculo.Area);
          comando.Parameters.AddWithValue("@experiencia", curriculo.Experiencias);

          //executando comando query
          comando.ExecuteNonQuery();

          //fexando conexao
          conexao.Close();

      }
    }
}