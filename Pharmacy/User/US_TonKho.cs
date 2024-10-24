using DGVPrinterHelper;
using System;
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
    public partial class US_TonKho : UserControl
    {
        function fn = new function();
        String query;
        public US_TonKho()
        {
            InitializeComponent();
        }

        private void setDataGridViews(String query, String lblName, Color col)
        {
            DataSet ds = fn.getData(query);
            DataTable dt = ds.Tables[0];
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Tên thuốc", typeof(string));
            filteredTable.Columns.Add("Số lô", typeof(string));
            filteredTable.Columns.Add("Ngày hết hạn", typeof(DateTime));
            filteredTable.Columns.Add("ĐVT", typeof(string));
            filteredTable.Columns.Add("Đơn giá nhập (VND)", typeof(string));
            filteredTable.Columns.Add("Đơn giá bán (VND)", typeof(string));
            filteredTable.Columns.Add("Ngày nhập", typeof(DateTime));
            filteredTable.Columns.Add("SL Nhập", typeof(string));
            filteredTable.Columns.Add("SL Tồn kho", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                filteredTable.Rows.Add(row["Ten_thuoc"], row["So_lo"], row["Ngay_het_han"], row["Don_vi_tinh"], Convert.ToDecimal(row["Don_gia_nhap"]).ToString("N4"), Convert.ToDecimal(row["Don_gia_ban"]).ToString("N4"), row["Ngay_nhap"], row["Sl_nhap"], row["Sl_ton_kho"]);
            }
            dgvThuoc.DataSource = filteredTable;
            dgvThuoc.ReadOnly = true;
            lblTinhTrang.Text = lblName;
            lblTinhTrang.ForeColor = col;
        }
        private void US_TonKho_Load(object sender, EventArgs e)
        {

        }

        private void txtTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtTinhTrang.SelectedIndex == 0)
            {
                query = "select * from So_lo_thuoc";
                setDataGridViews(query, "Tất cả thuốc trong kho", Color.Black);
            }
            else if (txtTinhTrang.SelectedIndex == 1)
            {
                query = "select * from So_lo_thuoc where Ngay_het_han >= getdate()";
                setDataGridViews(query, "Thuốc còn hạn", Color.Green);
            }
            else if (txtTinhTrang.SelectedIndex == 2)
            {
                query = "select * from So_lo_thuoc where Ngay_het_han <= dateadd(day, 90, getdate()) and Ngay_het_han >= getdate() order by Ngay_het_han ASC";
                setDataGridViews(query, "Thuốc sắp hết hạn", Color.DarkOrange);
            }
            else
            {
                query = "select * from So_lo_thuoc where Ngay_het_han < getdate() order by Ngay_het_han DESC";
                setDataGridViews(query, "Thuốc hết hạn", Color.Red);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTinhTrang.SelectedIndex == 0)
            {
                query = "select * from So_lo_thuoc where Ten_thuoc like N'" + txtTimKiem.Text + "%'";
                setDataGridViews(query, "Tất cả thuốc trong kho", Color.Black);

            }
            else if (txtTinhTrang.SelectedIndex == 1)
            {
                query = "select * from So_lo_thuoc where Ngay_het_han >= getdate() and Ten_thuoc like N'" + txtTimKiem.Text + "%'";
                setDataGridViews(query, "Thuốc còn hạn", Color.Green);
            }
            else if (txtTinhTrang.SelectedIndex == 2)
            {
                query = "select * from So_lo_thuoc where Ngay_het_han <= dateadd(day, 90, getdate()) and Ngay_het_han >= getdate() and Ten_thuoc like N'" + txtTimKiem.Text + "%' order by Ngay_het_han ASC";
                setDataGridViews(query, "Thuốc sắp hết hạn", Color.DarkOrange);
            }
            else
            {
                query = "select * from So_lo_thuoc where Ngay_het_han <= getdate() and Ten_thuoc like N'" + txtTimKiem.Text + "%' order by Ngay_het_han DESC";
                setDataGridViews(query, "Thuốc hết hạn", Color.Red);
            }
        }
    }
}
