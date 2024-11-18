using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenda.Controller;

namespace ProjetoAgenda.Views
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            UsuarioController controleCategorias = new UsuarioController();
            DataTable tabela = controleCategorias.GetUsuarios();
            dgvUsuarios.DataSource = tabela;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxExcluir.Text;
            UsuarioController excluirusuario = new UsuarioController();
            excluirusuario.ExcluirUsuario(usuario);

            UsuarioController controleUsuarios = new UsuarioController();
            DataTable tabela = controleUsuarios.GetUsuarios();
            dgvUsuarios.DataSource = tabela;
        }
    }
}
