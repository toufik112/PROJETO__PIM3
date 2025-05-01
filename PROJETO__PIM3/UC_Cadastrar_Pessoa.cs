using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using PROJETO__PIM3.Properties;

namespace PROJETO__PIM3
{
    public partial class UC_Cadastrar_Pessoa : Form
    {

        public UC_Cadastrar_Pessoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            ValidarCampos();

            // MessageBox.Show(Cadastro Realizado com sucesso!");

           /* if (string.IsNullOrWhiteSpace(txb_codigo_funcionario_cad_pess.Text))
            {
                MessageBox.Show("Cadastro Realizado com sucesso!");
                Tela_Principal tela_Principal = new Tela_Principal();

                tela_Principal.Show();
                this.Hide();
            }
            else if (txb_codigo_funcionario_cad_pess.Text == "#123")
            {
                MessageBox.Show("Cadastro Realizado com sucesso!");
                Tela_Usuario tela_Usuario = new Tela_Usuario();
                tela_Usuario.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Codigo fincionario esta errado! tenta novamente");
            }
            //  this.Hide();*/


        }



        private void btn_sair_Click(object sender, EventArgs e)
        {

            DialogResult resposta = MessageBox.Show("Quer sair do programa!", "Sair", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                }


            }
            else
            {
                this.Close();
            }
        }

        private void UC_Cadastrar_Pessoa_Load(object sender, EventArgs e)
        {

        }

        private void ValidarCampos()
        { 

            // Nome completo
            if (string.IsNullOrWhiteSpace(txb_nome_cad_pess.Text) || Regex.IsMatch(txb_nome_cad_pess.Text, @"[^a-zA-Z\s]"))
            {
                MessageBox.Show("Nome completo inválido. Não pode conter caracteres especiais.");
                return;
            }

            // Data de nascimento
            if (string.IsNullOrWhiteSpace(txb_data_nacimento_cad_pess.Text))
            {
                MessageBox.Show("Data de nascimento é obrigatória.");
                return;
            }

            // CPF
            string cpf = txb_cpf_cad_pess.Text.Trim();
            if (!Regex.IsMatch(cpf, @"^\d{11}$"))
            {
                MessageBox.Show("CPF deve conter exatamente 11 números.");
                return;
            }

            // E-mail
            string email = txb_email_cad_pess.Text.Trim();
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                MessageBox.Show("E-mail inválido.");
                return;
            }

            // Telefone
            string telefone = txb_telefone_cad_pess.Text.Trim();
            if (!Regex.IsMatch(telefone, @"^\d{11}$"))
            {
                MessageBox.Show("Telefone deve conter exatamente 11 números.");
                return;
            }

            // Endereço
            if (string.IsNullOrWhiteSpace(txb_endereco_cad_pess.Text))
            {
                MessageBox.Show("Endereço é obrigatório.");
                return;
            }
            // Senha
            string Senha = txb_senha_cad_pess.Text.Trim();
            if (!Regex.IsMatch(Senha, @"^\d{8}$"))
            {
                MessageBox.Show("Senha deve conter exatamente 8 números.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txb_codigo_funcionario_cad_pess.Text))
            {
                MessageBox.Show("Cadastro Realizado com sucesso!");
                Tela_Usuario tela_Usuario = new Tela_Usuario();
                tela_Usuario.Show();
                this.Hide();
            }
            else if (txb_codigo_funcionario_cad_pess.Text == "#123")
            {
                MessageBox.Show("Cadastro Realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tela_Principal tela_Principal = new Tela_Principal();
                tela_Principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Código de funcionário está errado! Tente novamente.");
            }
           
        }

       
    }
}

