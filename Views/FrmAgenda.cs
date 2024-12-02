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
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabelacategoria = controleCategoria.GetCategorias();
            comboBoxCategorias.DataSource = tabelacategoria;
            comboBoxCategorias.DisplayMember = "categoria";

            ContatoController controleContatos = new ContatoController();
            DataTable tabela = controleContatos.GetContato();
            dgvContatos.DataSource = tabela;


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int contato = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells[0].Value);
            ContatoController excluircontato = new ContatoController();
            excluircontato.ExcluirContato(contato);

            ContatoController controleCategorias = new ContatoController();
            DataTable tabela = controleCategorias.GetContato();
            dgvContatos.DataSource = tabela;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int contato = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells[0].Value);
            ContatoController alterarcontato = new ContatoController();
            alterarcontato.AlterarContato(txtBoxContato.Text, contato, (txtBoxTelefone.Text), comboBoxCategorias.Text);

            ContatoController controleContato = new ContatoController();
            DataTable tabela = controleContato.GetContato();
            dgvContatos.DataSource = tabela;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string contato = txtBoxContato.Text;
            string contato2 = txtBoxTelefone.Text;
            string contato3 = comboBoxCategorias.Text;
            ContatoController controleContato = new ContatoController();
            controleContato.AddContato(contato, contato2, contato3);

            ContatoController controleContatos = new ContatoController();
            DataTable tabela = controleContatos.GetContato();
            dgvContatos.DataSource = tabela;
        }
    }
}
