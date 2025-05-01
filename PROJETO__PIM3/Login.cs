using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


    using PROJETO__PIM3.Properties;

namespace PROJETO__PIM3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Cadastrar_Pessoa cadastrar_Pessoa = new UC_Cadastrar_Pessoa();
            cadastrar_Pessoa.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ValidarCampos();




          //  Tela_Usuario tela_Usuario = new Tela_Usuario();
          //tela_Usuario.Show(); 
          //this.Hide();

        }

           /* string UserName = txb_user_name.Text;
            string Senha = txb_senha.Text;

           
            if (UserName == "Admin" && Senha == "Admin")
            {
                Tela_Principal tela_Principal = new Tela_Principal();
                tela_Principal.Show();
                this.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nome de Usuario ou Senha errado /n tente novamente!");
            }*/


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txb_user_name_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void txb_senha_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void ValidarCampos()
        {

            // Nome completo
            if (string.IsNullOrWhiteSpace(txb_user_name.Text) || Regex.IsMatch(txb_user_name.Text, @"[^a-zA-Z\s]"))
            {
                MessageBox.Show("Nome do Usuario inválido.");
                return;
            }

            // Senha
            string Senha = txb_senha_Login.Text.Trim();
            if (!Regex.IsMatch(Senha, @"^\d{8}$"))
            {
                MessageBox.Show("Senha deve conter exatamente 8 números.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txb_codigo_funcionario_login.Text))
            {
                MessageBox.Show("Login realizado com sucesso!");
                Tela_Usuario tela_Usuario = new Tela_Usuario();
                tela_Usuario.Show();
                this.Hide();
            }
            else if (txb_codigo_funcionario_login.Text == "#123")
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
