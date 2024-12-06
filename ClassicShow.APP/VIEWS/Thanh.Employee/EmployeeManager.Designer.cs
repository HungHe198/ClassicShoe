namespace ClassicShow.APP.VIEWS
{
    partial class EmployeeManager
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_Ten = new TextBox();
            txt_acc = new TextBox();
            txt_pass = new TextBox();
            txt_soDienThoai = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_Email = new TextBox();
            txt_DiaChi = new TextBox();
            dtp_NgaySinh = new DateTimePicker();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_VoHieu = new Button();
            textBox7 = new TextBox();
            button5 = new Button();
            dgv_NhanVien = new DataGridView();
            label8 = new Label();
            label11 = new Label();
            cbo_CVNhanVien = new ComboBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_NhanVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 125);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 185);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 247);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 313);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 3;
            label4.Text = "Số Điện Thoại";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(153, 122);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(295, 27);
            txt_Ten.TabIndex = 4;
            // 
            // txt_acc
            // 
            txt_acc.Location = new Point(153, 178);
            txt_acc.Name = "txt_acc";
            txt_acc.Size = new Size(295, 27);
            txt_acc.TabIndex = 5;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(153, 247);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(295, 27);
            txt_pass.TabIndex = 6;
            // 
            // txt_soDienThoai
            // 
            txt_soDienThoai.Location = new Point(153, 310);
            txt_soDienThoai.Name = "txt_soDienThoai";
            txt_soDienThoai.Size = new Size(295, 27);
            txt_soDienThoai.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(858, 133);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(858, 185);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 9;
            label6.Text = "Ngày Sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(858, 250);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 10;
            label7.Text = "Địa Chỉ";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(974, 130);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(340, 27);
            txt_Email.TabIndex = 11;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(974, 244);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(340, 27);
            txt_DiaChi.TabIndex = 12;
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_NgaySinh.Location = new Point(974, 185);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(340, 27);
            dtp_NgaySinh.TabIndex = 13;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(26, 393);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(144, 40);
            btn_Them.TabIndex = 14;
            btn_Them.Text = "Thêm Nhân Viên";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(225, 392);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(149, 40);
            btn_Sua.TabIndex = 15;
            btn_Sua.Text = "Sửa Nhân Viên";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_VoHieu
            // 
            btn_VoHieu.Location = new Point(441, 393);
            btn_VoHieu.Name = "btn_VoHieu";
            btn_VoHieu.Size = new Size(156, 40);
            btn_VoHieu.TabIndex = 17;
            btn_VoHieu.Text = "Cho nghỉ việc";
            btn_VoHieu.UseVisualStyleBackColor = true;
            btn_VoHieu.Click += btn_VoHieu_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(865, 392);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(343, 40);
            textBox7.TabIndex = 18;
            // 
            // button5
            // 
            button5.Location = new Point(1227, 392);
            button5.Name = "button5";
            button5.Size = new Size(143, 41);
            button5.TabIndex = 19;
            button5.Text = "Tìm Kiếm";
            button5.UseVisualStyleBackColor = true;
            // 
            // dgv_NhanVien
            // 
            dgv_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NhanVien.Location = new Point(12, 492);
            dgv_NhanVien.Name = "dgv_NhanVien";
            dgv_NhanVien.RowHeadersWidth = 51;
            dgv_NhanVien.Size = new Size(1358, 349);
            dgv_NhanVien.TabIndex = 20;
            dgv_NhanVien.CellClick += dgv_NhanVien_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 469);
            label8.Name = "label8";
            label8.Size = new Size(151, 20);
            label8.TabIndex = 21;
            label8.Text = "Danh Sách Nhân Viên";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(476, 9);
            label11.Name = "label11";
            label11.Size = new Size(342, 46);
            label11.TabIndex = 29;
            label11.Text = "Quản lí nhân viên";
            // 
            // cbo_CVNhanVien
            // 
            cbo_CVNhanVien.FormattingEnabled = true;
            cbo_CVNhanVien.Location = new Point(974, 289);
            cbo_CVNhanVien.Name = "cbo_CVNhanVien";
            cbo_CVNhanVien.Size = new Size(340, 28);
            cbo_CVNhanVien.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(865, 292);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 31;
            label9.Text = "Chức vụ";
            // 
            // EmployeeManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(label9);
            Controls.Add(cbo_CVNhanVien);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(dgv_NhanVien);
            Controls.Add(button5);
            Controls.Add(textBox7);
            Controls.Add(btn_VoHieu);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(dtp_NgaySinh);
            Controls.Add(txt_DiaChi);
            Controls.Add(txt_Email);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_soDienThoai);
            Controls.Add(txt_pass);
            Controls.Add(txt_acc);
            Controls.Add(txt_Ten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeManager";
            Text = "EmployeeManager";
            Load += EmployeeManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_NhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_Ten;
        private TextBox txt_acc;
        private TextBox txt_pass;
        private TextBox txt_soDienThoai;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_Email;
        private TextBox txt_DiaChi;
        private DateTimePicker dtp_NgaySinh;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_VoHieu;
        private TextBox textBox7;
        private Button button5;
        private DataGridView dgv_NhanVien;
        private Label label8;
        private Label label11;
        private ComboBox cbo_CVNhanVien;
        private Label label9;
    }
}