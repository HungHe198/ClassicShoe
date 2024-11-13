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
        }
        public void LoadDGV()
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
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("Repository chưa được khởi tạo.");
            }

        }
        private void LoadComboBoxes()
        {
            // Load dữ liệu cho ComboBox Đế Giày
            cboDeGiay.DataSource = _repoDeGiay.GetAll();
            cboDeGiay.DisplayMember = "TenDe";
            cboDeGiay.ValueMember = "Id";

            // Load dữ liệu cho ComboBox Thân Giày
            cboThanGiay.DataSource = _repoThanGiay.GetAll();
            cboThanGiay.DisplayMember = "Ten";
            cboThanGiay.ValueMember = "Id";

            // Load dữ liệu cho ComboBox Loại Giày
            cboLoaiGiay.DataSource = _repoLoaiGiay.GetAll();
            cboLoaiGiay.DisplayMember = "TenLoai";
            cboLoaiGiay.ValueMember = "Id";

            // Load dữ liệu cho ComboBox Màu Sắc
            cboMauSac.DataSource = _repoMauSac.GetAll();
            cboMauSac.DisplayMember = "TenMau";
            cboMauSac.ValueMember = "Id";

            // Load dữ liệu cho ComboBox Hãng Sản Xuất
            cboHangSanXuat.DataSource = _repoHangSanXuat.GetAll();
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
    }
}
