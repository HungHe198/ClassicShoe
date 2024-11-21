using ClassicShoe.APP.SERVICES;
using ClassicShoe.DATA.Models;
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
        DiscountManagerSer _ser;
        public DiscountManager()
        {
            InitializeComponent();
            _ser = new DiscountManagerSer(new ClassicShoeDbContext());
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
            int STT = 1;
            foreach (var a in _ser.GetAllMaGiamGia())
            {
                dataGridView1.Rows.Add(STT, a.Id, a.TenMaGiamGia, a.PhanTramGiam, a.NgayBatDau, a.NgayKetThuc, a.MoTa);
                STT++;
            }
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

            if (!int.TryParse(phanTramGiam, out int phanTram))
            {
                MessageBox.Show("Phần trăm giảm phải là một số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MaGiamGia maGiamGia = new MaGiamGia
            {
                Id = Guid.NewGuid(),
                TenMaGiamGia = tenMa,
                PhanTramGiam = phanTram,
                NgayBatDau = ngayBatDau,
                NgayKetThuc = ngayKetThuc,
                MoTa = moTa,
            };

            if (_ser.CreateMaGiamGia(maGiamGia))
            {
                MessageBox.Show("Thêm mã giảm giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadView();

                txt_ma.Clear();
                txt_ten.Clear();
                txt_phantram.Clear();
                textBox1.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Thêm mã giảm giá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            if (!int.TryParse(phanTramGiam, out int phanTram))
            {
                MessageBox.Show("Phần trăm giảm phải là một số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guid maGiamGiaId = Guid.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());

            MaGiamGia updatedMaGiamGia = new MaGiamGia
            {
                Id = maGiamGiaId,
                TenMaGiamGia = maVoucher,
                PhanTramGiam = phanTram,
                NgayBatDau = ngayBatDau,
                NgayKetThuc = ngayKetThuc,
                MoTa = moTa,
                GT_HoaDonToiThieu = 0,
                GT_ToiDaGiam = 0
            };
            bool result = _ser.UpdateMaGiamGia(maGiamGiaId, updatedMaGiamGia);

            if (!result)
            {
                MessageBox.Show("Không thể cập nhật mã giảm giá. Vui lòng kiểm tra dữ liệu hoặc thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadView();
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
                Guid maGiamGiaId = Guid.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                bool result = _ser.DeleteMaGiamGia(maGiamGiaId);

                if (result)
                {
                    int selectedIndex = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    UpdateRowNumbers();

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa mã giảm giá này. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateRowNumbers()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = string.Empty;
            txt_ten.Text = string.Empty;
            txt_phantram.Text = string.Empty;
            textBox1.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            MessageBox.Show("Đã xóa toàn bộ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DiscountManager_Load(object sender, EventArgs e)
        {

        }
    }
}
