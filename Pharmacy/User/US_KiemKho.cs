using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.User
{
    public partial class US_KiemKho : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                txtNguoiKiem.Text = username; 
            }
        }

        public US_KiemKho()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lstThuoc.Items.Clear();
            query = "select So_lo, Ten_thuoc from So_lo_thuoc where Ten_thuoc like N'" + txtTimKiem.Text + "%' or So_lo like N'" + txtTimKiem.Text + "%'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string displaytext = $"Lô {ds.Tables[0].Rows[i][0]} - {ds.Tables[0].Rows[i][1]}";
                lstThuoc.Items.Add(displaytext);
            }
        }

        private void lstThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstThuoc.SelectedItems.Count > 0)
            {
                int startIndex = lstThuoc.SelectedItems[0].Text.IndexOf("Lô ") + 3;
                int endIndex = lstThuoc.SelectedItems[0].Text.IndexOf(" -");
                string soLo = lstThuoc.SelectedItems[0].Text.Substring(startIndex, endIndex - startIndex);
                query = "select * from So_lo_thuoc where So_lo = N'" + soLo + "'";
                ds = fn.getData(query);
                txtSoLo.Text = ds.Tables[0].Rows[0][0].ToString();
                txtTenThuoc.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDonViTinh.Text = ds.Tables[0].Rows[0][2].ToString();
                txtNgayHetHan.Text = Convert.ToDateTime(ds.Tables[0].Rows[0][4]).ToString("dd/MM/yyyy");
                txtSLTruocKiem.Text = ds.Tables[0].Rows[0][8].ToString();
            }
            else
            {
                txtSoLo.Text = "";
                txtTenThuoc.Text = "";
                txtDonViTinh.Text = "";
                txtNgayHetHan.Text = "";
                txtSLTruocKiem.Text = "";
                txtSLThucTe.Text = "";
                txtLyDo.Text = "";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoLo.Text == "" || txtSLThucTe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                query = "update So_lo_thuoc set Sl_ton_kho = " + txtSLThucTe.Text + " where So_lo = N'" + txtSoLo.Text + "'";
                fn.setData(query);
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearall();
            }
        }
        private void clearall()
        {
            txtTenThuoc.Clear();
            txtSoLo.Clear();
            txtDonViTinh.Clear();
            txtNgayHetHan.Clear();
            txtLyDo.Clear();
            txtSLTruocKiem.Clear();
            txtSLThucTe.Clear();
            txtTimKiem.Clear();
            lstThuoc.Items.Clear();
        }
    }
}
