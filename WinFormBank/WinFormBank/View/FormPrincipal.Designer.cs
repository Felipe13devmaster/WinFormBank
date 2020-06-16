﻿namespace WinFormBank.View
{
    partial class FormPrincipal
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonCadastre = new System.Windows.Forms.Button();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.buttonPagar = new System.Windows.Forms.Button();
            this.buttonDepositar = new System.Windows.Forms.Button();
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.panelContaPoupanca = new System.Windows.Forms.Panel();
            this.labelSaldoPoupanca = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelTransacao = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panelContaCorrente = new System.Windows.Forms.Panel();
            this.labelSaldoCorrente = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panelDadosUsuario = new System.Windows.Forms.Panel();
            this.labelConta = new System.Windows.Forms.Label();
            this.labelAgencia = new System.Windows.Forms.Label();
            this.labelBanco = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelCadastro.SuspendLayout();
            this.panelConta.SuspendLayout();
            this.panelContaPoupanca.SuspendLayout();
            this.panelTransacao.SuspendLayout();
            this.panelContaCorrente.SuspendLayout();
            this.panelDadosUsuario.SuspendLayout();
            this.SuspendLayout();
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
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(130, 149);
            this.textBoxSenha.MaxLength = 8;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(244, 20);
            this.textBoxSenha.TabIndex = 4;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(130, 105);
            this.textBoxUsuario.MaxLength = 50;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(244, 20);
            this.textBoxUsuario.TabIndex = 3;
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
            this.textBoxSenhaConfirm.Enabled = false;
            this.textBoxSenhaConfirm.Location = new System.Drawing.Point(138, 392);
            this.textBoxSenhaConfirm.MaxLength = 8;
            this.textBoxSenhaConfirm.Name = "textBoxSenhaConfirm";
            this.textBoxSenhaConfirm.PasswordChar = '*';
            this.textBoxSenhaConfirm.Size = new System.Drawing.Size(169, 26);
            this.textBoxSenhaConfirm.TabIndex = 23;
            this.textBoxSenhaConfirm.TextChanged += new System.EventHandler(this.textBoxSenhaConfirm_TextChanged);
            // 
            // textBoxSenhaInsert
            // 
            this.textBoxSenhaInsert.Enabled = false;
            this.textBoxSenhaInsert.Location = new System.Drawing.Point(138, 360);
            this.textBoxSenhaInsert.MaxLength = 8;
            this.textBoxSenhaInsert.Name = "textBoxSenhaInsert";
            this.textBoxSenhaInsert.PasswordChar = '*';
            this.textBoxSenhaInsert.Size = new System.Drawing.Size(169, 26);
            this.textBoxSenhaInsert.TabIndex = 22;
            this.textBoxSenhaInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSenhaInsert_KeyPress);
            // 
            // textBoxUsuarioInsert
            // 
            this.textBoxUsuarioInsert.Enabled = false;
            this.textBoxUsuarioInsert.Location = new System.Drawing.Point(138, 326);
            this.textBoxUsuarioInsert.MaxLength = 50;
            this.textBoxUsuarioInsert.Name = "textBoxUsuarioInsert";
            this.textBoxUsuarioInsert.Size = new System.Drawing.Size(318, 26);
            this.textBoxUsuarioInsert.TabIndex = 21;
            this.textBoxUsuarioInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsuarioInsert_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 395);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Senha";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Senha";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
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
            this.comboBoxUf.Enabled = false;
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
            this.comboBoxUf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxUf_KeyPress);
            this.comboBoxUf.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxUf_Validating);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(138, 294);
            this.textBoxEmail.MaxLength = 100;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(438, 26);
            this.textBoxEmail.TabIndex = 13;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Enabled = false;
            this.textBoxEndereco.Location = new System.Drawing.Point(138, 188);
            this.textBoxEndereco.MaxLength = 100;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(438, 26);
            this.textBoxEndereco.TabIndex = 12;
            this.textBoxEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEndereco_KeyPress);
            this.textBoxEndereco.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEndereco_Validating);
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.Enabled = false;
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(138, 257);
            this.maskedTextBoxCelular.Mask = "(00) 00000-9999";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(131, 26);
            this.maskedTextBoxCelular.TabIndex = 11;
            this.maskedTextBoxCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCelular_KeyPress);
            // 
            // maskedTextBoxNascimento
            // 
            this.maskedTextBoxNascimento.Enabled = false;
            this.maskedTextBoxNascimento.Location = new System.Drawing.Point(451, 154);
            this.maskedTextBoxNascimento.Mask = "00/00/0000";
            this.maskedTextBoxNascimento.Name = "maskedTextBoxNascimento";
            this.maskedTextBoxNascimento.Size = new System.Drawing.Size(125, 26);
            this.maskedTextBoxNascimento.TabIndex = 10;
            this.maskedTextBoxNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxNascimento_KeyPress);
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Enabled = false;
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(138, 154);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(169, 26);
            this.maskedTextBoxCpf.TabIndex = 9;
            this.maskedTextBoxCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCpf_KeyPress);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(138, 119);
            this.textBoxNome.MaxLength = 80;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(438, 26);
            this.textBoxNome.TabIndex = 8;
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            this.textBoxNome.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNome_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
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
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.panelConta.Controls.Add(this.buttonSair);
            this.panelConta.Controls.Add(this.buttonPagar);
            this.panelConta.Controls.Add(this.buttonDepositar);
            this.panelConta.Controls.Add(this.buttonTransferir);
            this.panelConta.Controls.Add(this.panelContaPoupanca);
            this.panelConta.Controls.Add(this.panelTransacao);
            this.panelConta.Controls.Add(this.panelContaCorrente);
            this.panelConta.Controls.Add(this.panelDadosUsuario);
            this.panelConta.Location = new System.Drawing.Point(12, 12);
            this.panelConta.Name = "panelConta";
            this.panelConta.Size = new System.Drawing.Size(893, 511);
            this.panelConta.TabIndex = 18;
            this.panelConta.Visible = false;
            this.panelConta.VisibleChanged += new System.EventHandler(this.panelConta_VisibleChanged);
            // 
            // buttonPagar
            // 
            this.buttonPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagar.Location = new System.Drawing.Point(749, 250);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(91, 29);
            this.buttonPagar.TabIndex = 5;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.UseVisualStyleBackColor = true;
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositar.Location = new System.Drawing.Point(749, 285);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(91, 29);
            this.buttonDepositar.TabIndex = 4;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = true;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransferir.Location = new System.Drawing.Point(749, 325);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(91, 29);
            this.buttonTransferir.TabIndex = 3;
            this.buttonTransferir.Text = "Transferir";
            this.buttonTransferir.UseVisualStyleBackColor = true;
            // 
            // panelContaPoupanca
            // 
            this.panelContaPoupanca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContaPoupanca.Controls.Add(this.labelSaldoPoupanca);
            this.panelContaPoupanca.Controls.Add(this.label20);
            this.panelContaPoupanca.Controls.Add(this.label17);
            this.panelContaPoupanca.Location = new System.Drawing.Point(269, 156);
            this.panelContaPoupanca.Name = "panelContaPoupanca";
            this.panelContaPoupanca.Size = new System.Drawing.Size(200, 236);
            this.panelContaPoupanca.TabIndex = 2;
            // 
            // labelSaldoPoupanca
            // 
            this.labelSaldoPoupanca.AutoSize = true;
            this.labelSaldoPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoPoupanca.Location = new System.Drawing.Point(15, 114);
            this.labelSaldoPoupanca.Name = "labelSaldoPoupanca";
            this.labelSaldoPoupanca.Size = new System.Drawing.Size(148, 46);
            this.labelSaldoPoupanca.TabIndex = 9;
            this.labelSaldoPoupanca.Text = "R$0,00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(75, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 17);
            this.label20.TabIndex = 7;
            this.label20.Text = "Saldo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(35, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Conta Poupança";
            // 
            // panelTransacao
            // 
            this.panelTransacao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTransacao.Controls.Add(this.label21);
            this.panelTransacao.Controls.Add(this.label18);
            this.panelTransacao.Location = new System.Drawing.Point(501, 156);
            this.panelTransacao.Name = "panelTransacao";
            this.panelTransacao.Size = new System.Drawing.Size(200, 236);
            this.panelTransacao.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.Control;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(67, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 17);
            this.label21.TabIndex = 8;
            this.label21.Text = "Histórico";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(49, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Transações";
            // 
            // panelContaCorrente
            // 
            this.panelContaCorrente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContaCorrente.Controls.Add(this.labelSaldoCorrente);
            this.panelContaCorrente.Controls.Add(this.label16);
            this.panelContaCorrente.Controls.Add(this.label19);
            this.panelContaCorrente.Location = new System.Drawing.Point(35, 156);
            this.panelContaCorrente.Name = "panelContaCorrente";
            this.panelContaCorrente.Size = new System.Drawing.Size(200, 236);
            this.panelContaCorrente.TabIndex = 1;
            // 
            // labelSaldoCorrente
            // 
            this.labelSaldoCorrente.AutoSize = true;
            this.labelSaldoCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoCorrente.Location = new System.Drawing.Point(11, 112);
            this.labelSaldoCorrente.Name = "labelSaldoCorrente";
            this.labelSaldoCorrente.Size = new System.Drawing.Size(148, 46);
            this.labelSaldoCorrente.TabIndex = 8;
            this.labelSaldoCorrente.Text = "R$0,00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(39, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Conta Corrente";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(67, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 17);
            this.label19.TabIndex = 6;
            this.label19.Text = "Saldo";
            // 
            // panelDadosUsuario
            // 
            this.panelDadosUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDadosUsuario.Controls.Add(this.labelConta);
            this.panelDadosUsuario.Controls.Add(this.labelAgencia);
            this.panelDadosUsuario.Controls.Add(this.labelBanco);
            this.panelDadosUsuario.Controls.Add(this.labelNome);
            this.panelDadosUsuario.Location = new System.Drawing.Point(35, 28);
            this.panelDadosUsuario.Name = "panelDadosUsuario";
            this.panelDadosUsuario.Size = new System.Drawing.Size(666, 100);
            this.panelDadosUsuario.TabIndex = 0;
            // 
            // labelConta
            // 
            this.labelConta.AutoSize = true;
            this.labelConta.BackColor = System.Drawing.SystemColors.Control;
            this.labelConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConta.Location = new System.Drawing.Point(462, 59);
            this.labelConta.Name = "labelConta";
            this.labelConta.Size = new System.Drawing.Size(52, 20);
            this.labelConta.TabIndex = 3;
            this.labelConta.Text = "Conta";
            // 
            // labelAgencia
            // 
            this.labelAgencia.AutoSize = true;
            this.labelAgencia.BackColor = System.Drawing.SystemColors.Control;
            this.labelAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgencia.Location = new System.Drawing.Point(462, 20);
            this.labelAgencia.Name = "labelAgencia";
            this.labelAgencia.Size = new System.Drawing.Size(67, 20);
            this.labelAgencia.TabIndex = 2;
            this.labelAgencia.Text = "Agencia";
            // 
            // labelBanco
            // 
            this.labelBanco.AutoSize = true;
            this.labelBanco.BackColor = System.Drawing.SystemColors.Control;
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
            this.labelNome.BackColor = System.Drawing.SystemColors.Control;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(15, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(51, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(749, 363);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(91, 29);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(932, 535);
            this.Controls.Add(this.panelConta);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelCadastro);
            this.Name = "FormPrincipal";
            this.Text = "FuBank";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.panelConta.ResumeLayout(false);
            this.panelContaPoupanca.ResumeLayout(false);
            this.panelContaPoupanca.PerformLayout();
            this.panelTransacao.ResumeLayout(false);
            this.panelTransacao.PerformLayout();
            this.panelContaCorrente.ResumeLayout(false);
            this.panelContaCorrente.PerformLayout();
            this.panelDadosUsuario.ResumeLayout(false);
            this.panelDadosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonCadastre;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Panel panelContaPoupanca;
        private System.Windows.Forms.Panel panelTransacao;
        private System.Windows.Forms.Panel panelContaCorrente;
        private System.Windows.Forms.Panel panelDadosUsuario;
        private System.Windows.Forms.Button buttonPagar;
        private System.Windows.Forms.Button buttonDepositar;
        private System.Windows.Forms.Button buttonTransferir;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelConta;
        private System.Windows.Forms.Label labelAgencia;
        private System.Windows.Forms.Label labelBanco;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelSaldoPoupanca;
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
    }
}