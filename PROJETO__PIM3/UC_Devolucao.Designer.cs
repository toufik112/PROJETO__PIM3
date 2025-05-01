namespace PROJETO__PIM3
{
    partial class UC_Devolucao
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
            label4 = new Label();
            btn_cancelar_devolucao = new Button();
            btn_devoluir_devolucao = new Button();
            btn_verificar_devolucao = new Button();
            dtpik_data_devolucao_devolucao = new DateTimePicker();
            label7 = new Label();
            dtpik_data_emprestimo_devolucao = new DateTimePicker();
            label9 = new Label();
            txb_cpf_devolucao = new TextBox();
            label3 = new Label();
            txb_nome_cliente_devolucao = new TextBox();
            label2 = new Label();
            txb_codigo_funcionario = new TextBox();
            label1 = new Label();
            txb_estatu_devolucao = new TextBox();
            label5 = new Label();
            txb_isbn_devolucao = new TextBox();
            label6 = new Label();
            txb_titulo_livro_devolucao = new TextBox();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(168, 55);
            label4.Name = "label4";
            label4.Size = new Size(280, 41);
            label4.TabIndex = 66;
            label4.Text = "Devolução de livro";
            // 
            // btn_cancelar_devolucao
            // 
            btn_cancelar_devolucao.Location = new Point(1082, 555);
            btn_cancelar_devolucao.Name = "btn_cancelar_devolucao";
            btn_cancelar_devolucao.Size = new Size(154, 56);
            btn_cancelar_devolucao.TabIndex = 65;
            btn_cancelar_devolucao.Text = "Cancelar";
            btn_cancelar_devolucao.UseVisualStyleBackColor = true;
            btn_cancelar_devolucao.Click += btn_cancelar_devolucao_Click;
            // 
            // btn_devoluir_devolucao
            // 
            btn_devoluir_devolucao.Location = new Point(831, 555);
            btn_devoluir_devolucao.Name = "btn_devoluir_devolucao";
            btn_devoluir_devolucao.Size = new Size(154, 56);
            btn_devoluir_devolucao.TabIndex = 64;
            btn_devoluir_devolucao.Text = "Devoluir";
            btn_devoluir_devolucao.UseVisualStyleBackColor = true;
            btn_devoluir_devolucao.Click += btn_devoluir_devolucao_Click;
            // 
            // btn_verificar_devolucao
            // 
            btn_verificar_devolucao.Location = new Point(586, 555);
            btn_verificar_devolucao.Name = "btn_verificar_devolucao";
            btn_verificar_devolucao.Size = new Size(154, 56);
            btn_verificar_devolucao.TabIndex = 63;
            btn_verificar_devolucao.Text = "Verificar";
            btn_verificar_devolucao.UseVisualStyleBackColor = true;
            btn_verificar_devolucao.Click += btn_verificar_devolucao_Click;
            // 
            // dtpik_data_devolucao_devolucao
            // 
            dtpik_data_devolucao_devolucao.Location = new Point(766, 452);
            dtpik_data_devolucao_devolucao.Name = "dtpik_data_devolucao_devolucao";
            dtpik_data_devolucao_devolucao.Size = new Size(291, 27);
            dtpik_data_devolucao_devolucao.TabIndex = 62;
            dtpik_data_devolucao_devolucao.Value = new DateTime(2025, 4, 21, 17, 9, 19, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(766, 414);
            label7.Name = "label7";
            label7.Size = new Size(199, 20);
            label7.TabIndex = 61;
            label7.Text = "*Data prevista de Devolução";
            // 
            // dtpik_data_emprestimo_devolucao
            // 
            dtpik_data_emprestimo_devolucao.Location = new Point(168, 452);
            dtpik_data_emprestimo_devolucao.Name = "dtpik_data_emprestimo_devolucao";
            dtpik_data_emprestimo_devolucao.Size = new Size(301, 27);
            dtpik_data_emprestimo_devolucao.TabIndex = 60;
            dtpik_data_emprestimo_devolucao.Value = new DateTime(2025, 4, 21, 17, 9, 19, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(161, 414);
            label9.Name = "label9";
            label9.Size = new Size(152, 20);
            label9.TabIndex = 59;
            label9.Text = "*Data de Emprestimo";
            // 
            // txb_cpf_devolucao
            // 
            txb_cpf_devolucao.Location = new Point(967, 178);
            txb_cpf_devolucao.Name = "txb_cpf_devolucao";
            txb_cpf_devolucao.Size = new Size(258, 27);
            txb_cpf_devolucao.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(967, 142);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 57;
            label3.Text = "*CPF";
            // 
            // txb_nome_cliente_devolucao
            // 
            txb_nome_cliente_devolucao.Location = new Point(513, 178);
            txb_nome_cliente_devolucao.Name = "txb_nome_cliente_devolucao";
            txb_nome_cliente_devolucao.Size = new Size(258, 27);
            txb_nome_cliente_devolucao.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 142);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 55;
            label2.Text = "*Nome do Cliente";
            // 
            // txb_codigo_funcionario
            // 
            txb_codigo_funcionario.Location = new Point(68, 178);
            txb_codigo_funcionario.Name = "txb_codigo_funcionario";
            txb_codigo_funcionario.Size = new Size(258, 27);
            txb_codigo_funcionario.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 142);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 53;
            label1.Text = "*Codigo de Funcionario";
            // 
            // txb_estatu_devolucao
            // 
            txb_estatu_devolucao.Location = new Point(967, 307);
            txb_estatu_devolucao.Name = "txb_estatu_devolucao";
            txb_estatu_devolucao.Size = new Size(258, 27);
            txb_estatu_devolucao.TabIndex = 73;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(967, 271);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 72;
            label5.Text = "Estatu";
            // 
            // txb_isbn_devolucao
            // 
            txb_isbn_devolucao.Location = new Point(513, 307);
            txb_isbn_devolucao.Name = "txb_isbn_devolucao";
            txb_isbn_devolucao.Size = new Size(258, 27);
            txb_isbn_devolucao.TabIndex = 71;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(513, 271);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 70;
            label6.Text = "*ISBN";
            // 
            // txb_titulo_livro_devolucao
            // 
            txb_titulo_livro_devolucao.Location = new Point(68, 307);
            txb_titulo_livro_devolucao.Name = "txb_titulo_livro_devolucao";
            txb_titulo_livro_devolucao.Size = new Size(258, 27);
            txb_titulo_livro_devolucao.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 271);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 68;
            label8.Text = "*Titulo de livro";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.library;
            pictureBox4.Location = new Point(18, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(122, 86);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 74;
            pictureBox4.TabStop = false;
            // 
            // UC_Devolucao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox4);
            Controls.Add(txb_estatu_devolucao);
            Controls.Add(label5);
            Controls.Add(txb_isbn_devolucao);
            Controls.Add(label6);
            Controls.Add(txb_titulo_livro_devolucao);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(btn_cancelar_devolucao);
            Controls.Add(btn_devoluir_devolucao);
            Controls.Add(btn_verificar_devolucao);
            Controls.Add(dtpik_data_devolucao_devolucao);
            Controls.Add(label7);
            Controls.Add(dtpik_data_emprestimo_devolucao);
            Controls.Add(label9);
            Controls.Add(txb_cpf_devolucao);
            Controls.Add(label3);
            Controls.Add(txb_nome_cliente_devolucao);
            Controls.Add(label2);
            Controls.Add(txb_codigo_funcionario);
            Controls.Add(label1);
            Name = "UC_Devolucao";
            Size = new Size(1371, 661);
            Load += UC_Devolucao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private Button btn_cancelar_devolucao;
        private Button btn_devoluir_devolucao;
        private Button btn_verificar_devolucao;
        private DateTimePicker dtpik_data_devolucao_devolucao;
        private Label label7;
        private DateTimePicker dtpik_data_emprestimo_devolucao;
        private Label label9;
        private TextBox txb_cpf_devolucao;
        private Label label3;
        private TextBox txb_nome_cliente_devolucao;
        private Label label2;
        private TextBox txb_codigo_funcionario;
        private Label label1;
        private TextBox txb_estatu_devolucao;
        private Label label5;
        private TextBox txb_isbn_devolucao;
        private Label label6;
        private TextBox txb_titulo_livro_devolucao;
        private Label label8;
        private PictureBox pictureBox4;
    }
}
