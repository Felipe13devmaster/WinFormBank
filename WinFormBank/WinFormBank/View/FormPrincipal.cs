using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormBank.Model;
using WinFormBank.Controller;

namespace WinFormBank.View
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
    // EVENTOS=========================================================================================================================
        private void textBoxNome_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                label5.ForeColor = Color.Red;
                buttonCadastrar.Enabled = false;
                
            }
        }

        private void textBoxEndereco_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxEndereco.Text))
            {
                label8.ForeColor = Color.Red;
                buttonCadastrar.Enabled = false;
            }
            else
            {
                buttonCadastrar.Enabled = true;
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                label11.ForeColor = Color.Red;
                buttonCadastrar.Enabled = false;
            }
            else
            {
                buttonCadastrar.Enabled = true;
            }
        }

        private void comboBoxUf_Validating(object sender, CancelEventArgs e)
        {
            string itemUf = comboBoxUf.Text;
            if(itemUf.Equals("Selecione..."))
            {
                buttonCadastrar.Enabled = false;
            }
            else
            {
                buttonCadastrar.Enabled = true;
            }
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ignora as teclas numericas quando pressionadas
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z]+$"))
                e.Handled = true;
            if ((e.KeyChar == (char)Keys.Enter) && (textBoxNome.Text.Length > 0))
            {
                maskedTextBoxCpf.Enabled = true;
                maskedTextBoxCpf.Focus();
            }
            else
            {
                label15.Text = "Por favor insira seu nome.";
                buttonCadastrar.Enabled = false;
            }
        }

        private void maskedTextBoxCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && (maskedTextBoxCpf.Text.Length == 14))
            {
                maskedTextBoxNascimento.Enabled = true;
                maskedTextBoxNascimento.Focus();
            }
            else
            {
                label15.Text = "Por favor insira seu CPF.";
                buttonCadastrar.Enabled = false;
            }
        }

        private void maskedTextBoxNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && (maskedTextBoxNascimento.Text.Length == 10))
            {
                textBoxEndereco.Enabled = true;
                textBoxEndereco.Focus();
            }
            else
            {
                label15.Text = "Por favor insira sua data de nascimento.";
                buttonCadastrar.Enabled = false;
            }
        }

        private void textBoxEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && (textBoxEndereco.Text.Length > 0))
            {
                comboBoxUf.Enabled = true;
                comboBoxUf.Focus();
                buttonCadastrar.Enabled = false;
            }
            else
            {
                label15.Text = "Por favor insira seu enderço (nome da rua, numero).";
                buttonCadastrar.Enabled = false;
            }
        }

        private void comboBoxUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && (comboBoxUf.SelectedIndex != 0))
            {
                maskedTextBoxCelular.Enabled = true;
                maskedTextBoxCelular.Focus();
                buttonCadastrar.Enabled = false;
            }
            else
            {
                label15.Text = "Por favor selecione o estado onde reside.";
                buttonCadastrar.Enabled = false;
            }
        }

        private void maskedTextBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && (maskedTextBoxCelular.Text.Length == 15))
            {
                textBoxEmail.Enabled = true;
                textBoxEmail.Focus();
                buttonCadastrar.Enabled = false;
            }
            else
            {
                label15.Text = "Por favor insira seu numero de celular.";
                buttonCadastrar.Enabled = false;
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && (textBoxEmail.Text.Length > 0))
            {
                textBoxUsuarioInsert.Enabled = true;
                textBoxUsuarioInsert.Focus();
                buttonCadastrar.Enabled = false;
            }
            else
            {
                label15.Text = "Por favor insira um email valido.";
                buttonCadastrar.Enabled = false;
            }
        }

        private void textBoxUsuarioInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && (textBoxUsuarioInsert.Text.Length >= 4))
            {
                textBoxSenhaInsert.Enabled = true;
                textBoxSenhaInsert.Focus();
                buttonCadastrar.Enabled = false;
            }
            else
            {
                label15.Text = "Por favor insira seu nome de usuario com no minimo 4 digitos.";
                buttonCadastrar.Enabled = false;
            }
        }

        private void textBoxSenhaInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && (textBoxSenhaInsert.Text.Length >= 4))
            {
                textBoxSenhaConfirm.Enabled = true;
                textBoxSenhaConfirm.Focus();
                buttonCadastrar.Enabled = false;
            }
            else
            {
                label15.Text = "A senha deve conter no minimo 4 digitos.";
                buttonCadastrar.Enabled = false;
            }
        }
    
        private void textBoxSenhaConfirm_TextChanged(object sender, EventArgs e)
        {
            string textSenhaInsert = textBoxSenhaInsert.Text;
            string textSenhaConfirm = textBoxSenhaConfirm.Text;
            if (textSenhaInsert.Equals(textSenhaConfirm))
            {
                labelConfirmaSenha.Text = "Senha validada com sucesso.";
                buttonCadastrar.Enabled = true;
            }
            else
            {
                labelConfirmaSenha.Text = "Senhas não conferem.";
                buttonCadastrar.Enabled = false;
            }
        }

        private void panelConta_VisibleChanged(object sender, EventArgs e)
        {
            if (panelConta.Visible == true)
            {
                labelNome.Text = "Seu nome";
                labelAgencia.Text = "Agencia: 0001 - 7";
                labelBanco.Text = "Banco: 13";
                labelConta.Text = "Conta: 59017";
            }
        }

        // BOTÕES =============================================================================================================
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            bool temAcesso;

            usuario.Nome = textBoxUsuario.Text;
            usuario.Senha = textBoxSenha.Text;

            temAcesso = usuarioDAO.verificarLogin(usuario.Nome, usuario.Senha);

            if (temAcesso == true)
            {
                panelLogin.Visible = false;
                panelConta.Visible = true;
            }
            else
            {
                MessageBox.Show("Senha e/ou login incorretos.");
            }
        }

        private void buttonCadastre_Click(object sender, EventArgs e)
        {
            panelCadastro.Visible = true;
            panelLogin.Visible = false;
            textBoxNome.Focus();
            comboBoxUf.SelectedIndex = 0;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            panelCadastro.Visible = false;
            panelLogin.Visible = true;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            maskedTextBoxCpf.Text = "";
            maskedTextBoxNascimento.Text = "";
            textBoxEndereco.Text = "";
            comboBoxUf.SelectedIndex = 0;
            maskedTextBoxCelular.Text = "";
            textBoxEmail.Text = "";
            textBoxUsuarioInsert.Text = "";
            textBoxSenhaInsert.Text = "";
            textBoxSenhaConfirm.Text = "";
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Usuario usuario = new Usuario();
            ClienteDAO clienteDAO = new ClienteDAO();
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            cliente.Nome = textBoxNome.Text;
            cliente.Cpf = maskedTextBoxCpf.Text;
            string dia = maskedTextBoxNascimento.Text.Substring(0, 2);
            string mes = maskedTextBoxNascimento.Text.Substring(2, 4);
            string ano = maskedTextBoxNascimento.Text.Substring(6, 4);
            string data = ano + mes + dia;
            cliente.Nascimento = DateTime.Parse(data);
            cliente.Endereco = textBoxEndereco.Text;
            cliente.Uf = comboBoxUf.Text;
            cliente.Celular = maskedTextBoxCelular.Text;
            cliente.Email = textBoxEmail.Text;
            usuario.Nome = textBoxUsuarioInsert.Text;
            usuario.Senha = textBoxSenhaConfirm.Text;

            clienteDAO.salvar(cliente);
            usuarioDAO.salvar(usuario);
            //Limpa os campos após salvar
            textBoxNome.Text = "";
            maskedTextBoxCpf.Text = "";
            maskedTextBoxNascimento.Text = "";
            textBoxEndereco.Text = "";
            comboBoxUf.SelectedIndex = 0;
            maskedTextBoxCelular.Text = "";
            textBoxEmail.Text = "";
            textBoxUsuarioInsert.Text = "";
            textBoxSenhaInsert.Text = "";
            textBoxSenhaConfirm.Text = "";
        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {

        }

        
    }
}