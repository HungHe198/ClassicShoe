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
        // lưu lại giá trị Id nhân viên hoặc admin
        private void Layout_Load(object sender, EventArgs e)
        {
            ShowFormInPanel(new ProductManager());
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
            ShowFormInPanel(new ProductManager());
        }

        private void btn_QLNhanVien_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new EmployeeManager());
        }

        private void btn_QLHoaDon_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Order());
        }

        private void btn_QLKhachHang_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new CustomerManager());
        }

        private void btn_QLGiamGia_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new DiscountManager());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
