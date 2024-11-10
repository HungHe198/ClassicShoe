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
        

        public EmployeeManager(AllRepositories<NhanVien> repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        public AllRepositories<NhanVien> _repo;
        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        public void LoadDGV()
        {
            if (_repo != null)
            {
                dataGridView1.DataSource = _repo.GetAll();
            }
            else
            {
                MessageBox.Show("Repository chưa được khởi tạo.");
            }

        }
    }
}
