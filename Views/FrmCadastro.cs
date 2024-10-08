using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;

namespace ProjetoAgenda
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void habilitarBotaoCadastrar()
        {
            if (txtBoxNome.Text != "" && txtBoxUsuario.Text != "" && txtBoxSenhaoficial.Text.Length >= 8 && txtBoxRepetirSenha.Text == txtBoxSenhaoficial.Text)
            {
                btnCadastrar.Enabled = true;
            }

            else
            {
                btnCadastrar.Enabled = false;
            }
        }

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = ConexaoDB.CriarConexao();

            //abrir a conexão
            conexao.Open();

            //Criando o comando SQL para inserir o usuário
            string sql = $"INSERT INTO tbUsuarios (nome, telefone, usuario, senha) VALUES (@nome, @usuario, @telefone, @senha)";

            //Criando o comando
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", txtBoxNome.Text);
            comando.Parameters.AddWithValue("@usuario", txtBoxUsuario.Text);
            comando.Parameters.AddWithValue("@telefone", txtBoxTelefone.Text);
            comando.Parameters.AddWithValue("@senha", txtBoxSenhaoficial.Text);

            //Executando a instrução SQL no banco
            comando.ExecuteNonQuery();

            //Fechando a conexão
            conexao.Close();

            MessageBox.Show("Você foi cadastrado com sucesso!");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
