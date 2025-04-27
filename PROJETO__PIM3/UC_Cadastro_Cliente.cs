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
    public partial class UC_Cadastro_Cliente : UserControl
    {
        public UC_Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Quer cadastrar nove cliente?", "Cadastrar", MessageBoxButtons.YesNo);
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Quer mesmo cancelar", "Cancelar", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
              
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                    if (c is ComboBox)
                    {
                        
                        
                    }
                    


                }

            }
           
        }
    }
}
