namespace ClassicShow.APP.VIEWS
{
    partial class OderDetail
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
            txt_MaHoaDon = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbo_SanPham = new ComboBox();
            txt_TenKhachHang = new TextBox();
            label4 = new Label();
            txt_SoLuongMua = new TextBox();
            btn_addProduct = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            btn_DelSP = new Button();
            btn_EditOrder = new Button();
            btn_XacNhan = new Button();
            btn_DelOrder = new Button();
            label11 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 172);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn";
            // 
            // txt_MaHoaDon
            // 
            txt_MaHoaDon.Location = new Point(231, 165);
            txt_MaHoaDon.Name = "txt_MaHoaDon";
            txt_MaHoaDon.Size = new Size(822, 27);
            txt_MaHoaDon.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 217);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 261);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 0;
            label3.Text = "Sản phẩm";
            // 
            // cbo_SanPham
            // 
            cbo_SanPham.FormattingEnabled = true;
            cbo_SanPham.Location = new Point(231, 258);
            cbo_SanPham.Name = "cbo_SanPham";
            cbo_SanPham.Size = new Size(822, 28);
            cbo_SanPham.TabIndex = 2;
            // 
            // txt_TenKhachHang
            // 
            txt_TenKhachHang.Location = new Point(231, 214);
            txt_TenKhachHang.Name = "txt_TenKhachHang";
            txt_TenKhachHang.Size = new Size(822, 27);
            txt_TenKhachHang.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 305);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 0;
            label4.Text = "Số lượng mua";
            // 
            // txt_SoLuongMua
            // 
            txt_SoLuongMua.Location = new Point(231, 302);
            txt_SoLuongMua.Name = "txt_SoLuongMua";
            txt_SoLuongMua.Size = new Size(822, 27);
            txt_SoLuongMua.TabIndex = 1;
            // 
            // btn_addProduct
            // 
            btn_addProduct.Location = new Point(1084, 274);
            btn_addProduct.Name = "btn_addProduct";
            btn_addProduct.Size = new Size(252, 38);
            btn_addProduct.TabIndex = 3;
            btn_addProduct.Text = "Thêm vào hóa đơn";
            btn_addProduct.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 386);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1365, 455);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 54);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 2;
            label6.Text = "Tìm kiếm";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(204, 47);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(822, 27);
            textBox4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1352, 356);
            dataGridView1.TabIndex = 0;
            // 
            // btn_DelSP
            // 
            btn_DelSP.Location = new Point(1084, 142);
            btn_DelSP.Name = "btn_DelSP";
            btn_DelSP.Size = new Size(252, 38);
            btn_DelSP.TabIndex = 3;
            btn_DelSP.Text = "Xóa khỏi hóa đơn";
            btn_DelSP.UseVisualStyleBackColor = true;
            // 
            // btn_EditOrder
            // 
            btn_EditOrder.Location = new Point(1084, 186);
            btn_EditOrder.Name = "btn_EditOrder";
            btn_EditOrder.Size = new Size(252, 38);
            btn_EditOrder.TabIndex = 3;
            btn_EditOrder.Text = "Cập nhật hóa đơn";
            btn_EditOrder.UseVisualStyleBackColor = true;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Location = new Point(1084, 230);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(252, 38);
            btn_XacNhan.TabIndex = 3;
            btn_XacNhan.Text = "Xác nhận đơn hàng";
            btn_XacNhan.UseVisualStyleBackColor = true;
            // 
            // btn_DelOrder
            // 
            btn_DelOrder.Location = new Point(1084, 318);
            btn_DelOrder.Name = "btn_DelOrder";
            btn_DelOrder.Size = new Size(252, 38);
            btn_DelOrder.TabIndex = 3;
            btn_DelOrder.Text = "Hủy đơn hàng";
            btn_DelOrder.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(490, 31);
            label11.Name = "label11";
            label11.Size = new Size(342, 46);
            label11.TabIndex = 29;
            label11.Text = "Chi tiết đơn hàng";
            // 
            // OderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Controls.Add(btn_DelOrder);
            Controls.Add(btn_XacNhan);
            Controls.Add(btn_EditOrder);
            Controls.Add(btn_DelSP);
            Controls.Add(btn_addProduct);
            Controls.Add(cbo_SanPham);
            Controls.Add(label3);
            Controls.Add(txt_SoLuongMua);
            Controls.Add(txt_TenKhachHang);
            Controls.Add(label4);
            Controls.Add(txt_MaHoaDon);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OderDetail";
            Text = "OderDetail";
            Load += OderDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_MaHoaDon;
        private Label label2;
        private Label label3;
        private ComboBox cbo_SanPham;
        private TextBox txt_TenKhachHang;
        private Label label4;
        private TextBox txt_SoLuongMua;
        private Button btn_addProduct;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Button btn_DelSP;
        private Button btn_EditOrder;
        private Button btn_XacNhan;
        private Button btn_DelOrder;
        private Label label6;
        private Label label11;
    }
}