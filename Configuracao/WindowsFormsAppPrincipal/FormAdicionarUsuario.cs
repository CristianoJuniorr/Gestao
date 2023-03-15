﻿using BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppPrincipal
{
    public partial class FormAdicionarUsuario : Form
    {
        private bool alterar;
        public FormAdicionarUsuario(bool _alterar = false, int _id=0)
        {
            InitializeComponent();
            alterar = _alterar;

            if (alterar)
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(_id);
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();


            try
            {
                usuarioBindingSource.EndEdit();
                usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current,textBoxConfrmarSenha.Text);

                MessageBox.Show("Cadastrado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar cadastrar um novo usuário."+ex.Message);
            }
         
        }

        private void buttonCancelarUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdicionarUsuario_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.AddNew();
        }
    }
}
