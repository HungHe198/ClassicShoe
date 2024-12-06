﻿using ClassicShoe.DATA.Models;
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
    public partial class Order : Form
    {

        public Order(AllRepositories<HoaDon> repoHoaDon)
        {
            InitializeComponent();
            _repoHoaDon = repoHoaDon;
        }

        public AllRepositories<HoaDon> _repoHoaDon;
        public AllRepositories<KhachHang> _repoKH = new AllRepositories<KhachHang>(new ClassicShoeDbContext());
        public AllRepositories<Admin> _repoAD = new AllRepositories<Admin>(new ClassicShoeDbContext());
        public AllRepositories<NhanVien> _repoNV = new AllRepositories<NhanVien>(new ClassicShoeDbContext());


        private void Order_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        //public void LoadDGV(int Status) { 


        //}
        public void LoadDGV()
        {

            if (_repoHoaDon != null)
            {
                var result = from hd in _repoHoaDon.GetAll()
                             let admin = _repoAD.GetAll().FirstOrDefault(x => x.Id == hd.AdminId)
                             let nhanVien = _repoNV.GetAll().FirstOrDefault(x => x.Id == hd.NhanVienId)
                             orderby hd.NgayTaoHoaDon descending
                             select new
                             {
                                 TenNguoiPhuTrach = admin != null ? admin.TaiKhoan : nhanVien != null ? nhanVien.TenNhanVien : "Không xác định",
                                 TenKhachHang = _repoKH.GetAll().FirstOrDefault(x => x.Id == hd.KhachHangId)?.TenKhachHang,
                                 GiaTriHoaDon = hd.ThanhTien,
                                 NgayTao = hd.NgayTaoHoaDon,
                                 TrangThai = hd.Status switch
                                 {
                                     0 => "Đã thanh toán",
                                     1 => "Đang xử lí",
                                     2 => "Đã hủy",
                                     _ => "Không xác định"
                                 }
                             };
                dgv_HoaDon.DataSource = result.ToList();
            }
            else
            {
                MessageBox.Show("Repository chưa được khởi tạo.");
            }

        }

        private void dgv_HoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
