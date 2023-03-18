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
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppPrincipal
{
    public partial class FormConsultarGrupoUsuario : Form
    {
        public int Id;
        public FormConsultarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscarConsultaGrupo_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarTodos();
        }

        private void buttonSelecionaConsultaGeupoUsuario_Click(object sender, EventArgs e)
        {
            if (grupoUsuarioBindingSource.Count > 0)
            {
                Id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                Close();
            }
            else
                MessageBox.Show("Não existe um grupo de usuário para ser relacionado. ");
        }

        private void buttonCancelarConsulta_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void textBoxConsultarGrupo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxConsultarGrupo.Text == "")
                    return;
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarPorNomeGrupoUsuario(textBoxConsultarGrupo.Text);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
