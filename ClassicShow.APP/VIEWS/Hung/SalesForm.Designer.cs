namespace ClassicShoe.APP.VIEWS.Hung
{
    partial class SalesForm
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
            groupBox1 = new GroupBox();
            lb_ID = new Label();
            btn_addOrder = new Button();
            txt_NameCustomer = new TextBox();
            label2 = new Label();
            txt_PhoneNumber = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgv_HDCT = new DataGridView();
            cbo_HoaDon = new ComboBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            txt_SLMua = new TextBox();
            txt_TKSanPham = new TextBox();
            dgv_SanPham = new DataGridView();
            label4 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            groupBox4 = new GroupBox();
            lb_traKhach = new Label();
            lb_TienDuocGiam = new Label();
            lb_ThanhTien = new Label();
            label11 = new Label();
            txt_tienKhachDua = new TextBox();
            txt_PhanTramGiam = new TextBox();
            label12 = new Label();
            lb_TongHoaDon = new Label();
            label13 = new Label();
            label10 = new Label();
            label6 = new Label();
            btn_Huy = new Button();
            btn_ThanhToan = new Button();
            label5 = new Label();
            lb_PhanTramGiam = new Label();
            txt_TKGiamGia = new TextBox();
            dgv_MaGiamGia = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_MaGiamGia).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_ID);
            groupBox1.Controls.Add(btn_addOrder);
            groupBox1.Controls.Add(txt_NameCustomer);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_PhoneNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // lb_ID
            // 
            lb_ID.AutoSize = true;
            lb_ID.Location = new Point(11, 34);
            lb_ID.Name = "lb_ID";
            lb_ID.Size = new Size(0, 20);
            lb_ID.TabIndex = 3;
            // 
            // btn_addOrder
            // 
            btn_addOrder.Location = new Point(92, 176);
            btn_addOrder.Name = "btn_addOrder";
            btn_addOrder.Size = new Size(137, 38);
            btn_addOrder.TabIndex = 2;
            btn_addOrder.Text = "Tạo hóa đơn";
            btn_addOrder.UseVisualStyleBackColor = true;
            btn_addOrder.Click += btn_addOrder_Click;
            // 
            // txt_NameCustomer
            // 
            txt_NameCustomer.Location = new Point(133, 125);
            txt_NameCustomer.Name = "txt_NameCustomer";
            txt_NameCustomer.Size = new Size(171, 27);
            txt_NameCustomer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 128);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên khách hàng";
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Location = new Point(133, 78);
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.Size = new Size(171, 27);
            txt_PhoneNumber.TabIndex = 1;
            txt_PhoneNumber.TextChanged += txt_PhoneNumber_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 81);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Số điện thoại";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_HDCT);
            groupBox2.Controls.Add(cbo_HoaDon);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(328, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 829);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // dgv_HDCT
            // 
            dgv_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HDCT.Location = new Point(6, 110);
            dgv_HDCT.Name = "dgv_HDCT";
            dgv_HDCT.RowHeadersWidth = 51;
            dgv_HDCT.Size = new Size(510, 713);
            dgv_HDCT.TabIndex = 1;
            // 
            // cbo_HoaDon
            // 
            cbo_HoaDon.FormattingEnabled = true;
            cbo_HoaDon.Location = new Point(199, 26);
            cbo_HoaDon.Name = "cbo_HoaDon";
            cbo_HoaDon.Size = new Size(253, 28);
            cbo_HoaDon.TabIndex = 0;
            cbo_HoaDon.SelectedIndexChanged += cbo_HoaDon_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 29);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã hóa đơn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_SLMua);
            groupBox3.Controls.Add(txt_TKSanPham);
            groupBox3.Controls.Add(dgv_SanPham);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(856, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(514, 829);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // txt_SLMua
            // 
            txt_SLMua.Location = new Point(130, 60);
            txt_SLMua.Name = "txt_SLMua";
            txt_SLMua.Size = new Size(359, 27);
            txt_SLMua.TabIndex = 11;
            // 
            // txt_TKSanPham
            // 
            txt_TKSanPham.Location = new Point(130, 27);
            txt_TKSanPham.Name = "txt_TKSanPham";
            txt_TKSanPham.Size = new Size(359, 27);
            txt_TKSanPham.TabIndex = 11;
            // 
            // dgv_SanPham
            // 
            dgv_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SanPham.Location = new Point(6, 110);
            dgv_SanPham.Name = "dgv_SanPham";
            dgv_SanPham.RowHeadersWidth = 51;
            dgv_SanPham.Size = new Size(502, 713);
            dgv_SanPham.TabIndex = 10;
            dgv_SanPham.CellClick += dgv_SanPham_CellClick;
            dgv_SanPham.CellDoubleClick += dgv_SanPham_CellDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 67);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 0;
            label4.Text = "Số lượng mua";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(-724, 579);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(184, 27);
            textBox5.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 29);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 0;
            label7.Text = "Tên sản phẩm";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lb_traKhach);
            groupBox4.Controls.Add(lb_TienDuocGiam);
            groupBox4.Controls.Add(lb_ThanhTien);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txt_tienKhachDua);
            groupBox4.Controls.Add(txt_PhanTramGiam);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(lb_TongHoaDon);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(btn_Huy);
            groupBox4.Controls.Add(btn_ThanhToan);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(lb_PhanTramGiam);
            groupBox4.Controls.Add(txt_TKGiamGia);
            groupBox4.Controls.Add(dgv_MaGiamGia);
            groupBox4.Location = new Point(12, 269);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(310, 572);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thanh toán hóa đơn";
            // 
            // lb_traKhach
            // 
            lb_traKhach.AutoSize = true;
            lb_traKhach.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_traKhach.Location = new Point(112, 433);
            lb_traKhach.Name = "lb_traKhach";
            lb_traKhach.Size = new Size(50, 38);
            lb_traKhach.TabIndex = 9;
            lb_traKhach.Text = "0đ";
            // 
            // lb_TienDuocGiam
            // 
            lb_TienDuocGiam.AutoSize = true;
            lb_TienDuocGiam.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TienDuocGiam.Location = new Point(113, 317);
            lb_TienDuocGiam.Name = "lb_TienDuocGiam";
            lb_TienDuocGiam.Size = new Size(50, 38);
            lb_TienDuocGiam.TabIndex = 9;
            lb_TienDuocGiam.Text = "0đ";
            // 
            // lb_ThanhTien
            // 
            lb_ThanhTien.AutoSize = true;
            lb_ThanhTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_ThanhTien.Location = new Point(113, 358);
            lb_ThanhTien.Name = "lb_ThanhTien";
            lb_ThanhTien.Size = new Size(50, 38);
            lb_ThanhTien.TabIndex = 9;
            lb_ThanhTien.Text = "0đ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 330);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 8;
            label11.Text = "Giảm giá";
            // 
            // txt_tienKhachDua
            // 
            txt_tienKhachDua.Location = new Point(120, 403);
            txt_tienKhachDua.Name = "txt_tienKhachDua";
            txt_tienKhachDua.Size = new Size(184, 27);
            txt_tienKhachDua.TabIndex = 1;
            txt_tienKhachDua.TextChanged += txt_tienKhachDua_TextChanged;
            // 
            // txt_PhanTramGiam
            // 
            txt_PhanTramGiam.Location = new Point(116, 246);
            txt_PhanTramGiam.Name = "txt_PhanTramGiam";
            txt_PhanTramGiam.Size = new Size(184, 27);
            txt_PhanTramGiam.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 371);
            label12.Name = "label12";
            label12.Size = new Size(78, 20);
            label12.TabIndex = 8;
            label12.Text = "Thành tiền";
            // 
            // lb_TongHoaDon
            // 
            lb_TongHoaDon.AutoSize = true;
            lb_TongHoaDon.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TongHoaDon.Location = new Point(112, 276);
            lb_TongHoaDon.Name = "lb_TongHoaDon";
            lb_TongHoaDon.Size = new Size(50, 38);
            lb_TongHoaDon.TabIndex = 5;
            lb_TongHoaDon.Text = "0đ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(4, 445);
            label13.Name = "label13";
            label13.Size = new Size(71, 20);
            label13.TabIndex = 8;
            label13.Text = "Trả khách";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 408);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 8;
            label10.Text = "Tiền khách đưa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 291);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 4;
            label6.Text = "Tổng hóa đơn";
            // 
            // btn_Huy
            // 
            btn_Huy.Location = new Point(116, 537);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(94, 29);
            btn_Huy.TabIndex = 3;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_Click;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Location = new Point(216, 537);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(94, 29);
            btn_ThanhToan.TabIndex = 3;
            btn_ThanhToan.Text = "Thanh toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 39);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 2;
            label5.Text = "Tìm kiếm";
            // 
            // lb_PhanTramGiam
            // 
            lb_PhanTramGiam.AutoSize = true;
            lb_PhanTramGiam.Location = new Point(3, 250);
            lb_PhanTramGiam.Name = "lb_PhanTramGiam";
            lb_PhanTramGiam.Size = new Size(114, 20);
            lb_PhanTramGiam.TabIndex = 2;
            lb_PhanTramGiam.Text = "Phần trăm giảm";
            // 
            // txt_TKGiamGia
            // 
            txt_TKGiamGia.Location = new Point(87, 36);
            txt_TKGiamGia.Name = "txt_TKGiamGia";
            txt_TKGiamGia.Size = new Size(217, 27);
            txt_TKGiamGia.TabIndex = 1;
            // 
            // dgv_MaGiamGia
            // 
            dgv_MaGiamGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_MaGiamGia.Location = new Point(11, 69);
            dgv_MaGiamGia.Name = "dgv_MaGiamGia";
            dgv_MaGiamGia.RowHeadersWidth = 51;
            dgv_MaGiamGia.Size = new Size(293, 174);
            dgv_MaGiamGia.TabIndex = 0;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SalesForm";
            Text = "SalesForm";
            Load += SalesForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_MaGiamGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txt_NameCustomer;
        private Label label2;
        private TextBox txt_PhoneNumber;
        private Label label1;
        private Button btn_addOrder;
        private ComboBox cbo_HoaDon;
        private Label label3;
        private DataGridView dgv_HDCT;
        private GroupBox groupBox4;
        private Label lb_PhanTramGiam;
        private TextBox txt_TKGiamGia;
        private DataGridView dgv_MaGiamGia;
        private Button btn_Huy;
        private Button btn_ThanhToan;
        private Label label5;
        private Label label10;
        private Label label6;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox5;
        private TextBox txt_PhanTramGiam;
        private Label lb_TongHoaDon;
        private TextBox txt_TKSanPham;
        private DataGridView dgv_SanPham;
        private Label label7;
        private Label lb_traKhach;
        private Label lb_TienDuocGiam;
        private Label lb_ThanhTien;
        private TextBox txt_tienKhachDua;
        private Label lb_ID;
        private TextBox txt_SLMua;
        private Label label4;
    }
}