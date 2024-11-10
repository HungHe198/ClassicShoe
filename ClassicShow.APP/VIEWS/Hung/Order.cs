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
    public partial class Order : Form
    {

        public Order(AllRepositories<HoaDon> repoHoaDon)
        {
            InitializeComponent();
            _repoHoaDon = repoHoaDon;
        }

        public AllRepositories<HoaDon> _repoHoaDon;


        private void Order_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        //public void LoadDGV(int Status) { 


        //}
        public void LoadDGV()
        {
            if (_repoHoaDon != null)
            {
                dgv_HoaDon.DataSource = _repoHoaDon.GetAll();
            }
            else
            {
                MessageBox.Show("Repository chưa được khởi tạo.");
            }

        }
    }
}
