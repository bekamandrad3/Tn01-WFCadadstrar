namespace WFCadastroEndereco
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            btnSalvar = new Button();
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            lblCep = new Label();
            lblLinha = new Label();
            mtbCep = new MaskedTextBox();
            lblLogradouro = new Label();
            lblNumero = new Label();
            lblComplemento = new Label();
            lblBairro = new Label();
            lblCidade = new Label();
            lblUf = new Label();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            chkSemNumero = new CheckBox();
            cbxUf = new ComboBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(477, 316);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 45);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(33, 9);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(25, 33);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(359, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(33, 85);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 9;
            lblCep.Text = "Cep";
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(25, 69);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(359, 1);
            lblLinha.TabIndex = 1;
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(25, 115);
            mtbCep.Mask = "00000-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(100, 23);
            mtbCep.TabIndex = 11;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(33, 156);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 12;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(158, 156);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 13;
            lblNumero.Text = "Número";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(25, 241);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 14;
            lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(158, 241);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 15;
            lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(42, 331);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 16;
            lblCidade.Text = "Cidade";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(144, 331);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 17;
            lblUf.Text = "UF";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(25, 188);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(100, 23);
            txtLogradouro.TabIndex = 18;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(158, 188);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 19;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(25, 279);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(100, 23);
            txtComplemento.TabIndex = 20;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(158, 279);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 21;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(25, 363);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 22;
            // 
            // chkSemNumero
            // 
            chkSemNumero.AutoSize = true;
            chkSemNumero.Location = new Point(264, 190);
            chkSemNumero.Name = "chkSemNumero";
            chkSemNumero.Size = new Size(104, 19);
            chkSemNumero.TabIndex = 24;
            chkSemNumero.Text = "Sem Número ?";
            chkSemNumero.UseVisualStyleBackColor = true;
            chkSemNumero.CheckedChanged += chkSemNumero_CheckedChanged;
            // 
            // cbxUf
            // 
            cbxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUf.FormattingEnabled = true;
            cbxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUf.Location = new Point(148, 367);
            cbxUf.Name = "cbxUf";
            cbxUf.Size = new Size(121, 23);
            cbxUf.TabIndex = 25;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 446);
            Controls.Add(cbxUf);
            Controls.Add(chkSemNumero);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(lblUf);
            Controls.Add(lblCidade);
            Controls.Add(lblBairro);
            Controls.Add(lblComplemento);
            Controls.Add(lblNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(mtbCep);
            Controls.Add(lblLinha);
            Controls.Add(lblCep);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalvar;
        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Label lblCep;
        private Label lblLinha;
        private MaskedTextBox mtbCep;
        private Label lblLogradouro;
        private Label lblNumero;
        private Label lblComplemento;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblUf;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private CheckBox chkSemNumero;
        private ComboBox cbxUf;
    }
}