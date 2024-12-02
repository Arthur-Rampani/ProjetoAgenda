using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class ContatoController
    {
        public bool AddContato(string contato, string telefone, string categoria)
        {
            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao(VariableGlobal.Usersession.Usuario, VariableGlobal.Usersession.Senha);

                //Comando SQL que será executado
                string sql = $@"INSERT INTO tbcontato(contato, telefone, categoria) VALUES (@contato, @telefone, @categoria)";



                //Abre a conexão com o banco
                conexao.Open();

                //Esse cara é o responsável por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Essas infromações vieram dos parametetos da função
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {

                    MessageBox.Show("Contato cadastrado com sucesso!");
                    return true;
                }
                else
                {
                    return false;
                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public DataTable GetContato()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = @"select id_contato, contato AS 'Contato', telefone AS 'Telefone', categoria AS 'Categoria'
                               from tbcontato";

                conexao.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO RECUPERAR CONTATOS: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool ExcluirContato(int id_contato)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = "delete from tbcontato where id_contato = @id_contato;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id_contato", id_contato);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Contato excluído com sucesso!");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        public bool AlterarContato(string contato, int id_contato, string telefone, string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao(VariableGlobal.Usersession.Usuario, VariableGlobal.Usersession.Senha);


                string sql = "UPDATE tbcontato set contato = @contato WHERE id_contato = @id_contato;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@id_contato", id_contato);


                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Contato alterado com sucesso!");
                    return true;
                }

                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}
