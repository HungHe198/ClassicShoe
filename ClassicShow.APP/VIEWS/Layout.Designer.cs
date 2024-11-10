namespace ClassicShoe.APP.VIEWS
{
    partial class Layout
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
            pn_mainRender = new Panel();
            ptb_Logo = new PictureBox();
            btn_QLSanPham = new Button();
            btn_QLNhanVien = new Button();
            btn_QLHoaDon = new Button();
            btn_QLKhachHang = new Button();
            btn_DangXuat = new Button();
            btn_QLGiamGia = new Button();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).BeginInit();
            SuspendLayout();
            // 
            // pn_mainRender
            // 
            pn_mainRender.Location = new Point(370, 12);
            pn_mainRender.Name = "pn_mainRender";
            pn_mainRender.Size = new Size(1400, 900);
            pn_mainRender.TabIndex = 0;
            // 
            // ptb_Logo
            // 
            ptb_Logo.BackgroundImage = Properties.Resources.logo;
            ptb_Logo.BackgroundImageLayout = ImageLayout.Stretch;
            ptb_Logo.Location = new Point(12, 12);
            ptb_Logo.Name = "ptb_Logo";
            ptb_Logo.Size = new Size(328, 133);
            ptb_Logo.TabIndex = 1;
            ptb_Logo.TabStop = false;
            // 
            // btn_QLSanPham
            // 
            btn_QLSanPham.Font = new Font("Arial", 12F);
            btn_QLSanPham.Location = new Point(12, 179);
            btn_QLSanPham.Name = "btn_QLSanPham";
            btn_QLSanPham.Size = new Size(328, 51);
            btn_QLSanPham.TabIndex = 2;
            btn_QLSanPham.Text = "Quản lí sản phẩm";
            btn_QLSanPham.UseVisualStyleBackColor = true;
            btn_QLSanPham.Click += btn_QLSanPham_Click;
            // 
            // btn_QLNhanVien
            // 
            btn_QLNhanVien.Font = new Font("Arial", 12F);
            btn_QLNhanVien.Location = new Point(12, 236);
            btn_QLNhanVien.Name = "btn_QLNhanVien";
            btn_QLNhanVien.Size = new Size(328, 51);
            btn_QLNhanVien.TabIndex = 2;
            btn_QLNhanVien.Text = "Quản lí nhân viên";
            btn_QLNhanVien.UseVisualStyleBackColor = true;
            btn_QLNhanVien.Click += btn_QLNhanVien_Click;
            // 
            // btn_QLHoaDon
            // 
            btn_QLHoaDon.Font = new Font("Arial", 12F);
            btn_QLHoaDon.Location = new Point(12, 293);
            btn_QLHoaDon.Name = "btn_QLHoaDon";
            btn_QLHoaDon.Size = new Size(328, 51);
            btn_QLHoaDon.TabIndex = 2;
            btn_QLHoaDon.Text = "Quản lí hóa đơn";
            btn_QLHoaDon.UseVisualStyleBackColor = true;
            btn_QLHoaDon.Click += btn_QLHoaDon_Click;
            // 
            // btn_QLKhachHang
            // 
            btn_QLKhachHang.Font = new Font("Arial", 12F);
            btn_QLKhachHang.Location = new Point(12, 350);
            btn_QLKhachHang.Name = "btn_QLKhachHang";
            btn_QLKhachHang.Size = new Size(328, 51);
            btn_QLKhachHang.TabIndex = 2;
            btn_QLKhachHang.Text = "Quản lí khách hàng";
            btn_QLKhachHang.UseVisualStyleBackColor = true;
            btn_QLKhachHang.Click += btn_QLKhachHang_Click;
            // 
            // btn_DangXuat
            // 
            btn_DangXuat.BackColor = Color.Red;
            btn_DangXuat.Font = new Font("Arial", 12F);
            btn_DangXuat.ForeColor = SystemColors.ButtonHighlight;
            btn_DangXuat.Location = new Point(12, 890);
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.Size = new Size(328, 51);
            btn_DangXuat.TabIndex = 2;
            btn_DangXuat.Text = "Đăng xuất";
            btn_DangXuat.UseVisualStyleBackColor = false;
            btn_DangXuat.Click += btn_DangXuat_Click;
            // 
            // btn_QLGiamGia
            // 
            btn_QLGiamGia.Font = new Font("Arial", 12F);
            btn_QLGiamGia.Location = new Point(12, 407);
            btn_QLGiamGia.Name = "btn_QLGiamGia";
            btn_QLGiamGia.Size = new Size(328, 51);
            btn_QLGiamGia.TabIndex = 2;
            btn_QLGiamGia.Text = "Quản lí giảm giá";
            btn_QLGiamGia.UseVisualStyleBackColor = true;
            btn_QLGiamGia.Click += btn_QLGiamGia_Click;
            // 
            // Layout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 953);
            Controls.Add(btn_DangXuat);
            Controls.Add(btn_QLGiamGia);
            Controls.Add(btn_QLKhachHang);
            Controls.Add(btn_QLHoaDon);
            Controls.Add(btn_QLNhanVien);
            Controls.Add(btn_QLSanPham);
            Controls.Add(ptb_Logo);
            Controls.Add(pn_mainRender);
            Name = "Layout";
            Text = "Layout";
            Load += Layout_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_mainRender;
        private PictureBox ptb_Logo;
        private Button btn_QLSanPham;
        private Button btn_QLNhanVien;
        private Button btn_QLHoaDon;
        private Button btn_QLKhachHang;
        private Button btn_DangXuat;
        private Button btn_QLGiamGia;
    }
}