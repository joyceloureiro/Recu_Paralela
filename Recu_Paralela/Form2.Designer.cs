namespace Recu_Paralela
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRegarregar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditarr = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gvContatos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbDataContato = new System.Windows.Forms.MaskedTextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvContatos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRegarregar);
            this.tabPage1.Controls.Add(this.btnCarregar);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.btnEditarr);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.gvContatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegarregar
            // 
            this.btnRegarregar.Location = new System.Drawing.Point(665, 158);
            this.btnRegarregar.Name = "btnRegarregar";
            this.btnRegarregar.Size = new System.Drawing.Size(75, 23);
            this.btnRegarregar.TabIndex = 6;
            this.btnRegarregar.Text = "Regarregar";
            this.btnRegarregar.UseVisualStyleBackColor = true;
            this.btnRegarregar.Click += new System.EventHandler(this.btnRegarregar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(523, 11);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(116, 23);
            this.btnCarregar.TabIndex = 5;
            this.btnCarregar.Text = "Carregar Contatos";
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Contatos";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(665, 58);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo contato";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditarr
            // 
            this.btnEditarr.Location = new System.Drawing.Point(665, 129);
            this.btnEditarr.Name = "btnEditarr";
            this.btnEditarr.Size = new System.Drawing.Size(75, 23);
            this.btnEditarr.TabIndex = 2;
            this.btnEditarr.Text = "Deletar";
            this.btnEditarr.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(665, 100);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // gvContatos
            // 
            this.gvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContatos.Location = new System.Drawing.Point(6, 40);
            this.gvContatos.Name = "gvContatos";
            this.gvContatos.Size = new System.Drawing.Size(633, 322);
            this.gvContatos.TabIndex = 0;
            this.gvContatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvContatos_CellMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtbairro);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtNumero);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtUf);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtCidade);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnSalvar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.mtbDataContato);
            this.tabPage2.Controls.Add(this.txtEmpresa);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtCargo);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dtpDtNascimento);
            this.tabPage2.Controls.Add(this.mkbTelefone);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TxtRua);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(168, 125);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(91, 20);
            this.txtbairro.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(165, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(266, 125);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(54, 20);
            this.txtNumero.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Numero";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(108, 125);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(51, 20);
            this.txtUf.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Uf";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(23, 125);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(82, 20);
            this.txtCidade.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Cidade";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(38, 231);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 33);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Data do contato";
            // 
            // mtbDataContato
            // 
            this.mtbDataContato.Location = new System.Drawing.Point(223, 166);
            this.mtbDataContato.Mask = "00/00/0000";
            this.mtbDataContato.Name = "mtbDataContato";
            this.mtbDataContato.Size = new System.Drawing.Size(100, 20);
            this.mtbDataContato.TabIndex = 36;
            this.mtbDataContato.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(117, 166);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtEmpresa.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Empresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 33;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(21, 166);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(87, 20);
            this.txtCargo.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cargo";
            // 
            // dtpDtNascimento
            // 
            this.dtpDtNascimento.Location = new System.Drawing.Point(108, 83);
            this.dtpDtNascimento.Name = "dtpDtNascimento";
            this.dtpDtNascimento.Size = new System.Drawing.Size(229, 20);
            this.dtpDtNascimento.TabIndex = 30;
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(21, 83);
            this.mkbTelefone.Mask = "(00) 0000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(81, 20);
            this.mkbTelefone.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Data de nascimento";
            // 
            // TxtRua
            // 
            this.TxtRua.Location = new System.Drawing.Point(338, 125);
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(146, 20);
            this.TxtRua.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rua";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(220, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(193, 20);
            this.txtNome.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvContatos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gvContatos;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditarr;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbDataContato;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDtNascimento;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnRegarregar;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label14;
    }
}