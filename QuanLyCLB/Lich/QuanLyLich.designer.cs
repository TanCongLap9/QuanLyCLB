
namespace QuanLyCLB.Lich
{
    partial class QuanLyLich
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
            QuanLyCLB.Models.LichModel lichModel1 = new QuanLyCLB.Models.LichModel();
            QuanLyCLB.Models.LichModel lichModel2 = new QuanLyCLB.Models.LichModel();
            QuanLyCLB.Models.LichModel lichModel3 = new QuanLyCLB.Models.LichModel();
            QuanLyCLB.Models.LichModel lichModel4 = new QuanLyCLB.Models.LichModel();
            QuanLyCLB.Models.LichModel lichModel5 = new QuanLyCLB.Models.LichModel();
            this.poisonToolTip1 = new ReaLTaiizor.Controls.PoisonToolTip();
            this.bTuanSau = new ReaLTaiizor.Controls.PoisonButton();
            this.bChonNgay = new ReaLTaiizor.Controls.PoisonButton();
            this.bTuanTruoc = new ReaLTaiizor.Controls.PoisonButton();
            this.bHomNay = new ReaLTaiizor.Controls.PoisonButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.alertBox1 = new QuanLyCLB.LuuTru.AlertBox();
            this.lich = new QuanLyCLB.Lich.Lich();
            this.cacThu1 = new QuanLyCLB.Lich.CacThu();
            this.suaLich1 = new QuanLyCLB.Lich.SuaLich();
            this.poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.lpCacLoaiLich = new System.Windows.Forms.FlowLayoutPanel();
            this.poisonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // poisonToolTip1
            // 
            this.poisonToolTip1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonToolTip1.StyleManager = null;
            this.poisonToolTip1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // bTuanSau
            // 
            this.bTuanSau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTuanSau.BackColor = System.Drawing.Color.Transparent;
            this.bTuanSau.BackgroundImage = global::QuanLyCLB.Properties.Resources.arrow_right_3;
            this.bTuanSau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bTuanSau.Location = new System.Drawing.Point(1012, 0);
            this.bTuanSau.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bTuanSau.Name = "bTuanSau";
            this.bTuanSau.Size = new System.Drawing.Size(32, 32);
            this.bTuanSau.TabIndex = 4;
            this.poisonToolTip1.SetToolTip(this.bTuanSau, "Tuần sau");
            this.bTuanSau.UseSelectable = true;
            this.bTuanSau.Click += new System.EventHandler(this.Control_Click);
            // 
            // bChonNgay
            // 
            this.bChonNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bChonNgay.BackColor = System.Drawing.Color.Transparent;
            this.bChonNgay.BackgroundImage = global::QuanLyCLB.Properties.Resources.view_calendar;
            this.bChonNgay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bChonNgay.Location = new System.Drawing.Point(904, 0);
            this.bChonNgay.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bChonNgay.Name = "bChonNgay";
            this.bChonNgay.Size = new System.Drawing.Size(32, 32);
            this.bChonNgay.TabIndex = 1;
            this.poisonToolTip1.SetToolTip(this.bChonNgay, "Chọn ngày");
            this.bChonNgay.UseSelectable = true;
            this.bChonNgay.Click += new System.EventHandler(this.Control_Click);
            // 
            // bTuanTruoc
            // 
            this.bTuanTruoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTuanTruoc.BackColor = System.Drawing.Color.Transparent;
            this.bTuanTruoc.BackgroundImage = global::QuanLyCLB.Properties.Resources.arrow_left_3;
            this.bTuanTruoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bTuanTruoc.Location = new System.Drawing.Point(976, 0);
            this.bTuanTruoc.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bTuanTruoc.Name = "bTuanTruoc";
            this.bTuanTruoc.Size = new System.Drawing.Size(32, 32);
            this.bTuanTruoc.TabIndex = 3;
            this.poisonToolTip1.SetToolTip(this.bTuanTruoc, "Tuần trước");
            this.bTuanTruoc.UseSelectable = true;
            this.bTuanTruoc.Click += new System.EventHandler(this.Control_Click);
            // 
            // bHomNay
            // 
            this.bHomNay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bHomNay.BackColor = System.Drawing.Color.Transparent;
            this.bHomNay.BackgroundImage = global::QuanLyCLB.Properties.Resources.view_calendar_day_2;
            this.bHomNay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bHomNay.Location = new System.Drawing.Point(940, 0);
            this.bHomNay.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bHomNay.Name = "bHomNay";
            this.bHomNay.Size = new System.Drawing.Size(32, 32);
            this.bHomNay.TabIndex = 2;
            this.poisonToolTip1.SetToolTip(this.bHomNay, "Hôm nay");
            this.bHomNay.UseSelectable = true;
            this.bHomNay.Click += new System.EventHandler(this.Control_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(750, 32);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // alertBox1
            // 
            this.alertBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.alertBox1.AutoSize = true;
            this.alertBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.alertBox1.Location = new System.Drawing.Point(460, 32);
            this.alertBox1.Margin = new System.Windows.Forms.Padding(0);
            this.alertBox1.Name = "alertBox1";
            this.alertBox1.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.alertBox1.Size = new System.Drawing.Size(107, 35);
            this.alertBox1.TabIndex = 6;
            this.alertBox1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.alertBox1.UseSelectable = true;
            this.alertBox1.Visible = false;
            // 
            // lich21
            // 
            this.lich.AutoScroll = true;
            this.lich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lich.Location = new System.Drawing.Point(120, 96);
            this.lich.Margin = new System.Windows.Forms.Padding(0);
            lichModel1.ChuDe = "Họp về công tác cho chuyến du lịch";
            lichModel1.DiaDiem = "KhongLap";
            lichModel1.LapLai = QuanLyCLB.Models.CheDoLapLai.KhongLap;
            lichModel1.MaCLB = "fdasfasfasfas";
            lichModel1.MaLich = "MaLich1";
            lichModel1.MaLoaiLich = "fdsafasfasfas";
            lichModel1.MaMau = 2508104;
            lichModel1.NgayBatDau = new System.DateTime(2024, 11, 10, 0, 0, 0, 0);
            lichModel1.NgayKetThuc = new System.DateTime(((long)(0)));
            lichModel1.NoiDung = "NoiDung1";
            lichModel1.TenLoaiLich = "fdsafasfasfasasf";
            lichModel1.ThoiGianBatDau = System.TimeSpan.Parse("09:00:00");
            lichModel1.ThoiGianKetThuc = System.TimeSpan.Parse("10:00:00");
            lichModel2.ChuDe = "Họp về công tác cho chuyến du lịch";
            lichModel2.DiaDiem = "MoiNgay";
            lichModel2.LapLai = QuanLyCLB.Models.CheDoLapLai.MoiNgay;
            lichModel2.MaCLB = "fdasfasfasfas";
            lichModel2.MaLich = "MaLich2";
            lichModel2.MaLoaiLich = "fdsafasfasfas";
            lichModel2.MaMau = 1193046;
            lichModel2.NgayBatDau = new System.DateTime(2024, 11, 6, 0, 0, 0, 0);
            lichModel2.NgayKetThuc = new System.DateTime(2024, 12, 10, 0, 0, 0, 0);
            lichModel2.NoiDung = "NoiDung2";
            lichModel2.TenLoaiLich = "fadfdasfdas";
            lichModel2.ThoiGianBatDau = System.TimeSpan.Parse("15:00:00");
            lichModel2.ThoiGianKetThuc = System.TimeSpan.Parse("16:00:00");
            lichModel3.ChuDe = "ChuDe3";
            lichModel3.DiaDiem = "Moi2Ngay";
            lichModel3.LapLai = QuanLyCLB.Models.CheDoLapLai.Moi2Ngay;
            lichModel3.MaCLB = "fdasfasfasfas";
            lichModel3.MaLich = "MaLich3";
            lichModel3.MaLoaiLich = "fdsafasfasfas";
            lichModel3.MaMau = 16711680;
            lichModel3.NgayBatDau = new System.DateTime(2024, 11, 5, 0, 0, 0, 0);
            lichModel3.NgayKetThuc = new System.DateTime(2024, 12, 10, 0, 0, 0, 0);
            lichModel3.NoiDung = "NoiDung3";
            lichModel3.TenLoaiLich = "fadfdasfdas";
            lichModel3.ThoiGianBatDau = System.TimeSpan.Parse("12:00:00");
            lichModel3.ThoiGianKetThuc = System.TimeSpan.Parse("14:30:00");
            lichModel4.ChuDe = "ChuDe4";
            lichModel4.DiaDiem = "MoiTuan";
            lichModel4.LapLai = QuanLyCLB.Models.CheDoLapLai.MoiTuan;
            lichModel4.MaCLB = "fdasfasfasfas";
            lichModel4.MaLich = "MaLich4";
            lichModel4.MaLoaiLich = "fdsafasfasfas";
            lichModel4.MaMau = 15663104;
            lichModel4.NgayBatDau = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            lichModel4.NgayKetThuc = new System.DateTime(2024, 12, 26, 0, 0, 0, 0);
            lichModel4.NoiDung = "NoiDung4";
            lichModel4.TenLoaiLich = "fadfdasfdas";
            lichModel4.ThoiGianBatDau = System.TimeSpan.Parse("18:00:00");
            lichModel4.ThoiGianKetThuc = System.TimeSpan.Parse("19:00:00");
            lichModel5.ChuDe = "dfas";
            lichModel5.DiaDiem = "MoiThang";
            lichModel5.LapLai = QuanLyCLB.Models.CheDoLapLai.MoiThang;
            lichModel5.MaCLB = "dfas";
            lichModel5.MaLich = "fasd";
            lichModel5.MaLoaiLich = "asdf";
            lichModel5.MaMau = 0;
            lichModel5.NgayBatDau = new System.DateTime(2024, 11, 6, 0, 0, 0, 0);
            lichModel5.NgayKetThuc = new System.DateTime(2024, 12, 10, 0, 0, 0, 0);
            lichModel5.NoiDung = "asdf";
            lichModel5.TenLoaiLich = "dfasfds";
            lichModel5.ThoiGianBatDau = System.TimeSpan.Parse("08:00:00");
            lichModel5.ThoiGianKetThuc = System.TimeSpan.Parse("09:00:00");
            this.lich.Models.Add(lichModel1);
            this.lich.Models.Add(lichModel2);
            this.lich.Models.Add(lichModel3);
            this.lich.Models.Add(lichModel4);
            this.lich.Models.Add(lichModel5);
            this.lich.Name = "lich21";
            this.lich.Size = new System.Drawing.Size(924, 277);
            this.lich.TabIndex = 4;
            this.lich.UseSelectable = true;
            this.lich.ItemClick += new System.EventHandler<QuanLyCLB.EventArgs.LichEventArgs>(this.lich_ItemClick);
            this.lich.LichMoi += new System.EventHandler<QuanLyCLB.EventArgs.LichEventArgs>(this.lich_LichMoi);
            // 
            // cacThu1
            // 
            this.cacThu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cacThu1.Location = new System.Drawing.Point(120, 32);
            this.cacThu1.Name = "cacThu1";
            this.cacThu1.Size = new System.Drawing.Size(924, 64);
            this.cacThu1.TabIndex = 3;
            this.cacThu1.UseSelectable = true;
            // 
            // suaLich1
            // 
            this.suaLich1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.suaLich1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.suaLich1.Location = new System.Drawing.Point(0, 373);
            this.suaLich1.Margin = new System.Windows.Forms.Padding(0);
            this.suaLich1.Name = "suaLich1";
            this.suaLich1.Padding = new System.Windows.Forms.Padding(8);
            this.suaLich1.Size = new System.Drawing.Size(1044, 186);
            this.suaLich1.TabIndex = 5;
            this.suaLich1.UseSelectable = true;
            this.suaLich1.Visible = false;
            this.suaLich1.OnFinished += new System.EventHandler<QuanLyCLB.EventArgs.SuaLichEventArgs>(this.suaLich1_OnFinished);
            // 
            // poisonPanel1
            // 
            this.poisonPanel1.Controls.Add(this.bTuanSau);
            this.poisonPanel1.Controls.Add(this.bChonNgay);
            this.poisonPanel1.Controls.Add(this.bTuanTruoc);
            this.poisonPanel1.Controls.Add(this.poisonLabel1);
            this.poisonPanel1.Controls.Add(this.bHomNay);
            this.poisonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.poisonPanel1.HorizontalScrollbarBarColor = true;
            this.poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.HorizontalScrollbarSize = 10;
            this.poisonPanel1.Location = new System.Drawing.Point(0, 0);
            this.poisonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.poisonPanel1.Name = "poisonPanel1";
            this.poisonPanel1.Size = new System.Drawing.Size(1044, 32);
            this.poisonPanel1.TabIndex = 0;
            this.poisonPanel1.VerticalScrollbarBarColor = true;
            this.poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel1.Location = new System.Drawing.Point(644, 3);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(256, 25);
            this.poisonLabel1.TabIndex = 0;
            this.poisonLabel1.Text = "4/11/2024 - 10/11/2024";
            this.poisonLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.lpCacLoaiLich.AutoScroll = true;
            this.lpCacLoaiLich.BackColor = System.Drawing.Color.Transparent;
            this.lpCacLoaiLich.Dock = System.Windows.Forms.DockStyle.Left;
            this.lpCacLoaiLich.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lpCacLoaiLich.Location = new System.Drawing.Point(0, 32);
            this.lpCacLoaiLich.Margin = new System.Windows.Forms.Padding(0);
            this.lpCacLoaiLich.Name = "flowLayoutPanel1";
            this.lpCacLoaiLich.Size = new System.Drawing.Size(120, 341);
            this.lpCacLoaiLich.TabIndex = 2;
            this.lpCacLoaiLich.WrapContents = false;
            // 
            // QuanLyLich
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.alertBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lich);
            this.Controls.Add(this.cacThu1);
            this.Controls.Add(this.lpCacLoaiLich);
            this.Controls.Add(this.poisonPanel1);
            this.Controls.Add(this.suaLich1);
            this.Name = "QuanLyLich";
            this.Size = new System.Drawing.Size(1044, 559);
            this.poisonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SuaLich suaLich1;
        private Lich lich;
        private ReaLTaiizor.Controls.PoisonToolTip poisonToolTip1;
        private CacThu cacThu1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private LuuTru.AlertBox alertBox1;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
        private ReaLTaiizor.Controls.PoisonButton bTuanSau;
        private ReaLTaiizor.Controls.PoisonButton bChonNgay;
        private ReaLTaiizor.Controls.PoisonButton bTuanTruoc;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonButton bHomNay;
        private System.Windows.Forms.FlowLayoutPanel lpCacLoaiLich;
    }
}