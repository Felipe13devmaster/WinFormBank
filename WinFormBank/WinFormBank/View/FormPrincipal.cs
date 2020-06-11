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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastre_Click(object sender, EventArgs e)
        {
            panelCadastro.Visible = true;
            panelLogin.Visible = false;
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

        private void textBoxSenhaConfirm_TextChanged(object sender, EventArgs e)
        {
            string textSenhaInsert = textBoxSenhaInsert.Text;
            string textSenhaConfirm = textBoxSenhaConfirm.Text;
            if(textSenhaInsert.Equals(textSenhaConfirm))
            {
                labelConfirmaSenha.Text = "Senha validada com sucesso.";
            }
            else
            {
                labelConfirmaSenha.Text = "Senhas não conferem.";
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Usuario usuario = new Usuario();
            ClienteDAO clienteDAO = new ClienteDAO();
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            cliente.Nome = textBoxNome.Text;
            cliente.Cpf = maskedTextBoxCpf.Text;//  13/04/1991
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
           


        }
    }
}
