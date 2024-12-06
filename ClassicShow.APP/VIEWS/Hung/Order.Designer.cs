namespace ClassicShow.APP.VIEWS
{
    partial class Order
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
            label1 = new Label();
            cbo_HoaDon = new ComboBox();
            dgv_HoaDon = new DataGridView();
            label11 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbo_HoaDon);
            groupBox1.Controls.Add(dgv_HoaDon);
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1358, 774);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 31);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 2;
            label1.Text = "Trạng thái hóa đơn";
            // 
            // cbo_HoaDon
            // 
            cbo_HoaDon.FormattingEnabled = true;
            cbo_HoaDon.Location = new Point(379, 28);
            cbo_HoaDon.Name = "cbo_HoaDon";
            cbo_HoaDon.Size = new Size(633, 28);
            cbo_HoaDon.TabIndex = 1;
            // 
            // dgv_HoaDon
            // 
            dgv_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDon.Location = new Point(6, 82);
            dgv_HoaDon.Name = "dgv_HoaDon";
            dgv_HoaDon.RowHeadersWidth = 51;
            dgv_HoaDon.Size = new Size(1346, 686);
            dgv_HoaDon.TabIndex = 0;
            dgv_HoaDon.CellDoubleClick += dgv_HoaDon_CellDoubleClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(391, 25);
            label11.Name = "label11";
            label11.Size = new Size(318, 46);
            label11.TabIndex = 29;
            label11.Text = "Quản lí hóa đơn";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Name = "Order";
            Text = " ";
            Load += Order_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbo_HoaDon;
        private DataGridView dgv_HoaDon;
        private Label label11;
    }
}