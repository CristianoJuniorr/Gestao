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
    public partial class FormConsultarCliente : Form
    {
        public FormConsultarCliente()
        {
            InitializeComponent();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                clienteBindingSource.DataSource = new ClienteBLL().BuscarPorNome(textBoxConsultarCliente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            using (FormCadastroCliente frm = new FormCadastroCliente())
            {
                frm.ShowDialog();

            }
        }

        private void FormConsultarCliente_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 3;
        }

        private void buttonExcluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if(clienteBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }
                new ClienteBLL().Excluir(((Cliente)clienteBindingSource.Current).Id);
                clienteBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonAlterarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe cliente para ser alterado.");
                    return;
                }
                int id = ((Cliente)clienteBindingSource.Current).Id;
                using (FormCadastroCliente frm = new FormCadastroCliente(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarCliente_Click(null, null);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
