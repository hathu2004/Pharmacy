using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pharmacy.User
{
    public partial class US_TrangChu : UserControl
    {
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                lblTen.Text = username;
            }
        }
        function fn = new function();
        string query;
        DataSet ds;
        public US_TrangChu()
        {
            InitializeComponent();
        }

        private void US_TrangChu_Load(object sender, EventArgs e)
        {
            lblNgay.Text = DateTime.Now.ToString();
            LoadChart();
        }

        private void LoadChart()
        {
            chart1.Series.Clear();
            Series series = new Series
            {
                Name = "Doanh số",
                ChartType = SeriesChartType.Column
            };
            chart1.Series.Add(series);
            
            for (int i=0; i<=31; i++)
            {
                DataPoint point = new DataPoint();
                point.SetValueXY(i, 0);  
                point.AxisLabel = i.ToString();
                series.Points.Add(point);
            }
            query = "select sum(So_luong * Don_gia) as DoanhSo, DAY(Ngay_ban) as Ngay from Hoa_don_ban where MONTH(Ngay_ban) = MONTH(getdate()) and YEAR(Ngay_ban) = YEAR(getdate()) group by DAY(Ngay_ban)";
            ds = fn.getData(query);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int ngay = Convert.ToInt32(row["Ngay"]);
                decimal doanhso = Convert.ToDecimal(row["DoanhSo"]);
                series.Points[ngay].SetValueY(doanhso);
            }
            chart1.ChartAreas[0].AxisX.Interval = 1;  // Hiển thị mỗi ngày
            chart1.ChartAreas[0].AxisX.Minimum = 0;  // Bắt đầu từ ngày 0
            chart1.ChartAreas[0].AxisX.Maximum = 31;  // Kết thúc ở ngày 31
            
            chart1.ChartAreas[0].AxisX.Title = "Ngày";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10);
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;  // Ẩn đường lưới trục X

            chart1.ChartAreas[0].AxisY.Title = "Doanh số (VNĐ)";
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10);
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:N0}";  // Định dạng số Y
            chart1.Legends.Clear();
            decimal DoanhSo = 0;
            query = "select sum(So_luong * Don_gia) from Hoa_don_ban where MONTH(Ngay_ban) = MONTH(getdate()) and YEAR(Ngay_ban) = YEAR(getdate())";
            ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                DoanhSo = Convert.ToDecimal(ds.Tables[0].Rows[0][0]);
            }
            lblDoanhso.Text = DoanhSo.ToString("N4") + " VND";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
