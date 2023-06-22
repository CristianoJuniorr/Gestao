namespace WindowsFormsAppPrincipal
{
    partial class FormConsultarFornecedor
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
            this.fornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxConsultarFornecedor = new System.Windows.Forms.TextBox();
            this.comboBoxBuscarPorForn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarFornecedor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAlterarFornecedor = new System.Windows.Forms.Button();
            this.buttonExcluirFornecedor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fornecedorDataGridView
            // 
            this.fornecedorDataGridView.AllowUserToAddRows = false;
            this.fornecedorDataGridView.AllowUserToDeleteRows = false;
            this.fornecedorDataGridView.AllowUserToOrderColumns = true;
            this.fornecedorDataGridView.AutoGenerateColumns = false;
            this.fornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.fornecedorDataGridView.DataSource = this.fornecedorBindingSource;
            this.fornecedorDataGridView.Location = new System.Drawing.Point(12, 132);
            this.fornecedorDataGridView.Name = "fornecedorDataGridView";
            this.fornecedorDataGridView.ReadOnly = true;
            this.fornecedorDataGridView.RowHeadersWidth = 51;
            this.fornecedorDataGridView.RowTemplate.Height = 24;
            this.fornecedorDataGridView.Size = new System.Drawing.Size(776, 257);
            this.fornecedorDataGridView.TabIndex = 1;
            // 
            // textBoxConsultarFornecedor
            // 
            this.textBoxConsultarFornecedor.Location = new System.Drawing.Point(140, 105);
            this.textBoxConsultarFornecedor.Name = "textBoxConsultarFornecedor";
            this.textBoxConsultarFornecedor.Size = new System.Drawing.Size(324, 22);
            this.textBoxConsultarFornecedor.TabIndex = 2;
            // 
            // comboBoxBuscarPorForn
            // 
            this.comboBoxBuscarPorForn.FormattingEnabled = true;
            this.comboBoxBuscarPorForn.Items.AddRange(new object[] {
            "ID ",
            "Nome ",
            "Site",
            "Todos"});
            this.comboBoxBuscarPorForn.Location = new System.Drawing.Point(13, 104);
            this.comboBoxBuscarPorForn.Name = "comboBoxBuscarPorForn";
            this.comboBoxBuscarPorForn.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBuscarPorForn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por:";
            // 
            // buttonBuscarFornecedor
            // 
            this.buttonBuscarFornecedor.Location = new System.Drawing.Point(470, 105);
            this.buttonBuscarFornecedor.Name = "buttonBuscarFornecedor";
            this.buttonBuscarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarFornecedor.TabIndex = 5;
            this.buttonBuscarFornecedor.Text = "Buscar";
            this.buttonBuscarFornecedor.UseVisualStyleBackColor = true;
            this.buttonBuscarFornecedor.Click += new System.EventHandler(this.buttonBuscarFornecedor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAlterarFornecedor
            // 
            this.buttonAlterarFornecedor.Location = new System.Drawing.Point(632, 104);
            this.buttonAlterarFornecedor.Name = "buttonAlterarFornecedor";
            this.buttonAlterarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarFornecedor.TabIndex = 7;
            this.buttonAlterarFornecedor.Text = "Alterar";
            this.buttonAlterarFornecedor.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirFornecedor
            // 
            this.buttonExcluirFornecedor.Location = new System.Drawing.Point(713, 103);
            this.buttonExcluirFornecedor.Name = "buttonExcluirFornecedor";
            this.buttonExcluirFornecedor.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirFornecedor.TabIndex = 8;
            this.buttonExcluirFornecedor.Text = "Excluir";
            this.buttonExcluirFornecedor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Consultar Fornecedor";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Site";
            this.dataGridViewTextBoxColumn5.HeaderText = "Site";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(Models.Fornecedor);
            // 
            // FormConsultarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExcluirFornecedor);
            this.Controls.Add(this.buttonAlterarFornecedor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBuscarFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBuscarPorForn);
            this.Controls.Add(this.textBoxConsultarFornecedor);
            this.Controls.Add(this.fornecedorDataGridView);
            this.Name = "FormConsultarFornecedor";
            this.Text = "FormConsultarFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.DataGridView fornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBoxConsultarFornecedor;
        private System.Windows.Forms.ComboBox comboBoxBuscarPorForn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarFornecedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAlterarFornecedor;
        private System.Windows.Forms.Button buttonExcluirFornecedor;
        private System.Windows.Forms.Label label2;
    }
}