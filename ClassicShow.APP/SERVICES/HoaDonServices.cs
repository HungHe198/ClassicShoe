using ClassicShoe.DATA.Models;
using ClassicShoe.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.APP.SERVICES
{
    public class HoaDonServices
    {

        AllRepositories<HoaDon> _repoHD = new AllRepositories<HoaDon>(new ClassicShoeDbContext());
        AllRepositories<HoaDonChiTiet> _repoHDCT = new AllRepositories<HoaDonChiTiet>(new ClassicShoeDbContext());
       
        AllRepositories<Giay> _repoG = new AllRepositories<Giay>(new ClassicShoeDbContext());
        AllRepositories<GiayChiTiet> _repoGCT = new AllRepositories<GiayChiTiet>(new ClassicShoeDbContext());
        AllRepositories<KhachHang> _repoKH = new AllRepositories<KhachHang>(new ClassicShoeDbContext());

        ClassicShoeDbContext _db = new ClassicShoeDbContext();
       
        // Mã hóa đơn invoice code phải là unique trong ngày hoặc có thể tạo tự động kèm mẫu VD(HD01, HD02,... )
        public string CreateOrder(HoaDon hoaDon)
        {
            try
            {
                if (_repoHD.Create(hoaDon))
                {
                    return "Tạo hóa đơn trống thành công";
                }
                return "Tạo hóa đơn trống thất bại";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }
        public string UpdateOrder(Guid id, HoaDon hoaDon)
        {
            try
            {
                if (_repoHD.Update(id, hoaDon))
                {
                    return "Sửa hóa đơn thành công";
                }
                return "Sửa hóa đơn thất bại";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }
        public string Delete(Guid id)
        {
            try
            {
                if (_repoHD.Delete(id))
                {
                    return "Xóa hóa đơn thành công";
                }
                return "Xóa hóa đơn trống thất bại";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        } // chỉ vô hiệu chứ không xóa
        public void loadCBO_HD(ComboBox cbo_HoaDon)
        {
            var lstHD = _repoHD.GetAll();
            cbo_HoaDon.Items.Clear();
            cbo_HoaDon.DataSource = lstHD;
            cbo_HoaDon.DisplayMember = "InvoiceCode";
            cbo_HoaDon.ValueMember = "Id";

        }

        // tạo hóa đơn chi tiết
        public string AddToOrder(Guid IdHD, GiayChiTiet giayChiTiet, int soLuongMua)
        {
            // tạo hóa đơn chi tiết tại đây
            // trừ luôn số lượng nếu bán
            // tạo nút save(cập nhật lại) nếu có giày bỏ ra thì cộng lại sl vào

            try
            {
                if (giayChiTiet == null)
                {
                    return "Hóa đơn đang trống kìa";
                }
                else
                {
                    HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet()
                    {
                        Id = Guid.NewGuid(),
                        GiayChiTietId = giayChiTiet.Id,
                        DonGia = giayChiTiet.Gia,
                        HoaDonId = IdHD,
                        SoLuong = soLuongMua,
                    };
                    if (_repoHDCT.Create(hoaDonChiTiet))
                    {
                        return "Thêm sản phẩm thành công";
                    }
                    else
                    {
                        return "Thêm sản phẩm không thành công";
                    }

                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string UpdateOrderDetail(Guid IdHD, Guid IdHDCT, int SLUpdate)
        {
            // tạo hóa đơn chi tiết tại đây
            // trừ luôn số lượng nếu bán
            // tạo nút save(cập nhật lại) nếu có giày bỏ ra thì cộng lại sl vào

            try
            {

                var hoaDonChiTiet = _repoHDCT.GetById(IdHDCT);

                if (hoaDonChiTiet != null && _repoHDCT.Update(IdHDCT, hoaDonChiTiet))
                {
                    return "Sửa hóa đơn thành công";
                }
                else
                {
                    return "Sửa hóa đơn không thành công";
                }

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }
        public string DeleteOrderDetail( Guid IdHDCT)
        {
            try
            {
                if (_repoHDCT.Delete(IdHDCT))
                {
                    return "Xóa thành công";
                }
                else
                {
                    return "Xóa thất bại";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string FindCustomerByPhone(string phoneNumber)
        {
            var customer = _db.KhachHangs.FirstOrDefault(x => x.SoDienThoai == phoneNumber);
            if (customer != null)
            {
                return customer.Id.ToString();
            }
            else
            { return "false"; }
            
        }
        public KhachHang FindCustomerById(Guid id)
        {
            return _repoKH.GetById(id);
           
        }



    }

}
