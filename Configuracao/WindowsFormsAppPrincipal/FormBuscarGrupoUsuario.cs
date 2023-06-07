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
    public partial class FormBuscarGrupoUsuario : Form
    {
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (textBox1.Text == "")
                return;
            GrupoUsuarioBLL grupoUsuario = new GrupoUsuarioBLL();
            grupoUsuariosBindingSource.DataSource = grupoUsuario.BuscarPorNomeGrupoUsuario(textBox1.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            grupoUsuariosBindingSource.DataSource = grupoUsuarioBLL.BuscarTodos();

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
            using (FormAdicionarGrupo frm = new FormAdicionarGrupo())
            {
                frm.ShowDialog();
            }
                button1_Click(sender, e);

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
            if (grupoUsuariosBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído. ");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
            new GrupoUsuarioBLL().Excluir(id);
                MessageBox.Show("Grupo excluído com sucesso!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

          

        }

        private void buttonAlterarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
            int id = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;

            using (FormAdicionarGrupo frm = new FormAdicionarGrupo(true, id))
            {
                frm.ShowDialog();
            }
            button1_Click(sender, e);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdiconarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
            using (FormConsultarPermissaoGrupo frm = new FormConsultarPermissaoGrupo())
            {
                frm.ShowDialog();

                if (frm.Id == 0)
                    return;
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                int idGrupoUsuario = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
                permissaoBLL.AdicionarPermissao(frm.Id, idGrupoUsuario);
                    MessageBox.Show("Permissão adicionada com sucesso!");
                button1_Click(sender, e);
            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirPermissao_Click(object sender, EventArgs e)
        {
            try
            {
            if (permissoesBindingSource.Count == 0 || permissoesBindingSource.Count == 0)
            {
                MessageBox.Show("Não existe grupo de usuário para ser excluir.");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idPermissao = ((Permissao)permissoesBindingSource.Current).Id;
            int idGrupoUsuario = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
            new GrupoUsuarioBLL().RemoverPermissao(idGrupoUsuario, idPermissao);
            permissoesBindingSource.RemoveCurrent();

            MessageBox.Show("Permissão excluída com sucesso! ");
            //button1_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}

