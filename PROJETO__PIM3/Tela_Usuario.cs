using PROJETO__PIM3.Telas_Usuario;

namespace PROJETO__PIM3
{
    public partial class Tela_Usuario : Form
    {
        public Tela_Usuario()
        {
            InitializeComponent();
        }

        private void Tela_Usuario_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_uc_biblioteca_Click(object sender, EventArgs e)
        {
            //pnl_tela_usuario.Controls.Clear();
            //UC_Biblioteca_Usuario uC_Biblioteca_Usuario = new UC_Biblioteca_Usuario();
            //Tela_Usuario tela_Usuario = new Tela_Usuario();
            //pnl_tela_usuario.Controls.Add(uC_Biblioteca_Usuario);

        }


        private void lbl_desconectar_Usuario_Click(object sender, EventArgs e)
        {


        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_biblioteca_usuario_Click(object sender, EventArgs e)
        {
            Tela_Usuario tela_Usuario = new Tela_Usuario();
            tela_Usuario.Show();
        }

        private void lbl_livros_brasileiros_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_Top_Brasileiros uC_Top_Brasileiros = new UC_Top_Brasileiros();
            panel2.Controls.Add(uC_Top_Brasileiros);


        }

        private void lbl_top10_usuario_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Top10_Livros_Usuario top10_Livros_Usuario = new Top10_Livros_Usuario();
            panel2.Controls.Add(top10_Livros_Usuario);
        }

        private void lbl_livros_desponiveis_usuario_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_Livros_desponiveis uC_Livros_desponiveis = new UC_Livros_desponiveis();
            panel2.Controls.Add(uC_Livros_desponiveis);
        }

        private void lbl_estoque_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
