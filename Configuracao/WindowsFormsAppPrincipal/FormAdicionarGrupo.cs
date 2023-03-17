using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormAdicionarGrupo : Form
    {
        private bool alterar;
        public FormAdicionarGrupo(bool _alterar = false, int _id = 0)
        {
            InitializeComponent();
            alterar = _alterar;

            if (alterar)
                grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorId(_id);
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
                if (!alterar)
                    grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
                else
                    grupoUsuarioBLL.Alterar((GrupoUsuario)grupoUsuarioBindingSource.Current);
                MessageBox.Show("Salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UsuarioBLL usuarioBLL = new UsuarioBLL();


        }

        private void FormAdicionarGrupo_Load(object sender, EventArgs e)
        {
            if (!alterar)
                grupoUsuarioBindingSource.AddNew();
        }
    }
}
