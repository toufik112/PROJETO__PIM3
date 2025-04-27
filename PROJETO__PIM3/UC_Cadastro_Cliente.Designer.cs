namespace PROJETO__PIM3
{
    partial class UC_Cadastro_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Cadastro_Cliente));
            btn_cancelar = new Button();
            btn_cadastrar = new Button();
            datpik_data_cadastro = new DateTimePicker();
            label9 = new Label();
            txb_telefone = new TextBox();
            label8 = new Label();
            txb_endereco = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txb_cpf = new TextBox();
            label4 = new Label();
            txb_rg = new TextBox();
            label3 = new Label();
            txb_nome_cliente = new TextBox();
            label2 = new Label();
            txb_codigo_funcionario = new TextBox();
            label1 = new Label();
            txb_email = new TextBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(987, 554);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(154, 56);
            btn_cancelar.TabIndex = 39;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(742, 554);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(154, 56);
            btn_cadastrar.TabIndex = 38;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // datpik_data_cadastro
            // 
            datpik_data_cadastro.Location = new Point(173, 554);
            datpik_data_cadastro.Name = "datpik_data_cadastro";
            datpik_data_cadastro.Size = new Size(241, 27);
            datpik_data_cadastro.TabIndex = 37;
            datpik_data_cadastro.Value = new DateTime(2025, 4, 21, 17, 9, 19, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(166, 516);
            label9.Name = "label9";
            label9.Size = new Size(131, 20);
            label9.TabIndex = 36;
            label9.Text = "*Data de Cadastro";
            // 
            // txb_telefone
            // 
            txb_telefone.Location = new Point(716, 449);
            txb_telefone.Name = "txb_telefone";
            txb_telefone.Size = new Size(275, 27);
            txb_telefone.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(716, 413);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 34;
            label8.Text = "Telefone";
            // 
            // txb_endereco
            // 
            txb_endereco.Location = new Point(77, 449);
            txb_endereco.Name = "txb_endereco";
            txb_endereco.Size = new Size(415, 27);
            txb_endereco.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 413);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 32;
            label7.Text = "Endereço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(965, 295);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(41, 20);
            label6.TabIndex = 30;
            label6.Text = "Sexo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(589, 295);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 29;
            label5.Text = "Email";
            // 
            // txb_cpf
            // 
            txb_cpf.Location = new Point(128, 331);
            txb_cpf.Name = "txb_cpf";
            txb_cpf.Size = new Size(302, 27);
            txb_cpf.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 296);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 27;
            label4.Text = "*CPF/CNPJ";
            // 
            // txb_rg
            // 
            txb_rg.Location = new Point(976, 203);
            txb_rg.Name = "txb_rg";
            txb_rg.Size = new Size(258, 27);
            txb_rg.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(976, 167);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 25;
            label3.Text = "*RG/RNE";
            // 
            // txb_nome_cliente
            // 
            txb_nome_cliente.Location = new Point(522, 203);
            txb_nome_cliente.Name = "txb_nome_cliente";
            txb_nome_cliente.Size = new Size(258, 27);
            txb_nome_cliente.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 167);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 23;
            label2.Text = "*Nome do Cliente";
            // 
            // txb_codigo_funcionario
            // 
            txb_codigo_funcionario.Location = new Point(77, 203);
            txb_codigo_funcionario.Name = "txb_codigo_funcionario";
            txb_codigo_funcionario.Size = new Size(258, 27);
            txb_codigo_funcionario.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 167);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 21;
            label1.Text = "*Codigo de Funcionario";
            // 
            // txb_email
            // 
            txb_email.Location = new Point(589, 328);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(302, 27);
            txb_email.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 71;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.Location = new Point(168, 53);
            label10.Name = "label10";
            label10.Size = new Size(293, 41);
            label10.TabIndex = 70;
            label10.Text = "Cadastro de Cliente";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Feminino" });
            comboBox1.Location = new Point(976, 330);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 28);
            comboBox1.TabIndex = 72;
            // 
            // UC_Cadastro_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(txb_email);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_cadastrar);
            Controls.Add(datpik_data_cadastro);
            Controls.Add(label9);
            Controls.Add(txb_telefone);
            Controls.Add(label8);
            Controls.Add(txb_endereco);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txb_cpf);
            Controls.Add(label4);
            Controls.Add(txb_rg);
            Controls.Add(label3);
            Controls.Add(txb_nome_cliente);
            Controls.Add(label2);
            Controls.Add(txb_codigo_funcionario);
            Controls.Add(label1);
            Name = "UC_Cadastro_Cliente";
            Size = new Size(1371, 661);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_cancelar;
        private Button btn_cadastrar;
        private DateTimePicker datpik_data_cadastro;
        private Label label9;
        private TextBox txb_telefone;
        private Label label8;
        private TextBox txb_endereco;
        private Label label7;
        private ListBox lsbx_sexo;
        private Label label6;
        private Label label5;
        private TextBox txb_cpf;
        private Label label4;
        private TextBox txb_rg;
        private Label label3;
        private TextBox txb_nome_cliente;
        private Label label2;
        private TextBox txb_codigo_funcionario;
        private Label label1;
        private TextBox txb_email;
        private PictureBox pictureBox1;
        private Label label10;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}
