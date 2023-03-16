using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BLL;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormConsultarGrupoUsuario : Form
    {
        public FormConsultarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscarConsultaGrupo_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorNomeGrupoUsuario(buttonBuscarConsultaGrupo.Text);
        }
    }
}
