using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppPrincipal
{
    public partial class FormAdicionarUsuario : Form
    {
        public FormAdicionarUsuario()
        {
            InitializeComponent();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = textBoxNome.Text;
            usuario.NomeUsuario = textBoxNomeUsuario.Text;
            usuario.CPF = textBoxCPF.Text;
            usuario.Email = textBoxEmail.Text;
            usuario.Senha = textBox5.Text;
            usuario.Ativo = checkBox1.Checked;


            usuarioBLL.Inserir(usuario);
            Close();
        }
    }
}
