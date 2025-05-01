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
    public partial class UC_Devolucao : UserControl
    {
        public UC_Devolucao()
        {
            InitializeComponent();
        }

        private void btn_verificar_devolucao_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Clinte esta no prazo?", "Verificação", MessageBoxButtons.OK);
            if (resposta == DialogResult.OK)
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

        private void btn_devoluir_devolucao_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Quer devoluir o livro!", "Devoluir", MessageBoxButtons.YesNo);
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
        private void btn_cancelar_devolucao_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Quer cancelar a devoluçao?", "Cncelar", MessageBoxButtons.YesNo);
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

        private void UC_Devolucao_Load(object sender, EventArgs e)
        {

        }
    }
}

