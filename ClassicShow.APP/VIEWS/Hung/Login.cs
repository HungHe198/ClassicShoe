using ClassicShoe.APP.SERVICES;
using ClassicShoe.APP.VIEWS;
using ClassicShoe.DATA.Models;
using ClassicShoe.DATA.Repositories;
using Microsoft.Identity.Client.NativeInterop;
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
        AllRepositories<VaiTro> _repoVT = new AllRepositories<VaiTro>(new ClassicShoeDbContext());
        AllRepositories<NhanVien> _repoNV = new AllRepositories<NhanVien>(new ClassicShoeDbContext());
        AllRepositories<Admin> _repoAD = new AllRepositories<Admin>(new ClassicShoeDbContext());
        private void Login_Load(object sender, EventArgs e)
        {
            LoadCBO();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Layout form2 = new Layout();
            //form2.Show();
            //form2.WindowState = FormWindowState.Maximized;// Hiển thị Form2
            //this.Hide();     // Ẩn Form1

            //form2.FormClosed += (s, args) => this.Show(); // Hiện lại Form1 khi Form2 đóng

            CheckVT(txt_TaiKhoan.Text, txt_MatKhau.Text);
        }

        public void CheckVT(string username, string password)
        {
            if (cbo_VaiTro.SelectedIndex == 0)
            {
                var CheckAcc = _repoAD.GetAll().FirstOrDefault(x => x.TaiKhoan == username && x.MatKhau == password);
                if (CheckAcc != null)
                {
                    GlobalVariable.UserId = CheckAcc.Id;
                    GlobalVariable.MaVaiTro = "ADMIN";
                    GoHome();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
                }
            }
            else
            {
                var CheckAcc = _repoNV.GetAll().FirstOrDefault(x => x.TenTaiKhoan == username && x.MatKhau == password);
                if (CheckAcc != null)
                {
                    GlobalVariable.UserId = CheckAcc.Id;
                    GlobalVariable.MaVaiTro = "NV";
                    GoHome();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
                }
            }
        }

        public void GoHome()
        {
            Layout form2 = new Layout();
            form2.Show();
            form2.WindowState = FormWindowState.Maximized;// Hiển thị Form2
            this.Hide();     // Ẩn Form1

            form2.FormClosed += (s, args) => this.Show();
        }

        public void LoadCBO()
        {
            //cbo_VaiTro.DataSource = _repoVT.GetAll();
            //cbo_VaiTro.DisplayMember = "TenVaiTro";
            //cbo_VaiTro.ValueMember = "MaVaiTro";
            List<KeyValuePair<int, string>> roles = new List<KeyValuePair<int, string>>
                                            {
                                                new KeyValuePair<int, string>(1, "ADMIN"),
                                                new KeyValuePair<int, string>(2, "NHANVIEN")
                                            };
            cbo_VaiTro.DataSource = roles;
            cbo_VaiTro.ValueMember = "Key";
            cbo_VaiTro.DisplayMember = "Value";

            cbo_VaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbo_VaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_VaiTro.SelectedIndex == 0)
            {
                GlobalVariable.MaVaiTro = "ADMIN";
            }
            else
                if (cbo_VaiTro.SelectedIndex == 1)
            {
                GlobalVariable.MaVaiTro = "NV";
            }
        }


    }
}
