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

namespace WindowsFormsAppPrincipal
{
    public partial class FormAdicionarGrupo : Form
    {
        public FormAdicionarGrupo()
        {
            InitializeComponent();
        }

        private void buttonCancelarAdicionarGrupo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSavarAdicionarGrupo_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            try
            {

                grupoUsuarioBindingSource.EndEdit();
                grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
                MessageBox.Show("Cadastrado com sucesso!");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tenrtar inserir um grupo no banco de dados."+ex.Message);
            }


        }

        private void FormAdicionarGrupo_Load(object sender, EventArgs e)
        {
            grupoUsuarioBindingSource.AddNew();
        }
    }
}
