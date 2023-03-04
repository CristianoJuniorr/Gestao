using System.Windows.Forms;

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
    }
}
