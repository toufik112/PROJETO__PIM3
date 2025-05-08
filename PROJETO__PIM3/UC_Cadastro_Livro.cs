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
        public string Categoria { get; set; }
        public string AnoPublicacao { get; set; }

        private List<UC_Cadastro_Livro> listaLivros = new List<UC_Cadastro_Livro>();

        public event Action<UC_Cadastro_Livro> LivroCadastrado;

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

            if ((string.IsNullOrWhiteSpace(txb_titulo_livro.Text) ||
                   (string.IsNullOrWhiteSpace(txb_nome_autor.Text) ||
                   (string.IsNullOrWhiteSpace(cmbx_categoria_cadastrar_livros.Text) ||
                   (string.IsNullOrWhiteSpace(dtpik_dart_cadastro.Text))
                   
            {
                MessageBox.Show("Prenche todos os campos.");
                return;

            }


            UC_Cadastro_Livro novo_livro = new UC_Cadastro_Livro
            {
                Titulo = txb_titulo_livro.Text,
                Autor = txb_nome_autor.Text,
                Categoria = cmbx_categoria_cadastrar_livros.Text,
                AnoPublicacao = dtpik_dart_cadastro.Value.Year.ToString(),
            };
            LivroCadastrado?.Invoke(novo_livro);

            listaLivros.Add(novo_livro);

            MessageBox.Show("Livro cadastrado com sucesso!");

            AtualizarDataGridView();
            LimparCampos();
        }
        
        private void AtualizarDataGridView()
        {
            // Adicione aqui seu controle de DataGridView, por exemplo:
          //  dtgr_estoque.DataSource = null;
           // dtgr_estoque.DataSource = listaLivros;
        }

        private void LimparCampos()
        {
            txb_titulo_livro.Clear();
            txb_nome_autor.Clear();
            cmbx_categoria_cadastrar_livros.SelectedIndex = -1;
            dtpik_dart_cadastro.Value = DateTime.Today;
        }

        private void UC_Cadastro_Livro_Load(object sender, EventArgs e)
        {

        }
    }
}
