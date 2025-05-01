using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO__PIM3.Properties
{
    public partial class Tela_Principal : Form
    {
        

        public Tela_Principal()
        {
            InitializeComponent();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            UC_Cadastro_Cliente uC_Cadastro_Cliente = new UC_Cadastro_Cliente();
            pnl_principal.Controls.Clear();
            pnl_principal.Controls.Add(uC_Cadastro_Cliente);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pnl_principal.Controls.Clear();
            UC_Biblioteca uC_Biblioteca = new UC_Biblioteca();
            Tela_Principal tela_Principal = new Tela_Principal();
            pnl_principal.Controls.Add(uC_Biblioteca);
        }

        public void pnl_principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {
           
        }

        private void lbl_cadasteo_livros_Click(object sender, EventArgs e)
        {
            pnl_principal.Controls.Clear();
            UC_Cadastro_Livro uC_Cadastro_Livro = new UC_Cadastro_Livro();
            Tela_Principal tela_Principal = new Tela_Principal();
            pnl_principal.Controls.Add(uC_Cadastro_Livro);
        }

        private void lbl_emprestimo_Click(object sender, EventArgs e)
        {
            pnl_principal.Controls.Clear();
            UC_Emprestimo uC_Emprestimo = new UC_Emprestimo();
            Tela_Principal tela_Principal = new Tela_Principal();
            pnl_principal.Controls.Add(uC_Emprestimo);
        }

        private void lbl_devolucao_Click(object sender, EventArgs e)
        {
            pnl_principal.Controls.Clear();
            UC_Devolucao uC_Devolucao = new UC_Devolucao();
            Tela_Principal tela_Principal = new Tela_Principal();
            pnl_principal.Controls.Add(uC_Devolucao);

        }

        private void lbl_estoque_Click(object sender, EventArgs e)
        {
            pnl_principal.Controls.Clear();
            UC_Estoque uC_Estoque = new UC_Estoque();
            Tela_Principal tela_Principal = new Tela_Principal();
            pnl_principal.Controls.Add(uC_Estoque);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
