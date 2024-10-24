using System;
using System.Collections.Generic;
using DGVPrinterHelper;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy.User
{
    public partial class US_BanThuoc : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                txtDuocSy.Text = username; 
            }
        }

        public US_BanThuoc()
        {
            InitializeComponent();
        }
        
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            lstTenThuoc.Items.Clear();
            query = "select So_lo, Ten_thuoc from So_lo_thuoc where Ten_thuoc like N'" + txtTimKiem.Text + "%' and Ngay_het_han >= getdate() and Sl_ton_kho > 0 Order by Ngay_het_han ASC";
            ds = fn.getData(query);
            for (int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
                string displaytext = $"Lô {ds.Tables[0].Rows[i][0]} - {ds.Tables[0].Rows[i][1]}";
                lstTenThuoc.Items.Add(displaytext);
            }
        }

        private void lstTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTenThuoc.SelectedItems.Count > 0)
            {
                int startIndex = lstTenThuoc.SelectedItems[0].Text.IndexOf("Lô ") + 3;
                int endIndex = lstTenThuoc.SelectedItems[0].Text.IndexOf(" -");
                string soLo = lstTenThuoc.SelectedItems[0].Text.Substring(startIndex, endIndex - startIndex);
                query = "select * from So_lo_thuoc where So_lo = N'" + soLo + "'";
                ds = fn.getData(query);
                txtSoLo.Text = ds.Tables[0].Rows[0][0].ToString();
                txtThuoc.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDonViTinh.Text = ds.Tables[0].Rows[0][2].ToString();
                txtNgayHetHan.Text = Convert.ToDateTime(ds.Tables[0].Rows[0][4]).ToString("dd/MM/yyyy");
                //txtNgayHetHan.Text = ds.Tables[0].Rows[0][4].ToString("dd/MM/yyyy");
                txtDonGiaBan.Text = Convert.ToDecimal(ds.Tables[0].Rows[0][6]).ToString("N4");
                txtTonKho.Text = ds.Tables[0].Rows[0][8].ToString();
            }
            else
            {
                txtSoLo.Text = "";
                txtThuoc.Text = "";
                txtDonViTinh.Text = "";
                txtNgayHetHan.Text = "";
                txtDonGiaBan.Text = "";
                txtTonKho.Text = "";
            }

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSoLuong.Text, "[^0-9]"))
            {
                // Hiển thị thông báo lỗi nếu muốn
                MessageBox.Show("Vui lòng chỉ nhập số.");

                // Xóa các ký tự không phải số
                txtSoLuong.Text = System.Text.RegularExpressions.Regex.Replace(txtSoLuong.Text, "[^0-9]", "");
            }
            else if(txtSoLuong.TextLength>0 && int.Parse(txtSoLuong.Text) > int.Parse(txtTonKho.Text))
            {
                MessageBox.Show("Số lượng bán vượt quá số lượng tồn kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Text = "";
            }
        }

        protected int n;
        protected int so = 0;
        protected decimal TongTien = 0;

        private void US_BanThuoc_Load(object sender, EventArgs e)
        {
            txtNgayBan.Value = DateTime.Now;
            //txtDuocSy.Text = frmUser.username;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtSoLo.Text=="" || txtSoLuong.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Thuốc bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(txtTenKhachHang.Text==""||txtSoHoaDon.Text==""||txtDuocSy.Text=="")
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng và hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                so++;
                n = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[n].Cells[0].Value = txtThuoc.Text;
               dgvHoaDon.Rows[n].Cells[1].Value = txtDonViTinh.Text;
               dgvHoaDon.Rows[n].Cells[3].Value = txtDonGiaBan.Text;
               dgvHoaDon.Rows[n].Cells[2].Value = txtSoLuong.Text;
               Decimal ThanhTien = decimal.Parse(txtDonGiaBan.Text) * decimal.Parse(txtSoLuong.Text);
               dgvHoaDon.Rows[n].Cells[4].Value = ThanhTien.ToString("N4");
               dgvHoaDon.Rows[n].Cells[5].Value = txtSoLo.Text;
                dgvHoaDon.Rows[n].Cells[6].Value = so;
                TongTien += ThanhTien;
                txtTongTien.Text = TongTien.ToString("N4");
                query = "update So_lo_thuoc set Sl_ton_kho = Sl_ton_kho - " + txtSoLuong.Text + " where So_lo = N'" + txtSoLo.Text + "'";
               fn.setData(query);
               query = "insert into Hoa_don_ban (So_hoa_don, Ngay_ban, Ten_khach_hang, So_dien_thoai, Ten_duoc_sy, Ten_thuoc, So_lo, So_luong, don_gia, don_vi_tinh, STT) values (@SoHoaDon, @NgayBan, @TenKhachHang, @SoDienThoai, @TenDuocSy, @TenThuoc, @SoLo, @SoLuong, @DonGia, @DonViTinh, @STT)";
                List<SqlParameter> parameters = new List<SqlParameter>
               {
                    new SqlParameter("@SoHoaDon", txtSoHoaDon.Text),
                    new SqlParameter("@NgayBan", txtNgayBan.Value),
                    new SqlParameter("@TenKhachHang", txtTenKhachHang.Text),
                    new SqlParameter("@SoDienThoai", txtSdt.Text),
                    new SqlParameter("@TenDuocSy", txtDuocSy.Text),
                    new SqlParameter("@TenThuoc", txtThuoc.Text),
                    new SqlParameter("@SoLo", txtSoLo.Text),
                    new SqlParameter("@SoLuong", txtSoLuong.Text),
                    new SqlParameter("@DonGia", txtDonGiaBan.Text),
                    new SqlParameter("@DonViTinh", txtDonViTinh.Text),
                    new SqlParameter("@STT", so)
               };
                fn.setDataList(query, parameters);
                //MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearall();
            }
        }

        private void clearall()
        {
            txtThuoc.Clear();
            txtSoLo.Clear();
            txtDonViTinh.Clear();
            txtNgayHetHan.Clear();
            txtDonGiaBan.Clear();
            txtTonKho.Clear();
            txtSoLuong.Clear();
            txtTimKiem.Clear();
            lstTenThuoc.Items.Clear();
        }

        protected String SoHoaDon;
        protected String SoLo;
        protected Decimal SoLuong;
        protected Decimal Tien;
        protected int stt;

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvHoaDon.Rows.Count && e.ColumnIndex >= 0)
                {
                    SoHoaDon = txtSoHoaDon.Text;
                    SoLo = dgvHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString(); // Corrected the column index for SoLo
                    SoLuong = decimal.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Tien = decimal.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[4].Value.ToString());
                    stt = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[6].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting the row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoai_Click(object sender, EventArgs e)
        {
           if(this.dgvHoaDon.SelectedRows.Count > 0)
            {
                try
                {
                    dgvHoaDon.Rows.RemoveAt(this.dgvHoaDon.SelectedRows[0].Index);
                    query = "update So_lo_thuoc set Sl_ton_kho = Sl_ton_kho + " + SoLuong + " where So_lo = N'" + SoLo + "'";
                    fn.setData(query);
                    query = "delete from Hoa_don_ban where So_hoa_don = N'" + SoHoaDon + "' and STT = N'" + stt + "'"; 
                    fn.setData(query);
                    TongTien -= Tien;
                    txtTongTien.Text = TongTien.ToString();
                    //MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            n = dgvHoaDon.Rows.Add();
            dgvHoaDon.Rows[n].Cells[4].Value = txtTongTien.Text;
            // Khởi tạo DGVPrinter
            DGVPrinter printer = new DGVPrinter();

            // Thiết lập tiêu đề hóa đơn
            printer.Title = "HÓA ĐƠN BÁN THUỐC"; // Tiêu đề chính của hóa đơn
            printer.SubTitle = string.Format("Ngày: {0}\nKhách hàng: {1}\nDược sỹ: {2}\nSố hóa đơn: {3}", DateTime.Now.ToString("dd/MM/yyyy"), txtTenKhachHang.Text, txtDuocSy.Text, txtSoHoaDon.Text);
            // Căn lề phải cho phụ đề
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            // Thiết lập các thông tin in chi tiết
            printer.PageNumbers = true;           // Hiển thị số trang
            printer.PageNumberInHeader = false;   // Hiển thị số trang ở footer thay vì header
            printer.PorportionalColumns = true;   // Tự động điều chỉnh kích thước các cột theo tỷ lệ
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Tổng tiền: " + txtTongTien.Text + " VND"; // Footer của hóa đơn
            printer.FooterSpacing = 15;           // Khoảng cách giữa dữ liệu và footer

            // Thiết lập phông chữ
            printer.TitleFont = new Font("Arial", 20, FontStyle.Bold);
            printer.SubTitleFont = new Font("Arial", 14, FontStyle.Italic);
            printer.PageNumberFont = new Font("Arial", 12, FontStyle.Regular);
            printer.FooterFont = new Font("Arial", 14, FontStyle.Italic);

            // In DataGridView
            printer.PrintDataGridView(dgvHoaDon);
           
            so = 0;
            TongTien = 0;
            clearall();
            clearHoaDon();
        }

        private void clearHoaDon()
        {
            txtTenKhachHang.Clear();
            txtSdt.Clear();
            txtSoHoaDon.Clear();
            txtTongTien.Clear();
            dgvHoaDon.Rows.Clear();
        }
    }
}
