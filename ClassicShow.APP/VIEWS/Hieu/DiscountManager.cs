using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicShow.APP.VIEWS
{
    public partial class DiscountManager : Form
    {
        public DiscountManager()
        {
            InitializeComponent();

            LoadView();
        }
        private void LoadView()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã Voucher";
            dataGridView1.Columns[2].Name = "Tên Mã";
            dataGridView1.Columns[3].Name = "Phần Trăm Giảm";
            dataGridView1.Columns[4].Name = "Ngày Bắt Đầu";
            dataGridView1.Columns[5].Name = "Ngày Kết Thúc";
            dataGridView1.Columns[6].Name = "Mô tả";
            dataGridView1.Rows.Clear();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string maVoucher = txt_ma.Text.Trim();
            string tenMa = txt_ten.Text.Trim();
            string phanTramGiam = txt_phantram.Text.Trim();
            DateTime ngayBatDau = dateTimePicker1.Value;
            DateTime ngayKetThuc = dateTimePicker2.Value;
            string moTa = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(maVoucher) || string.IsNullOrEmpty(tenMa) || string.IsNullOrEmpty(phanTramGiam))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int stt = dataGridView1.Rows.Count + 1;
            dataGridView1.Rows.Add(
                stt,
                maVoucher,
                tenMa,
                phanTramGiam,
                ngayBatDau.ToString("dd/MM/yyyy"),
                ngayKetThuc.ToString("dd/MM/yyyy"),
                moTa
            );
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_ma.Clear();
            txt_ten.Clear();
            txt_phantram.Clear();
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_ma.Text = row.Cells[1].Value?.ToString();
                txt_ten.Text = row.Cells[2].Value?.ToString();
                txt_phantram.Text = row.Cells[3].Value?.ToString().Replace("%", "");
                dateTimePicker1.Value = DateTime.Parse(row.Cells[4].Value?.ToString());
                dateTimePicker2.Value = DateTime.Parse(row.Cells[5].Value?.ToString());
                textBox1.Text = row.Cells[6].Value?.ToString();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index == -1)
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maVoucher = txt_ma.Text.Trim();
            string tenMa = txt_ten.Text.Trim();
            string phanTramGiam = txt_phantram.Text.Trim();
            DateTime ngayBatDau = dateTimePicker1.Value;
            DateTime ngayKetThuc = dateTimePicker2.Value;
            string moTa = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(maVoucher) || string.IsNullOrEmpty(tenMa) || string.IsNullOrEmpty(phanTramGiam))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            currentRow.Cells[1].Value = maVoucher;
            currentRow.Cells[2].Value = tenMa;
            currentRow.Cells[3].Value = phanTramGiam;
            currentRow.Cells[4].Value = ngayBatDau.ToString("dd/MM/yyyy");
            currentRow.Cells[5].Value = ngayKetThuc.ToString("dd/MM/yyyy");
            currentRow.Cells[6].Value = moTa;
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_ma.Clear();
            txt_ten.Clear();
            txt_phantram.Clear();
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index == -1)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hàng này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                int selectedIndex = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Clear();
            txt_ten.Clear();
            txt_phantram.Clear();
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.ClearSelection();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string searchValue = txt_timkiem.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                LoadView();
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells["Phần Trăm Giảm"].Value != null)
                    {
                        string phanTramGiam = row.Cells["Phần Trăm Giảm"].Value.ToString();
                        if (phanTramGiam.Contains(searchValue))
                        {
                            row.Visible = true;  
                        }
                        else
                        {
                            row.Visible = false; 
                        }
                    }
                }
            }
        }
    }
}
