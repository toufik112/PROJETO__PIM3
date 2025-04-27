using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using PROJETO__PIM3.Properties;

namespace PROJETO__PIM3
{
    public partial class UC_Cadastrar_Pessoa : Form
    {

        public string CodigoUsuario { get; set; }
        public string Nome { get; set; }
        public string DataNacimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Resultado { get; set; }



        public UC_Cadastrar_Pessoa(string codigoUsuario, string nome, string dataNacimento, string cpf, string email, string telefone, string endereco, string resultado)
        {
            InitializeComponent();

            CodigoUsuario = codigoUsuario;
            Nome = nome;
            DataNacimento = dataNacimento;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Resultado = resultado;
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro Realizado com sucesso!");
            Tela_Principal tela_Principal = new Tela_Principal();
            tela_Principal.Show();

            // this.Close();
            this.Hide();

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("O programa esta sendo fechado!");
            // this.Close();

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

        private void btn_voltar_cad_pess_Click(object sender, EventArgs e)
        {
           // Login login = new Login();
            //login.Show();
          // this.Hide();
        }
    }
}
