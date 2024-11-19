using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao(Usersession.Nome, Usersession.Usuario);


                string sql = "INSERT INTO tbcategoria(categoria) VALUES (@categoria);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@categoria", categoria);


                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Categoria cadastrada com sucesso!");
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

        public DataTable GetCategorias()
        {
            //Criando uma conexão vazia
            MySqlConnection conexao = null;
            try
            {
                //Inserindo a conexão usando a conexão que eu já havia criado
                 conexao = ConexaoDB.CriarConexao();

                //Montei o SELECT que retorna todas as categorias
                string sql = @"select id_categoria AS 'Código', categoria AS 'Categoria'
                               from tbcategoria;";

                //Abri a conexão
                conexao.Open();

                //Criei um adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //Criei uma tabela vazia
                DataTable tabela = new DataTable();

                //Pedindo para o adaptador preencher a tabela
                adaptador.Fill(tabela);

                //Retorno a tabela preenchida
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO RECUPERAR CATEGORIAS: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool ExcluirCategoria(int id_categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = "delete from tbcategoria where id_categoria = @id_categoria;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id_categoria", id_categoria);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Categoria excluida com sucesso!");
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
    }
}