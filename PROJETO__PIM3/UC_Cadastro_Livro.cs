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
    public partial class UC_Cadastro_Livro : UserControl
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Ctegoria { get; set; }
        public string AnoPublicacao { get; set; }


        public UC_Cadastro_Livro()
        {
            InitializeComponent();
        }

        public void Cadastrar()
        {
            DialogResult resposta = MessageBox.Show("Quer cadastrar nove Livro?", "Cadastrar", MessageBoxButtons.YesNo);
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
        public void Cancelar()
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
                    else if (c is ComboBox)
                    {

                    }


                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Cancelar();

        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            {
                Cadastrar();
            }

        }

        private void UC_Cadastro_Livro_Load(object sender, EventArgs e)
        {

        }
    }
}
