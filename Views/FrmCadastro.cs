using MySql.Data.MySqlClient;
using ProjetoAgenda.Controller;
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
            //pegando os dados do formulário
            string nome = txtBoxNome.Text;
            string usuario = txtBoxUsuario.Text;
            string telefone = txtBoxTelefone.Text;
            string senha = txtBoxSenhaoficial.Text;

            //instanciando o objeto UsuarioController
            UsuarioController controleUsuario = new UsuarioController();

            //Inserindo o usuário
            bool resultado = controleUsuario.AddUsuario(nome, usuario, telefone, senha);

            if(resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
