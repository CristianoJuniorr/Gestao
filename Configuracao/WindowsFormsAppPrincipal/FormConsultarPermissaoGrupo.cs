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
    public partial class FormConsultarPermissaoGrupo : Form
    {
        public int Id;
        public FormConsultarPermissaoGrupo()
        {
            InitializeComponent();
        }

        private void buttonBuscarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            permissaoBindingSource.DataSource = permissaoBLL.BuscarTodos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxConsultarPermissao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxConsultarPermissao.Text == "")
                    return;
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                permissaoBindingSource.DataSource = permissaoBLL.BuscarPorNomeDescricao(textBoxConsultarPermissao.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonSelecionarConsultarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
            if (permissaoBindingSource.Count > 0)
            {
                Id = ((Permissao)permissaoBindingSource.Current).Id;
                Close();
            }
            else
                MessageBox.Show("Não existe permissões para serem relacionadas. ");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CancelarConsultaPermissao_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
