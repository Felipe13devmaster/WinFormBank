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
                
            }
            else
            {
                label5.ForeColor = Color.Black;
            }
        }

        private void maskedTextBoxCpf_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxCpf.Text.Length < 14)
            {
                label6.ForeColor = Color.Red;
            }
            else
            {
                label6.ForeColor = Color.Black;
            }
        }

        private void maskedTextBoxNascimento_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxNascimento.Text.Length < 10)
            {
                label7.ForeColor = Color.Red;
            }
            else
            {
                label7.ForeColor = Color.Black;
            }
        }

        private void textBoxEndereco_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxEndereco.Text))
            {
                label8.ForeColor = Color.Red;
            }
            else
            {
                label8.ForeColor = Color.Black;
            }
        }

        private void maskedTextBoxCelular_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxCelular.Text.Length < 15)
            {
                label10.ForeColor = Color.Red;
            }
            else
            {
                label10.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                label11.ForeColor = Color.Red;
            }
            else
            {
                label11.ForeColor = Color.Black;
            }
        }

        private void textBoxUsuarioInsert_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxUsuarioInsert.Text.Length < 1)
            {
                label12.ForeColor = Color.Red;
            }
            else
            {
                label12.ForeColor = Color.Black;
            }
        }

        private void textBoxSenhaInsert_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxSenhaInsert.Text.Length < 4)
            {
                label13.ForeColor = Color.Red;
                label14.ForeColor = Color.Red;
            }
            else
            {
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
            }
        }

        private void textBoxSenhaConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxSenhaConfirm.Text.Length < textBoxSenhaInsert.Text.Length)
            {
                label13.ForeColor = Color.Red;
                label14.ForeColor = Color.Red;
            }
            else
            {
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
            }
        }

        private void comboBoxUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUf.SelectedIndex == 0)
            {
                label9.ForeColor = Color.Red;
                buttonCadastrar.Enabled = false;
            }
            else
            {
                label9.ForeColor = Color.Black;
                buttonCadastrar.Enabled = true;
            }
        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ignora as teclas numericas quando pressionadas
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^a-zA-Z\s]"))
                e.Handled = true;
        }

        private void textBoxNome_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                label5.ForeColor = Color.Red;
            }
            else
            {
                label5.ForeColor = Color.Black;
            }
        }

        private void maskedTextBoxCpf_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxCpf.Text.Length < 14)
            {
                label6.ForeColor = Color.Red;
            }
            else
            {
                label6.ForeColor = Color.Black;
            }
        }

        private void maskedTextBoxNascimento_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxNascimento.Text.Length < 10)
            {
                label7.ForeColor = Color.Red;
            }
            else
            {
                label7.ForeColor = Color.Black;
            }
        }

        private void textBoxEndereco_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxEndereco.Text))
            {
                label8.ForeColor = Color.Red;
            }
            else
            {
                label8.ForeColor = Color.Black;
            }
        }

        private void maskedTextBoxCelular_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxCelular.Text.Length < 15)
            {
                label10.ForeColor = Color.Red;
            }
            else
            {
                label10.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                label11.ForeColor = Color.Red;
            }
            else
            {
                label11.ForeColor = Color.Red;
            }
        }

        private void textBoxUsuarioInsert_Click(object sender, EventArgs e)
        {
            if (textBoxUsuarioInsert.Text.Length < 4)
            {
                label12.ForeColor = Color.Red;
            }
            else
            {
                label12.ForeColor = Color.Black;
            }
        }

        private void textBoxSenhaInsert_Click(object sender, EventArgs e)
        {
            if (textBoxSenhaInsert.Text.Length < 4)
            {
                label13.ForeColor = Color.Red;
                label14.ForeColor = Color.Red;
            }
            else
            {
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
            }
        }

        private void textBoxSenhaConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxSenhaConfirm.Text.Length < textBoxSenhaInsert.Text.Length)
            {
                label13.ForeColor = Color.Red;
                label14.ForeColor = Color.Red;
            }
            else
            {
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
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
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
            }
            else
            {
                labelConfirmaSenha.Text = "Senhas não conferem.";
                buttonCadastrar.Enabled = false;
                label13.ForeColor = Color.Red;
                label14.ForeColor = Color.Red;
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

            usuario.IdNome = textBoxUsuario.Text;
            usuario.Senha = textBoxSenha.Text;

            temAcesso = usuarioDAO.VerificarLogin(usuario.IdNome, usuario.Senha);

            if (temAcesso == true)
            {
                panelLogin.Visible = false;
                panelConta.Visible = true;
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
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

            try
            {
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
                usuario.IdNome = textBoxUsuarioInsert.Text;
                usuario.Senha = textBoxSenhaConfirm.Text;

                bool validadoC = cliente.ValidaCliente(cliente);
                clienteDAO.Salvar(cliente, validadoC);
                bool validadoU = usuario.ValidaUsuario(usuario);
                string cpfCliente = cliente.Cpf;
                usuarioDAO.Salvar(usuario, validadoU, cpfCliente);
            }
            catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("Por favor informe sua data de nascimento. ");
            }
            catch (FormatException )
            {
                MessageBox.Show("Formato de data de nascimento invalida!. ");
            }

            panelLogin.Visible = true;
            panelCadastro.Visible = false;

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

        //Botoes Panel Conta
        private void buttonPagar_Click(object sender, EventArgs e)
        {

        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {

        }

        private void buttonTransferir_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Até logo!");
            panelLogin.Visible = true;
            panelConta.Visible = false;
        }        
    }
}