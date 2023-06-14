namespace WindowsFormsAppPrincipal
{
    partial class FormCadastroCliente
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cPFLabel;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvarCliente = new System.Windows.Forms.Button();
            this.buttonCancelarCadCliente = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(53, 149);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(394, 211);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(30, 16);
            rGLabel.TabIndex = 3;
            rGLabel.Text = "RG:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(36, 264);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(64, 16);
            telefoneLabel.TabIndex = 5;
            telefoneLabel.Text = "Telefone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(56, 208);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(388, 146);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(36, 16);
            cPFLabel.TabIndex = 9;
            cPFLabel.Text = "CPF:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(106, 146);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(237, 22);
            this.nomeTextBox.TabIndex = 2;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(430, 208);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(257, 22);
            this.rGTextBox.TabIndex = 4;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(106, 261);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(237, 22);
            this.telefoneTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(106, 205);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(237, 22);
            this.emailTextBox.TabIndex = 8;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(430, 143);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(257, 22);
            this.cPFTextBox.TabIndex = 10;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // buttonSalvarCliente
            // 
            this.buttonSalvarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCliente.Location = new System.Drawing.Point(499, 362);
            this.buttonSalvarCliente.Name = "buttonSalvarCliente";
            this.buttonSalvarCliente.Size = new System.Drawing.Size(78, 40);
            this.buttonSalvarCliente.TabIndex = 12;
            this.buttonSalvarCliente.Text = "Salvar";
            this.buttonSalvarCliente.UseVisualStyleBackColor = true;
            this.buttonSalvarCliente.Click += new System.EventHandler(this.buttonSalvarCliente_Click);
            // 
            // buttonCancelarCadCliente
            // 
            this.buttonCancelarCadCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelarCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadCliente.Location = new System.Drawing.Point(597, 362);
            this.buttonCancelarCadCliente.Name = "buttonCancelarCadCliente";
            this.buttonCancelarCadCliente.Size = new System.Drawing.Size(112, 41);
            this.buttonCancelarCadCliente.TabIndex = 13;
            this.buttonCancelarCadCliente.Text = "Cancelar";
            this.buttonCancelarCadCliente.UseVisualStyleBackColor = true;
            this.buttonCancelarCadCliente.Click += new System.EventHandler(this.buttonCancelarCadCliente_Click);
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelarCadCliente);
            this.Controls.Add(this.buttonSalvarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Name = "FormCadastroCliente";
            this.Text = "FormCadastroCliente";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvarCliente;
        private System.Windows.Forms.Button buttonCancelarCadCliente;
    }
}