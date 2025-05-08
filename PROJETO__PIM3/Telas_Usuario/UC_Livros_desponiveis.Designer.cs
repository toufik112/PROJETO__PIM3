namespace PROJETO__PIM3.Telas_Usuario
{
    partial class UC_Livros_desponiveis
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_buscar_cu_biblioteca = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            IDLivro = new DataGridViewTextBoxColumn();
            TituloLivro = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Editora = new DataGridViewTextBoxColumn();
            AnoPublicacao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_buscar_cu_biblioteca
            // 
            btn_buscar_cu_biblioteca.BackColor = Color.DarkViolet;
            btn_buscar_cu_biblioteca.CustomizableEdges = customizableEdges13;
            btn_buscar_cu_biblioteca.DisabledState.BorderColor = Color.DarkGray;
            btn_buscar_cu_biblioteca.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_buscar_cu_biblioteca.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_buscar_cu_biblioteca.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_buscar_cu_biblioteca.Font = new Font("Segoe UI", 9F);
            btn_buscar_cu_biblioteca.ForeColor = Color.White;
            btn_buscar_cu_biblioteca.Location = new Point(908, 26);
            btn_buscar_cu_biblioteca.Name = "btn_buscar_cu_biblioteca";
            btn_buscar_cu_biblioteca.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btn_buscar_cu_biblioteca.Size = new Size(71, 31);
            btn_buscar_cu_biblioteca.TabIndex = 6;
            btn_buscar_cu_biblioteca.Text = "Buscar";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BackColor = SystemColors.ControlDark;
            guna2TextBox1.CustomizableEdges = customizableEdges15;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeft = Properties.Resources.serching;
            guna2TextBox1.Location = new Point(447, 25);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "Buscar por Livro ou Autor...";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2TextBox1.Size = new Size(440, 33);
            guna2TextBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDLivro, TituloLivro, Categoria, Autor, Editora, AnoPublicacao });
            dataGridView1.Location = new Point(3, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1359, 640);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 21);
            label1.Name = "label1";
            label1.Size = new Size(278, 41);
            label1.TabIndex = 8;
            label1.Text = "Livros Desponíveis";
            // 
            // IDLivro
            // 
            IDLivro.HeaderText = "ID Livro";
            IDLivro.MinimumWidth = 6;
            IDLivro.Name = "IDLivro";
            IDLivro.Width = 125;
            // 
            // TituloLivro
            // 
            TituloLivro.HeaderText = "Titulo de Livro";
            TituloLivro.MinimumWidth = 6;
            TituloLivro.Name = "TituloLivro";
            TituloLivro.Width = 260;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.Width = 200;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.Width = 300;
            // 
            // Editora
            // 
            Editora.HeaderText = "Editor";
            Editora.MinimumWidth = 6;
            Editora.Name = "Editora";
            Editora.Width = 300;
            // 
            // AnoPublicacao
            // 
            AnoPublicacao.HeaderText = "Ano de Publicação";
            AnoPublicacao.MinimumWidth = 6;
            AnoPublicacao.Name = "AnoPublicacao";
            AnoPublicacao.Width = 125;
            // 
            // UC_Livros_desponiveis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btn_buscar_cu_biblioteca);
            Controls.Add(guna2TextBox1);
            Name = "UC_Livros_desponiveis";
            Size = new Size(1365, 738);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_buscar_cu_biblioteca;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private FlowLayoutPanel Livro10;
        private PictureBox pictureBox10;
        private TextBox textBox10;
        private FlowLayoutPanel Livro9;
        private PictureBox pictureBox9;
        private TextBox textBox9;
        private FlowLayoutPanel Livro8;
        private PictureBox pictureBox8;
        private TextBox textBox8;
        private FlowLayoutPanel Livro7;
        private PictureBox pictureBox7;
        private TextBox textBox7;
        private FlowLayoutPanel Livro5;
        private PictureBox pictureBox5;
        private TextBox textBox5;
        private FlowLayoutPanel Livro4;
        private PictureBox pictureBox4;
        private TextBox textBox4;
        private FlowLayoutPanel Livro3;
        private PictureBox pictureBox3;
        private TextBox textBox3;
        private FlowLayoutPanel Livro2;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private FlowLayoutPanel Livro6;
        private PictureBox pictureBox6;
        private TextBox textBox6;
        private FlowLayoutPanel Livro1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn IDLivro;
        private DataGridViewTextBoxColumn TituloLivro;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Editora;
        private DataGridViewTextBoxColumn AnoPublicacao;
    }
}
