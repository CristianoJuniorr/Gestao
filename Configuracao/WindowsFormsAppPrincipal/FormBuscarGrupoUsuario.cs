using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarGrupoUsuario : Form
    {
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuario = new GrupoUsuarioBLL();
            grupoUsuariosBindingSource.DataSource = grupoUsuario.BuscarPorNomeGrupoUsuario(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            grupoUsuariosBindingSource.DataSource = grupoUsuarioBLL.BuscarTodos();
        }

        private void FormBuscarGrupoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
