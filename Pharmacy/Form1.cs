using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            query = "select Ho_ten from Duoc_sy where Ten_dang_nhap = '" + txtTenDangNhap.Text + "' and Mat_khau = '" + txtMatKhau.Text + "'";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                String username = ds.Tables[0].Rows[0][0].ToString();
                this.Hide();
                frmUser user = new frmUser(username);
                user.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
