using PROJETO__PIM3.Properties;

namespace PROJETO__PIM3
{
    public partial class Login : Form
    {

        public string NomeUsuario { get; set; }
        public string Senha { get; set; }




        public Login(string nomeUsuario, string senha)
        {
            InitializeComponent();

            NomeUsuario = nomeUsuario;
            Senha = senha;

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            UC_Cadastrar_Pessoa cadastrar_Pessoa = new UC_Cadastrar_Pessoa();
            cadastrar_Pessoa.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            Tela_Principal tela_Principal = new Tela_Principal();
            tela_Principal.Show(); 
            this.Hide();
            //this.Close();
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








            //Tela_Principal tela_Principal = new Tela_Principal();
            //tela_Principal.TopLevel = false;
            // tela_Principal.FormBorderStyle = FormBorderStyle.None;
            // tela_Principal.Dock = DockStyle.Fill;
            // tela_Principal.ShowDialog();
            // pnl_principal.Control.Add(UC_Biblioteca);
            // UC_Biblioteca.Show();
            // UC_biblioteca.ShowDialog();

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txb_user_name_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void txb_senha_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
