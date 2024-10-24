using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.User
{
    public partial class US_NhapThuoc : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        public US_NhapThuoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenThuoc.Text == "" || txtMoTa.Text == "" || txtHangSanXuat.Text == "" || txtNuocSanXuat.Text == "" || txtSoLo.Text == "" || txtDonViTinh.Text == "" || txtNhaCungCap.Text == "" || txtDonGiaNhap.Text == "" || txtDonGiaBan.Text == "" || txtSoLuongNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                String Dau_thuoc = txtTenThuoc.Text;
                String Mo_ta = txtMoTa.Text;
                String Hang_sx = txtHangSanXuat.Text;
                String Nuoc_sx = txtNuocSanXuat.Text;
                String So_lo = txtSoLo.Text;
                String Don_vi_tinh = txtDonViTinh.Text;
                DateTime Ngay_sx = txtNgaySanXuat.Value;
                DateTime Ngay_hh = txtNgayHetHan.Value;
                DateTime Ngay_nhap = txtNgayNhap.Value;
                String Nha_cung_cap = txtNhaCungCap.Text;
                Decimal Don_gia_nhap = Decimal.Parse(txtDonGiaNhap.Text);
                Decimal Don_gia_ban = Decimal.Parse(txtDonGiaBan.Text);
                Decimal Sl_nhap = Decimal.Parse(txtSoLuongNhap.Text);
                Decimal Sl_ton_kho = Sl_nhap;
                query = "select * from Dau_Thuoc where Dau_thuoc = N'" + txtTenThuoc.Text + "'";
                ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count < 1)
                {
                    query = "insert into Dau_Thuoc (Dau_thuoc, Mo_ta_chi_tiet, Hang_sx, Nuoc_sx) values (@Dau_thuoc, @Mo_ta, @Hang_sx, @Nuoc_sx)";
                    List<SqlParameter> para = new List<SqlParameter>
                    {
                     new SqlParameter("@Dau_thuoc", Dau_thuoc),
                     new SqlParameter("@Mo_ta", Mo_ta),
                     new SqlParameter("@Hang_sx", Hang_sx),
                     new SqlParameter("@Nuoc_sx", Nuoc_sx)
                    };
                    fn.setDataList(query, para);
                }

                query = "insert into So_lo_thuoc (So_lo, Ten_thuoc, Don_vi_tinh, Ngay_san_xuat, Ngay_het_han, Don_gia_nhap, Don_gia_ban, Ngay_nhap, Sl_nhap, Sl_ton_kho, Nha_cung_cap) values (@So_lo, @Ten_thuoc, @Don_vi_tinh, @Ngay_san_xuat, @Ngay_het_han, @Don_gia_nhap, @Don_gia_ban, @Ngay_nhap, @Sl_nhap, @Sl_ton_kho, @Nha_cung_cap)";
                List<SqlParameter> parameters = new List<SqlParameter>
               {
               new SqlParameter("@So_lo", So_lo),
               new SqlParameter("@Ten_thuoc", Dau_thuoc),
               new SqlParameter("@Don_vi_tinh", Don_vi_tinh),
               new SqlParameter("@Ngay_san_xuat", Ngay_sx),
               new SqlParameter("@Ngay_het_han", Ngay_hh),
               new SqlParameter("@Don_gia_nhap", Don_gia_nhap),
               new SqlParameter("@Don_gia_ban", Don_gia_ban),
               new SqlParameter("@Ngay_nhap", Ngay_nhap),
               new SqlParameter("@Sl_nhap", Sl_nhap),
               new SqlParameter("@Sl_ton_kho", Sl_ton_kho),
               new SqlParameter("@Nha_cung_cap", Nha_cung_cap)
               };
                fn.setDataList(query, parameters);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }


        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            lstDauThuoc.Items.Clear();
            query = "Select Dau_thuoc from Dau_Thuoc where Dau_thuoc like N'%" + txtTimKiem.Text + "%'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lstDauThuoc.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void lstDauThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstDauThuoc.SelectedItems.Count > 0)
            {
                query = "Select * from Dau_Thuoc where Dau_thuoc = N'" + lstDauThuoc.SelectedItems[0].Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtTenThuoc.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtMoTa.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtHangSanXuat.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtNuocSanXuat.Text = ds.Tables[0].Rows[0][3].ToString();
                }
                else
                {
                    // Handle the case where no rows are returned
                    txtTenThuoc.Text = "";
                    txtMoTa.Text = "";
                    txtHangSanXuat.Text = "";
                    txtNuocSanXuat.Text = "";
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            lstDauThuoc.Items.Clear();
            txtTenThuoc.Clear();
            txtMoTa.Clear();
            txtHangSanXuat.Clear();
            txtNuocSanXuat.Clear();
            txtSoLo.Clear();
            txtDonViTinh.SelectedIndex = -1;
            txtNgaySanXuat.ResetText();
            txtNgayHetHan.ResetText();
            txtNgayNhap.ResetText();
            txtNhaCungCap.SelectedIndex = -1;
            txtDonGiaNhap.Clear();
            txtDonGiaBan.Clear();
            txtSoLuongNhap.Clear();
        }

        private void US_NhapThuoc_Load(object sender, EventArgs e)
        {
            txtNgayNhap.Value = DateTime.Now;
        }
    }
}
