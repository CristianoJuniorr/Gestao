using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
           UsuarioBLL usuarioBLL = new UsuarioBLL();
           usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UsuarioBLL usuario = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuario.BuscarPorNomeUsuario(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FormAdicionarUsuario frm = new FormAdicionarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

          int id =  ((Usuario)usuarioBindingSource.Current).Id;

            using (FormAdicionarUsuario frm = new FormAdicionarUsuario(true, id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(sender, e);


        }


    }
}
