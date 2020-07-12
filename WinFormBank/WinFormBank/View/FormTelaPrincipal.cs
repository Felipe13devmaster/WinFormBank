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
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
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
                buttonCadastrar.Enabled = false;
            }
            else
            {
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                buttonCadastrar.Enabled = true;
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
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
            }
            else
            {
                labelConfirmaSenha.Text = "Senhas não conferem.";
                label13.ForeColor = Color.Red;
                label14.ForeColor = Color.Red;
            }
        }

        private void panelConta_VisibleChanged(object sender, EventArgs e)
        {
            if (panelConta.Visible == true)
            {
                Cliente cliente = new Cliente();
                Conta conta = new Conta();
                ContaDAO contaDAO = new ContaDAO();
                Transacao transacao = new Transacao();
                TransacaoDAO transacaoDAO = new TransacaoDAO();
                List<Transacao> transacoesList = new List<Transacao>();

                string idUsuario = textBoxUsuario.Text;

                cliente = contaDAO.ConsultarDados(cliente, idUsuario);
                conta = contaDAO.ConsultarDados(conta, idUsuario);

                labelNome.Text = "Nome: "+ cliente.Nome;
                labelAgencia.Text = "Agencia: 0001 - 7";
                labelBanco.Text = "Banco: 13";
                labelConta.Text = "Conta: "+ conta.Numero;
                labelSaldoCorrente.Text = "R$ "+conta.Saldo.ToString("0.00");


                transacoesList = transacaoDAO.ConsultarDados(conta.Numero);

                foreach (Transacao item in transacoesList)
                {
                    textBoxHistorico.AppendText("=================================" + System.Environment.NewLine.ToString());//metodo newline para pular linha
                    textBoxHistorico.AppendText("Data e Hora : " + item.DataHora.ToString() + " " + System.Environment.NewLine.ToString());
                    textBoxHistorico.AppendText("Descrição: " + item.Descricao + " " + System.Environment.NewLine.ToString());
                    textBoxHistorico.AppendText("Tipo: " + item.Tipo + " | ");
                    textBoxHistorico.AppendText("Valor: R$" + item.Valor.ToString("0.00") + " " + System.Environment.NewLine.ToString());
                    textBoxHistorico.AppendText("=================================" + System.Environment.NewLine.ToString());
                }
            }
        }

        private void comboBoxTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBoxTipoConta.SelectedIndex;
            if (indice == 1)
            {
                textBoxContaDestino.Visible = true;
                labelInfConta.Visible = true;
            }
            else
            {
                textBoxContaDestino.Visible = false;
                labelInfConta.Visible = false;
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
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            panelCadastro.Visible = false;
            panelLogin.Visible = true;
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
            Conta conta = new Conta();
            ContaCorrente contaCorrente = new ContaCorrente();
            ClienteDAO clienteDAO = new ClienteDAO();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            ContaDAO contaDAO = new ContaDAO();
            ContaCorrenteDAO contaCorrenteDAO = new ContaCorrenteDAO();

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
                // metodos
                bool validadoC = cliente.ValidaCliente(cliente);
                clienteDAO.Salvar(cliente, validadoC);
                bool validadoU = usuario.ValidaUsuario(usuario);
                string cpfCliente = cliente.Cpf;
                usuarioDAO.Salvar(usuario, validadoU, cpfCliente);
                conta = contaCorrente.CriarConta();
                contaDAO.Salvar(validadoC, conta, cpfCliente);
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
        
        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            panelDeposito.Visible = true;
            panelSaque.Visible = false;
            panelTransferencia.Visible = false;
            labelMensagemTransf.Visible = false;
            labelMensagemSaque.Visible = false;
            labelMensagemDeposito.Visible = false;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Até logo!");
            panelLogin.Visible = true;
            panelConta.Visible = false;
        }

        private void buttonSaque_Click(object sender, EventArgs e)
        {
            panelSaque.Visible = true;
            panelTransferencia.Visible = false;
            panelDeposito.Visible = false;
            labelMensagemTransf.Visible = false;
            labelMensagemSaque.Visible = false;
            labelMensagemDeposito.Visible = false;
            labelMensagemTransf.Visible = false;
            labelMensagemSaque.Visible = false;
            labelMensagemDeposito.Visible = false;
        }

        private void buttonLimpa_Click(object sender, EventArgs e)
        {
            textBoxValorSaque.Text = "";
        }

        private void buttonCancela_Click(object sender, EventArgs e)
        {
            textBoxValorSaque.Text = "";
            panelSaque.Visible = false;
            labelMensagemSaque.Visible = false;
        }

        private void buttonSairDeposito_Click(object sender, EventArgs e)
        {
            panelDeposito.Visible = false;
            textBoxValorDeposito.Text = "";
            
        }

        private void buttonLimparDeposito_Click(object sender, EventArgs e)
        {
            textBoxValorDeposito.Text = "";
            labelMensagemDeposito.Visible = false;
        }

        private void buttonConfirmaDeposito_Click(object sender, EventArgs e)
        {
            Transacao transacao = new Transacao();
            TransacaoDAO transacaoDAO = new TransacaoDAO();
            ContaCorrenteDAO contaCorrenteDAO = new ContaCorrenteDAO();
            List<Transacao> transacoesList = new List<Transacao>();
            string input = textBoxValorDeposito.Text;
            int valorValidacao = 0;

            if (!int.TryParse(input, out valorValidacao))
            {
                textBoxValorDeposito.Focus();
                labelMensagemDeposito.Text = "Digite um valor valido.";
                labelMensagemDeposito.Visible = true;
                MessageBox.Show("Valor de deposito invalido!", "Atenção");
            }
            else
            {
                try
                {
                    decimal valor = Convert.ToDecimal(textBoxValorDeposito.Text);
                    int conta = Convert.ToInt32(labelConta.Text.Substring(6));
                    bool aprovado = contaCorrenteDAO.Depositar(conta, valor);

                    if (aprovado == true && valor > 0)
                    {
                        labelMensagemDeposito.Text = "Deposito confirmado.";
                        labelMensagemDeposito.Visible = true;
                        textBoxValorDeposito.Text = "";
                        decimal saldo = contaCorrenteDAO.ConsultarSaldo(conta);
                        labelSaldoCorrente.Text = "R$ " + saldo.ToString("0.00");
                        transacao.Tipo = "Deposito";
                        transacao.Descricao = "Deposito em C/C";
                        transacao.Valor = valor;
                        transacao.DataHora = DateTime.Now;
                        transacao.NumeroConta = conta;
                        transacaoDAO.RegistrarTransacao(transacao);
                        transacoesList = transacaoDAO.ConsultarDados(conta);

                        foreach (Transacao item in transacoesList)
                        {
                            textBoxHistorico.AppendText("=================================" + System.Environment.NewLine.ToString());
                            textBoxHistorico.AppendText("Data e Hora : " + item.DataHora.ToString() + " " + System.Environment.NewLine.ToString());
                            textBoxHistorico.AppendText("Descrição: " + item.Descricao + " " + System.Environment.NewLine.ToString());
                            textBoxHistorico.AppendText("Tipo: " + item.Tipo + " | ");
                            textBoxHistorico.AppendText("Valor: R$" + item.Valor.ToString("0.00") + " " + System.Environment.NewLine.ToString());
                            textBoxHistorico.AppendText("=================================" + System.Environment.NewLine.ToString());
                        }
                    }
                    else
                    {
                        labelMensagemDeposito.Text = "Deposito fracassou.";
                        labelMensagemDeposito.Visible = true;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Valor de deposito invalido!", "Atenção");
                    labelMensagemDeposito.Text = "Digite um valor valido.";
                    labelMensagemDeposito.Visible = true;
                    textBoxValorDeposito.Focus();
                }
            }
        }

        private void buttonConfirmaSaque_Click(object sender, EventArgs e)
        {
            Transacao transacao = new Transacao();
            TransacaoDAO transacaoDAO = new TransacaoDAO();
            ContaCorrenteDAO contaCorrenteDAO = new ContaCorrenteDAO();
            List<Transacao> transacoesList = new List<Transacao>();
            
            string input = textBoxValorSaque.Text;
            int valorValidacao = 0;

            if (!int.TryParse(input, out valorValidacao))
            {
                textBoxValorSaque.Focus();
                labelMensagemSaque.Text = "Digite um valor valido.";
                labelMensagemSaque.Visible = true;
                MessageBox.Show("Valor de deposito invalido!", "Atenção");
            }
            else
            {
                try
                {
                    decimal valorSaque = Convert.ToDecimal(textBoxValorSaque.Text);
                    int conta = Convert.ToInt32(labelConta.Text.Substring(6));
                    decimal saldo = contaCorrenteDAO.ConsultarSaldo(conta);
                    bool aprovado = contaCorrenteDAO.Sacar(conta, saldo, valorSaque);

                    if (aprovado == true && valorSaque > 0)
                    {
                        labelMensagemSaque.Text = "Saque confirmado.";
                        labelMensagemSaque.Visible = true;
                        textBoxValorSaque.Text = "";
                        decimal saldoAtual = contaCorrenteDAO.ConsultarSaldo(conta);
                        labelSaldoCorrente.Text = "R$ " + saldoAtual.ToString("0.00");
                        transacao.Tipo = "Saque";
                        transacao.Descricao = "Saque em C/C";
                        transacao.Valor = valorSaque;
                        transacao.DataHora = DateTime.Now;
                        transacao.NumeroConta = conta;
                        transacaoDAO.RegistrarTransacao(transacao);
                        transacoesList = transacaoDAO.ConsultarDados(conta);

                        foreach (Transacao item in transacoesList)
                        {
                            textBoxHistorico.AppendText("=================================" + System.Environment.NewLine.ToString());
                            textBoxHistorico.AppendText("Data e Hora : " + item.DataHora.ToString() + " " + System.Environment.NewLine.ToString());
                            textBoxHistorico.AppendText("Descrição: " + item.Descricao + " " + System.Environment.NewLine.ToString());
                            textBoxHistorico.AppendText("Tipo: " + item.Tipo + " | ");
                            textBoxHistorico.AppendText("Valor: R$" + item.Valor.ToString("0.00") + " " + System.Environment.NewLine.ToString());
                            textBoxHistorico.AppendText("=================================" + System.Environment.NewLine.ToString());
                        }
                    }
                    else
                    {
                        labelMensagemSaque.Text = "Saque fracassou.";
                        labelMensagemSaque.Visible = true;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Valor de deposito invalido!", "Atenção");
                    labelMensagemSaque.Text = "Digite um valor valido.";
                    labelMensagemSaque.Visible = true;
                    textBoxValorSaque.Focus();
                }
            }   
        }

        private void buttonLimparTransf_Click(object sender, EventArgs e)
        {
            textBoxValorTransf.Text = "";
        }

        private void buttonCancelarTransf_Click(object sender, EventArgs e)
        {
            textBoxValorTransf.Text = "";
            panelTransferencia.Visible = false;
            labelMensagemTransf.Visible = false;
        }

        private void buttonConfirmaTransf_Click(object sender, EventArgs e)
        {
            try
            {
                Transacao transacaoTransfEnvio = new Transacao();
                Transacao transacaoTransfReceb = new Transacao();
                TransacaoDAO transacaoDAO = new TransacaoDAO();
                ContaCorrenteDAO contaCorrenteDAO = new ContaCorrenteDAO();
                List<Transacao> transacoesList = new List<Transacao>();

                int contaOrigem = Convert.ToInt32(labelConta.Text.Substring(6));
                int contaDestino = Convert.ToInt32(textBoxContaDestino.Text);
                int valorTransf = Convert.ToInt32(textBoxValorTransf.Text);
                bool aprovado = contaCorrenteDAO.Transferir(contaOrigem, contaDestino, valorTransf);
                string nomeBeneficiario = contaCorrenteDAO.ConsultarNome(Convert.ToInt32(textBoxContaDestino.Text));

                if (nomeBeneficiario.Length == 0)
                {
                    labelNomeDestinoTransf.Visible = false;
                }
                else
                {
                    labelNomeDestinoTransf.Visible = true;
                    labelNomeDestinoTransf.Text = "Beneficiario: " + nomeBeneficiario;
                    if (DialogResult.Cancel == MessageBox.Show("Deseja transferir R$ " + valorTransf.ToString("0.00") + " reais para: " + nomeBeneficiario + "?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        aprovado = false;
                    }
                }

                if (aprovado == true)
                {
                    labelMensagemTransf.Visible = true;
                    labelMensagemTransf.Text = "Transferencia realizada com sucesso.";
                    textBoxContaDestino.Text = "";
                    textBoxValorTransf.Text = "";
                    decimal saldoAnterior = Convert.ToDecimal(labelSaldoCorrente.Text.Substring(2));
                    decimal saldoAtual = saldoAnterior - valorTransf;
                    labelSaldoCorrente.Text = "R$ " + saldoAtual.ToString("0.00");
                    transacaoTransfEnvio.Tipo = "Transferencia";
                    transacaoTransfEnvio.Descricao = "Transferencia efetuada para " + nomeBeneficiario + " C/C: " + contaDestino.ToString();
                    transacaoTransfEnvio.Valor = valorTransf;
                    transacaoTransfEnvio.DataHora = DateTime.Now;
                    transacaoTransfEnvio.NumeroConta = contaOrigem;
                    transacaoDAO.RegistrarTransacao(transacaoTransfEnvio);
                    string nomeRemetente = labelNome.Text;
                    transacaoTransfReceb.Tipo = "Transferencia";
                    transacaoTransfReceb.Descricao = "Transferencia recebida de " + nomeRemetente.Substring(6) + " C/C: " + contaOrigem.ToString();
                    transacaoTransfReceb.Valor = valorTransf;
                    transacaoTransfReceb.DataHora = DateTime.Now;
                    transacaoTransfReceb.NumeroConta = contaDestino;
                    transacaoDAO.RegistrarTransacao(transacaoTransfReceb);
                    transacoesList = transacaoDAO.ConsultarDados(contaOrigem);

                    foreach (Transacao item in transacoesList)
                    {
                        textBoxHistorico.AppendText("=================================" + System.Environment.NewLine.ToString());
                        textBoxHistorico.AppendText("Data e Hora : " + item.DataHora.ToString() + " " + System.Environment.NewLine.ToString());
                        textBoxHistorico.AppendText("Descrição: " + item.Descricao + " " + System.Environment.NewLine.ToString());
                        textBoxHistorico.AppendText("Tipo: " + item.Tipo + " | ");
                        textBoxHistorico.AppendText("Valor: R$" + item.Valor.ToString("0.00") + " " + System.Environment.NewLine.ToString());
                        textBoxHistorico.AppendText("=================================" + System.Environment.NewLine.ToString());
                    }
                }
                else
                {
                    labelMensagemTransf.Visible = true;
                    labelMensagemTransf.Text = "Transferencia nao realizada.";
                    labelMensagemTransf.ForeColor = Color.Red;
                    textBoxContaDestino.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor invalido e/ou Conta para transferencia nao informada.", "Atenção");
                textBoxValorTransf.Focus();
            }  
        }

        private void buttonTransferir_Click(object sender, EventArgs e)
        {
            panelTransferencia.Visible = true;
            panelSaque.Visible = false;
            panelDeposito.Visible = false;
            labelMensagemTransf.Visible = false;
            labelMensagemSaque.Visible = false;
            labelMensagemDeposito.Visible = false;
            comboBoxTipoConta.SelectedIndex = 0;
        }
    }
}