namespace WindowsFormsAppPrincipal
{
    partial class FormConsultarCliente
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
            this.buttonExcluirCliente = new System.Windows.Forms.Button();
            this.buttonAlterarCliente = new System.Windows.Forms.Button();
            this.buttonAdicionarCliente = new System.Windows.Forms.Button();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.textBoxConsultarCliente = new System.Windows.Forms.TextBox();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSelecionarConsultaCliente = new System.Windows.Forms.Button();
            this.buttonCancelarConsultaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExcluirCliente
            // 
            this.buttonExcluirCliente.Location = new System.Drawing.Point(873, 103);
            this.buttonExcluirCliente.Name = "buttonExcluirCliente";
            this.buttonExcluirCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirCliente.TabIndex = 12;
            this.buttonExcluirCliente.Text = "Exlcuir";
            this.buttonExcluirCliente.UseVisualStyleBackColor = true;
            this.buttonExcluirCliente.Click += new System.EventHandler(this.buttonExcluirCliente_Click);
            // 
            // buttonAlterarCliente
            // 
            this.buttonAlterarCliente.Location = new System.Drawing.Point(792, 103);
            this.buttonAlterarCliente.Name = "buttonAlterarCliente";
            this.buttonAlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarCliente.TabIndex = 11;
            this.buttonAlterarCliente.Text = "Alterar";
            this.buttonAlterarCliente.UseVisualStyleBackColor = true;
            this.buttonAlterarCliente.Click += new System.EventHandler(this.buttonAlterarCliente_Click);
            // 
            // buttonAdicionarCliente
            // 
            this.buttonAdicionarCliente.Location = new System.Drawing.Point(700, 102);
            this.buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            this.buttonAdicionarCliente.Size = new System.Drawing.Size(86, 23);
            this.buttonAdicionarCliente.TabIndex = 10;
            this.buttonAdicionarCliente.Text = "Adicionar ";
            this.buttonAdicionarCliente.UseVisualStyleBackColor = true;
            this.buttonAdicionarCliente.Click += new System.EventHandler(this.buttonAdicionarCliente_Click);
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(619, 102);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarCliente.TabIndex = 9;
            this.buttonBuscarCliente.Text = "Buscar";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // textBoxConsultarCliente
            // 
            this.textBoxConsultarCliente.Location = new System.Drawing.Point(139, 104);
            this.textBoxConsultarCliente.Name = "textBoxConsultarCliente";
            this.textBoxConsultarCliente.Size = new System.Drawing.Size(474, 22);
            this.textBoxConsultarCliente.TabIndex = 8;
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AllowUserToOrderColumns = true;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(12, 138);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.RowHeadersWidth = 51;
            this.clienteDataGridView.RowTemplate.Height = 24;
            this.clienteDataGridView.Size = new System.Drawing.Size(936, 340);
            this.clienteDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RG";
            this.dataGridViewTextBoxColumn4.HeaderText = "RG";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Consultar Cliente";
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Id ",
            "Nome ",
            "CPF",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(12, 103);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBuscarPor.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar por ";
            // 
            // buttonSelecionarConsultaCliente
            // 
            this.buttonSelecionarConsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionarConsultaCliente.Location = new System.Drawing.Point(688, 485);
            this.buttonSelecionarConsultaCliente.Name = "buttonSelecionarConsultaCliente";
            this.buttonSelecionarConsultaCliente.Size = new System.Drawing.Size(110, 32);
            this.buttonSelecionarConsultaCliente.TabIndex = 17;
            this.buttonSelecionarConsultaCliente.Text = "Selecionar";
            this.buttonSelecionarConsultaCliente.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarConsultaCliente
            // 
            this.buttonCancelarConsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarConsultaCliente.Location = new System.Drawing.Point(821, 488);
            this.buttonCancelarConsultaCliente.Name = "buttonCancelarConsultaCliente";
            this.buttonCancelarConsultaCliente.Size = new System.Drawing.Size(112, 29);
            this.buttonCancelarConsultaCliente.TabIndex = 18;
            this.buttonCancelarConsultaCliente.Text = "Cancelar";
            this.buttonCancelarConsultaCliente.UseVisualStyleBackColor = true;
            // 
            // FormConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 523);
            this.Controls.Add(this.buttonCancelarConsultaCliente);
            this.Controls.Add(this.buttonSelecionarConsultaCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.buttonExcluirCliente);
            this.Controls.Add(this.buttonAlterarCliente);
            this.Controls.Add(this.buttonAdicionarCliente);
            this.Controls.Add(this.buttonBuscarCliente);
            this.Controls.Add(this.textBoxConsultarCliente);
            this.Name = "FormConsultarCliente";
            this.Text = "FormConsultarCliente";
            this.Load += new System.EventHandler(this.FormConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExcluirCliente;
        private System.Windows.Forms.Button buttonAlterarCliente;
        private System.Windows.Forms.Button buttonAdicionarCliente;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.TextBox textBoxConsultarCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelecionarConsultaCliente;
        private System.Windows.Forms.Button buttonCancelarConsultaCliente;
    }
}