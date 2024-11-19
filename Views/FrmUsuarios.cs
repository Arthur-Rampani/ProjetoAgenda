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
            string usuario = Convert.ToString(dgvUsuarios.SelectedRows[0].Cells[0].Value);
            UsuarioController excluirusuario = new UsuarioController();
            bool resultado = excluirusuario.ExcluirUsuario(usuario);

            if (resultado)
            {
                DialogResult result = MessageBox.Show("Exclusão Concluída!");

                if (result == DialogResult.OK)
                {
                    UsuarioController controleUsuarios = new UsuarioController();
                    DataTable tabela = controleUsuarios.GetUsuarios();

                    dgvUsuarios.DataSource = tabela;
                }
            }
            else
            {
                MessageBox.Show("Exclusão não foi Concluída");
            }

           
        }
    }
}
