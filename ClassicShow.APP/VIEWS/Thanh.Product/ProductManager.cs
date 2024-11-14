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
    public partial class ProductManager : Form
    {




        public ProductManager(AllRepositories<GiayChiTiet> repoGCT, AllRepositories<Giay> repoG, AllRepositories<DeGiay> repoDeGiay, AllRepositories<ThanGiay> repoThanGiay, AllRepositories<LoaiGiay> repoLoaiGiay, AllRepositories<MauSac> repoMauSac, AllRepositories<HangSanXuat> repoHangSanXuat)
        {
            InitializeComponent();
            _repoGCT = repoGCT;
            _repoG = repoG;
            _repoDeGiay = repoDeGiay;
            _repoThanGiay = repoThanGiay;
            _repoLoaiGiay = repoLoaiGiay;
            _repoMauSac = repoMauSac;
            _repoHangSanXuat = repoHangSanXuat;
        }

        public AllRepositories<GiayChiTiet> _repoGCT;
        public AllRepositories<Giay> _repoG;
        public AllRepositories<DeGiay> _repoDeGiay;
        public AllRepositories<ThanGiay> _repoThanGiay;
        public AllRepositories<LoaiGiay> _repoLoaiGiay;
        public AllRepositories<MauSac> _repoMauSac;
        public AllRepositories<HangSanXuat> _repoHangSanXuat;
        private void ProductManager_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadComboBoxes();

            dgvSanPham.CellClick += dgvSanPham_CellContentClick;
        }
        public void LoadDGV(string searchName = "")
        {
            if (_repoG != null && _repoGCT != null)
            {
                var giayChiTietList = _repoGCT.GetAll();
                var giayList = _repoG.GetAll();
                var deGiayList = _repoDeGiay.GetAll();
                var thanGiayList = _repoThanGiay.GetAll();
                var loaiGiayList = _repoLoaiGiay.GetAll();
                var mauSacList = _repoMauSac.GetAll();
                var hangSanXuatList = _repoHangSanXuat.GetAll();
                // Perform the join using LINQ
                var result = (from gct in giayChiTietList
                              join g in giayList on gct.GiayId equals g.Id // Adjust 'GiayId' and 'Id' as per actual field names                       
                              join de in deGiayList on gct.DeGiayId equals de.Id
                              join than in thanGiayList on gct.ThanGiayId equals than.Id
                              join loai in loaiGiayList on g.LoaiGiayId equals loai.Id
                              join mau in mauSacList on gct.MauSacId equals mau.Id
                              join hang in hangSanXuatList on g.HangSanXuatId equals hang.Id
                              where gct.TrangThai == 1
                               && (string.IsNullOrEmpty(searchName) || gct.TenHang.Contains(searchName))
                              select new
                              {
                                  GiayChiTietId = gct.Id,
                                  TenHang = gct.TenHang,
                                  Gia = gct.Gia,
                                  SoLuong = gct.SoLuong,
                                  NgayNhanKho = gct.NgayNhanKho,
                                  BaoHang = gct.BaoHang,
                                  TrangThai = gct.TrangThai == 1 ? "Còn bán" : "Ngừng bán",
                                  MauSac = mau.TenMau,
                                  DeGiay = de.TenDe,
                                  ThanGiay = than.Ten,
                                  LoaiGiay = loai.TenLoai,
                                  HangSanXuat = hang.TenHang
                              }).ToList();
                dgvSanPham.DataSource = result;
            }
            else
            {
                MessageBox.Show("Repository chưa được khởi tạo.");
            }

        }
        private void LoadComboBoxes()
        {
            // Load dữ liệu cho ComboBox Đế Giày
            var deGiayList = _repoDeGiay.GetAll();
            deGiayList.Insert(0, new DeGiay { Id = Guid.Empty });  // Sử dụng Guid.Empty
            cboDeGiay.DataSource = deGiayList;
            cboDeGiay.DisplayMember = "TenDe";
            cboDeGiay.ValueMember = "Id";

            // Load dữ liệu cho ComboBox Thân Giày
            var thanGiayList = _repoThanGiay.GetAll();
            thanGiayList.Insert(0, new ThanGiay { Id = Guid.Empty });  // Sử dụng Guid.Empty
            cboThanGiay.DataSource = thanGiayList;
            cboThanGiay.DisplayMember = "Ten";
            cboThanGiay.ValueMember = "Id";

            // Load dữ liệu cho ComboBox Loại Giày
            var loaiGiayList = _repoLoaiGiay.GetAll();
            loaiGiayList.Insert(0, new LoaiGiay { Id = Guid.Empty });  // Sử dụng Guid.Empty
            cboLoaiGiay.DataSource = loaiGiayList;
            cboLoaiGiay.DisplayMember = "TenLoai";
            cboLoaiGiay.ValueMember = "Id";

            // Load dữ liệu cho ComboBox Màu Sắc
            var mauSacList = _repoMauSac.GetAll();
            mauSacList.Insert(0, new MauSac { Id = Guid.Empty });  // Sử dụng Guid.Empty
            cboMauSac.DataSource = mauSacList;
            cboMauSac.DisplayMember = "TenMau";
            cboMauSac.ValueMember = "Id";

            // Load dữ liệu cho ComboBox Hãng Sản Xuất
            var hangSanXuatList = _repoHangSanXuat.GetAll();
            hangSanXuatList.Insert(0, new HangSanXuat { Id = Guid.Empty });  // Sử dụng Guid.Empty
            cboHangSanXuat.DataSource = hangSanXuatList;
            cboHangSanXuat.DisplayMember = "TenHang";
            cboHangSanXuat.ValueMember = "Id";

        }


        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            try
            {

                var newGiay = new Giay
                {
                    Id = Guid.NewGuid(),
                    LoaiGiayId = (Guid)cboLoaiGiay.SelectedValue,
                    HangSanXuatId = (Guid)cboHangSanXuat.SelectedValue,
                    TrangThai = int.Parse(txtTrangThai.Text)
                };

                bool giayAdded = _repoG.Create(newGiay);
                if (!giayAdded)
                {
                    MessageBox.Show("Lỗi khi thêm sản phẩm.");
                    return;
                }

                var newGiayChiTiet = new GiayChiTiet
                {
                    Id = Guid.NewGuid(),
                    GiayId = newGiay.Id,
                    DeGiayId = (Guid)cboDeGiay.SelectedValue,
                    ThanGiayId = (Guid)cboThanGiay.SelectedValue,
                    MauSacId = (Guid)cboMauSac.SelectedValue,
                    TenHang = txtTenHang.Text,
                    BaoHang = txtBaoHanh.Text,
                    NgayNhanKho = dtpNgayNhapKho.Value,
                    Gia = decimal.Parse(txtGia.Text),
                    SoLuong = int.Parse(txtSoLuong.Text),
                    TrangThai = int.Parse(txtTrangThai.Text)
                };


                bool giayChiTietAdded = _repoGCT.Create(newGiayChiTiet);
                if (!giayChiTietAdded)
                {
                    MessageBox.Show("Lỗi khi thêm chi tiết sản phẩm.");
                    return;
                }

                MessageBox.Show("Thêm sản phẩm thành công.");

                LoadDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvSanPham.Rows[e.RowIndex];

                // Lấy thông tin từ dòng đã chọn và điền vào các trường nhập liệu
                txtTenHang.Text = selectedRow.Cells["TenHang"].Value.ToString();
                txtGia.Text = selectedRow.Cells["Gia"].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                txtBaoHanh.Text = selectedRow.Cells["BaoHang"].Value.ToString();
                dtpNgayNhapKho.Value = DateTime.Parse(selectedRow.Cells["NgayNhanKho"].Value.ToString());
                string trangThai = selectedRow.Cells["TrangThai"].Value.ToString();
                txtTrangThai.Text = trangThai == "Còn bán" ? "1" : "0"; // Gán số vào ô nhập
                txtTrangThai.ReadOnly = true;
                // Tìm item trong ComboBox dựa vào TenDe
                string tenDe = selectedRow.Cells["DeGiay"].Value.ToString();

                foreach (var item in cboDeGiay.Items)
                {
                    // Giả sử item là đối tượng với các thuộc tính `Id` và `TenDe`
                    if ((item as DeGiay)?.TenDe == tenDe)
                    {
                        cboDeGiay.SelectedItem = item;
                        break;
                    }
                }
                // Thiết lập giá trị cho ComboBox cboThanGiay dựa trên tên
                string tenThanGiay = selectedRow.Cells["ThanGiay"].Value.ToString();
                foreach (var item in cboThanGiay.Items)
                {
                    if ((item as ThanGiay)?.Ten == tenThanGiay)
                    {
                        cboThanGiay.SelectedItem = item;
                        break;
                    }
                }

                // Thiết lập giá trị cho ComboBox cboLoaiGiay dựa trên tên
                string tenLoaiGiay = selectedRow.Cells["LoaiGiay"].Value.ToString();
                foreach (var item in cboLoaiGiay.Items)
                {
                    if ((item as LoaiGiay)?.TenLoai == tenLoaiGiay)
                    {
                        cboLoaiGiay.SelectedItem = item;
                        break;
                    }
                }

                // Thiết lập giá trị cho ComboBox cboMauSac dựa trên tên
                string tenMauSac = selectedRow.Cells["MauSac"].Value.ToString();
                foreach (var item in cboMauSac.Items)
                {
                    if ((item as MauSac)?.TenMau == tenMauSac)
                    {
                        cboMauSac.SelectedItem = item;
                        break;
                    }
                }

                // Thiết lập giá trị cho ComboBox cboHangSanXuat dựa trên tên
                string tenHangSanXuat = selectedRow.Cells["HangSanXuat"].Value.ToString();
                foreach (var item in cboHangSanXuat.Items)
                {
                    if ((item as HangSanXuat)?.TenHang == tenHangSanXuat)
                    {
                        cboHangSanXuat.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvSanPham.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.");
                    return;
                }

                var selectedRow = dgvSanPham.SelectedRows[0];


                var giayChiTietIdValue = selectedRow.Cells["GiayChiTietId"].Value;

                if (giayChiTietIdValue == null || string.IsNullOrEmpty(giayChiTietIdValue.ToString()))
                {
                    MessageBox.Show("Giá trị 'GiayChiTietId' không hợp lệ.");
                    return;
                }

                if (Guid.TryParse(giayChiTietIdValue.ToString(), out Guid giayChiTietId))
                {

                    var giayChiTiet = _repoGCT.GetById(giayChiTietId);
                    if (giayChiTiet == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm cần sửa.");
                        return;
                    }

                    giayChiTiet.TenHang = txtTenHang.Text;
                    giayChiTiet.Gia = decimal.Parse(txtGia.Text);
                    giayChiTiet.SoLuong = int.Parse(txtSoLuong.Text);
                    giayChiTiet.BaoHang = txtBaoHanh.Text;
                    giayChiTiet.NgayNhanKho = dtpNgayNhapKho.Value;
                    giayChiTiet.TrangThai = int.Parse(txtTrangThai.Text);

                    giayChiTiet.DeGiayId = (Guid)cboDeGiay.SelectedValue;
                    giayChiTiet.ThanGiayId = (Guid)cboThanGiay.SelectedValue;
                    giayChiTiet.MauSacId = (Guid)cboMauSac.SelectedValue;


                    bool giayChiTietUpdated = _repoGCT.Update(giayChiTietId, giayChiTiet);
                    if (!giayChiTietUpdated)
                    {
                        MessageBox.Show("Lỗi khi sửa chi tiết sản phẩm.");
                        return;
                    }


                    var giay = _repoG.GetById(giayChiTiet.GiayId);
                    if (giay != null)
                    {
                        giay.LoaiGiayId = (Guid)cboLoaiGiay.SelectedValue;
                        giay.HangSanXuatId = (Guid)cboHangSanXuat.SelectedValue;
                        giay.TrangThai = int.Parse(txtTrangThai.Text);


                        bool giayUpdated = _repoG.Update(giay.Id, giay);
                        if (!giayUpdated)
                        {
                            MessageBox.Show("Lỗi khi cập nhật sản phẩm chính.");
                            return;
                        }
                    }


                    MessageBox.Show("Sửa sản phẩm thành công.");
                    LoadDGV();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btnVoHieu_Click(object sender, EventArgs e)
        {

            try
            {
                // Kiểm tra nếu không có sản phẩm nào được chọn
                if (dgvSanPham.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần vô hiệu.");
                    return;
                }

                // Lấy dòng dữ liệu của sản phẩm đã chọn
                var selectedRow = dgvSanPham.SelectedRows[0];

                // Lấy giá trị GiayChiTietId từ dòng đã chọn
                var giayChiTietIdValue = selectedRow.Cells["GiayChiTietId"].Value;

                // Kiểm tra giá trị GiayChiTietId có hợp lệ không
                if (giayChiTietIdValue == null || string.IsNullOrEmpty(giayChiTietIdValue.ToString()))
                {
                    MessageBox.Show("Giá trị 'GiayChiTietId' không hợp lệ.");
                    return;
                }

                // Kiểm tra nếu GiayChiTietId có thể chuyển đổi thành Guid
                if (Guid.TryParse(giayChiTietIdValue.ToString(), out Guid giayChiTietId))
                {
                    // Lấy chi tiết sản phẩm từ repository
                    var giayChiTiet = _repoGCT.GetById(giayChiTietId);
                    if (giayChiTiet == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm cần vô hiệu.");
                        return;
                    }

                    // Cập nhật trạng thái của sản phẩm (Ngừng bán)
                    giayChiTiet.TrangThai = 0;

                    // Cập nhật sản phẩm trong repository
                    bool giayChiTietUpdated = _repoGCT.Update(giayChiTietId, giayChiTiet);
                    if (!giayChiTietUpdated)
                    {
                        MessageBox.Show("Lỗi khi vô hiệu sản phẩm.");
                        return;
                    }

                    // Thông báo thành công và tải lại DataGridView
                    MessageBox.Show("Trạng thái sản phẩm đã được cập nhật thành: Ngừng bán");

                    // Tải lại DataGridView, nhưng ẩn sản phẩm đã vô hiệu
                    LoadDGV();
                }
                else
                {
                    MessageBox.Show("ID sản phẩm không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            string searchName = txtTimKiemSanPham.Text.Trim(); // Lấy giá trị tìm kiếm từ TextBox
            LoadDGV(searchName);  // Gọi lại phương thức LoadDGV với tên tìm kiếm
        }
        private void ClearForm()
        {
            // Xóa dữ liệu trong các TextBox
            txtTenHang.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
            txtBaoHanh.Clear();
            txtTrangThai.Clear();
            txtTimKiemSanPham.Clear();
            // Đặt lại giá trị ComboBox về giá trị mặc định hoặc không chọn
            cboDeGiay.SelectedIndex = -1; // -1 là giá trị "Không có lựa chọn"
            cboThanGiay.SelectedIndex = -1;
            cboLoaiGiay.SelectedIndex = -1;
            cboMauSac.SelectedIndex = -1;
            cboHangSanXuat.SelectedIndex = -1;
            
            // Đặt lại giá trị cho DateTimePicker về ngày hiện tại
            dtpNgayNhapKho.Value = DateTime.Now;

            // Nếu bạn muốn làm mới lại các CheckBox, RadioButton, hoặc các trường nhập liệu khác, cũng có thể làm như sau:
            // chkOption.Checked = false; // Ví dụ cho CheckBox
            // rbtnOption.Checked = false; // Ví dụ cho RadioButton
            LoadDGV();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
