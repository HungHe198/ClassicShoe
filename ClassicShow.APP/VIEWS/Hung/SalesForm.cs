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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicShoe.APP.VIEWS.Hung
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }
        HoaDonServices _sv = new HoaDonServices();


        // để tạm thôi đấy
        // sau sẽ lưu id vào một file và lấy dữ liệu chung tại đó

        // sau sẽ lưu id vào một file và lấy dữ liệu chung tại đó
        AllRepositories<HoaDon> _repoHD = new AllRepositories<HoaDon>(new ClassicShoeDbContext());
        AllRepositories<HoaDonChiTiet> _repoHDCT = new AllRepositories<HoaDonChiTiet>(new ClassicShoeDbContext());
        AllRepositories<GiayChiTiet> _repoGCT = new AllRepositories<GiayChiTiet>(new ClassicShoeDbContext());
        AllRepositories<Giay> _repoG = new AllRepositories<Giay>(new ClassicShoeDbContext());
        AllRepositories<DeGiay> _repoDeGiay = new AllRepositories<DeGiay>(new ClassicShoeDbContext());
        AllRepositories<ThanGiay> _repoThanGiay = new AllRepositories<ThanGiay>(new ClassicShoeDbContext());
        AllRepositories<LoaiGiay> _repoLoaiGiay = new AllRepositories<LoaiGiay>(new ClassicShoeDbContext());
        AllRepositories<MauSac> _repoMauSac = new AllRepositories<MauSac>(new ClassicShoeDbContext());
        AllRepositories<HangSanXuat> _repoHangSanXuat = new AllRepositories<HangSanXuat>(new ClassicShoeDbContext());
        AllRepositories<KhachHang> _repoKH = new AllRepositories<KhachHang>(new ClassicShoeDbContext());

        private void SalesForm_Load(object sender, EventArgs e)
        {
            txt_tienKhachDua.Text = "";
            loadCBO_HD(1);
            LoadHDCT(GlobalVariable.IdHD);
            LoadSanPham();

        }
        public void loadCBO_HD(int status)
        {
            LoadHDCT(GlobalVariable.IdHD);
            var lstHD = _repoHD.GetAll().Where(x => x.Status == status);
            cbo_HoaDon.DataSource = lstHD.ToList();
            cbo_HoaDon.DisplayMember = "InvoiceCode";
            cbo_HoaDon.ValueMember = "Id";
            cbo_HoaDon.DropDownStyle = ComboBoxStyle.DropDownList;

            // tính tiền của tổng hóa đơn


        }
        public void LoadSanPham(string searchName = "", int? trangThai = null)
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
                                  Gia = gct.Gia.ToString(), // "N0", new System.Globalization.CultureInfo("vi-VN")
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


                dgv_SanPham.DataSource = result;
            }
            else
            {
                MessageBox.Show("Repository chưa được khởi tạo.");
            }

        }

        public void LoadHDCT(Guid? idHD)
        {
            var result = from h in _repoHD.GetAll()
                         join hct in _repoHDCT.GetAll() on h.Id equals hct.HoaDonId
                         join gct in _repoGCT.GetAll() on hct.GiayChiTietId equals gct.Id
                         where h.Id == idHD && h.Status == 1
                         select new
                         {
                             HoaDonId = h.Id,
                             InvoiceCode = h.InvoiceCode,
                             NgayTaoHoaDon = h.NgayTaoHoaDon,
                             TenSanPham = gct.TenHang,
                             SoLuong = hct.SoLuong,
                             DonGia = hct.DonGia,
                             ThanhTien = hct.DonGia * hct.SoLuong
                         };
            dgv_HDCT.DataSource = result.ToList();
            decimal tongHD = 0;


            foreach (var h in result)
            {
                tongHD += h.SoLuong * h.DonGia;

            }
            decimal giamGia = 0;
            decimal thanhTien = tongHD - giamGia;
            decimal khachDua = 0;
            if (!string.IsNullOrEmpty(txt_tienKhachDua.Text))
            {
                decimal number;
                if (decimal.TryParse(txt_tienKhachDua.Text, out number))
                {
                    khachDua = Convert.ToDecimal(txt_tienKhachDua.Text);
                }
                else
                {
                }
            }
            else
            {
                Console.WriteLine("Chuỗi đầu vào trống hoặc null.");
            }
            decimal traKhach = khachDua - thanhTien;

            lb_TongHoaDon.Text = tongHD.ToString();
            lb_TienDuocGiam.Text = giamGia.ToString();
            lb_ThanhTien.Text = thanhTien.ToString();
            lb_traKhach.Text = traKhach.ToString();
            txt_tienKhachDua.Text = khachDua.ToString();

        }
        private void btn_addOrder_Click(object sender, EventArgs e)
        { // tạo hóa đơn trống và có thể sử dụng
            if (GlobalVariable.MaVaiTro != "ADMIN")
            {
                var defaultGuid = new Guid("11111111-1111-1111-1111-111111111111");
                HoaDon hoaDon = new HoaDon()
                {
                    Id = Guid.NewGuid(),
                    InvoiceCode = $"INV-{DateTime.Now:yyyyMMddHHmmss}",
                    KhachHangId = GlobalVariable.CustomerId,
                    MaGiamGiaId = defaultGuid,
                    NgayTaoHoaDon = DateTime.Now,
                    NhanVienId = GlobalVariable.UserId,
                    PhuongThucThanhToan = "Tại quầy",
                    Status = 1,
                    ThanhTien = 0,
                };
                GlobalVariable.IdHD = hoaDon.Id;
                MessageBox.Show(_sv.CreateOrder(hoaDon));
                loadCBO_HD(1);

            }
            else
            {
                var defaultGuid = new Guid("11111111-1111-1111-1111-111111111111");
                HoaDon hoaDon = new HoaDon()
                {
                    Id = Guid.NewGuid(),
                    InvoiceCode = $"INV-{DateTime.Now:yyyyMMddHHmmss}",
                    KhachHangId = GlobalVariable.CustomerId,
                    MaGiamGiaId = defaultGuid,
                    NgayTaoHoaDon = DateTime.Now,
                    AdminId = GlobalVariable.UserId,
                    PhuongThucThanhToan = "Tại quầy",
                    Status = 1,
                    ThanhTien = 0,
                };
                GlobalVariable.IdHD = hoaDon.Id;
                MessageBox.Show(_sv.CreateOrder(hoaDon));
                loadCBO_HD(1);
            }

        }

        private void txt_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            //try
            //{

            // Lấy giá trị từ TextBox
            string input = txt_PhoneNumber.Text;

            // Kiểm tra nếu đủ 10 ký tự và tất cả đều là số
            if (input.Length == 10 && input.All(char.IsDigit))
            {
                // Gọi phương thức tìm kiếm từ _repo
                string customerId = _sv.FindCustomerByPhone(input);

                if (customerId != null && customerId != "false")
                {
                    // có tồn tại thì cho hiển thị tên và tạo hóa đơn
                    txt_NameCustomer.Text = _sv.FindCustomerById(Guid.Parse(customerId)).TenKhachHang.ToString();
                    GlobalVariable.CustomerId = Guid.Parse(customerId);

                }
                else
                {
                    {

                        MessageBox.Show("Không tồn tại khách hàng này!\nBạn có muốn tạo mới", "Lỗi", MessageBoxButtons.YesNoCancel);

                        // có thì tạo mới không thì thôi
                        //if ()
                        //{

                        //}
                    }
                }


            }
            else if (input.Length > 10 || !(input.All(char.IsDigit)))
            {

                MessageBox.Show("Làm gì có má ơi", "Lỗi", MessageBoxButtons.OKCancel);
                txt_NameCustomer.Text = "";
                txt_PhoneNumber.Text = "";
            }
            //} 
            //catch (Exception ex) {
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_SanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv_SanPham.Rows[e.RowIndex].DataBoundItem == null)
            {
                MessageBox.Show("Không có dữ liệu để thêm.");
                return;
            }
            var selectedRow = dgv_SanPham.Rows[e.RowIndex].DataBoundItem;
            var Id_GCT = dgv_SanPham.Rows[e.RowIndex].Cells["GiayChiTietId"].Value;

            var giayCT = _repoGCT.GetById(Guid.Parse(Id_GCT.ToString()));


            var DonGia = dgv_SanPham.Rows[e.RowIndex].Cells["Gia"].Value;
            var SoLuongConLai = Convert.ToInt32(dgv_SanPham.Rows[e.RowIndex].Cells["SoLuong"].Value);
            // Ép kiểu về kiểu dữ liệu phù hợp

            // tạo mới hdct
            // kiểm tra xem hóa đơn chi tiết có chưa
            // kiểm tra xem ô chứa số lượng đã tồn tại dữ liệu chưa và trừ số lượng nếu có
            if (string.IsNullOrEmpty(txt_SLMua.Text)
                || txt_SLMua.Text == "0"
                || !int.TryParse(txt_SLMua.Text, out int soLuong)
                || soLuong <= 0
                || SoLuongConLai - soLuong < 0)
            {
                // Xử lý nếu điều kiện không hợp lệ
                MessageBox.Show("Số lượng mua không hợp lệ. \nVui lòng nhập một số nguyên dương nhỏ hơn hoặc bằng số lượng sản phẩm còn lại.");
            }
            else
            {
                //bool isExist = true;
                //var lstGCT = _repoHDCT.GetAll().Where(hdct => hdct.GiayChiTietId == Guid.Parse(Id_GCT.ToString()) && hdct.HoaDonId == GlobalVariable.IdHD);
                //if ( lstGCT.ToList() != null)
                //{
                //    isExist = true;
                //}   
                //else { isExist = false; }
                //MessageBox.Show(isExist.ToString());
                //if (!isExist)
                //{


                //    HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet()
                //    {
                //        Id = Guid.NewGuid(),
                //        HoaDonId = GlobalVariable.IdHD,
                //        GiayChiTietId = Guid.Parse(Id_GCT.ToString()),
                //        DonGia = Convert.ToDecimal(DonGia),
                //        SoLuong = Convert.ToInt32(txt_SLMua.Text),
                //    };

                //    MessageBox.Show("Thêm", _repoHDCT.Create(hoaDonChiTiet).ToString());
                //    // tru so luong
                //    giayCT.SoLuong = giayCT.SoLuong - Convert.ToInt32(txt_SLMua.Text);
                //    _repoGCT.Update(giayCT.Id, giayCT);

                //}
                //else
                //{

                //    // bị trùng
                //    var hdctFind = _repoHDCT.GetAll().FirstOrDefault(x => x.HoaDonId == GlobalVariable.IdHD && x.GiayChiTietId == Guid.Parse(Id_GCT.ToString()));
                //    if (hdctFind != null)
                //    {
                //        hdctFind.SoLuong += soLuong;

                //        MessageBox.Show("Thêm", _repoHDCT.Update(hdctFind.Id, hdctFind).ToString());
                //    }
                //}
                bool isExist = true;
                var lstSP = from hd in _repoHD.GetAll()
                            join hdct in _repoHDCT.GetAll()
                            on hd.Id equals hdct.HoaDonId
                            where hd.Id == GlobalVariable.IdHD
                            select
                            new
                            {
                                IdHD = hd.Id,
                                IdHDCT = hdct.Id,
                                IdGiayCT = hdct.GiayChiTietId,
                                SoLuong = hdct.SoLuong,
                            };
                foreach (var item in lstSP)
                {

                    if (Guid.Parse(Id_GCT.ToString()) == item.IdGiayCT)
                    {
                        isExist = false;
                        break;
                    }

                }



                if (!isExist)
                {
                    var hdctFind = _repoHDCT.GetAll().FirstOrDefault(x => x.HoaDonId == GlobalVariable.IdHD && x.GiayChiTietId == Guid.Parse(Id_GCT.ToString()));
                    if (hdctFind != null)
                    {
                        hdctFind.SoLuong += soLuong;

                        MessageBox.Show("Thêm", _repoHDCT.Update(hdctFind.Id, hdctFind).ToString());
                    }
                    giayCT.SoLuong = giayCT.SoLuong - Convert.ToInt32(txt_SLMua.Text);
                    _repoGCT.Update(giayCT.Id, giayCT);
                }
                else
                {
                    HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet()
                    {
                        Id = Guid.NewGuid(),
                        HoaDonId = GlobalVariable.IdHD,
                        GiayChiTietId = Guid.Parse(Id_GCT.ToString()),
                        DonGia = Convert.ToDecimal(DonGia),
                        SoLuong = Convert.ToInt32(txt_SLMua.Text),

                    };

                    MessageBox.Show("Thêm" + _repoHDCT.Create(hoaDonChiTiet).ToString());
                    // tru so luong
                    giayCT.SoLuong = giayCT.SoLuong - Convert.ToInt32(txt_SLMua.Text);
                    _repoGCT.Update(giayCT.Id, giayCT);
                }

            }


            LoadHDCT(GlobalVariable.IdHD);
            LoadSanPham();
        }

        private void cbo_HoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_HoaDon.SelectedValue != null && Guid.TryParse(cbo_HoaDon.SelectedValue.ToString(), out Guid idHD))
            {
                GlobalVariable.IdHD = idHD;
                LoadHDCT(GlobalVariable.IdHD); // Gọi hàm để load danh sách hóa đơn chi tiết

                HoaDon hoaDonFind = _repoHD.GetById(idHD);
                if (hoaDonFind.KhachHangId != null)
                {

                    GlobalVariable.khachHangNow = _repoKH.GetById(hoaDonFind.KhachHangId.Value);
                    txt_NameCustomer.Text = GlobalVariable.khachHangNow.TenKhachHang.ToString();
                    txt_PhoneNumber.Text = GlobalVariable.khachHangNow.SoDienThoai.ToString();
                }

            }


        }
        public void TinhTien()
        {

        }
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (cbo_HoaDon.SelectedValue != null && Guid.TryParse(cbo_HoaDon.SelectedValue.ToString(), out Guid idHD))
            {
                GlobalVariable.IdHD = idHD;
                LoadHDCT(GlobalVariable.IdHD); // Gọi hàm để load danh sách hóa đơn chi tiết

                HoaDon hoaDonFind = _repoHD.GetById(idHD);
                if (hoaDonFind.KhachHangId != null)
                {
                    hoaDonFind.Status = 0;
                    hoaDonFind.ThanhTien = Convert.ToDecimal(lb_ThanhTien.Text);
                    _repoHD.Update(hoaDonFind.Id, hoaDonFind);
                    loadCBO_HD(1);
                    LoadHDCT(GlobalVariable.IdHD);
                    LoadSanPham();
                }

            }
        }

        private void txt_tienKhachDua_TextChanged(object sender, EventArgs e)
        {
            LoadHDCT(GlobalVariable.IdHD);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            // Cộng thêm số lượng và trạng thái đổi thành 2
            var hoaDonHuy = _repoHD.GetAll().FirstOrDefault(x => x.Id == GlobalVariable.IdHD);
            if (hoaDonHuy != null)
            {
                hoaDonHuy.Status = 2; // trạng thái đã hủy
                _repoHD.Update(hoaDonHuy.Id, hoaDonHuy);
            }
            var lstSP = from hd in _repoHD.GetAll()
                        join hdct in _repoHDCT.GetAll()
                        on hd.Id equals hdct.HoaDonId
                        where hd.Id == GlobalVariable.IdHD
                        select
                        new
                        {
                            IdHD = hd.Id,
                            IdHDCT = hdct.Id,
                            IdGiayCT = hdct.GiayChiTietId,
                            SoLuong = hdct.SoLuong,
                        };


            foreach (var item in lstSP.ToList())
            {

                var FindGiayCT = _repoGCT.GetById(item.IdGiayCT);
                FindGiayCT.SoLuong = FindGiayCT.SoLuong + item.SoLuong;
                _repoGCT.Update(FindGiayCT.Id, FindGiayCT);

            }
            LoadSanPham();
            loadCBO_HD(1);

        }
    }
}
