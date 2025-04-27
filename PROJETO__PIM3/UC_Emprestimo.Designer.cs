namespace PROJETO__PIM3
{
    partial class UC_Emprestimo
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
            txb_cpf__emprestimo = new TextBox();
            label3 = new Label();
            txb_nome_cliente_emprestimo = new TextBox();
            label2 = new Label();
            txb_codigo_funcionario_emprestimo = new TextBox();
            label1 = new Label();
            dtpik_data_emprestimo_emprestimo = new DateTimePicker();
            label9 = new Label();
            dtpik_data_devolucao_emprestimo = new DateTimePicker();
            label7 = new Label();
            btn_emprestar__emprestimo = new Button();
            btn_verificar_emprestimo = new Button();
            btn_cancelar__emprestimo = new Button();
            label4 = new Label();
            txb_isbn_emprestimo = new TextBox();
            label6 = new Label();
            txb_titulo_livro_emprestimo = new TextBox();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txb_cpf__emprestimo
            // 
            txb_cpf__emprestimo.Location = new Point(977, 185);
            txb_cpf__emprestimo.Name = "txb_cpf__emprestimo";
            txb_cpf__emprestimo.Size = new Size(258, 27);
            txb_cpf__emprestimo.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(977, 149);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 36;
            label3.Text = "*CPF";
            // 
            // txb_nome_cliente_emprestimo
            // 
            txb_nome_cliente_emprestimo.Location = new Point(523, 185);
            txb_nome_cliente_emprestimo.Name = "txb_nome_cliente_emprestimo";
            txb_nome_cliente_emprestimo.Size = new Size(258, 27);
            txb_nome_cliente_emprestimo.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 149);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 34;
            label2.Text = "*Nome do Cliente";
            // 
            // txb_codigo_funcionario_emprestimo
            // 
            txb_codigo_funcionario_emprestimo.Location = new Point(78, 185);
            txb_codigo_funcionario_emprestimo.Name = "txb_codigo_funcionario_emprestimo";
            txb_codigo_funcionario_emprestimo.Size = new Size(258, 27);
            txb_codigo_funcionario_emprestimo.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 149);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 32;
            label1.Text = "*Codigo de Funcionario";
            // 
            // dtpik_data_emprestimo_emprestimo
            // 
            dtpik_data_emprestimo_emprestimo.Location = new Point(167, 450);
            dtpik_data_emprestimo_emprestimo.Name = "dtpik_data_emprestimo_emprestimo";
            dtpik_data_emprestimo_emprestimo.Size = new Size(301, 27);
            dtpik_data_emprestimo_emprestimo.TabIndex = 45;
            dtpik_data_emprestimo_emprestimo.Value = new DateTime(2025, 4, 21, 17, 9, 19, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(160, 412);
            label9.Name = "label9";
            label9.Size = new Size(152, 20);
            label9.TabIndex = 44;
            label9.Text = "*Data de Emprestimo";
            // 
            // dtpik_data_devolucao_emprestimo
            // 
            dtpik_data_devolucao_emprestimo.Location = new Point(765, 450);
            dtpik_data_devolucao_emprestimo.Name = "dtpik_data_devolucao_emprestimo";
            dtpik_data_devolucao_emprestimo.Size = new Size(291, 27);
            dtpik_data_devolucao_emprestimo.TabIndex = 47;
            dtpik_data_devolucao_emprestimo.Value = new DateTime(2025, 4, 21, 17, 9, 19, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(765, 412);
            label7.Name = "label7";
            label7.Size = new Size(199, 20);
            label7.TabIndex = 46;
            label7.Text = "*Data prevista de DEvolução";
            // 
            // btn_emprestar__emprestimo
            // 
            btn_emprestar__emprestimo.Location = new Point(830, 555);
            btn_emprestar__emprestimo.Name = "btn_emprestar__emprestimo";
            btn_emprestar__emprestimo.Size = new Size(154, 56);
            btn_emprestar__emprestimo.TabIndex = 49;
            btn_emprestar__emprestimo.Text = "Emprestar";
            btn_emprestar__emprestimo.UseVisualStyleBackColor = true;
            btn_emprestar__emprestimo.Click += btn_emprestar__emprestimo_Click_1;
            // 
            // btn_verificar_emprestimo
            // 
            btn_verificar_emprestimo.Location = new Point(585, 555);
            btn_verificar_emprestimo.Name = "btn_verificar_emprestimo";
            btn_verificar_emprestimo.Size = new Size(154, 56);
            btn_verificar_emprestimo.TabIndex = 48;
            btn_verificar_emprestimo.Text = "Verificar";
            btn_verificar_emprestimo.UseVisualStyleBackColor = true;
            btn_verificar_emprestimo.Click += btn_verificar_emprestimo_Click;
            // 
            // btn_cancelar__emprestimo
            // 
            btn_cancelar__emprestimo.Location = new Point(1081, 555);
            btn_cancelar__emprestimo.Name = "btn_cancelar__emprestimo";
            btn_cancelar__emprestimo.Size = new Size(154, 56);
            btn_cancelar__emprestimo.TabIndex = 50;
            btn_cancelar__emprestimo.Text = "Cancelar";
            btn_cancelar__emprestimo.UseVisualStyleBackColor = true;
            btn_cancelar__emprestimo.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(167, 55);
            label4.Name = "label4";
            label4.Size = new Size(264, 41);
            label4.TabIndex = 51;
            label4.Text = "Livro Emprestado";
            // 
            // txb_isbn_emprestimo
            // 
            txb_isbn_emprestimo.Location = new Point(741, 324);
            txb_isbn_emprestimo.Name = "txb_isbn_emprestimo";
            txb_isbn_emprestimo.Size = new Size(258, 27);
            txb_isbn_emprestimo.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(741, 288);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 55;
            label6.Text = "*ISBN";
            // 
            // txb_titulo_livro_emprestimo
            // 
            txb_titulo_livro_emprestimo.Location = new Point(296, 324);
            txb_titulo_livro_emprestimo.Name = "txb_titulo_livro_emprestimo";
            txb_titulo_livro_emprestimo.Size = new Size(258, 27);
            txb_titulo_livro_emprestimo.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(296, 288);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 53;
            label8.Text = "*Titulo de livro";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.library;
            pictureBox4.Location = new Point(16, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(118, 86);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 57;
            pictureBox4.TabStop = false;
            // 
            // UC_Emprestimo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox4);
            Controls.Add(txb_isbn_emprestimo);
            Controls.Add(label6);
            Controls.Add(txb_titulo_livro_emprestimo);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(btn_cancelar__emprestimo);
            Controls.Add(btn_emprestar__emprestimo);
            Controls.Add(btn_verificar_emprestimo);
            Controls.Add(dtpik_data_devolucao_emprestimo);
            Controls.Add(label7);
            Controls.Add(dtpik_data_emprestimo_emprestimo);
            Controls.Add(label9);
            Controls.Add(txb_cpf__emprestimo);
            Controls.Add(label3);
            Controls.Add(txb_nome_cliente_emprestimo);
            Controls.Add(label2);
            Controls.Add(txb_codigo_funcionario_emprestimo);
            Controls.Add(label1);
            Name = "UC_Emprestimo";
            Size = new Size(1371, 661);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txb_cpf__emprestimo;
        private Label label3;
        private TextBox txb_nome_cliente_emprestimo;
        private Label label2;
        private TextBox txb_codigo_funcionario_emprestimo;
        private Label label1;
        private DateTimePicker dtpik_data_emprestimo_emprestimo;
        private Label label9;
        private DateTimePicker dtpik_data_devolucao_emprestimo;
        private Label label7;
        private Button btn_emprestar__emprestimo;
        private Button btn_verificar_emprestimo;
        private Button btn_cancelar__emprestimo;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox txb_isbn_emprestimo;
        private Label label6;
        private TextBox txb_titulo_livro_emprestimo;
        private Label label8;
        private ListBox lsbx_estatu_emprestimo;
        private PictureBox pictureBox4;
    }
}
