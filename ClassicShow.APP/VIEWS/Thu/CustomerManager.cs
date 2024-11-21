using ClassicShoe.DATA.Models;
using ClassicShoe.DATA.Repositories;
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
    public partial class CustomerManager : Form
    {
        Guid _IdWhenClick;

        public CustomerManager(AllRepositories<KhachHang> repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        public AllRepositories<KhachHang> _repo;
        private void CustomerManager_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        public void LoadDGV()
        {
            try
            {
                var customers = _repo.GetAll();
                if (customers != null && customers.Count > 0)
                {

                    dataGridViewkh.DataSource = customers;
                    dataGridViewkh.Columns["Id"].HeaderText = "Mã Khách Hàng";
                    dataGridViewkh.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
                    dataGridViewkh.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                    dataGridViewkh.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
                    dataGridViewkh.Columns["Email"].HeaderText = "Email";
                    dataGridViewkh.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                    dataGridViewkh.Columns["DiemTichLuy"].HeaderText = "Điểm Tích Lũy";
                    dataGridViewkh.Columns["TongChiTieu"].HeaderText = "Tổng Chi Tiêu";

                }
                else
                {
                    MessageBox.Show("Không có khách hàng nào trong danh sách.");
                    dataGridViewkh.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    var khachHang = new KhachHang
                    {
                        Id = Guid.NewGuid(),
                        TenKhachHang = txt_ten.Text,
                        NgaySinh = dtp_ngsinh.Value,
                        SoDienThoai = txt_sdt.Text,
                        Email = txt_email.Text,
                        DiaChi = txt_dchi.Text,
                        DiemTichLuy = int.TryParse(txt_diem.Text, out var diemTichLuy) ? diemTichLuy : 0,
                        TongChiTieu = decimal.TryParse(textBox2.Text, out var tongChiTieu) ? tongChiTieu : 0
                    };

                    if (_repo.Create(khachHang))
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                        LoadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewkh.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                    return;
                }

                var selectedId = Guid.Parse(dataGridViewkh.SelectedRows[0].Cells["Id"].Value.ToString());

                var existingCustomer = _repo.GetAll().FirstOrDefault(x => x.Id == selectedId);
                if (existingCustomer == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng để sửa.");
                    return;
                }

                existingCustomer.TenKhachHang = txt_ten.Text;
                existingCustomer.NgaySinh = dtp_ngsinh.Value;
                existingCustomer.SoDienThoai = txt_sdt.Text;
                existingCustomer.Email = txt_email.Text;
                existingCustomer.DiaChi = txt_dchi.Text;
                existingCustomer.DiemTichLuy = int.TryParse(txt_diem.Text, out var diemTichLuy) ? diemTichLuy : 0;
                existingCustomer.TongChiTieu = decimal.TryParse(textBox2.Text, out var tongChiTieu) ? tongChiTieu : 0;


                if (_repo.Update(selectedId, existingCustomer))
                {
                    MessageBox.Show("Sửa khách hàng thành công!");
                    LoadDGV();
                }
                else
                {
                    MessageBox.Show("Sửa khách hàng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi sửa khách hàng: {ex.Message}");
            }
        }

        private void dataGridViewkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0 && dataGridViewkh.Rows[e.RowIndex].Cells["Id"].Value != null)
                {

                    _IdWhenClick = Guid.Parse(dataGridViewkh.Rows[e.RowIndex].Cells["Id"].Value.ToString());


                    var selectedKhachHang = _repo.GetAll().FirstOrDefault(x => x.Id == _IdWhenClick);
                    if (selectedKhachHang != null)
                    {

                        txt_mkh.Text = selectedKhachHang.Id.ToString();
                        txt_ten.Text = selectedKhachHang.TenKhachHang;
                        dtp_ngsinh.Value = selectedKhachHang.NgaySinh ?? DateTime.Now;
                        txt_sdt.Text = selectedKhachHang.SoDienThoai;
                        txt_email.Text = selectedKhachHang.Email;
                        txt_dchi.Text = selectedKhachHang.DiaChi;
                        txt_diem.Text = selectedKhachHang.DiemTichLuy.ToString();
                        textBox2.Text = selectedKhachHang.TongChiTieu.ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ten.Text = "";
            txt_sdt.Text = "";
            txt_mkh.Text = "";
            txt_email.Text = "";
            txt_diem.Text = "";
            txt_dchi.Text = "";
            dtp_ngsinh.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewkh.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                    return;
                }


                var selectedId = Guid.Parse(dataGridViewkh.SelectedRows[0].Cells["Id"].Value.ToString());


                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa khách hàng này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    if (_repo.Delete(selectedId))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        LoadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại. Vui lòng thử lại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa khách hàng: {ex.Message}");
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            
        }
    }
}