using ClassicShoe.APP.SERVICES;
using ClassicShoe.DATA.Models;
using ClassicShoe.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicShow.APP.VIEWS
{
    public partial class OderDetail : Form
    {
       

        public OderDetail()
        {
            InitializeComponent();
            
        }

        public AllRepositories<HoaDonChiTiet> _repo = new AllRepositories<HoaDonChiTiet> (new ClassicShoeDbContext());

        private void OderDetail_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        public void LoadDGV()
        {
            if (_repo != null)
            {
                dataGridView1.DataSource = _repo.GetAll().Where(x=>x.HoaDonId == GlobalVariable.IdHD).ToList();
            }
            else
            {
                MessageBox.Show("Repository chưa được khởi tạo.");
            }

        }
    }
}
