using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void HabilitarBotaoLogin()
        {
            // Se a caixa de texto for diferente de vazio e a senha for maior ou igual do que 8 ele exibi o botão de entrar
            if (txtBoxUsuario.Text != "" && txtBoxSenha.Text.Length >= 8)
            {
                btnEntrar.Enabled = true;
            }

            else
            {
                btnEntrar.Enabled = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro FormularioTeste = new FrmCadastro();
            FormularioTeste.ShowDialog();
        }

        private void txtBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            
           HabilitarBotaoLogin();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotaoLogin();
        }
    }
}
