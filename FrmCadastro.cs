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
            if (txtBoxNome.Text != "" && txtBoxUsuario.Text != "" && txtBoxSenha.Text.Length >= 8 && txtBoxRepetirSenha.Text == txtBoxSenha.Text)
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
            
        }
    }
}
