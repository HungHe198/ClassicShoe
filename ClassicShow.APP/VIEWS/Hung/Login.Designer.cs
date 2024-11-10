namespace ClassicShow.APP.VIEWS
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_TaiKhoan = new TextBox();
            txt_MatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            cbo_VaiTro = new ComboBox();
            SuspendLayout();
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.BackColor = SystemColors.Info;
            txt_TaiKhoan.Font = new Font("Segoe UI", 24F);
            txt_TaiKhoan.Location = new Point(446, 189);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(612, 61);
            txt_TaiKhoan.TabIndex = 0;
            txt_TaiKhoan.TextChanged += txt_TaiKhoan_TextChanged;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.BackColor = SystemColors.Info;
            txt_MatKhau.Font = new Font("Segoe UI", 24F);
            txt_MatKhau.Location = new Point(446, 274);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(612, 61);
            txt_MatKhau.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(202, 281);
            label1.Name = "label1";
            label1.Size = new Size(190, 54);
            label1.TabIndex = 1;
            label1.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(202, 196);
            label2.Name = "label2";
            label2.Size = new Size(190, 54);
            label2.TabIndex = 2;
            label2.Text = "Tài khoản";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientInactiveCaption;
            btnLogin.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(563, 493);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(276, 74);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(202, 362);
            label3.Name = "label3";
            label3.Size = new Size(137, 54);
            label3.TabIndex = 1;
            label3.Text = "Vai trò";
            // 
            // cbo_VaiTro
            // 
            cbo_VaiTro.BackColor = SystemColors.Info;
            cbo_VaiTro.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_VaiTro.FormattingEnabled = true;
            cbo_VaiTro.Location = new Point(446, 354);
            cbo_VaiTro.Name = "cbo_VaiTro";
            cbo_VaiTro.Size = new Size(612, 62);
            cbo_VaiTro.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = ClassicShoe.APP.Properties.Resources.logo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1382, 753);
            Controls.Add(cbo_VaiTro);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_TaiKhoan);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_TaiKhoan;
        private TextBox txt_MatKhau;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Label label3;
        private ComboBox cbo_VaiTro;
    }
}