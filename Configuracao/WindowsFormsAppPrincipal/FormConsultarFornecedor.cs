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
    public partial class FormConsultarFornecedor : Form
    {
        public FormConsultarFornecedor()
        {
            InitializeComponent();
        }

        private void buttonBuscarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPorForn.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxConsultarFornecedor.Text))
                            throw new Exception("Informe um id para fazer a busca.");

                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorId(Convert.ToInt32(textBoxConsultarFornecedor.Text));
                        break;

                    case 1:
                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorNome(textBoxConsultarFornecedor.Text);
                        break;

                    case 2:
                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorSite(textBoxConsultarFornecedor.Text);
                        break;

                    case 3:
                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarTodos();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormCadastroFornecedor frm = new FormCadastroFornecedor())
            {
                frm.ShowDialog();

            }
        }

        private void buttonAlterarFornecedor_Click(object sender, EventArgs e)
        {

            try
            {
                if (fornecedorBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe fornecedor para ser alterado.");
                    return;
                }
                int id = ((Fornecedor)fornecedorBindingSource.Current).Id;
                using (FormCadastroFornecedor frm = new FormCadastroFornecedor(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarFornecedor_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (fornecedorBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;


                new FornecedorBLL().Excluir(((Fornecedor)fornecedorBindingSource.Current).Id);
                fornecedorBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
