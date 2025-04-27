namespace PROJETO__PIM3
{
    partial class UC_Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Estoque));
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            IdLivro = new DataGridViewTextBoxColumn();
            TituloDeLIvro = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Editora = new DataGridViewTextBoxColumn();
            AnoDePublicacao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdLivro, TituloDeLIvro, Categoria, Autor, Editora, AnoDePublicacao });
            dataGridView1.Location = new Point(0, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1371, 512);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(167, 56);
            label4.Name = "label4";
            label4.Size = new Size(130, 41);
            label4.TabIndex = 53;
            label4.Text = "Estoque";
            // 
            // IdLivro
            // 
            IdLivro.DataPropertyName = "IdLivro";
            IdLivro.DividerWidth = 5;
            IdLivro.HeaderText = "ID LIvro";
            IdLivro.MinimumWidth = 6;
            IdLivro.Name = "IdLivro";
            IdLivro.ReadOnly = true;
            IdLivro.Width = 75;
            // 
            // TituloDeLIvro
            // 
            TituloDeLIvro.HeaderText = "Titulo de Livro";
            TituloDeLIvro.MinimumWidth = 6;
            TituloDeLIvro.Name = "TituloDeLIvro";
            TituloDeLIvro.Width = 318;
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
            Editora.HeaderText = "Editora";
            Editora.MinimumWidth = 6;
            Editora.Name = "Editora";
            Editora.Width = 300;
            // 
            // AnoDePublicacao
            // 
            AnoDePublicacao.HeaderText = "Ano de Publicaçao";
            AnoDePublicacao.MinimumWidth = 6;
            AnoDePublicacao.Name = "AnoDePublicacao";
            AnoDePublicacao.Width = 125;
            // 
            // UC_Estoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Name = "UC_Estoque";
            Size = new Size(1371, 661);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdLivro;
        private DataGridViewTextBoxColumn TituloDeLIvro;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Editora;
        private DataGridViewTextBoxColumn AnoDePublicacao;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
