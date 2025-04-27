using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO__PIM3
{
    public partial class UC_Emprestimo : UserControl
    {
        public UC_Emprestimo()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Quer cancelar a operação", "Cancelar", MessageBoxButtons.YesNo);
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

        }

        private void btn_verificar_emprestimo_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Cliente sem Emprestimo atualmente", "Verificação", MessageBoxButtons.OK);


        }

        private void btn_emprestar__emprestimo_Click_1(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Quer emprestar o livro!", "Emprestar", MessageBoxButtons.YesNo);
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

        }
    }
}
