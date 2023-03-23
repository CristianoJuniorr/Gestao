using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
           UsuarioBLL usuarioBLL = new UsuarioBLL();
           usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (textBox1.Text == "")
                return;
            UsuarioBLL usuario = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuario.BuscarPorNome(textBox1.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            using (FormAdicionarUsuario frm = new FormAdicionarUsuario())
            {
                frm.ShowDialog();
            }
                buttonBuscar_Click(sender, e);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
          int id =  ((Usuario)usuarioBindingSource.Current).Id;

            using (FormAdicionarUsuario frm = new FormAdicionarUsuario(true, id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(sender, e);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void buttonExcluirUsuario_Click_1(object sender, EventArgs e)
        {
            try
            {

            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído. ");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Usuario)usuarioBindingSource.Current).Id;
            new UsuarioBLL().Excluir(id);

            MessageBox.Show("Registro excluido com sucesso! ");
            buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void buttonAdicionarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
            using (FormConsultarGrupoUsuario frm = new FormConsultarGrupoUsuario())
            {
                frm.ShowDialog();

                if (frm.Id == 0)
                    return;
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                usuarioBLL.AdicionarGrupo(idUsuario, frm.Id);
                buttonBuscar_Click(sender, null);

            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        

        private void buttonExcluirGrupo_Click(object sender, EventArgs e)
        {
            try
            {
            if(usuarioBindingSource.Count == 0 || grupoUsuariosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existe grupo de usuário para ser excluir.");
                return;
            }
           
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
            int idGrupoUsuario = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
            new UsuarioBLL().RemoverGrupoUsuario(idUsuario, idGrupoUsuario);
            grupoUsuariosBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluido com sucesso! ");
            buttonBuscar_Click(null, null);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
