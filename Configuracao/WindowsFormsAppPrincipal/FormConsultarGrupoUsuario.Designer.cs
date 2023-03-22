namespace WindowsFormsAppPrincipal
{
    partial class FormConsultarGrupoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelecionaConsultaGeupoUsuario = new System.Windows.Forms.Button();
            this.buttonCancelarConsulta = new System.Windows.Forms.Button();
            this.textBoxConsultarGrupo = new System.Windows.Forms.TextBox();
            this.buttonBuscarConsultaGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // grupoUsuarioDataGridView
            // 
            this.grupoUsuarioDataGridView.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView.AllowUserToResizeRows = false;
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(31, 185);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersVisible = false;
            this.grupoUsuarioDataGridView.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(775, 346);
            this.grupoUsuarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Grupos";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // buttonSelecionaConsultaGeupoUsuario
            // 
            this.buttonSelecionaConsultaGeupoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionaConsultaGeupoUsuario.Location = new System.Drawing.Point(596, 537);
            this.buttonSelecionaConsultaGeupoUsuario.Name = "buttonSelecionaConsultaGeupoUsuario";
            this.buttonSelecionaConsultaGeupoUsuario.Size = new System.Drawing.Size(109, 35);
            this.buttonSelecionaConsultaGeupoUsuario.TabIndex = 2;
            this.buttonSelecionaConsultaGeupoUsuario.Text = "Selecionar";
            this.buttonSelecionaConsultaGeupoUsuario.UseVisualStyleBackColor = true;
            this.buttonSelecionaConsultaGeupoUsuario.Click += new System.EventHandler(this.buttonSelecionaConsultaGeupoUsuario_Click);
            // 
            // buttonCancelarConsulta
            // 
            this.buttonCancelarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarConsulta.Location = new System.Drawing.Point(711, 537);
            this.buttonCancelarConsulta.Name = "buttonCancelarConsulta";
            this.buttonCancelarConsulta.Size = new System.Drawing.Size(95, 35);
            this.buttonCancelarConsulta.TabIndex = 2;
            this.buttonCancelarConsulta.Text = "Cancelar";
            this.buttonCancelarConsulta.UseVisualStyleBackColor = true;
            this.buttonCancelarConsulta.Click += new System.EventHandler(this.buttonCancelarConsulta_Click);
            // 
            // textBoxConsultarGrupo
            // 
            this.textBoxConsultarGrupo.Location = new System.Drawing.Point(31, 157);
            this.textBoxConsultarGrupo.Name = "textBoxConsultarGrupo";
            this.textBoxConsultarGrupo.Size = new System.Drawing.Size(652, 22);
            this.textBoxConsultarGrupo.TabIndex = 3;
            this.textBoxConsultarGrupo.TextChanged += new System.EventHandler(this.textBoxConsultarGrupo_TextChanged);
            // 
            // buttonBuscarConsultaGrupo
            // 
            this.buttonBuscarConsultaGrupo.Location = new System.Drawing.Point(689, 156);
            this.buttonBuscarConsultaGrupo.Name = "buttonBuscarConsultaGrupo";
            this.buttonBuscarConsultaGrupo.Size = new System.Drawing.Size(117, 23);
            this.buttonBuscarConsultaGrupo.TabIndex = 4;
            this.buttonBuscarConsultaGrupo.Text = "Buscar";
            this.buttonBuscarConsultaGrupo.UseVisualStyleBackColor = true;
            this.buttonBuscarConsultaGrupo.Click += new System.EventHandler(this.buttonBuscarConsultaGrupo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(131, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consultar grupos de usuários ";
            // 
            // FormConsultarGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppPrincipal.Properties.Resources.Foto_Panel_de_Cadastro7;
            this.ClientSize = new System.Drawing.Size(833, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscarConsultaGrupo);
            this.Controls.Add(this.textBoxConsultarGrupo);
            this.Controls.Add(this.buttonCancelarConsulta);
            this.Controls.Add(this.buttonSelecionaConsultaGeupoUsuario);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultarGrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Grupos de usuarios ";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.Button buttonSelecionaConsultaGeupoUsuario;
        private System.Windows.Forms.Button buttonCancelarConsulta;
        private System.Windows.Forms.TextBox textBoxConsultarGrupo;
        private System.Windows.Forms.Button buttonBuscarConsultaGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}