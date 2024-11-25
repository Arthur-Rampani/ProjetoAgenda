using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxRegistrarCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string categoria = txtBoxRegistrarCategoria.Text;
            CategoriaController controleCategoria = new CategoriaController();
            controleCategoria.AddCategoria(categoria);

            CategoriaController controleCategorias = new CategoriaController();
            DataTable tabela = controleCategorias.GetCategorias();
            dgvCategorias.DataSource = tabela;
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategorias = new CategoriaController();
            DataTable tabela = controleCategorias.GetCategorias();
            dgvCategorias.DataSource = tabela;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int categoria = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value);
            CategoriaController excluircategoria = new CategoriaController();
            excluircategoria.ExcluirCategoria(categoria);

            CategoriaController controleCategorias = new CategoriaController();
            DataTable tabela = controleCategorias.GetCategorias();
            dgvCategorias.DataSource = tabela;
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            int categoria = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value);
            CategoriaController alterarcategoria = new CategoriaController();
            alterarcategoria.AlterarCategoria(txtBoxRegistrarCategoria.Text, categoria);

            CategoriaController controleCategorias = new CategoriaController();
            DataTable tabela = controleCategorias.GetCategorias();
            dgvCategorias.DataSource = tabela;
        }
    }
}
