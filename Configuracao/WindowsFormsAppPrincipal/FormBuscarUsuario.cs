using BLL;
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
            using (FormAlterarUsuarioi frm = new FormAlterarUsuarioi())
            {
                frm.ShowDialog();
            }

        }

        private void buttonBuscarGrupo_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
            grupoUsuariosBindingSource.DataSource = grupousuarioBLL.BuscarTodos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                GrupoUsuarioBLL grupousuario = new GrupoUsuarioBLL();
                grupoUsuariosBindingSource.DataSource = grupousuario.BuscarPorNomeGrupoUsuario(textBox2.Text);
            

        }
    }
}
