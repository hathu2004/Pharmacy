using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;

namespace Pharmacy
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MD61LA1\FEB;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True");
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setDataList(String query, List<SqlParameter> parameters)
        {
            using (SqlConnection con = getConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        public void setData(String query)
        {
            using (SqlConnection con = getConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

}
//public void setData(String query, List<SqlParameter> parameters)
//{
//    using (SqlConnection con = getConnection())
//    {
//        using (SqlCommand cmd = new SqlCommand(query, con))
//        {
//            cmd.Parameters.AddRange(parameters.ToArray());
//            con.Open();
//            cmd.ExecuteNonQuery();
//        }
//    }
//}

//private void btnThem_Click(object sender, EventArgs e)
//{
//    String Dau_thuoc = txtTenThuoc.Text;
//    String Mo_ta = txtMoTa.Text;
//    String Hang_sx = txtHangSanXuat.Text;
//    String Nuoc_sx = txtNuocSanXuat.Text;
//    String So_lo = txtSoLo.Text;
//    String Don_vi_tinh = txtDonViTinh.Text;
//    DateTime Ngay_sx = DateTime.ParseExact(txtNgaySanXuat.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
//    DateTime Ngay_hh = DateTime.ParseExact(txtNgayHetHan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
//    DateTime Ngay_nhap = DateTime.ParseExact(txtNgayNhap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
//    String Nha_cung_cap = txtNhaCungCap.Text;
//    Decimal Don_gia_nhap = Decimal.Parse(txtDonGiaNhap.Text);
//    Decimal Don_gia_ban = Decimal.Parse(txtDonGiaBan.Text);
//    Int64 Sl_nhap = Int64.Parse(txtSoLuongNhap.Text);
//    Int64 Sl_ton_kho = Sl_nhap;

//    query = "insert into Dau_Thuoc (Dau_thuoc, Mo_ta_chi_tiet, Hang_sx, Nuoc_sx) values (@Dau_thuoc, @Mo_ta, @Hang_sx, @Nuoc_sx)";
//    List<SqlParameter> parameters = new List<SqlParameter>
//    {
//        new SqlParameter("@Dau_thuoc", Dau_thuoc),
//        new SqlParameter("@Mo_ta", Mo_ta),
//        new SqlParameter("@Hang_sx", Hang_sx),
//        new SqlParameter("@Nuoc_sx", Nuoc_sx)
//    };
//    fn.setData(query, parameters);

//    query = "insert into So_lo_thuoc (So_lo, Ten_thuoc, Don_vi_tinh, Ngay_san_xuat, Ngay_het_han, Don_gia_nhap, Don_gia_ban, Ngay_nhap, Sl_nhap, Sl_ton_kho, Nha_cung_cap) values (@So_lo, @Ten_thuoc, @Don_vi_tinh, @Ngay_san_xuat, @Ngay_het_han, @Don_gia_nhap, @Don_gia_ban, @Ngay_nhap, @Sl_nhap, @Sl_ton_kho, @Nha_cung_cap)";
//    parameters = new List<SqlParameter>
//    {
//        new SqlParameter("@So_lo", So_lo),
//        new SqlParameter("@Ten_thuoc", Dau_thuoc),
//        new SqlParameter("@Don_vi_tinh", Don_vi_tinh),
//        new SqlParameter("@Ngay_san_xuat", Ngay_sx),
//        new SqlParameter("@Ngay_het_han", Ngay_hh),
//        new SqlParameter("@Don_gia_nhap", Don_gia_nhap),
//        new SqlParameter("@Don_gia_ban", Don_gia_ban),
//        new SqlParameter("@Ngay_nhap", Ngay_nhap),
//        new SqlParameter("@Sl_nhap", Sl_nhap),
//        new SqlParameter("@Sl_ton_kho", Sl_ton_kho),
//        new SqlParameter("@Nha_cung_cap", Nha_cung_cap)
//    };
//    fn.setData(query, parameters);

//    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//}
