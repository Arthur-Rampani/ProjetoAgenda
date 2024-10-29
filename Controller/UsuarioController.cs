using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            MySqlConnection conexao = ConexaoDB.CriarConexao();

            //Comando SQL que será executado
            string sql = "INSERT INTO tbUsuarios(nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

            //Abre a conexão com o banco
            conexao.Open();

            //Esse cara é o responsável por executar o comando SQL
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            //Estou trocando o valor dos @ pelas informações qur serão cadstradas
            //Essas infromações vieram dos parametetos da função
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@senha", senha);

            //Executando no banco de dados
            int linhasAfetadas = comando.ExecuteNonQuery();

            conexao.Close();

            if( linhasAfetadas > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
