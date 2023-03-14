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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppPrincipal
{
    public partial class FormAlterarUsuarioi : Form
    {
        public FormAlterarUsuarioi()
        {
            InitializeComponent();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario _alterar = new Usuario();
            _alterar.NomeUsuario = textBoxAlterarNomeUsuario.Text;
            _alterar.Email = textBoxAlterarEmailUsuario.Text;
            _alterar.Senha = textBoxAlterarSenhaUsuario.Text;
            _alterar.Ativo = checkBoxAtivo.Checked;
            _alterar.Id = Convert.ToInt32(textBoxAlterarUsuarioID.Text);
            _alterar.Nome = textBoxAlterarNome.Text;
            usuarioBLL.Alterar(_alterar);
            Close();
        }

        private void buttonCancelarAlteraçãoUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
