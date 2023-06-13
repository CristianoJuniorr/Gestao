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
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void buttonSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)clienteBindingSource.Current;
                clienteBindingSource.EndEdit();
                new ClienteBLL().Inserir(cliente);
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void buttonCancelarCadCliente_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            try
            {
                clienteBindingSource.AddNew();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
