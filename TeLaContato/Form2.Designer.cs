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
            tabControl1=new TabControl();
            tabPage1=new TabPage();
            btnRegarregar=new Button();
            btnCarregar=new Button();
            label8=new Label();
            btnNovo=new Button();
            btnEditarr=new Button();
            btnEditar=new Button();
            gvContatos=new DataGridView();
            tabPage2=new TabPage();
            txtbairro=new TextBox();
            label14=new Label();
            txtNumero=new TextBox();
            label13=new Label();
            txtUf=new TextBox();
            label11=new Label();
            txtCidade=new TextBox();
            label12=new Label();
            btnSalvar=new Button();
            label10=new Label();
            mtbDataContato=new MaskedTextBox();
            txtEmpresa=new TextBox();
            label9=new Label();
            label6=new Label();
            txtCargo=new TextBox();
            label7=new Label();
            dtpDtNascimento=new DateTimePicker();
            mkbTelefone=new MaskedTextBox();
            label5=new Label();
            label4=new Label();
            TxtRua=new TextBox();
            label3=new Label();
            txtEmail=new TextBox();
            label2=new Label();
            txtNome=new TextBox();
            label1=new Label();
            Delete=new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvContatos).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location=new Point(4, 14);
            tabControl1.Margin=new Padding(4, 3, 4, 3);
            tabControl1.Name="tabControl1";
            tabControl1.SelectedIndex=0;
            tabControl1.Size=new Size(905, 468);
            tabControl1.TabIndex=0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRegarregar);
            tabPage1.Controls.Add(btnCarregar);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btnNovo);
            tabPage1.Controls.Add(btnEditarr);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(gvContatos);
            tabPage1.Location=new Point(4, 24);
            tabPage1.Margin=new Padding(4, 3, 4, 3);
            tabPage1.Name="tabPage1";
            tabPage1.Padding=new Padding(4, 3, 4, 3);
            tabPage1.Size=new Size(897, 440);
            tabPage1.TabIndex=0;
            tabPage1.UseVisualStyleBackColor=true;
            // 
            // btnRegarregar
            // 
            btnRegarregar.Location=new Point(776, 182);
            btnRegarregar.Margin=new Padding(4, 3, 4, 3);
            btnRegarregar.Name="btnRegarregar";
            btnRegarregar.Size=new Size(88, 27);
            btnRegarregar.TabIndex=6;
            btnRegarregar.Text="Regarregar";
            btnRegarregar.UseVisualStyleBackColor=true;
            btnRegarregar.Click+=btnRegarregar_Click;
            // 
            // btnCarregar
            // 
            btnCarregar.Location=new Point(610, 13);
            btnCarregar.Margin=new Padding(4, 3, 4, 3);
            btnCarregar.Name="btnCarregar";
            btnCarregar.Size=new Size(135, 27);
            btnCarregar.TabIndex=5;
            btnCarregar.Text="Carregar Contatos";
            btnCarregar.UseVisualStyleBackColor=true;
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Font=new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location=new Point(7, 3);
            label8.Margin=new Padding(4, 0, 4, 0);
            label8.Name="label8";
            label8.Size=new Size(83, 24);
            label8.TabIndex=4;
            label8.Text="Contatos";
            // 
            // btnNovo
            // 
            btnNovo.Location=new Point(776, 67);
            btnNovo.Margin=new Padding(4, 3, 4, 3);
            btnNovo.Name="btnNovo";
            btnNovo.Size=new Size(88, 27);
            btnNovo.TabIndex=3;
            btnNovo.Text="Novo contato";
            btnNovo.UseVisualStyleBackColor=true;
            // 
            // btnEditarr
            // 
            btnEditarr.Location=new Point(776, 149);
            btnEditarr.Margin=new Padding(4, 3, 4, 3);
            btnEditarr.Name="btnEditarr";
            btnEditarr.Size=new Size(88, 27);
            btnEditarr.TabIndex=2;
            btnEditarr.Text="Deletar";
            btnEditarr.UseVisualStyleBackColor=true;
            // 
            // btnEditar
            // 
            btnEditar.Location=new Point(776, 115);
            btnEditar.Margin=new Padding(4, 3, 4, 3);
            btnEditar.Name="btnEditar";
            btnEditar.Size=new Size(88, 27);
            btnEditar.TabIndex=1;
            btnEditar.Text="Editar";
            btnEditar.UseVisualStyleBackColor=true;
            // 
            // gvContatos
            // 
            gvContatos.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvContatos.Columns.AddRange(new DataGridViewColumn[] { Delete });
            gvContatos.Location=new Point(7, 46);
            gvContatos.Margin=new Padding(4, 3, 4, 3);
            gvContatos.Name="gvContatos";
            gvContatos.Size=new Size(738, 372);
            gvContatos.TabIndex=0;
            gvContatos.CellMouseClick+=gvContatos_CellMouseClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtbairro);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(txtNumero);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(txtUf);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtCidade);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(btnSalvar);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(mtbDataContato);
            tabPage2.Controls.Add(txtEmpresa);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtCargo);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dtpDtNascimento);
            tabPage2.Controls.Add(mkbTelefone);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TxtRua);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtEmail);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtNome);
            tabPage2.Controls.Add(label1);
            tabPage2.Location=new Point(4, 24);
            tabPage2.Margin=new Padding(4, 3, 4, 3);
            tabPage2.Name="tabPage2";
            tabPage2.Padding=new Padding(4, 3, 4, 3);
            tabPage2.Size=new Size(897, 440);
            tabPage2.TabIndex=1;
            tabPage2.Text="tabPage2";
            tabPage2.UseVisualStyleBackColor=true;
            // 
            // txtbairro
            // 
            txtbairro.Location=new Point(196, 144);
            txtbairro.Margin=new Padding(4, 3, 4, 3);
            txtbairro.Name="txtbairro";
            txtbairro.Size=new Size(106, 23);
            txtbairro.TabIndex=46;
            // 
            // label14
            // 
            label14.AutoSize=true;
            label14.Location=new Point(192, 126);
            label14.Margin=new Padding(4, 0, 4, 0);
            label14.Name="label14";
            label14.Size=new Size(38, 15);
            label14.TabIndex=45;
            label14.Text="Bairro";
            // 
            // txtNumero
            // 
            txtNumero.Location=new Point(310, 144);
            txtNumero.Margin=new Padding(4, 3, 4, 3);
            txtNumero.Name="txtNumero";
            txtNumero.Size=new Size(62, 23);
            txtNumero.TabIndex=44;
            // 
            // label13
            // 
            label13.AutoSize=true;
            label13.Location=new Point(310, 129);
            label13.Margin=new Padding(4, 0, 4, 0);
            label13.Name="label13";
            label13.Size=new Size(51, 15);
            label13.TabIndex=43;
            label13.Text="Numero";
            // 
            // txtUf
            // 
            txtUf.Location=new Point(126, 144);
            txtUf.Margin=new Padding(4, 3, 4, 3);
            txtUf.Name="txtUf";
            txtUf.Size=new Size(59, 23);
            txtUf.TabIndex=42;
            // 
            // label11
            // 
            label11.AutoSize=true;
            label11.Location=new Point(130, 126);
            label11.Margin=new Padding(4, 0, 4, 0);
            label11.Name="label11";
            label11.Size=new Size(19, 15);
            label11.TabIndex=41;
            label11.Text="Uf";
            // 
            // txtCidade
            // 
            txtCidade.Location=new Point(27, 144);
            txtCidade.Margin=new Padding(4, 3, 4, 3);
            txtCidade.Name="txtCidade";
            txtCidade.Size=new Size(95, 23);
            txtCidade.TabIndex=40;
            // 
            // label12
            // 
            label12.AutoSize=true;
            label12.Location=new Point(23, 126);
            label12.Margin=new Padding(4, 0, 4, 0);
            label12.Name="label12";
            label12.Size=new Size(44, 15);
            label12.TabIndex=39;
            label12.Text="Cidade";
            // 
            // btnSalvar
            // 
            btnSalvar.Location=new Point(44, 267);
            btnSalvar.Margin=new Padding(4, 3, 4, 3);
            btnSalvar.Name="btnSalvar";
            btnSalvar.Size=new Size(115, 38);
            btnSalvar.TabIndex=38;
            btnSalvar.Text="Salvar";
            btnSalvar.UseVisualStyleBackColor=true;
            btnSalvar.Click+=btnSalvar_Click;
            // 
            // label10
            // 
            label10.AutoSize=true;
            label10.Location=new Point(257, 173);
            label10.Margin=new Padding(4, 0, 4, 0);
            label10.Name="label10";
            label10.Size=new Size(92, 15);
            label10.TabIndex=37;
            label10.Text="Data do contato";
            // 
            // mtbDataContato
            // 
            mtbDataContato.Location=new Point(260, 192);
            mtbDataContato.Margin=new Padding(4, 3, 4, 3);
            mtbDataContato.Mask="00/00/0000";
            mtbDataContato.Name="mtbDataContato";
            mtbDataContato.Size=new Size(116, 23);
            mtbDataContato.TabIndex=36;
            mtbDataContato.ValidatingType=typeof(DateTime);
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location=new Point(136, 192);
            txtEmpresa.Margin=new Padding(4, 3, 4, 3);
            txtEmpresa.Name="txtEmpresa";
            txtEmpresa.Size=new Size(116, 23);
            txtEmpresa.TabIndex=35;
            // 
            // label9
            // 
            label9.AutoSize=true;
            label9.Location=new Point(133, 173);
            label9.Margin=new Padding(4, 0, 4, 0);
            label9.Name="label9";
            label9.Size=new Size(52, 15);
            label9.TabIndex=34;
            label9.Text="Empresa";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(253, 173);
            label6.Margin=new Padding(4, 0, 4, 0);
            label6.Name="label6";
            label6.Size=new Size(0, 15);
            label6.TabIndex=33;
            // 
            // txtCargo
            // 
            txtCargo.Location=new Point(24, 192);
            txtCargo.Margin=new Padding(4, 3, 4, 3);
            txtCargo.Name="txtCargo";
            txtCargo.Size=new Size(101, 23);
            txtCargo.TabIndex=32;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(24, 173);
            label7.Margin=new Padding(4, 0, 4, 0);
            label7.Name="label7";
            label7.Size=new Size(39, 15);
            label7.TabIndex=31;
            label7.Text="Cargo";
            // 
            // dtpDtNascimento
            // 
            dtpDtNascimento.Location=new Point(126, 96);
            dtpDtNascimento.Margin=new Padding(4, 3, 4, 3);
            dtpDtNascimento.Name="dtpDtNascimento";
            dtpDtNascimento.Size=new Size(266, 23);
            dtpDtNascimento.TabIndex=30;
            // 
            // mkbTelefone
            // 
            mkbTelefone.Location=new Point(24, 96);
            mkbTelefone.Margin=new Padding(4, 3, 4, 3);
            mkbTelefone.Mask="(00) 0000-0000";
            mkbTelefone.Name="mkbTelefone";
            mkbTelefone.Size=new Size(94, 23);
            mkbTelefone.TabIndex=29;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(21, 77);
            label5.Margin=new Padding(4, 0, 4, 0);
            label5.Name="label5";
            label5.Size=new Size(51, 15);
            label5.TabIndex=28;
            label5.Text="Telefone";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(122, 77);
            label4.Margin=new Padding(4, 0, 4, 0);
            label4.Name="label4";
            label4.Size=new Size(112, 15);
            label4.TabIndex=27;
            label4.Text="Data de nascimento";
            // 
            // TxtRua
            // 
            TxtRua.Location=new Point(394, 144);
            TxtRua.Margin=new Padding(4, 3, 4, 3);
            TxtRua.Name="TxtRua";
            TxtRua.Size=new Size(170, 23);
            TxtRua.TabIndex=26;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(391, 126);
            label3.Margin=new Padding(4, 0, 4, 0);
            label3.Name="label3";
            label3.Size=new Size(27, 15);
            label3.TabIndex=25;
            label3.Text="Rua";
            // 
            // txtEmail
            // 
            txtEmail.Location=new Point(257, 52);
            txtEmail.Margin=new Padding(4, 3, 4, 3);
            txtEmail.Name="txtEmail";
            txtEmail.Size=new Size(212, 23);
            txtEmail.TabIndex=24;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(257, 33);
            label2.Margin=new Padding(4, 0, 4, 0);
            label2.Name="label2";
            label2.Size=new Size(36, 15);
            label2.TabIndex=23;
            label2.Text="Email";
            // 
            // txtNome
            // 
            txtNome.Location=new Point(24, 52);
            txtNome.Margin=new Padding(4, 3, 4, 3);
            txtNome.Name="txtNome";
            txtNome.Size=new Size(224, 23);
            txtNome.TabIndex=22;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(21, 33);
            label1.Margin=new Padding(4, 0, 4, 0);
            label1.Name="label1";
            label1.Size=new Size(40, 15);
            label1.TabIndex=21;
            label1.Text="Nome";
            // 
            // Delete
            // 
            Delete.HeaderText="Delete";
            Delete.Name="Delete";
            // 
            // Form2
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightBlue;
            ClientSize=new Size(933, 519);
            Controls.Add(tabControl1);
            Margin=new Padding(4, 3, 4, 3);
            Name="Form2";
            Text="Form2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvContatos).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView gvContatos;
        private Button btnNovo;
        private Button btnEditarr;
        private Button btnEditar;
        private Label label10;
        private MaskedTextBox mtbDataContato;
        private TextBox txtEmpresa;
        private Label label9;
        private Label label6;
        private TextBox txtCargo;
        private Label label7;
        private DateTimePicker dtpDtNascimento;
        private MaskedTextBox mkbTelefone;
        private Label label5;
        private Label label4;
        private TextBox TxtRua;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Label label8;
        private Button btnSalvar;
        private Button btnCarregar;
        private Button btnRegarregar;
        private TextBox txtUf;
        private Label label11;
        private TextBox txtCidade;
        private Label label12;
        private TextBox txtNumero;
        private Label label13;
        private TextBox txtbairro;
        private Label label14;
        private DataGridViewTextBoxColumn Delete;
    }
}