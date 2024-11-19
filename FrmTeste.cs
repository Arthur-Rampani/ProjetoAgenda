using MySqlX.XDevAPI;
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
using ProjetoAgenda.VariableGlobal;

namespace ProjetoAgenda
{
    public partial class FrmTeste : Form
    {
        public FrmTeste()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Usersession.Usuario = textBox1.Text;
            Usersession.Senha = textBox2.Text;
            Usersession.Nome = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Usersession.Usuario);
            MessageBox.Show(Usersession.Senha);
            MessageBox.Show(Usersession.Nome);
        }
    }
}
