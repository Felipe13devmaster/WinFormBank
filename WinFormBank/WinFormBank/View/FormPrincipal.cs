using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
