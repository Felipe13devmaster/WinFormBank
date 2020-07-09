using System;
using System.ComponentModel;

namespace WinFormBank.View
{
    partial class FormTelaPrincipal
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
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.labelConfirmaSenha = new System.Windows.Forms.Label();
            this.labelCriaSenha = new System.Windows.Forms.Label();
            this.textBoxSenhaConfirm = new System.Windows.Forms.TextBox();
            this.textBoxSenhaInsert = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioInsert = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.comboBoxUf = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNascimento = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelConta = new System.Windows.Forms.Panel();
            this.panelTransferencia = new System.Windows.Forms.Panel();
            this.labelNomeDestinoTransf = new System.Windows.Forms.Label();
            this.labelInfConta = new System.Windows.Forms.Label();
            this.textBoxContaDestino = new System.Windows.Forms.TextBox();
            this.comboBoxTipoConta = new System.Windows.Forms.ComboBox();
            this.labelMensagemTransf = new System.Windows.Forms.Label();
            this.buttonConfirmaTransf = new System.Windows.Forms.Button();
            this.buttonLimparTransf = new System.Windows.Forms.Button();
            this.textBoxValorTransf = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.buttonCancelarTransf = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.panelTransacao = new System.Windows.Forms.Panel();
            this.textBoxHistorico = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panelSaque = new System.Windows.Forms.Panel();
            this.labelMensagemSaque = new System.Windows.Forms.Label();
            this.buttonCancela = new System.Windows.Forms.Button();
            this.buttonConfirma = new System.Windows.Forms.Button();
            this.buttonLimpa = new System.Windows.Forms.Button();
            this.textBoxValorSaque = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.labelSaque = new System.Windows.Forms.Label();
            this.panelDeposito = new System.Windows.Forms.Panel();
            this.labelMensagemDeposito = new System.Windows.Forms.Label();
            this.buttonConfirmaDeposito = new System.Windows.Forms.Button();
            this.buttonLimparDeposito = new System.Windows.Forms.Button();
            this.textBoxValorDeposito = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.buttonSairDeposito = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonDepositar = new System.Windows.Forms.Button();
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.panelContaCorrente = new System.Windows.Forms.Panel();
            this.labelSaldoCorrente = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panelDadosUsuario = new System.Windows.Forms.Panel();
            this.labelConta = new System.Windows.Forms.Label();
            this.labelAgencia = new System.Windows.Forms.Label();
            this.labelBanco = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonCadastre = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelCadastro.SuspendLayout();
            this.panelConta.SuspendLayout();
            this.panelTransferencia.SuspendLayout();
            this.panelTransacao.SuspendLayout();
            this.panelSaque.SuspendLayout();
            this.panelDeposito.SuspendLayout();
            this.panelContaCorrente.SuspendLayout();
            this.panelDadosUsuario.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadastro
            // 
            this.panelCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.panelCadastro.Controls.Add(this.label15);
            this.panelCadastro.Controls.Add(this.labelConfirmaSenha);
            this.panelCadastro.Controls.Add(this.labelCriaSenha);
            this.panelCadastro.Controls.Add(this.textBoxSenhaConfirm);
            this.panelCadastro.Controls.Add(this.textBoxSenhaInsert);
            this.panelCadastro.Controls.Add(this.textBoxUsuarioInsert);
            this.panelCadastro.Controls.Add(this.label14);
            this.panelCadastro.Controls.Add(this.label13);
            this.panelCadastro.Controls.Add(this.label12);
            this.panelCadastro.Controls.Add(this.buttonVoltar);
            this.panelCadastro.Controls.Add(this.buttonLimpar);
            this.panelCadastro.Controls.Add(this.buttonCadastrar);
            this.panelCadastro.Controls.Add(this.comboBoxUf);
            this.panelCadastro.Controls.Add(this.textBoxEmail);
            this.panelCadastro.Controls.Add(this.textBoxEndereco);
            this.panelCadastro.Controls.Add(this.maskedTextBoxCelular);
            this.panelCadastro.Controls.Add(this.maskedTextBoxNascimento);
            this.panelCadastro.Controls.Add(this.maskedTextBoxCpf);
            this.panelCadastro.Controls.Add(this.textBoxNome);
            this.panelCadastro.Controls.Add(this.label11);
            this.panelCadastro.Controls.Add(this.label10);
            this.panelCadastro.Controls.Add(this.label9);
            this.panelCadastro.Controls.Add(this.label8);
            this.panelCadastro.Controls.Add(this.label7);
            this.panelCadastro.Controls.Add(this.label6);
            this.panelCadastro.Controls.Add(this.label5);
            this.panelCadastro.Controls.Add(this.label4);
            this.panelCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCadastro.Location = new System.Drawing.Point(105, 12);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(696, 519);
            this.panelCadastro.TabIndex = 1;
            this.panelCadastro.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(172, 431);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Status Formulario";
            // 
            // labelConfirmaSenha
            // 
            this.labelConfirmaSenha.AutoSize = true;
            this.labelConfirmaSenha.Location = new System.Drawing.Point(330, 395);
            this.labelConfirmaSenha.Name = "labelConfirmaSenha";
            this.labelConfirmaSenha.Size = new System.Drawing.Size(160, 20);
            this.labelConfirmaSenha.TabIndex = 25;
            this.labelConfirmaSenha.Text = "Cornfirme sua senha.";
            // 
            // labelCriaSenha
            // 
            this.labelCriaSenha.AutoSize = true;
            this.labelCriaSenha.Location = new System.Drawing.Point(330, 363);
            this.labelCriaSenha.Name = "labelCriaSenha";
            this.labelCriaSenha.Size = new System.Drawing.Size(119, 20);
            this.labelCriaSenha.TabIndex = 24;
            this.labelCriaSenha.Text = "Crie sua senha.";
            // 
            // textBoxSenhaConfirm
            // 
            this.textBoxSenhaConfirm.Location = new System.Drawing.Point(138, 392);
            this.textBoxSenhaConfirm.MaxLength = 8;
            this.textBoxSenhaConfirm.Name = "textBoxSenhaConfirm";
            this.textBoxSenhaConfirm.PasswordChar = '*';
            this.textBoxSenhaConfirm.Size = new System.Drawing.Size(169, 26);
            this.textBoxSenhaConfirm.TabIndex = 23;
            this.textBoxSenhaConfirm.Click += new System.EventHandler(this.textBoxSenhaConfirm_Click);
            this.textBoxSenhaConfirm.TextChanged += new System.EventHandler(this.textBoxSenhaConfirm_TextChanged);
            this.textBoxSenhaConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSenhaConfirm_Validating);
            // 
            // textBoxSenhaInsert
            // 
            this.textBoxSenhaInsert.Location = new System.Drawing.Point(138, 360);
            this.textBoxSenhaInsert.MaxLength = 8;
            this.textBoxSenhaInsert.Name = "textBoxSenhaInsert";
            this.textBoxSenhaInsert.PasswordChar = '*';
            this.textBoxSenhaInsert.Size = new System.Drawing.Size(169, 26);
            this.textBoxSenhaInsert.TabIndex = 22;
            this.textBoxSenhaInsert.Click += new System.EventHandler(this.textBoxSenhaInsert_Click);
            this.textBoxSenhaInsert.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSenhaInsert_Validating);
            // 
            // textBoxUsuarioInsert
            // 
            this.textBoxUsuarioInsert.Location = new System.Drawing.Point(138, 326);
            this.textBoxUsuarioInsert.MaxLength = 20;
            this.textBoxUsuarioInsert.Name = "textBoxUsuarioInsert";
            this.textBoxUsuarioInsert.Size = new System.Drawing.Size(318, 26);
            this.textBoxUsuarioInsert.TabIndex = 21;
            this.textBoxUsuarioInsert.Click += new System.EventHandler(this.textBoxUsuarioInsert_Click);
            this.textBoxUsuarioInsert.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsuarioInsert_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(42, 395);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Senha";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(42, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Senha";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(41, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Usuario";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.Location = new System.Drawing.Point(355, 463);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(90, 30);
            this.buttonVoltar.TabIndex = 17;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(249, 463);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(90, 30);
            this.buttonLimpar.TabIndex = 16;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Enabled = false;
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(138, 463);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(90, 30);
            this.buttonCadastrar.TabIndex = 15;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // comboBoxUf
            // 
            this.comboBoxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUf.FormattingEnabled = true;
            this.comboBoxUf.Items.AddRange(new object[] {
            "Selecione...",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxUf.Location = new System.Drawing.Point(138, 223);
            this.comboBoxUf.Name = "comboBoxUf";
            this.comboBoxUf.Size = new System.Drawing.Size(121, 28);
            this.comboBoxUf.TabIndex = 14;
            this.comboBoxUf.SelectedIndexChanged += new System.EventHandler(this.comboBoxUf_SelectedIndexChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(138, 294);
            this.textBoxEmail.MaxLength = 100;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(438, 26);
            this.textBoxEmail.TabIndex = 13;
            this.textBoxEmail.Click += new System.EventHandler(this.textBoxEmail_Click);
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(138, 188);
            this.textBoxEndereco.MaxLength = 100;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(438, 26);
            this.textBoxEndereco.TabIndex = 12;
            this.textBoxEndereco.Click += new System.EventHandler(this.textBoxEndereco_Click);
            this.textBoxEndereco.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEndereco_Validating);
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(138, 257);
            this.maskedTextBoxCelular.Mask = "(00) 00000-9999";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(131, 26);
            this.maskedTextBoxCelular.TabIndex = 11;
            this.maskedTextBoxCelular.Click += new System.EventHandler(this.maskedTextBoxCelular_Click);
            this.maskedTextBoxCelular.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxCelular_Validating);
            // 
            // maskedTextBoxNascimento
            // 
            this.maskedTextBoxNascimento.Location = new System.Drawing.Point(451, 154);
            this.maskedTextBoxNascimento.Mask = "00/00/0000";
            this.maskedTextBoxNascimento.Name = "maskedTextBoxNascimento";
            this.maskedTextBoxNascimento.Size = new System.Drawing.Size(125, 26);
            this.maskedTextBoxNascimento.TabIndex = 10;
            this.maskedTextBoxNascimento.Click += new System.EventHandler(this.maskedTextBoxNascimento_Click);
            this.maskedTextBoxNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxNascimento_Validating);
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(138, 154);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(169, 26);
            this.maskedTextBoxCpf.TabIndex = 9;
            this.maskedTextBoxCpf.Click += new System.EventHandler(this.maskedTextBoxCpf_Click);
            this.maskedTextBoxCpf.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxCpf_Validating);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(138, 119);
            this.textBoxNome.MaxLength = 80;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(438, 26);
            this.textBoxNome.TabIndex = 8;
            this.textBoxNome.Click += new System.EventHandler(this.textBoxNome_Click);
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            this.textBoxNome.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNome_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(41, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(41, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(42, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(42, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(42, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(41, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cadastre- se";
            // 
            // panelConta
            // 
            this.panelConta.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelConta.Controls.Add(this.panelTransacao);
            this.panelConta.Controls.Add(this.buttonSacar);
            this.panelConta.Controls.Add(this.buttonSair);
            this.panelConta.Controls.Add(this.buttonDepositar);
            this.panelConta.Controls.Add(this.buttonTransferir);
            this.panelConta.Controls.Add(this.panelContaCorrente);
            this.panelConta.Controls.Add(this.panelDadosUsuario);
            this.panelConta.Controls.Add(this.panelTransferencia);
            this.panelConta.Controls.Add(this.panelDeposito);
            this.panelConta.Controls.Add(this.panelSaque);
            this.panelConta.Location = new System.Drawing.Point(12, 12);
            this.panelConta.Name = "panelConta";
            this.panelConta.Size = new System.Drawing.Size(908, 519);
            this.panelConta.TabIndex = 18;
            this.panelConta.Visible = false;
            this.panelConta.VisibleChanged += new System.EventHandler(this.panelConta_VisibleChanged);
            // 
            // panelTransferencia
            // 
            this.panelTransferencia.BackColor = System.Drawing.Color.MintCream;
            this.panelTransferencia.Controls.Add(this.labelNomeDestinoTransf);
            this.panelTransferencia.Controls.Add(this.labelInfConta);
            this.panelTransferencia.Controls.Add(this.textBoxContaDestino);
            this.panelTransferencia.Controls.Add(this.comboBoxTipoConta);
            this.panelTransferencia.Controls.Add(this.labelMensagemTransf);
            this.panelTransferencia.Controls.Add(this.buttonConfirmaTransf);
            this.panelTransferencia.Controls.Add(this.buttonLimparTransf);
            this.panelTransferencia.Controls.Add(this.textBoxValorTransf);
            this.panelTransferencia.Controls.Add(this.label26);
            this.panelTransferencia.Controls.Add(this.buttonCancelarTransf);
            this.panelTransferencia.Controls.Add(this.label27);
            this.panelTransferencia.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panelTransferencia.Location = new System.Drawing.Point(33, 274);
            this.panelTransferencia.Name = "panelTransferencia";
            this.panelTransferencia.Size = new System.Drawing.Size(308, 237);
            this.panelTransferencia.TabIndex = 8;
            this.panelTransferencia.Visible = false;
            // 
            // labelNomeDestinoTransf
            // 
            this.labelNomeDestinoTransf.AutoSize = true;
            this.labelNomeDestinoTransf.BackColor = System.Drawing.Color.Snow;
            this.labelNomeDestinoTransf.Location = new System.Drawing.Point(11, 150);
            this.labelNomeDestinoTransf.Name = "labelNomeDestinoTransf";
            this.labelNomeDestinoTransf.Size = new System.Drawing.Size(65, 13);
            this.labelNomeDestinoTransf.TabIndex = 24;
            this.labelNomeDestinoTransf.Text = "Beneficiario:";
            this.labelNomeDestinoTransf.Visible = false;
            // 
            // labelInfConta
            // 
            this.labelInfConta.AutoSize = true;
            this.labelInfConta.BackColor = System.Drawing.Color.Snow;
            this.labelInfConta.Location = new System.Drawing.Point(12, 126);
            this.labelInfConta.Name = "labelInfConta";
            this.labelInfConta.Size = new System.Drawing.Size(81, 13);
            this.labelInfConta.TabIndex = 23;
            this.labelInfConta.Text = "Informe a conta";
            this.labelInfConta.Visible = false;
            // 
            // textBoxContaDestino
            // 
            this.textBoxContaDestino.Location = new System.Drawing.Point(133, 123);
            this.textBoxContaDestino.Name = "textBoxContaDestino";
            this.textBoxContaDestino.Size = new System.Drawing.Size(160, 20);
            this.textBoxContaDestino.TabIndex = 22;
            this.textBoxContaDestino.Visible = false;
            // 
            // comboBoxTipoConta
            // 
            this.comboBoxTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoConta.FormattingEnabled = true;
            this.comboBoxTipoConta.Items.AddRange(new object[] {
            "Transferir para:",
            "Outra Conta Corrente"});
            this.comboBoxTipoConta.Location = new System.Drawing.Point(15, 94);
            this.comboBoxTipoConta.Name = "comboBoxTipoConta";
            this.comboBoxTipoConta.Size = new System.Drawing.Size(138, 21);
            this.comboBoxTipoConta.TabIndex = 21;
            this.comboBoxTipoConta.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoConta_SelectedIndexChanged);
            // 
            // labelMensagemTransf
            // 
            this.labelMensagemTransf.AutoSize = true;
            this.labelMensagemTransf.BackColor = System.Drawing.Color.Lime;
            this.labelMensagemTransf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagemTransf.Location = new System.Drawing.Point(17, 204);
            this.labelMensagemTransf.Name = "labelMensagemTransf";
            this.labelMensagemTransf.Size = new System.Drawing.Size(76, 16);
            this.labelMensagemTransf.TabIndex = 20;
            this.labelMensagemTransf.Text = "Mensagem";
            this.labelMensagemTransf.Visible = false;
            // 
            // buttonConfirmaTransf
            // 
            this.buttonConfirmaTransf.BackColor = System.Drawing.Color.Purple;
            this.buttonConfirmaTransf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmaTransf.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonConfirmaTransf.Location = new System.Drawing.Point(104, 169);
            this.buttonConfirmaTransf.Name = "buttonConfirmaTransf";
            this.buttonConfirmaTransf.Size = new System.Drawing.Size(85, 31);
            this.buttonConfirmaTransf.TabIndex = 19;
            this.buttonConfirmaTransf.Text = "Confirma";
            this.buttonConfirmaTransf.UseVisualStyleBackColor = false;
            this.buttonConfirmaTransf.Click += new System.EventHandler(this.buttonConfirmaTransf_Click);
            // 
            // buttonLimparTransf
            // 
            this.buttonLimparTransf.BackColor = System.Drawing.Color.Purple;
            this.buttonLimparTransf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimparTransf.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLimparTransf.Location = new System.Drawing.Point(14, 169);
            this.buttonLimparTransf.Name = "buttonLimparTransf";
            this.buttonLimparTransf.Size = new System.Drawing.Size(84, 31);
            this.buttonLimparTransf.TabIndex = 18;
            this.buttonLimparTransf.Text = "Limpar";
            this.buttonLimparTransf.UseVisualStyleBackColor = false;
            this.buttonLimparTransf.Click += new System.EventHandler(this.buttonLimparTransf_Click);
            // 
            // textBoxValorTransf
            // 
            this.textBoxValorTransf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorTransf.Location = new System.Drawing.Point(76, 59);
            this.textBoxValorTransf.Name = "textBoxValorTransf";
            this.textBoxValorTransf.Size = new System.Drawing.Size(217, 29);
            this.textBoxValorTransf.TabIndex = 17;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(13, 62);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 24);
            this.label26.TabIndex = 16;
            this.label26.Text = "Valor";
            // 
            // buttonCancelarTransf
            // 
            this.buttonCancelarTransf.BackColor = System.Drawing.Color.Purple;
            this.buttonCancelarTransf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarTransf.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCancelarTransf.Location = new System.Drawing.Point(194, 169);
            this.buttonCancelarTransf.Name = "buttonCancelarTransf";
            this.buttonCancelarTransf.Size = new System.Drawing.Size(93, 29);
            this.buttonCancelarTransf.TabIndex = 15;
            this.buttonCancelarTransf.Text = "Cancelar";
            this.buttonCancelarTransf.UseVisualStyleBackColor = false;
            this.buttonCancelarTransf.Click += new System.EventHandler(this.buttonCancelarTransf_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.DarkMagenta;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label27.Location = new System.Drawing.Point(70, 17);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(181, 31);
            this.label27.TabIndex = 14;
            this.label27.Text = "Transferencia";
            // 
            // panelTransacao
            // 
            this.panelTransacao.BackColor = System.Drawing.Color.MintCream;
            this.panelTransacao.Controls.Add(this.textBoxHistorico);
            this.panelTransacao.Controls.Add(this.label21);
            this.panelTransacao.Controls.Add(this.label18);
            this.panelTransacao.Location = new System.Drawing.Point(350, 131);
            this.panelTransacao.Name = "panelTransacao";
            this.panelTransacao.Size = new System.Drawing.Size(241, 368);
            this.panelTransacao.TabIndex = 2;
            // 
            // textBoxHistorico
            // 
            this.textBoxHistorico.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxHistorico.Location = new System.Drawing.Point(8, 75);
            this.textBoxHistorico.Multiline = true;
            this.textBoxHistorico.Name = "textBoxHistorico";
            this.textBoxHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxHistorico.Size = new System.Drawing.Size(225, 287);
            this.textBoxHistorico.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Plum;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(95, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 17);
            this.label21.TabIndex = 8;
            this.label21.Text = "Histórico";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.DarkMagenta;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label18.Location = new System.Drawing.Point(74, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Transações";
            // 
            // panelSaque
            // 
            this.panelSaque.BackColor = System.Drawing.Color.MintCream;
            this.panelSaque.Controls.Add(this.labelMensagemSaque);
            this.panelSaque.Controls.Add(this.buttonCancela);
            this.panelSaque.Controls.Add(this.buttonConfirma);
            this.panelSaque.Controls.Add(this.buttonLimpa);
            this.panelSaque.Controls.Add(this.textBoxValorSaque);
            this.panelSaque.Controls.Add(this.label22);
            this.panelSaque.Controls.Add(this.labelSaque);
            this.panelSaque.Location = new System.Drawing.Point(41, 289);
            this.panelSaque.Name = "panelSaque";
            this.panelSaque.Size = new System.Drawing.Size(295, 180);
            this.panelSaque.TabIndex = 7;
            this.panelSaque.Visible = false;
            // 
            // labelMensagemSaque
            // 
            this.labelMensagemSaque.AutoSize = true;
            this.labelMensagemSaque.BackColor = System.Drawing.Color.Lime;
            this.labelMensagemSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagemSaque.Location = new System.Drawing.Point(89, 158);
            this.labelMensagemSaque.Name = "labelMensagemSaque";
            this.labelMensagemSaque.Size = new System.Drawing.Size(76, 16);
            this.labelMensagemSaque.TabIndex = 8;
            this.labelMensagemSaque.Text = "Mensagem";
            this.labelMensagemSaque.Visible = false;
            // 
            // buttonCancela
            // 
            this.buttonCancela.BackColor = System.Drawing.Color.Purple;
            this.buttonCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancela.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCancela.Location = new System.Drawing.Point(197, 113);
            this.buttonCancela.Name = "buttonCancela";
            this.buttonCancela.Size = new System.Drawing.Size(89, 31);
            this.buttonCancela.TabIndex = 7;
            this.buttonCancela.Text = "Cancelar";
            this.buttonCancela.UseVisualStyleBackColor = false;
            this.buttonCancela.Click += new System.EventHandler(this.buttonCancela_Click);
            // 
            // buttonConfirma
            // 
            this.buttonConfirma.BackColor = System.Drawing.Color.Purple;
            this.buttonConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirma.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonConfirma.Location = new System.Drawing.Point(106, 113);
            this.buttonConfirma.Name = "buttonConfirma";
            this.buttonConfirma.Size = new System.Drawing.Size(85, 31);
            this.buttonConfirma.TabIndex = 6;
            this.buttonConfirma.Text = "Confirma";
            this.buttonConfirma.UseVisualStyleBackColor = false;
            this.buttonConfirma.Click += new System.EventHandler(this.buttonConfirmaSaque_Click);
            // 
            // buttonLimpa
            // 
            this.buttonLimpa.BackColor = System.Drawing.Color.Purple;
            this.buttonLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLimpa.Location = new System.Drawing.Point(16, 113);
            this.buttonLimpa.Name = "buttonLimpa";
            this.buttonLimpa.Size = new System.Drawing.Size(84, 31);
            this.buttonLimpa.TabIndex = 5;
            this.buttonLimpa.Text = "Limpar";
            this.buttonLimpa.UseVisualStyleBackColor = false;
            this.buttonLimpa.Click += new System.EventHandler(this.buttonLimpa_Click);
            // 
            // textBoxValorSaque
            // 
            this.textBoxValorSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorSaque.Location = new System.Drawing.Point(72, 77);
            this.textBoxValorSaque.Name = "textBoxValorSaque";
            this.textBoxValorSaque.Size = new System.Drawing.Size(214, 29);
            this.textBoxValorSaque.TabIndex = 4;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 24);
            this.label22.TabIndex = 3;
            this.label22.Text = "Valor";
            // 
            // labelSaque
            // 
            this.labelSaque.AutoSize = true;
            this.labelSaque.BackColor = System.Drawing.Color.DarkMagenta;
            this.labelSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaque.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelSaque.Location = new System.Drawing.Point(111, 12);
            this.labelSaque.Name = "labelSaque";
            this.labelSaque.Size = new System.Drawing.Size(92, 31);
            this.labelSaque.TabIndex = 0;
            this.labelSaque.Text = "Saque";
            // 
            // panelDeposito
            // 
            this.panelDeposito.BackColor = System.Drawing.Color.MintCream;
            this.panelDeposito.Controls.Add(this.labelMensagemDeposito);
            this.panelDeposito.Controls.Add(this.buttonConfirmaDeposito);
            this.panelDeposito.Controls.Add(this.buttonLimparDeposito);
            this.panelDeposito.Controls.Add(this.textBoxValorDeposito);
            this.panelDeposito.Controls.Add(this.label25);
            this.panelDeposito.Controls.Add(this.buttonSairDeposito);
            this.panelDeposito.Controls.Add(this.label23);
            this.panelDeposito.Location = new System.Drawing.Point(35, 278);
            this.panelDeposito.Name = "panelDeposito";
            this.panelDeposito.Size = new System.Drawing.Size(302, 207);
            this.panelDeposito.TabIndex = 8;
            this.panelDeposito.Visible = false;
            // 
            // labelMensagemDeposito
            // 
            this.labelMensagemDeposito.AutoSize = true;
            this.labelMensagemDeposito.BackColor = System.Drawing.Color.Lime;
            this.labelMensagemDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagemDeposito.Location = new System.Drawing.Point(92, 171);
            this.labelMensagemDeposito.Name = "labelMensagemDeposito";
            this.labelMensagemDeposito.Size = new System.Drawing.Size(76, 16);
            this.labelMensagemDeposito.TabIndex = 13;
            this.labelMensagemDeposito.Text = "Mensagem";
            this.labelMensagemDeposito.Visible = false;
            // 
            // buttonConfirmaDeposito
            // 
            this.buttonConfirmaDeposito.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonConfirmaDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmaDeposito.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonConfirmaDeposito.Location = new System.Drawing.Point(109, 126);
            this.buttonConfirmaDeposito.Name = "buttonConfirmaDeposito";
            this.buttonConfirmaDeposito.Size = new System.Drawing.Size(85, 31);
            this.buttonConfirmaDeposito.TabIndex = 12;
            this.buttonConfirmaDeposito.Text = "Confirma";
            this.buttonConfirmaDeposito.UseVisualStyleBackColor = false;
            this.buttonConfirmaDeposito.Click += new System.EventHandler(this.buttonConfirmaDeposito_Click);
            // 
            // buttonLimparDeposito
            // 
            this.buttonLimparDeposito.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonLimparDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimparDeposito.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLimparDeposito.Location = new System.Drawing.Point(19, 126);
            this.buttonLimparDeposito.Name = "buttonLimparDeposito";
            this.buttonLimparDeposito.Size = new System.Drawing.Size(84, 31);
            this.buttonLimparDeposito.TabIndex = 11;
            this.buttonLimparDeposito.Text = "Limpar";
            this.buttonLimparDeposito.UseVisualStyleBackColor = false;
            this.buttonLimparDeposito.Click += new System.EventHandler(this.buttonLimparDeposito_Click);
            // 
            // textBoxValorDeposito
            // 
            this.textBoxValorDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorDeposito.Location = new System.Drawing.Point(75, 90);
            this.textBoxValorDeposito.Name = "textBoxValorDeposito";
            this.textBoxValorDeposito.Size = new System.Drawing.Size(217, 29);
            this.textBoxValorDeposito.TabIndex = 10;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(15, 95);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 24);
            this.label25.TabIndex = 9;
            this.label25.Text = "Valor";
            // 
            // buttonSairDeposito
            // 
            this.buttonSairDeposito.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonSairDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSairDeposito.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSairDeposito.Location = new System.Drawing.Point(199, 128);
            this.buttonSairDeposito.Name = "buttonSairDeposito";
            this.buttonSairDeposito.Size = new System.Drawing.Size(93, 29);
            this.buttonSairDeposito.TabIndex = 1;
            this.buttonSairDeposito.Text = "Cancelar";
            this.buttonSairDeposito.UseVisualStyleBackColor = false;
            this.buttonSairDeposito.Click += new System.EventHandler(this.buttonSairDeposito_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.DarkMagenta;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label23.Location = new System.Drawing.Point(110, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 31);
            this.label23.TabIndex = 0;
            this.label23.Text = "Deposito";
            // 
            // buttonSacar
            // 
            this.buttonSacar.BackColor = System.Drawing.Color.Purple;
            this.buttonSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSacar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSacar.Location = new System.Drawing.Point(597, 359);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(91, 33);
            this.buttonSacar.TabIndex = 8;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = false;
            this.buttonSacar.Click += new System.EventHandler(this.buttonSaque_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Purple;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSair.Location = new System.Drawing.Point(597, 470);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(91, 29);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.BackColor = System.Drawing.Color.Purple;
            this.buttonDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDepositar.Location = new System.Drawing.Point(597, 399);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(91, 29);
            this.buttonDepositar.TabIndex = 4;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = false;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.BackColor = System.Drawing.Color.Purple;
            this.buttonTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransferir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonTransferir.Location = new System.Drawing.Point(597, 434);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(91, 29);
            this.buttonTransferir.TabIndex = 3;
            this.buttonTransferir.Text = "Transferir";
            this.buttonTransferir.UseVisualStyleBackColor = false;
            this.buttonTransferir.Click += new System.EventHandler(this.buttonTransferir_Click);
            // 
            // panelContaCorrente
            // 
            this.panelContaCorrente.BackColor = System.Drawing.Color.MintCream;
            this.panelContaCorrente.Controls.Add(this.labelSaldoCorrente);
            this.panelContaCorrente.Controls.Add(this.label16);
            this.panelContaCorrente.Controls.Add(this.label19);
            this.panelContaCorrente.Location = new System.Drawing.Point(35, 131);
            this.panelContaCorrente.Name = "panelContaCorrente";
            this.panelContaCorrente.Size = new System.Drawing.Size(309, 141);
            this.panelContaCorrente.TabIndex = 1;
            // 
            // labelSaldoCorrente
            // 
            this.labelSaldoCorrente.AutoSize = true;
            this.labelSaldoCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoCorrente.Location = new System.Drawing.Point(11, 83);
            this.labelSaldoCorrente.Name = "labelSaldoCorrente";
            this.labelSaldoCorrente.Size = new System.Drawing.Size(148, 46);
            this.labelSaldoCorrente.TabIndex = 8;
            this.labelSaldoCorrente.Text = "R$0,00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DarkMagenta;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Location = new System.Drawing.Point(74, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Conta Corrente";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Plum;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(102, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 17);
            this.label19.TabIndex = 6;
            this.label19.Text = "Saldo";
            // 
            // panelDadosUsuario
            // 
            this.panelDadosUsuario.BackColor = System.Drawing.Color.MintCream;
            this.panelDadosUsuario.Controls.Add(this.labelConta);
            this.panelDadosUsuario.Controls.Add(this.labelAgencia);
            this.panelDadosUsuario.Controls.Add(this.labelBanco);
            this.panelDadosUsuario.Controls.Add(this.labelNome);
            this.panelDadosUsuario.Location = new System.Drawing.Point(35, 19);
            this.panelDadosUsuario.Name = "panelDadosUsuario";
            this.panelDadosUsuario.Size = new System.Drawing.Size(556, 100);
            this.panelDadosUsuario.TabIndex = 0;
            // 
            // labelConta
            // 
            this.labelConta.AutoSize = true;
            this.labelConta.BackColor = System.Drawing.Color.Plum;
            this.labelConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConta.Location = new System.Drawing.Point(388, 59);
            this.labelConta.Name = "labelConta";
            this.labelConta.Size = new System.Drawing.Size(52, 20);
            this.labelConta.TabIndex = 3;
            this.labelConta.Text = "Conta";
            // 
            // labelAgencia
            // 
            this.labelAgencia.AutoSize = true;
            this.labelAgencia.BackColor = System.Drawing.Color.Plum;
            this.labelAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgencia.Location = new System.Drawing.Point(388, 19);
            this.labelAgencia.Name = "labelAgencia";
            this.labelAgencia.Size = new System.Drawing.Size(67, 20);
            this.labelAgencia.TabIndex = 2;
            this.labelAgencia.Text = "Agencia";
            // 
            // labelBanco
            // 
            this.labelBanco.AutoSize = true;
            this.labelBanco.BackColor = System.Drawing.Color.Plum;
            this.labelBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanco.Location = new System.Drawing.Point(15, 59);
            this.labelBanco.Name = "labelBanco";
            this.labelBanco.Size = new System.Drawing.Size(55, 20);
            this.labelBanco.TabIndex = 1;
            this.labelBanco.Text = "Banco";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Plum;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(15, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(51, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(130, 105);
            this.textBoxUsuario.MaxLength = 50;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(244, 20);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(130, 149);
            this.textBoxSenha.MaxLength = 8;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(244, 20);
            this.textBoxSenha.TabIndex = 4;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(198, 222);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(75, 23);
            this.buttonEntrar.TabIndex = 5;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonCadastre
            // 
            this.buttonCadastre.Location = new System.Drawing.Point(299, 222);
            this.buttonCadastre.Name = "buttonCadastre";
            this.buttonCadastre.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastre.TabIndex = 6;
            this.buttonCadastre.Text = "Cadastre-se";
            this.buttonCadastre.UseVisualStyleBackColor = true;
            this.buttonCadastre.Click += new System.EventHandler(this.buttonCadastre_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.Control;
            this.panelLogin.Controls.Add(this.buttonCadastre);
            this.panelLogin.Controls.Add(this.buttonEntrar);
            this.panelLogin.Controls.Add(this.textBoxSenha);
            this.panelLogin.Controls.Add(this.textBoxUsuario);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(229, 159);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(458, 295);
            this.panelLogin.TabIndex = 0;
            // 
            // FormTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(932, 535);
            this.Controls.Add(this.panelConta);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelCadastro);
            this.Name = "FormTelaPrincipal";
            this.Text = "FuBank";
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.panelConta.ResumeLayout(false);
            this.panelTransferencia.ResumeLayout(false);
            this.panelTransferencia.PerformLayout();
            this.panelTransacao.ResumeLayout(false);
            this.panelTransacao.PerformLayout();
            this.panelSaque.ResumeLayout(false);
            this.panelSaque.PerformLayout();
            this.panelDeposito.ResumeLayout(false);
            this.panelDeposito.PerformLayout();
            this.panelContaCorrente.ResumeLayout(false);
            this.panelContaCorrente.PerformLayout();
            this.panelDadosUsuario.ResumeLayout(false);
            this.panelDadosUsuario.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelular;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNascimento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.ComboBox comboBoxUf;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Panel panelConta;
        private System.Windows.Forms.Panel panelTransacao;
        private System.Windows.Forms.Panel panelContaCorrente;
        private System.Windows.Forms.Panel panelDadosUsuario;
        private System.Windows.Forms.Button buttonDepositar;
        private System.Windows.Forms.Button buttonTransferir;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelConta;
        private System.Windows.Forms.Label labelAgencia;
        private System.Windows.Forms.Label labelBanco;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelSaldoCorrente;
        private System.Windows.Forms.Label labelConfirmaSenha;
        private System.Windows.Forms.Label labelCriaSenha;
        private System.Windows.Forms.TextBox textBoxSenhaConfirm;
        private System.Windows.Forms.TextBox textBoxSenhaInsert;
        private System.Windows.Forms.TextBox textBoxUsuarioInsert;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.Panel panelSaque;
        private System.Windows.Forms.Panel panelDeposito;
        private System.Windows.Forms.Panel panelTransferencia;
        private System.Windows.Forms.Label labelMensagemSaque;
        private System.Windows.Forms.Button buttonCancela;
        private System.Windows.Forms.Button buttonConfirma;
        private System.Windows.Forms.Button buttonLimpa;
        private System.Windows.Forms.TextBox textBoxValorSaque;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelSaque;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button buttonSairDeposito;
        private System.Windows.Forms.Label labelMensagemDeposito;
        private System.Windows.Forms.Button buttonConfirmaDeposito;
        private System.Windows.Forms.Button buttonLimparDeposito;
        private System.Windows.Forms.TextBox textBoxValorDeposito;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labelMensagemTransf;
        private System.Windows.Forms.Button buttonConfirmaTransf;
        private System.Windows.Forms.Button buttonLimparTransf;
        private System.Windows.Forms.TextBox textBoxValorTransf;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button buttonCancelarTransf;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBoxTipoConta;
        private System.Windows.Forms.Label labelInfConta;
        private System.Windows.Forms.TextBox textBoxContaDestino;
        private System.Windows.Forms.Label labelNomeDestinoTransf;
        private System.Windows.Forms.TextBox textBoxHistorico;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonCadastre;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}