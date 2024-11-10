namespace ClassicShow.APP.VIEWS
{
    partial class DiscountManager
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
            lbl_mavoucher = new Label();
            lbl_tenma = new Label();
            lbl_phantramgiam = new Label();
            lbl_ngaybatdau = new Label();
            lbl_ngayketthuc = new Label();
            txt_ma = new TextBox();
            txt_ten = new TextBox();
            txt_phantram = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            lbl_mota = new Label();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_clear = new Button();
            txt_timkiem = new TextBox();
            btn_timkiem = new Button();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_mavoucher
            // 
            lbl_mavoucher.AutoSize = true;
            lbl_mavoucher.Location = new Point(50, 171);
            lbl_mavoucher.Name = "lbl_mavoucher";
            lbl_mavoucher.Size = new Size(87, 20);
            lbl_mavoucher.TabIndex = 0;
            lbl_mavoucher.Text = "Mã Voucher";
            // 
            // lbl_tenma
            // 
            lbl_tenma.AutoSize = true;
            lbl_tenma.Location = new Point(50, 214);
            lbl_tenma.Name = "lbl_tenma";
            lbl_tenma.Size = new Size(57, 20);
            lbl_tenma.TabIndex = 1;
            lbl_tenma.Text = "Tên Mã";
            // 
            // lbl_phantramgiam
            // 
            lbl_phantramgiam.AutoSize = true;
            lbl_phantramgiam.Location = new Point(50, 267);
            lbl_phantramgiam.Name = "lbl_phantramgiam";
            lbl_phantramgiam.Size = new Size(114, 20);
            lbl_phantramgiam.TabIndex = 2;
            lbl_phantramgiam.Text = "Phần trăm giảm";
            // 
            // lbl_ngaybatdau
            // 
            lbl_ngaybatdau.AutoSize = true;
            lbl_ngaybatdau.Location = new Point(50, 324);
            lbl_ngaybatdau.Name = "lbl_ngaybatdau";
            lbl_ngaybatdau.Size = new Size(99, 20);
            lbl_ngaybatdau.TabIndex = 3;
            lbl_ngaybatdau.Text = "Ngày bắt đầu";
            // 
            // lbl_ngayketthuc
            // 
            lbl_ngayketthuc.AutoSize = true;
            lbl_ngayketthuc.Location = new Point(50, 376);
            lbl_ngayketthuc.Name = "lbl_ngayketthuc";
            lbl_ngayketthuc.Size = new Size(100, 20);
            lbl_ngayketthuc.TabIndex = 4;
            lbl_ngayketthuc.Text = "Ngày kết thúc";
            // 
            // txt_ma
            // 
            txt_ma.Location = new Point(173, 164);
            txt_ma.Name = "txt_ma";
            txt_ma.Size = new Size(786, 27);
            txt_ma.TabIndex = 5;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(173, 207);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(786, 27);
            txt_ten.TabIndex = 6;
            // 
            // txt_phantram
            // 
            txt_phantram.Location = new Point(173, 260);
            txt_phantram.Name = "txt_phantram";
            txt_phantram.Size = new Size(786, 27);
            txt_phantram.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 319);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(786, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(173, 369);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(786, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 511);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 330);
            panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1325, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 426);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(786, 27);
            textBox1.TabIndex = 12;
            // 
            // lbl_mota
            // 
            lbl_mota.AutoSize = true;
            lbl_mota.Location = new Point(50, 433);
            lbl_mota.Name = "lbl_mota";
            lbl_mota.Size = new Size(48, 20);
            lbl_mota.TabIndex = 11;
            lbl_mota.Text = "Mô tả";
            // 
            // btn_them
            // 
            btn_them.Location = new Point(987, 352);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(164, 44);
            btn_them.TabIndex = 13;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(987, 409);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(164, 44);
            btn_sua.TabIndex = 14;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(1157, 352);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(164, 44);
            btn_xoa.TabIndex = 15;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(1157, 409);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(164, 44);
            btn_clear.TabIndex = 16;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(598, 469);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(354, 27);
            txt_timkiem.TabIndex = 18;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(487, 469);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(94, 29);
            btn_timkiem.TabIndex = 19;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(450, 28);
            label11.Name = "label11";
            label11.Size = new Size(324, 46);
            label11.TabIndex = 29;
            label11.Text = "Quản lí giảm giá";
            // 
            // DiscountManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(label11);
            Controls.Add(btn_timkiem);
            Controls.Add(txt_timkiem);
            Controls.Add(btn_clear);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(textBox1);
            Controls.Add(lbl_mota);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_phantram);
            Controls.Add(txt_ten);
            Controls.Add(txt_ma);
            Controls.Add(lbl_ngayketthuc);
            Controls.Add(lbl_ngaybatdau);
            Controls.Add(lbl_phantramgiam);
            Controls.Add(lbl_tenma);
            Controls.Add(lbl_mavoucher);
            Name = "DiscountManager";
            Text = "DiscountManager";
            Load += DiscountManager_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_mavoucher;
        private Label lbl_tenma;
        private Label lbl_phantramgiam;
        private Label lbl_ngaybatdau;
        private Label lbl_ngayketthuc;
        private TextBox txt_ma;
        private TextBox txt_ten;
        private TextBox txt_phantram;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Panel panel1;
        private TextBox textBox1;
        private Label lbl_mota;
        private DataGridView dataGridView1;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_clear;
        private TextBox txt_timkiem;
        private Button btn_timkiem;
        private Label label11;
    }
}