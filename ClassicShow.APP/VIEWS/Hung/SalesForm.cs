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

namespace ClassicShoe.APP.VIEWS.Hung
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }
        HoaDonServices _sv = new HoaDonServices();


        Guid _nvGuid = Guid.Parse("42F79FCD-7FD6-4B24-B498-09337BDB4A3F"); // để tạm thôi đấy
                                                                           // sau sẽ lưu id vào một file và lấy dữ liệu chung tại đó

        // sau sẽ lưu id vào một file và lấy dữ liệu chung tại đó


        private void SalesForm_Load(object sender, EventArgs e)
        {
            _sv.loadCBO_HD(cbo_HoaDon);
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        { // tạo hóa đơn trống và có thể sử dụng

            HoaDon hoaDon = new HoaDon()
            {
                Id = Guid.NewGuid(),
                InvoiceCode = DateTime.Now.ToString(),
                KhachHangId = Guid.Parse(_sv.FindCustomerByPhone(txt_PhoneNumber.ToString())), // đã kiểm tra có khách rồi mới thêm ở đây chưa có thì tạo mới đi
                MaGiamGiaId = Guid.Parse(txt_TKGiamGia.ToString()),
                NgayTaoHoaDon = DateTime.Now,
                NhanVienId = _nvGuid,
                PhuongThucThanhToan = "Tại quầy",
                Status = 1,
                ThanhTien = 0,
            };
            _sv.CreateOrder(hoaDon);

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
    }
}
