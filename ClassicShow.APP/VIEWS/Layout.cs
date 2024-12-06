using ClassicShoe.APP.SERVICES;
using ClassicShoe.APP.VIEWS.Hung;
using ClassicShoe.DATA.Models;
using ClassicShoe.DATA.Repositories;
using ClassicShow.APP.VIEWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicShoe.APP.VIEWS
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
        }
        AllRepositories<NhanVien> _repoNV = new AllRepositories<NhanVien>(new ClassicShoeDbContext());
        AllRepositories<Admin> _repoAD = new AllRepositories<Admin>(new ClassicShoeDbContext());

        // lưu lại giá trị Id nhân viên hoặc admin
        private void Layout_Load(object sender, EventArgs e)
        {
            AllRepositories<Giay> repoG = new AllRepositories<Giay>(new ClassicShoeDbContext());
            AllRepositories<GiayChiTiet> repoGCT = new AllRepositories<GiayChiTiet>(new ClassicShoeDbContext());
            AllRepositories<DeGiay> repoDG = new AllRepositories<DeGiay>(new ClassicShoeDbContext());
            AllRepositories<ThanGiay> repoTG = new AllRepositories<ThanGiay>(new ClassicShoeDbContext());
            AllRepositories<LoaiGiay> repoLG = new AllRepositories<LoaiGiay>(new ClassicShoeDbContext());
            AllRepositories<MauSac> repoMS = new AllRepositories<MauSac>(new ClassicShoeDbContext());
            AllRepositories<HangSanXuat> repoHSX = new AllRepositories<HangSanXuat>(new ClassicShoeDbContext());
            ProductManager newForm = new ProductManager(repoGCT, repoG, repoDG, repoTG, repoLG, repoMS, repoHSX);
            ShowFormInPanel(newForm);

            if (GlobalVariable.MaVaiTro != "ADMIN" )
            //{
            //    var guid = GlobalVariable.UserId.ToString();
            //    btn_Sales.Visible = false;
            //    var user = _repoAD.GetAll().FirstOrDefault(x=>x.Id == GlobalVariable.UserId);
            //    lb_ID.Text = user.Id.ToString();
            //    lb_TenNhanVien.Text = user.TaiKhoan.ToString();

            //}
            //else
            {
                btn_QLNhanVien.Visible = false;
                var guid = GlobalVariable.UserId.ToString();
                var user = _repoNV.GetAll().FirstOrDefault(x=>x.Id == GlobalVariable.UserId);
               
            } 
                
            
        }
        private void ShowFormInPanel(Form form)
        {
            // Xóa nội dung cũ của Panel
            pn_mainRender.Controls.Clear();

            // Đặt form con vào panel
            form.TopLevel = false;         // Đặt TopLevel false để sử dụng trong Panel
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;    // Đặt Dock Fill để form con chiếm toàn bộ Panel
            pn_mainRender.Controls.Add(form);
            form.Show();
        }

        private void btn_QLSanPham_Click(object sender, EventArgs e)
        {
            AllRepositories<Giay> repoG = new AllRepositories<Giay>(new ClassicShoeDbContext());
            AllRepositories<GiayChiTiet> repoGCT = new AllRepositories<GiayChiTiet>(new ClassicShoeDbContext());
            AllRepositories<DeGiay> repoDG = new AllRepositories<DeGiay>(new ClassicShoeDbContext());
            AllRepositories<ThanGiay> repoTG = new AllRepositories<ThanGiay>(new ClassicShoeDbContext());
            AllRepositories<LoaiGiay> repoLG = new AllRepositories<LoaiGiay>(new ClassicShoeDbContext());
            AllRepositories<MauSac> repoMS = new AllRepositories<MauSac>(new ClassicShoeDbContext());
            AllRepositories<HangSanXuat> repoHSX = new AllRepositories<HangSanXuat>(new ClassicShoeDbContext());
            ProductManager newForm = new ProductManager(repoGCT, repoG, repoDG, repoTG, repoLG, repoMS, repoHSX);
            ShowFormInPanel(newForm);

        }

        private void btn_QLNhanVien_Click(object sender, EventArgs e)
        {

            AllRepositories<NhanVien> repo = new AllRepositories<NhanVien>(new ClassicShoeDbContext());
            AllRepositories<VaiTro> repocv = new AllRepositories<VaiTro>(new ClassicShoeDbContext());
            EmployeeManager newForm = new EmployeeManager(repo,repocv);
            ShowFormInPanel(newForm);
        }

        private void btn_QLHoaDon_Click(object sender, EventArgs e)
        {
            //HoaDonRepositories repo = new HoaDonRepositories(new ClassicShoeDbContext());
            //Order orderForm = new Order(repo);
            //ShowFormInPanel(orderForm);
            AllRepositories<HoaDon> repo = new AllRepositories<HoaDon>(new ClassicShoeDbContext());
            Order orderForm = new Order(repo);
            ShowFormInPanel(orderForm);

        }

        private void btn_QLKhachHang_Click(object sender, EventArgs e)
        {

            AllRepositories<KhachHang> repo = new AllRepositories<KhachHang>(new ClassicShoeDbContext());
            CustomerManager newForm = new CustomerManager(repo);
            ShowFormInPanel(newForm);

        }

        private void btn_QLGiamGia_Click(object sender, EventArgs e)
        {
            //AllRepositories<KhachHang> repo = new AllRepositories<KhachHang>(new ClassicShoeDbContext());
            //CustomerManager newForm = new CustomerManager(repo);
            //ShowFormInPanel(newForm);
            ShowFormInPanel(new DiscountManager());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            // Hiển thị lại Form Login và đóng Form Layout
            Form loginForm = Application.OpenForms["Login"]; // Tên class của Form đăng nhập (sửa theo tên thực tế)

            if (loginForm != null)
            {
                loginForm.Show(); // Hiển thị lại Form Login
            }

            this.Close(); // Đóng Form Layout
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            
            SalesForm newForm = new SalesForm();
            ShowFormInPanel(newForm);
        }
    }
}
