using Pharmacy.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy
{
    public partial class frmUser : Form
    {
        //protected string username;
        public frmUser(string username)
        {
            InitializeComponent();
            uS_BanThuoc1.Username = username;
            uS_KiemKho1.Username = username;
            uS_TrangChu1.Username = username;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            //lblTen.Text = username;
            uS_BanThuoc1.Visible = false;
            btnBanThuoc.PerformClick();
            uS_NhapThuoc1.Visible=false;
            btnNhapThuoc.PerformClick();
            uS_TonKho1.Visible = false;
            btnTonKho.PerformClick();
            uS_KiemKho1.Visible = false;
            btnKiemKho.PerformClick();
            uS_TrangChu1.Visible = false;
            btnTrangChu.PerformClick();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
           uS_TrangChu1.Visible = true;
           uS_TrangChu1.BringToFront();

        }

        private void btnBanThuoc_Click(object sender, EventArgs e)
        {
            uS_BanThuoc1.Visible = true;
            uS_BanThuoc1.BringToFront();
        }

        private void btnNhapThuoc_Click(object sender, EventArgs e)
        {
            uS_NhapThuoc1.Visible=true;
            uS_NhapThuoc1.BringToFront();
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            uS_TonKho1.Visible = true;
            uS_TonKho1.BringToFront();
        }

        private void btnKiemKho_Click(object sender, EventArgs e)
        {
            uS_KiemKho1.Visible = true;
            uS_KiemKho1.BringToFront();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
