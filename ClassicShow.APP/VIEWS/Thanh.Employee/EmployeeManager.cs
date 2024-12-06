using ClassicShoe.APP.SERVICES;
using ClassicShoe.DATA.Models;
using ClassicShoe.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicShow.APP.VIEWS
{
    public partial class EmployeeManager : Form
    {



        public EmployeeManager(AllRepositories<NhanVien> repoNV, AllRepositories<VaiTro> repoCV)
        {
            InitializeComponent();
            _repoNV = repoNV;
            _repoCV = repoCV;
        }

        public AllRepositories<NhanVien> _repoNV;
        public AllRepositories<VaiTro> _repoCV;

        NhanVienServices _services = new NhanVienServices();
        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadCBO();

        }
        public void LoadCBO()
        {

            cbo_CVNhanVien.DataSource = _repoCV.GetAll();
            cbo_CVNhanVien.DisplayMember = "TenVaiTro";
            cbo_CVNhanVien.ValueMember = "Id";
        }
        public void LoadDGV()
        {
            if (_repoNV != null)
            {
                var result = from nv in _repoNV.GetAll()
                             select new
                             {
                                 Id = nv.Id,
                                 TenNhanVien = nv.TenNhanVien,
                                 TenTaiKhoan = nv.TenTaiKhoan,
                                 MatKhau = nv.MatKhau,
                                 NgaySinh = nv.NgaySinh,
                                 DiaChi = nv.DiaChi,
                                 SoDienThoai = nv.SoDienThoai,
                                 Email = nv.Email,
                                 VaiTroId = nv.VaiTroId,
                                 TenVaiTro = _repoCV.GetAll().FirstOrDefault(x => x.Id == nv.VaiTroId).TenVaiTro,
                                 TrangThai = nv.Status switch
                                 {
                                     0 => "Đã nghỉ làm",
                                     1 => "Đang đi làm",
                                     _ => "Không xác định" // Trường hợp mặc định nếu Status có giá trị khác
                                 }
                             };
                dgv_NhanVien.DataSource = result.ToList();
            }
            else
            {
                MessageBox.Show("Repository chưa được khởi tạo.");
            }

        }
        private bool ValidateNhanVien()
        {
            // Kiểm tra tên nhân viên không được rỗng
            if (string.IsNullOrWhiteSpace(txt_Ten.Text))
            {
                MessageBox.Show("Tên nhân viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra tài khoản không được rỗng
            if (string.IsNullOrWhiteSpace(txt_acc.Text))
            {
                MessageBox.Show("Tên tài khoản không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra trùng tên tài khoản
            var existingNhanVien = _repoNV.GetAll().FirstOrDefault(nv => nv.TenTaiKhoan == txt_acc.Text.Trim());
            if (existingNhanVien != null)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tài khoản khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra mật khẩu có ít nhất 6 ký tự
            if (txt_pass.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra email hợp lệ
            if (!Regex.IsMatch(txt_Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra số điện thoại chỉ chứa số và có ít nhất 10 ký tự
            if (!Regex.IsMatch(txt_soDienThoai.Text, @"^\d{10,}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra Vai trò
            if (cbo_CVNhanVien.SelectedValue == null || string.IsNullOrWhiteSpace(cbo_CVNhanVien.SelectedValue.ToString()))
            {
                MessageBox.Show("Vui lòng chọn vai trò cho nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txt_Ten.Clear();
            txt_acc.Clear();
            txt_pass.Clear();
            txt_DiaChi.Clear();
            txt_Email.Clear();
            txt_soDienThoai.Clear();
            cbo_CVNhanVien.SelectedIndex = -1;
            dtp_NgaySinh.Value = DateTime.Now;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (ValidateNhanVien())
            {
                NhanVien nhanVienNew = new NhanVien()
                {
                    Id = Guid.NewGuid(),
                    TenNhanVien = txt_Ten.Text.Trim(),
                    TenTaiKhoan = txt_acc.Text.Trim(),
                    MatKhau = txt_pass.Text.Trim(),
                    DiaChi = txt_DiaChi.Text.Trim(),
                    Email = txt_Email.Text.Trim(),
                    NgaySinh = dtp_NgaySinh.Value,
                    SoDienThoai = txt_soDienThoai.Text.Trim(),
                    VaiTroId = Guid.Parse(cbo_CVNhanVien.SelectedValue.ToString()),
                    Status = 1,
                };

                try
                {
                    _repoNV.Create(nhanVienNew);
                    MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (ValidateNhanVien())
            {
                if (dgv_NhanVien.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.");
                    return;
                }

                var selectedRow = dgv_NhanVien.SelectedRows[0];
                var nhanVienSelectedId = selectedRow.Cells["Id"].Value;
                try
                {
                    // Tìm nhân viên cần sửa
                    NhanVien nhanVien = _repoNV.GetById(Guid.Parse(nhanVienSelectedId.ToString()));
                    if (nhanVien != null)
                    {
                        // Cập nhật thông tin nhân viên
                        nhanVien.TenNhanVien = txt_Ten.Text.Trim();
                        nhanVien.TenTaiKhoan = txt_acc.Text.Trim();
                        nhanVien.MatKhau = txt_pass.Text.Trim();
                        nhanVien.DiaChi = txt_DiaChi.Text.Trim();
                        nhanVien.Email = txt_Email.Text.Trim();
                        nhanVien.NgaySinh = dtp_NgaySinh.Value;
                        nhanVien.SoDienThoai = txt_soDienThoai.Text.Trim();
                        nhanVien.VaiTroId = Guid.Parse(cbo_CVNhanVien.SelectedValue.ToString());
                        nhanVien.Status = 1;

                        // Gọi hàm cập nhật dữ liệu
                        _repoNV.Update(nhanVien.Id, nhanVien);
                        MessageBox.Show("Sửa thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới danh sách
                        LoadDGV();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
            }

        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_NhanVien.Rows[e.RowIndex];

                // Gán dữ liệu từ hàng được chọn vào các trường
                txt_Ten.Text = row.Cells["TenNhanVien"].Value.ToString();
                txt_acc.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                txt_pass.Text = row.Cells["MatKhau"].Value.ToString();
                txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_soDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                dtp_NgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cbo_CVNhanVien.SelectedValue = row.Cells["VaiTroId"].Value;

                // Lưu lại Id nhân viên để sử dụng khi sửa

            }
        }

        private void btn_VoHieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_NhanVien.SelectedRows.Count > 0)
                {
                    var selectedRow = dgv_NhanVien.SelectedRows[0];
                    var nhanVienSelectedId = selectedRow.Cells["Id"].Value;

                    if (nhanVienSelectedId != null)
                    {
                        // Hiển thị hộp thoại xác nhận
                        var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật trạng thái nhân viên này thành 'Đã nghỉ làm'?",
                                                            "Xác nhận",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                        if (confirmResult == DialogResult.Yes)
                        {
                            var findNhanVien = _repoNV.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(nhanVienSelectedId.ToString()));
                            if (findNhanVien != null)
                            {
                                findNhanVien.Status = 0;
                                bool updateResult = _repoNV.Update(findNhanVien.Id, findNhanVien);
                                if (updateResult)
                                {
                                    MessageBox.Show("Cập nhật trạng thái thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật trạng thái thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                LoadDGV();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để thực hiện hành động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
