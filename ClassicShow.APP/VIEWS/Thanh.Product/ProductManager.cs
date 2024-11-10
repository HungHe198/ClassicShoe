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




        public ProductManager(AllRepositories<GiayChiTiet> repoGCT, AllRepositories<Giay> repoG)
        {
            InitializeComponent();
            _repoGCT = repoGCT;
            _repoG = repoG;
        }

        public AllRepositories<GiayChiTiet> _repoGCT;
        public AllRepositories<Giay> _repoG;
        private void ProductManager_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        public void LoadDGV()
        {
            if (_repoG != null && _repoGCT != null)
            {
                var giayChiTietList = _repoGCT.GetAll();
                var giayList = _repoG.GetAll();

                // Perform the join using LINQ
                var result = (from gct in giayChiTietList
                              join g in giayList on gct.GiayId equals g.Id // Adjust 'GiayId' and 'Id' as per actual field names

                              select new
                              {
                                  GiayChiTietId = gct.Id,
                                  TenHang = gct.TenHang,
                                  Gia = gct.Gia,
                                  SoLuong = gct.SoLuong,
                                  GiayId = g.Id,
                                  LoaiGiayId = g.LoaiGiayId,
                                  HangSanXuatId = g.HangSanXuatId,
                                  TrangThaiGiayChiTiet = gct.TrangThai,
                                  TrangThaiGiay = g.TrangThai
                              }).ToList();
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("Repository chưa được khởi tạo.");
            }

        }
    }
}
