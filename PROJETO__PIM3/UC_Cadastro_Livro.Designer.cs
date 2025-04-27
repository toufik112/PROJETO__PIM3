namespace PROJETO__PIM3
{
    partial class UC_Cadastro_Livro
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
            label1 = new Label();
            txb_codigo_funcionario = new TextBox();
            txb_titulo_livro = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txb_nome_autor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lsbx_ano_publicacao = new ListBox();
            txb_editora = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dtpik_dart_cadastro = new DateTimePicker();
            btn_cadastrar = new Button();
            btn_cancelar = new Button();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            cmbx_prateleira_cadastrar_livros = new ComboBox();
            cmbx_categoria_cadastrar_livros = new ComboBox();
            comboBox3cmbx_localizacao_cadastrar_livro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 162);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 0;
            label1.Text = "*Codigo de Funcionario";
            // 
            // txb_codigo_funcionario
            // 
            txb_codigo_funcionario.Location = new Point(89, 198);
            txb_codigo_funcionario.Name = "txb_codigo_funcionario";
            txb_codigo_funcionario.Size = new Size(258, 27);
            txb_codigo_funcionario.TabIndex = 1;
            // 
            // txb_titulo_livro
            // 
            txb_titulo_livro.Location = new Point(534, 198);
            txb_titulo_livro.Name = "txb_titulo_livro";
            txb_titulo_livro.Size = new Size(258, 27);
            txb_titulo_livro.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(534, 162);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "*Titulo do Livro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(988, 162);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "*Prateleira";
            // 
            // txb_nome_autor
            // 
            txb_nome_autor.Location = new Point(95, 329);
            txb_nome_autor.Name = "txb_nome_autor";
            txb_nome_autor.Size = new Size(302, 27);
            txb_nome_autor.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 294);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 6;
            label4.Text = "Nome de Autor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(550, 296);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 8;
            label5.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(926, 296);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 10;
            label6.Text = "Ano de Publicação";
            // 
            // lsbx_ano_publicacao
            // 
            lsbx_ano_publicacao.FormattingEnabled = true;
            lsbx_ano_publicacao.Items.AddRange(new object[] { "", "Masculino", "Feminino" });
            lsbx_ano_publicacao.Location = new Point(926, 332);
            lsbx_ano_publicacao.Name = "lsbx_ano_publicacao";
            lsbx_ano_publicacao.Size = new Size(164, 24);
            lsbx_ano_publicacao.TabIndex = 11;
            // 
            // txb_editora
            // 
            txb_editora.Location = new Point(104, 452);
            txb_editora.Name = "txb_editora";
            txb_editora.Size = new Size(415, 27);
            txb_editora.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 416);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 12;
            label7.Text = "Editora";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(743, 416);
            label8.Name = "label8";
            label8.Size = new Size(150, 20);
            label8.TabIndex = 14;
            label8.Text = "Localização(Estoque)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(178, 519);
            label9.Name = "label9";
            label9.Size = new Size(131, 20);
            label9.TabIndex = 16;
            label9.Text = "*Data de Cadastro";
            // 
            // dtpik_dart_cadastro
            // 
            dtpik_dart_cadastro.Location = new Point(185, 557);
            dtpik_dart_cadastro.Name = "dtpik_dart_cadastro";
            dtpik_dart_cadastro.Size = new Size(241, 27);
            dtpik_dart_cadastro.TabIndex = 17;
            dtpik_dart_cadastro.Value = new DateTime(2025, 4, 21, 17, 9, 19, 0);
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(754, 557);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(154, 56);
            btn_cadastrar.TabIndex = 18;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(999, 557);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(154, 56);
            btn_cancelar.TabIndex = 19;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.books_stack_of_three;
            pictureBox1.Location = new Point(17, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.Location = new Point(168, 55);
            label10.Name = "label10";
            label10.Size = new Size(258, 41);
            label10.TabIndex = 68;
            label10.Text = "Cadastro de livro";
            // 
            // cmbx_prateleira_cadastrar_livros
            // 
            cmbx_prateleira_cadastrar_livros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbx_prateleira_cadastrar_livros.FormattingEnabled = true;
            cmbx_prateleira_cadastrar_livros.Items.AddRange(new object[] { "Prateleira01", "Prateleira02", "Prateleira03", "Prateleira04", "Prateleira05", "Prateleira06", "Prateleira07", "Prateleira08", "Prateleira09" });
            cmbx_prateleira_cadastrar_livros.Location = new Point(988, 197);
            cmbx_prateleira_cadastrar_livros.Name = "cmbx_prateleira_cadastrar_livros";
            cmbx_prateleira_cadastrar_livros.Size = new Size(146, 28);
            cmbx_prateleira_cadastrar_livros.TabIndex = 73;
            // 
            // cmbx_categoria_cadastrar_livros
            // 
            cmbx_categoria_cadastrar_livros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbx_categoria_cadastrar_livros.FormattingEnabled = true;
            cmbx_categoria_cadastrar_livros.Items.AddRange(new object[] { "Categoria01", "Categoria02", "Categoria03", "Categoria04", "Categoria05", "Categoria06", "Categoria07", "Categoria08", "Categoria09" });
            cmbx_categoria_cadastrar_livros.Location = new Point(550, 332);
            cmbx_categoria_cadastrar_livros.Name = "cmbx_categoria_cadastrar_livros";
            cmbx_categoria_cadastrar_livros.Size = new Size(146, 28);
            cmbx_categoria_cadastrar_livros.TabIndex = 74;
            // 
            // comboBox3cmbx_localizacao_cadastrar_livro
            // 
            comboBox3cmbx_localizacao_cadastrar_livro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3cmbx_localizacao_cadastrar_livro.FormattingEnabled = true;
            comboBox3cmbx_localizacao_cadastrar_livro.Items.AddRange(new object[] { "Zona01", "Zona02", "Zona03", "Zona04", "Zona05", "Zona06", "Zona07", "Zona08", "Zona09" });
            comboBox3cmbx_localizacao_cadastrar_livro.Location = new Point(743, 451);
            comboBox3cmbx_localizacao_cadastrar_livro.Name = "comboBox3cmbx_localizacao_cadastrar_livro";
            comboBox3cmbx_localizacao_cadastrar_livro.Size = new Size(146, 28);
            comboBox3cmbx_localizacao_cadastrar_livro.TabIndex = 75;
            // 
            // UC_Cadastro_Livro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox3cmbx_localizacao_cadastrar_livro);
            Controls.Add(cmbx_categoria_cadastrar_livros);
            Controls.Add(cmbx_prateleira_cadastrar_livros);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_cadastrar);
            Controls.Add(dtpik_dart_cadastro);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txb_editora);
            Controls.Add(label7);
            Controls.Add(lsbx_ano_publicacao);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txb_nome_autor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txb_titulo_livro);
            Controls.Add(label2);
            Controls.Add(txb_codigo_funcionario);
            Controls.Add(label1);
            Name = "UC_Cadastro_Livro";
            Size = new Size(1371, 661);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txb_codigo_funcionario;
        private TextBox txb_titulo_livro;
        private Label label2;
        private Label label3;
        private TextBox txb_nome_autor;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox lsbx_ano_publicacao;
        private TextBox txb_editora;
        private Label label7;
        private TextBox txb_localizacao;
        private Label label8;
        private Label label9;
        private DateTimePicker dtpik_dart_cadastro;
        private Button btn_cadastrar;
        private Button btn_cancelar;
        private ListBox lsbx_prateleira;
        private ListBox lsbx_categoria;
        private PictureBox pictureBox1;
        private Label label10;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox cmbx_prateleira_cadastrar_livros;
        private ComboBox cmbx_categoria_cadastrar_livros;
        private ComboBox comboBox3cmbx_localizacao_cadastrar_livro;
    }
}
