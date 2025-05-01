namespace PROJETO__PIM3
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_user_login = new Label();
            lbl_senha_login = new Label();
            txb_user_name = new TextBox();
            txb_senha_Login = new TextBox();
            pictureBox1 = new PictureBox();
            btn_cadastrar_login = new Button();
            btn_login_login = new Button();
            pictureBox2 = new PictureBox();
            txb_codigo_funcionario_login = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_user_login
            // 
            lbl_user_login.AutoSize = true;
            lbl_user_login.Location = new Point(1082, 447);
            lbl_user_login.Name = "lbl_user_login";
            lbl_user_login.Size = new Size(125, 20);
            lbl_user_login.TabIndex = 0;
            lbl_user_login.Text = "Nome de Usuario";
            // 
            // lbl_senha_login
            // 
            lbl_senha_login.AutoSize = true;
            lbl_senha_login.Location = new Point(1082, 549);
            lbl_senha_login.Name = "lbl_senha_login";
            lbl_senha_login.Size = new Size(49, 20);
            lbl_senha_login.TabIndex = 1;
            lbl_senha_login.Text = "Senha";
            // 
            // txb_user_name
            // 
            txb_user_name.Location = new Point(1082, 484);
            txb_user_name.Name = "txb_user_name";
            txb_user_name.Size = new Size(262, 27);
            txb_user_name.TabIndex = 2;
            txb_user_name.TextChanged += txb_user_name_TextChanged;
            // 
            // txb_senha_Login
            // 
            txb_senha_Login.Location = new Point(1082, 583);
            txb_senha_Login.Name = "txb_senha_Login";
            txb_senha_Login.Size = new Size(262, 27);
            txb_senha_Login.TabIndex = 3;
            txb_senha_Login.TextChanged += txb_senha_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(1110, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_cadastrar_login
            // 
            btn_cadastrar_login.Location = new Point(1249, 673);
            btn_cadastrar_login.Name = "btn_cadastrar_login";
            btn_cadastrar_login.Size = new Size(119, 48);
            btn_cadastrar_login.TabIndex = 5;
            btn_cadastrar_login.Text = "Cadastrar";
            btn_cadastrar_login.UseVisualStyleBackColor = true;
            btn_cadastrar_login.Click += button1_Click;
            // 
            // btn_login_login
            // 
            btn_login_login.Location = new Point(1069, 673);
            btn_login_login.Name = "btn_login_login";
            btn_login_login.Size = new Size(119, 48);
            btn_login_login.TabIndex = 6;
            btn_login_login.Text = "login";
            btn_login_login.UseVisualStyleBackColor = true;
            btn_login_login.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.circle;
            pictureBox2.Location = new Point(-411, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1404, 1007);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // txb_codigo_funcionario_login
            // 
            txb_codigo_funcionario_login.Location = new Point(1082, 360);
            txb_codigo_funcionario_login.Name = "txb_codigo_funcionario_login";
            txb_codigo_funcionario_login.Size = new Size(180, 27);
            txb_codigo_funcionario_login.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1082, 325);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 8;
            label1.Text = "Codigo (para Funcinarios)";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 751);
            Controls.Add(txb_codigo_funcionario_login);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(btn_login_login);
            Controls.Add(btn_cadastrar_login);
            Controls.Add(pictureBox1);
            Controls.Add(txb_senha_Login);
            Controls.Add(txb_user_name);
            Controls.Add(lbl_senha_login);
            Controls.Add(lbl_user_login);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Minimized;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_user_login;
        private Label lbl_senha_login;
        private TextBox txb_user_name;
        private TextBox txb_senha;
        private PictureBox pictureBox1;
        private Button btn_cadastrar_login;
        private Button btn_login_login;
        private PictureBox pictureBox2;
        private TextBox txb_senha_Login;
        private TextBox txb_codigo_funcionario_login;
        private Label label1;
    }
}
