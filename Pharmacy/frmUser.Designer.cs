namespace Pharmacy
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnKiemKho = new Guna.UI2.WinForms.Guna2Button();
            this.btnTonKho = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBanThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.uS_TonKho1 = new Pharmacy.User.US_TonKho();
            this.uS_KiemKho1 = new Pharmacy.User.US_KiemKho();
            this.uS_NhapThuoc1 = new Pharmacy.User.US_NhapThuoc();
            this.uS_BanThuoc1 = new Pharmacy.User.US_BanThuoc();
            this.uS_TrangChu1 = new Pharmacy.User.US_TrangChu();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btnKiemKho);
            this.guna2Panel1.Controls.Add(this.btnTonKho);
            this.guna2Panel1.Controls.Add(this.btnTrangChu);
            this.guna2Panel1.Controls.Add(this.btnNhapThuoc);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.btnBanThuoc);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(250, 800);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(101, 728);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(45, 45);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnKiemKho
            // 
            this.btnKiemKho.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKiemKho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKiemKho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKiemKho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKiemKho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKiemKho.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnKiemKho.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemKho.ForeColor = System.Drawing.Color.White;
            this.btnKiemKho.HoverState.FillColor = System.Drawing.Color.White;
            this.btnKiemKho.HoverState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnKiemKho.Image = ((System.Drawing.Image)(resources.GetObject("btnKiemKho.Image")));
            this.btnKiemKho.ImageSize = new System.Drawing.Size(35, 35);
            this.btnKiemKho.Location = new System.Drawing.Point(0, 620);
            this.btnKiemKho.Name = "btnKiemKho";
            this.btnKiemKho.Size = new System.Drawing.Size(250, 80);
            this.btnKiemKho.TabIndex = 3;
            this.btnKiemKho.Text = "Kiểm kho";
            this.btnKiemKho.Click += new System.EventHandler(this.btnKiemKho_Click);
            // 
            // btnTonKho
            // 
            this.btnTonKho.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTonKho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTonKho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTonKho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTonKho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTonKho.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnTonKho.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTonKho.ForeColor = System.Drawing.Color.White;
            this.btnTonKho.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTonKho.HoverState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTonKho.Image = ((System.Drawing.Image)(resources.GetObject("btnTonKho.Image")));
            this.btnTonKho.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTonKho.Location = new System.Drawing.Point(0, 540);
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.Size = new System.Drawing.Size(250, 80);
            this.btnTonKho.TabIndex = 4;
            this.btnTonKho.Text = "Tồn kho";
            this.btnTonKho.Click += new System.EventHandler(this.btnTonKho_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrangChu.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTrangChu.HoverState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTrangChu.Location = new System.Drawing.Point(0, 300);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(250, 80);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnNhapThuoc
            // 
            this.btnNhapThuoc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhapThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhapThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhapThuoc.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnNhapThuoc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapThuoc.ForeColor = System.Drawing.Color.White;
            this.btnNhapThuoc.HoverState.FillColor = System.Drawing.Color.White;
            this.btnNhapThuoc.HoverState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNhapThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapThuoc.Image")));
            this.btnNhapThuoc.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNhapThuoc.Location = new System.Drawing.Point(0, 460);
            this.btnNhapThuoc.Name = "btnNhapThuoc";
            this.btnNhapThuoc.Size = new System.Drawing.Size(250, 80);
            this.btnNhapThuoc.TabIndex = 5;
            this.btnNhapThuoc.Text = "Nhập thuốc";
            this.btnNhapThuoc.Click += new System.EventHandler(this.btnNhapThuoc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBanThuoc
            // 
            this.btnBanThuoc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBanThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBanThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBanThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBanThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBanThuoc.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnBanThuoc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanThuoc.ForeColor = System.Drawing.Color.White;
            this.btnBanThuoc.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBanThuoc.HoverState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBanThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnBanThuoc.Image")));
            this.btnBanThuoc.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBanThuoc.Location = new System.Drawing.Point(0, 380);
            this.btnBanThuoc.Name = "btnBanThuoc";
            this.btnBanThuoc.Size = new System.Drawing.Size(250, 80);
            this.btnBanThuoc.TabIndex = 2;
            this.btnBanThuoc.Text = "Bán thuốc";
            this.btnBanThuoc.Click += new System.EventHandler(this.btnBanThuoc_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.guna2Panel2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.uS_TonKho1);
            this.guna2Panel2.Controls.Add(this.uS_KiemKho1);
            this.guna2Panel2.Controls.Add(this.uS_NhapThuoc1);
            this.guna2Panel2.Controls.Add(this.uS_BanThuoc1);
            this.guna2Panel2.Controls.Add(this.uS_TrangChu1);
            this.guna2Panel2.Location = new System.Drawing.Point(250, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1150, 800);
            this.guna2Panel2.TabIndex = 6;
            // 
            // uS_TonKho1
            // 
            this.uS_TonKho1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uS_TonKho1.BackColor = System.Drawing.Color.White;
            this.uS_TonKho1.Location = new System.Drawing.Point(0, 0);
            this.uS_TonKho1.Name = "uS_TonKho1";
            this.uS_TonKho1.Size = new System.Drawing.Size(1150, 800);
            this.uS_TonKho1.TabIndex = 4;
            // 
            // uS_KiemKho1
            // 
            this.uS_KiemKho1.BackColor = System.Drawing.Color.White;
            this.uS_KiemKho1.Location = new System.Drawing.Point(0, 0);
            this.uS_KiemKho1.Name = "uS_KiemKho1";
            this.uS_KiemKho1.Size = new System.Drawing.Size(1150, 800);
            this.uS_KiemKho1.TabIndex = 3;
            this.uS_KiemKho1.Username = null;
            // 
            // uS_NhapThuoc1
            // 
            this.uS_NhapThuoc1.BackColor = System.Drawing.Color.White;
            this.uS_NhapThuoc1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uS_NhapThuoc1.Location = new System.Drawing.Point(0, 0);
            this.uS_NhapThuoc1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uS_NhapThuoc1.Name = "uS_NhapThuoc1";
            this.uS_NhapThuoc1.Size = new System.Drawing.Size(1150, 800);
            this.uS_NhapThuoc1.TabIndex = 2;
            // 
            // uS_BanThuoc1
            // 
            this.uS_BanThuoc1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uS_BanThuoc1.BackColor = System.Drawing.Color.White;
            this.uS_BanThuoc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uS_BanThuoc1.Location = new System.Drawing.Point(0, 0);
            this.uS_BanThuoc1.Name = "uS_BanThuoc1";
            this.uS_BanThuoc1.Size = new System.Drawing.Size(1150, 800);
            this.uS_BanThuoc1.TabIndex = 1;
            this.uS_BanThuoc1.Username = null;
            // 
            // uS_TrangChu1
            // 
            this.uS_TrangChu1.BackColor = System.Drawing.Color.White;
            this.uS_TrangChu1.Location = new System.Drawing.Point(0, 0);
            this.uS_TrangChu1.Name = "uS_TrangChu1";
            this.uS_TrangChu1.Size = new System.Drawing.Size(1150, 800);
            this.uS_TrangChu1.TabIndex = 0;
            this.uS_TrangChu1.Username = null;
            // 
            // frmUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnBanThuoc;
        private Guna.UI2.WinForms.Guna2Button btnKiemKho;
        private Guna.UI2.WinForms.Guna2Button btnTonKho;
        private Guna.UI2.WinForms.Guna2Button btnNhapThuoc;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private User.US_TrangChu uS_TrangChu1;
        private User.US_BanThuoc uS_BanThuoc1;
        private User.US_NhapThuoc uS_NhapThuoc1;
        private User.US_KiemKho uS_KiemKho1;
        private User.US_TonKho uS_TonKho1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}