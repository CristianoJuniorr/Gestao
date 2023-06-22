﻿using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario()) 
            {
                frm.ShowDialog();
             
            }
            
        }

        private void grupoDeUsuáriosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (FormBuscarGrupoUsuario frm = new FormBuscarGrupoUsuario())
            {
                frm.ShowDialog();
             
            }
            

        }

        private void FormPrincipal_Load(object sender, System.EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (FormConsultarCliente frm = new FormConsultarCliente()) 
            {
                frm.ShowDialog();

            }
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (FormConsultarFornecedor frm = new FormConsultarFornecedor())
            {
                frm.ShowDialog();

            }
        }
    }
}
