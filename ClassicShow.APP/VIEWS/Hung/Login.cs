using ClassicShoe.APP.VIEWS;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        AllRepositories<VaiTro> _repoVT;
        AllRepositories<NhanVien> _repoNV;
        AllRepositories<Admin> _repoAD;
        private void Login_Load(object sender, EventArgs e)
        {
            //if (cbo_VaiTro.SelectedValue == "Admin") // so Sánh với Mã Vai trò
            //{
                
            //}
        }
        public void loadCBO()
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Layout form2 = new Layout();
            form2.Show();
            form2.WindowState = FormWindowState.Maximized;// Hiển thị Form2
            this.Hide();     // Ẩn Form1

            form2.FormClosed += (s, args) => this.Show(); // Hiện lại Form1 khi Form2 đóng
        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
