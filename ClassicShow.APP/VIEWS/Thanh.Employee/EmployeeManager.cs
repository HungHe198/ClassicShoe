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

namespace ClassicShow.APP.VIEWS
{
    public partial class EmployeeManager : Form
    {



        public EmployeeManager(AllRepositories<NhanVien> repoNV, AllRepositories<VaiTro> repoCV)
        {
            InitializeComponent();
            _repoNV = repoNV;
            _repoCV = repoCV;
        }

        public AllRepositories<NhanVien> _repoNV;
        public AllRepositories<VaiTro> _repoCV;

        NhanVienServices _services = new NhanVienServices();
        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadCBO();

        }
        public void LoadCBO()
        {

            cbo_CVNhanVien.DataSource = _repoCV.GetAll();
            cbo_CVNhanVien.DisplayMember = "TenVaiTro";
            cbo_CVNhanVien.ValueMember = "Id";
        }
        public void LoadDGV()
        {
            if (_repoNV != null)
            {
                dataGridView1.DataSource = _repoNV.GetAll();
            }
            else
            {
                MessageBox.Show("Repository chưa được khởi tạo.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
