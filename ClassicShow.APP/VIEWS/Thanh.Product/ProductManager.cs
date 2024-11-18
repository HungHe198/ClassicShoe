using ClassicShoe.DATA.Migrations;
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
            dgvSanPham.Columns["Gia"].DefaultCellStyle.Format = "N0";
            dgvSanPham.CellClick += dgvSanPham_CellContentClick;
            dtpNgayNhapKho.Enabled = false;
        }
        public void LoadDGV(string searchName = "", int? trangThai = null)
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

                var result = (from gct in giayChiTietList
                              join g in giayList on gct.GiayId equals g.Id
                              join de in deGiayList on gct.DeGiayId equals de.Id
                              join than in thanGiayList on gct.ThanGiayId equals than.Id
                              join loai in loaiGiayList on g.LoaiGiayId equals loai.Id
                              join mau in mauSacList on gct.MauSacId equals mau.Id
                              join hang in hangSanXuatList on g.HangSanXuatId equals hang.Id
                              where (string.IsNullOrEmpty(searchName) || gct.TenHang.Contains(searchName)) &&
                              (!trangThai.HasValue || gct.TrangThai == trangThai.Value)
                              orderby gct.NgayNhanKho descending
                              select new
                              {
                                  GiayChiTietId = gct.Id,
                                  TenHang = gct.TenHang,
                                  Gia = gct.Gia.ToString("N0", new System.Globalization.CultureInfo("vi-VN")),
                                  SoLuong = gct.SoLuong,
                                  NgayNhanKho = gct.NgayNhanKho,
                                  BaoHang = gct.BaoHang,
                                  TrangThai = gct.TrangThai == 1 ? "Còn bán" : "Ngừng bán",
                                  MauSac = mau.TenMau,
                                  DeGiay = de.TenDe,
                                  ThanGiay = than.Ten,
                                  LoaiGiay = loai.TenLoai,
                                  HangSanXuat = hang.TenHang,

                              }).ToList();
                if (!trangThai.HasValue)
                {
                    result = result.Where(r => r.TrangThai == "Còn bán").ToList();
                }


                dgvSanPham.DataSource = result;
            }
            else
            {
                MessageBox.Show("Repository chưa được khởi tạo.");
            }

        }
        private void LoadComboBoxes()
        {

            var deGiayList = _repoDeGiay.GetAll();
            deGiayList.Insert(0, new DeGiay { Id = Guid.Empty });
            cboDeGiay.DataSource = deGiayList;
            cboDeGiay.DisplayMember = "TenDe";
            cboDeGiay.ValueMember = "Id";


            var thanGiayList = _repoThanGiay.GetAll();
            thanGiayList.Insert(0, new ThanGiay { Id = Guid.Empty });
            cboThanGiay.DataSource = thanGiayList;
            cboThanGiay.DisplayMember = "Ten";
            cboThanGiay.ValueMember = "Id";


            var loaiGiayList = _repoLoaiGiay.GetAll();
            loaiGiayList.Insert(0, new LoaiGiay { Id = Guid.Empty });
            cboLoaiGiay.DataSource = loaiGiayList;
            cboLoaiGiay.DisplayMember = "TenLoai";
            cboLoaiGiay.ValueMember = "Id";


            var mauSacList = _repoMauSac.GetAll();
            mauSacList.Insert(0, new MauSac { Id = Guid.Empty });
            cboMauSac.DataSource = mauSacList;
            cboMauSac.DisplayMember = "TenMau";
            cboMauSac.ValueMember = "Id";


            var hangSanXuatList = _repoHangSanXuat.GetAll();
            hangSanXuatList.Insert(0, new HangSanXuat { Id = Guid.Empty });
            cboHangSanXuat.DataSource = hangSanXuatList;
            cboHangSanXuat.DisplayMember = "TenHang";
            cboHangSanXuat.ValueMember = "Id";

            var trangThaiItems = new List<KeyValuePair<int, string>>
            {
            new KeyValuePair<int, string>(1, "1"),
             new KeyValuePair<int, string>(0, "0")
            };

            cboTrangThai.DataSource = trangThaiItems;
            cboTrangThai.DisplayMember = "Value";
            cboTrangThai.ValueMember = "Key";
            cboTrangThai.SelectedIndex = -1;
        }


        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtTenHang.Text) ||
                    string.IsNullOrEmpty(txtGia.Text) ||
                    string.IsNullOrEmpty(txtSoLuong.Text) ||
                    string.IsNullOrEmpty(txtBaoHanh.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                if (!decimal.TryParse(txtGia.Text, out decimal gia))
                {
                    MessageBox.Show("Giá phải là số");
                    return;
                }
                if (gia <= 0)
                {
                    MessageBox.Show("Giá phải lớn hơn 0.");
                    return;
                }

                if (!int.TryParse(txtSoLuong.Text, out int soLuong))
                {
                    MessageBox.Show("Số lượng phải là số.");
                    return;
                }
                if (soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0.");
                    return;
                }


                if (cboLoaiGiay.SelectedItem == null || cboHangSanXuat.SelectedItem == null ||
                    cboDeGiay.SelectedItem == null || cboThanGiay.SelectedItem == null || cboMauSac.SelectedItem == null ||
                    cboTrangThai.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin.");
                    return;
                }

                int trangThai = ((KeyValuePair<int, string>)cboTrangThai.SelectedItem).Key;
                decimal Gia = decimal.Parse(txtGia.Text);
                int SoLuong = int.Parse(txtSoLuong.Text);

                var newGiay = new Giay
                {
                    Id = Guid.NewGuid(),
                    LoaiGiayId = (Guid)cboLoaiGiay.SelectedValue,
                    HangSanXuatId = (Guid)cboHangSanXuat.SelectedValue,
                    TrangThai = trangThai
                };

                bool giayAdded = _repoG.Create(newGiay);
                if (!giayAdded)
                {
                    MessageBox.Show("Thêm sản phẩm không thành công.");
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
                    TrangThai = trangThai
                };

                bool giayChiTietAdded = _repoGCT.Create(newGiayChiTiet);
                if (!giayChiTietAdded)
                {
                    MessageBox.Show("Thêm chi tiết sản phẩm không thành công.");
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


                txtTenHang.Text = selectedRow.Cells["TenHang"].Value.ToString();
                txtGia.Text = selectedRow.Cells["Gia"].Value.ToString();

                txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                txtBaoHanh.Text = selectedRow.Cells["BaoHang"].Value.ToString();
                dtpNgayNhapKho.Value = DateTime.Parse(selectedRow.Cells["NgayNhanKho"].Value.ToString());
                int trangThai = selectedRow.Cells["TrangThai"].Value.ToString() == "Còn bán" ? 1 : 0;
                cboTrangThai.SelectedValue = trangThai;



                string tenDe = selectedRow.Cells["DeGiay"].Value.ToString();

                foreach (var item in cboDeGiay.Items)
                {

                    if ((item as DeGiay)?.TenDe == tenDe)
                    {
                        cboDeGiay.SelectedItem = item;
                        break;
                    }
                }

                string tenThanGiay = selectedRow.Cells["ThanGiay"].Value.ToString();
                foreach (var item in cboThanGiay.Items)
                {
                    if ((item as ThanGiay)?.Ten == tenThanGiay)
                    {
                        cboThanGiay.SelectedItem = item;
                        break;
                    }
                }


                string tenLoaiGiay = selectedRow.Cells["LoaiGiay"].Value.ToString();
                foreach (var item in cboLoaiGiay.Items)
                {
                    if ((item as LoaiGiay)?.TenLoai == tenLoaiGiay)
                    {
                        cboLoaiGiay.SelectedItem = item;
                        break;
                    }
                }


                string tenMauSac = selectedRow.Cells["MauSac"].Value.ToString();
                foreach (var item in cboMauSac.Items)
                {
                    if ((item as MauSac)?.TenMau == tenMauSac)
                    {
                        cboMauSac.SelectedItem = item;
                        break;
                    }
                }


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
                    MessageBox.Show("Không thể xác định sản phẩm cần sửa.");
                    return;
                }

                if (Guid.TryParse(giayChiTietIdValue.ToString(), out Guid giayChiTietId))
                {

                    if (string.IsNullOrEmpty(txtTenHang.Text) ||
                        string.IsNullOrEmpty(txtGia.Text) ||
                        string.IsNullOrEmpty(txtSoLuong.Text) ||
                        string.IsNullOrEmpty(txtBaoHanh.Text))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                        return;
                    }


                    if (!decimal.TryParse(txtGia.Text, out decimal gia))
                    {
                        MessageBox.Show("Giá phải là số.");
                        return;
                    }
                    if (gia <= 0)
                    {
                        MessageBox.Show("Giá phải lớn hơn 0.");
                        return;
                    }


                    if (!int.TryParse(txtSoLuong.Text, out int soLuong))
                    {
                        MessageBox.Show("Số lượng phải là số");
                        return;
                    }
                    if (soLuong <= 0)
                    {
                        MessageBox.Show("Giá phải lớn hơn 0.");
                        return;
                    }

                    if (cboLoaiGiay.SelectedItem == null || cboHangSanXuat.SelectedItem == null ||
                        cboDeGiay.SelectedItem == null || cboThanGiay.SelectedItem == null || cboMauSac.SelectedItem == null ||
                        cboTrangThai.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn đầy đủ thông tin.");
                        return;
                    }

                    var giayChiTiet = _repoGCT.GetById(giayChiTietId);
                    if (giayChiTiet == null)
                    {
                        MessageBox.Show("Sản phẩm chi tiết không tồn tại.");
                        return;
                    }


                    giayChiTiet.TenHang = txtTenHang.Text;
                    giayChiTiet.Gia = decimal.Parse(txtGia.Text);
                    giayChiTiet.SoLuong = int.Parse(txtSoLuong.Text);
                    giayChiTiet.BaoHang = txtBaoHanh.Text;
                    giayChiTiet.NgayNhanKho = dtpNgayNhapKho.Value;
                    if (cboTrangThai.SelectedItem.ToString() != giayChiTiet.TrangThai.ToString() || cboTrangThai.SelectedIndex != 1)
                    {
                        giayChiTiet.TrangThai = cboTrangThai.SelectedItem.ToString() == "Còn bán" ? 1 : 1;
                        MessageBox.Show("không thể thay đổi trạng thái");
                        ClearForm();

                    }
                    else
                    {
                        giayChiTiet.DeGiayId = (Guid)cboDeGiay.SelectedValue;
                        giayChiTiet.ThanGiayId = (Guid)cboThanGiay.SelectedValue;
                        giayChiTiet.MauSacId = (Guid)cboMauSac.SelectedValue;


                        bool giayChiTietUpdated = _repoGCT.Update(giayChiTietId, giayChiTiet);
                        if (!giayChiTietUpdated)
                        {
                            MessageBox.Show("Cập nhật sản phẩm chi tiết không thành công.");
                            return;
                        }


                        var giay = _repoG.GetById(giayChiTiet.GiayId);
                        if (giay != null)
                        {
                            giay.LoaiGiayId = (Guid)cboLoaiGiay.SelectedValue;
                            giay.HangSanXuatId = (Guid)cboHangSanXuat.SelectedValue;
                            if (cboTrangThai.SelectedItem.ToString() != giayChiTiet.TrangThai.ToString())
                            {
                                giayChiTiet.TrangThai = cboTrangThai.SelectedItem.ToString() == "Còn bán" ? 1 : 1;

                            }

                            bool giayUpdated = _repoG.Update(giay.Id, giay);
                            if (!giayUpdated)
                            {
                                MessageBox.Show("Cập nhật sản phẩm không thành công.");
                                return;
                            }
                        }

                        MessageBox.Show("Sửa sản phẩm thành công.");
                    }    
                    LoadDGV();
                }
                else
                {
                    MessageBox.Show("Dữ liệu sản phẩm không hợp lệ.");
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

                if (dgvSanPham.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần vô hiệu.");
                    return;
                }


                var selectedRow = dgvSanPham.SelectedRows[0];


                var giayChiTietIdValue = selectedRow.Cells["GiayChiTietId"].Value;


                if (giayChiTietIdValue == null || string.IsNullOrEmpty(giayChiTietIdValue.ToString()))
                {
                    MessageBox.Show("");
                    return;
                }


                if (Guid.TryParse(giayChiTietIdValue.ToString(), out Guid giayChiTietId))
                {

                    var giayChiTiet = _repoGCT.GetById(giayChiTietId);
                    if (giayChiTiet == null)
                    {
                        MessageBox.Show("");
                        return;
                    }



                    int currentStatus = giayChiTiet.TrangThai;


                    giayChiTiet.TrangThai = (currentStatus == 1) ? 0 : 1;


                    bool giayChiTietUpdated = _repoGCT.Update(giayChiTietId, giayChiTiet);
                    if (!giayChiTietUpdated)
                    {
                        MessageBox.Show("");
                        return;
                    }



                    string newStatus = giayChiTiet.TrangThai == 1 ? "Còn bán" : "Ngừng bán";
                    MessageBox.Show($"Trạng thái sản phẩm đã được cập nhật thành: {newStatus}");

                    LoadDGV();
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            string searchName = txtTimKiemSanPham.Text.Trim();

            if (string.IsNullOrEmpty(searchName))
            {

                MessageBox.Show("Vui lòng nhập tên sản phẩm cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadDGV(searchName);

            if (dgvSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm với tên đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV();
            }
        }
        private void ClearForm()
        {

            txtTenHang.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
            txtBaoHanh.Clear();
            cboTrangThai.SelectedIndex = -1;

            txtTimKiemSanPham.Clear();

            cboDeGiay.SelectedIndex = -1;
            cboThanGiay.SelectedIndex = -1;
            cboLoaiGiay.SelectedIndex = -1;
            cboMauSac.SelectedIndex = -1;
            cboHangSanXuat.SelectedIndex = -1;


            dtpNgayNhapKho.Value = DateTime.Now;


            LoadDGV();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void locSanPham_Click(object sender, EventArgs e)
        {


            int? trangThai = null;


            if (cboTrangThai.SelectedItem != null)
            {
                var selectedItem = (KeyValuePair<int, string>)cboTrangThai.SelectedItem;
                trangThai = selectedItem.Key;
            }
            else
            {

                MessageBox.Show("Vui lòng chọn trạng thái để lọc sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadDGV("", trangThai);
        }

        private void btn_addMau_Click(object sender, EventArgs e)
        {

        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
