namespace WindowsFormsAppPrincipal
{
    partial class FormConsultarPermissaoGrupo
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
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelecionarConsultarPermissao = new System.Windows.Forms.Button();
            this.CancelarConsultaPermissao = new System.Windows.Forms.Button();
            this.textBoxConsultarPermissao = new System.Windows.Forms.TextBox();
            this.buttonBuscarPermissao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(31, 197);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersWidth = 51;
            this.permissaoDataGridView.RowTemplate.Height = 24;
            this.permissaoDataGridView.Size = new System.Drawing.Size(796, 374);
            this.permissaoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Permissões";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // buttonSelecionarConsultarPermissao
            // 
            this.buttonSelecionarConsultarPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarConsultarPermissao.Location = new System.Drawing.Point(584, 578);
            this.buttonSelecionarConsultarPermissao.Name = "buttonSelecionarConsultarPermissao";
            this.buttonSelecionarConsultarPermissao.Size = new System.Drawing.Size(118, 44);
            this.buttonSelecionarConsultarPermissao.TabIndex = 2;
            this.buttonSelecionarConsultarPermissao.Text = "Selecionar";
            this.buttonSelecionarConsultarPermissao.UseVisualStyleBackColor = true;
            this.buttonSelecionarConsultarPermissao.Click += new System.EventHandler(this.buttonSelecionarConsultarPermissao_Click);
            // 
            // CancelarConsultaPermissao
            // 
            this.CancelarConsultaPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarConsultaPermissao.Location = new System.Drawing.Point(708, 577);
            this.CancelarConsultaPermissao.Name = "CancelarConsultaPermissao";
            this.CancelarConsultaPermissao.Size = new System.Drawing.Size(118, 44);
            this.CancelarConsultaPermissao.TabIndex = 2;
            this.CancelarConsultaPermissao.Text = "Cancelar";
            this.CancelarConsultaPermissao.UseVisualStyleBackColor = true;
            this.CancelarConsultaPermissao.Click += new System.EventHandler(this.CancelarConsultaPermissao_Click);
            // 
            // textBoxConsultarPermissao
            // 
            this.textBoxConsultarPermissao.Location = new System.Drawing.Point(31, 169);
            this.textBoxConsultarPermissao.Name = "textBoxConsultarPermissao";
            this.textBoxConsultarPermissao.Size = new System.Drawing.Size(672, 22);
            this.textBoxConsultarPermissao.TabIndex = 3;
            this.textBoxConsultarPermissao.TextChanged += new System.EventHandler(this.textBoxConsultarPermissao_TextChanged);
            // 
            // buttonBuscarPermissao
            // 
            this.buttonBuscarPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarPermissao.Location = new System.Drawing.Point(707, 165);
            this.buttonBuscarPermissao.Name = "buttonBuscarPermissao";
            this.buttonBuscarPermissao.Size = new System.Drawing.Size(118, 29);
            this.buttonBuscarPermissao.TabIndex = 4;
            this.buttonBuscarPermissao.Text = "Buscar";
            this.buttonBuscarPermissao.UseVisualStyleBackColor = true;
            this.buttonBuscarPermissao.Click += new System.EventHandler(this.buttonBuscarPermissao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(196, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consultar permissão";
            // 
            // FormConsultarPermissaoGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppPrincipal.Properties.Resources.Foto_Panel_de_Cadastro8;
            this.ClientSize = new System.Drawing.Size(860, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscarPermissao);
            this.Controls.Add(this.textBoxConsultarPermissao);
            this.Controls.Add(this.CancelarConsultaPermissao);
            this.Controls.Add(this.buttonSelecionarConsultarPermissao);
            this.Controls.Add(this.permissaoDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultarPermissaoGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultarPermissaoGrupo";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonSelecionarConsultarPermissao;
        private System.Windows.Forms.Button CancelarConsultaPermissao;
        private System.Windows.Forms.TextBox textBoxConsultarPermissao;
        private System.Windows.Forms.Button buttonBuscarPermissao;
        private System.Windows.Forms.Label label1;
    }
}