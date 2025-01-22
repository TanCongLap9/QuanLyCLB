
namespace QuanLyCLB.CauLacBo
{
    partial class CauLacBo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauLacBo));
            this.poisonTabControl1 = new ReaLTaiizor.Controls.PoisonTabControl();
            this.tabBaiViet = new ReaLTaiizor.Controls.PoisonTabPage();
            this.danhSachBaiViet1 = new QuanLyCLB.BaiViet.DanhSachBaiViet();
            this.tabThanhVien = new ReaLTaiizor.Controls.PoisonTabPage();
            this.thanhVien1 = new QuanLyCLB.CauLacBo.DanhSachThanhVien();
            this.tabLuuTru = new ReaLTaiizor.Controls.PoisonTabPage();
            this.luuTru1 = new QuanLyCLB.LuuTru.LuuTru();
            this.tabLich = new ReaLTaiizor.Controls.PoisonTabPage();
            this.quanLyLich1 = new QuanLyCLB.Lich.QuanLyLich();
            this.tabThongTin = new ReaLTaiizor.Controls.PoisonTabPage();
            this.thongTinCLB1 = new QuanLyCLB.CauLacBo.ThongTinCLB();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lTenCLB = new ReaLTaiizor.Controls.PoisonLabel();
            this.bExit = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonTabControl1.SuspendLayout();
            this.tabBaiViet.SuspendLayout();
            this.tabThanhVien.SuspendLayout();
            this.tabLuuTru.SuspendLayout();
            this.tabLich.SuspendLayout();
            this.tabThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // poisonTabControl1
            // 
            this.poisonTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonTabControl1.Controls.Add(this.tabBaiViet);
            this.poisonTabControl1.Controls.Add(this.tabThanhVien);
            this.poisonTabControl1.Controls.Add(this.tabLuuTru);
            this.poisonTabControl1.Controls.Add(this.tabLich);
            this.poisonTabControl1.Controls.Add(this.tabThongTin);
            this.poisonTabControl1.Location = new System.Drawing.Point(0, 33);
            this.poisonTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.poisonTabControl1.Name = "poisonTabControl1";
            this.poisonTabControl1.SelectedIndex = 0;
            this.poisonTabControl1.Size = new System.Drawing.Size(900, 440);
            this.poisonTabControl1.TabIndex = 2;
            this.poisonTabControl1.UseSelectable = true;
            this.poisonTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.poisonTabControl1_Selected);
            // 
            // tabBaiViet
            // 
            this.tabBaiViet.Controls.Add(this.danhSachBaiViet1);
            this.tabBaiViet.HorizontalScrollbarBarColor = true;
            this.tabBaiViet.HorizontalScrollbarHighlightOnWheel = false;
            this.tabBaiViet.HorizontalScrollbarSize = 10;
            this.tabBaiViet.Location = new System.Drawing.Point(4, 38);
            this.tabBaiViet.Margin = new System.Windows.Forms.Padding(0);
            this.tabBaiViet.Name = "tabBaiViet";
            this.tabBaiViet.Padding = new System.Windows.Forms.Padding(1);
            this.tabBaiViet.Size = new System.Drawing.Size(892, 398);
            this.tabBaiViet.TabIndex = 0;
            this.tabBaiViet.Text = "Bài viết";
            this.tabBaiViet.VerticalScrollbarBarColor = true;
            this.tabBaiViet.VerticalScrollbarHighlightOnWheel = false;
            this.tabBaiViet.VerticalScrollbarSize = 10;
            // 
            // danhSachBaiViet1
            // 
            this.danhSachBaiViet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhSachBaiViet1.Location = new System.Drawing.Point(1, 1);
            this.danhSachBaiViet1.Margin = new System.Windows.Forms.Padding(0);
            this.danhSachBaiViet1.Name = "danhSachBaiViet1";
            this.danhSachBaiViet1.Size = new System.Drawing.Size(890, 396);
            this.danhSachBaiViet1.TabIndex = 0;
            this.danhSachBaiViet1.UseSelectable = true;
            this.danhSachBaiViet1.BaiVietMoi += new System.EventHandler(this.dsBaiViet1_BaiVietMoi);
            // 
            // tabThanhVien
            // 
            this.tabThanhVien.Controls.Add(this.thanhVien1);
            this.tabThanhVien.HorizontalScrollbarBarColor = true;
            this.tabThanhVien.HorizontalScrollbarHighlightOnWheel = false;
            this.tabThanhVien.HorizontalScrollbarSize = 10;
            this.tabThanhVien.Location = new System.Drawing.Point(4, 35);
            this.tabThanhVien.Margin = new System.Windows.Forms.Padding(0);
            this.tabThanhVien.Name = "tabThanhVien";
            this.tabThanhVien.Padding = new System.Windows.Forms.Padding(1);
            this.tabThanhVien.Size = new System.Drawing.Size(892, 401);
            this.tabThanhVien.TabIndex = 2;
            this.tabThanhVien.Text = "Thành viên";
            this.tabThanhVien.VerticalScrollbarBarColor = true;
            this.tabThanhVien.VerticalScrollbarHighlightOnWheel = false;
            this.tabThanhVien.VerticalScrollbarSize = 10;
            // 
            // thanhVien1
            // 
            this.thanhVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thanhVien1.Location = new System.Drawing.Point(1, 1);
            this.thanhVien1.Margin = new System.Windows.Forms.Padding(0);
            this.thanhVien1.Name = "thanhVien1";
            this.thanhVien1.Size = new System.Drawing.Size(890, 399);
            this.thanhVien1.TabIndex = 0;
            this.thanhVien1.UseSelectable = true;
            // 
            // tabLuuTru
            // 
            this.tabLuuTru.Controls.Add(this.luuTru1);
            this.tabLuuTru.HorizontalScrollbarBarColor = true;
            this.tabLuuTru.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLuuTru.HorizontalScrollbarSize = 10;
            this.tabLuuTru.Location = new System.Drawing.Point(4, 35);
            this.tabLuuTru.Margin = new System.Windows.Forms.Padding(0);
            this.tabLuuTru.Name = "tabLuuTru";
            this.tabLuuTru.Padding = new System.Windows.Forms.Padding(1);
            this.tabLuuTru.Size = new System.Drawing.Size(892, 401);
            this.tabLuuTru.TabIndex = 5;
            this.tabLuuTru.Text = "Lưu trữ";
            this.tabLuuTru.VerticalScrollbarBarColor = true;
            this.tabLuuTru.VerticalScrollbarHighlightOnWheel = false;
            this.tabLuuTru.VerticalScrollbarSize = 10;
            // 
            // luuTru1
            // 
            this.luuTru1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luuTru1.Location = new System.Drawing.Point(1, 1);
            this.luuTru1.Margin = new System.Windows.Forms.Padding(0);
            this.luuTru1.Name = "luuTru1";
            this.luuTru1.Size = new System.Drawing.Size(890, 399);
            this.luuTru1.TabIndex = 0;
            this.luuTru1.UseSelectable = true;
            // 
            // tabLich
            // 
            this.tabLich.Controls.Add(this.quanLyLich1);
            this.tabLich.HorizontalScrollbarBarColor = true;
            this.tabLich.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLich.HorizontalScrollbarSize = 10;
            this.tabLich.Location = new System.Drawing.Point(4, 35);
            this.tabLich.Margin = new System.Windows.Forms.Padding(0);
            this.tabLich.Name = "tabLich";
            this.tabLich.Padding = new System.Windows.Forms.Padding(1);
            this.tabLich.Size = new System.Drawing.Size(892, 401);
            this.tabLich.TabIndex = 1;
            this.tabLich.Text = "Lịch hoạt động";
            this.tabLich.VerticalScrollbarBarColor = true;
            this.tabLich.VerticalScrollbarHighlightOnWheel = false;
            this.tabLich.VerticalScrollbarSize = 10;
            // 
            // quanLyLich1
            // 
            this.quanLyLich1.AutoScroll = true;
            this.quanLyLich1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyLich1.Location = new System.Drawing.Point(1, 1);
            this.quanLyLich1.Margin = new System.Windows.Forms.Padding(0);
            this.quanLyLich1.Name = "quanLyLich1";
            this.quanLyLich1.Size = new System.Drawing.Size(890, 399);
            this.quanLyLich1.TabIndex = 0;
            this.quanLyLich1.UseSelectable = true;
            // 
            // tabThongTin
            // 
            this.tabThongTin.Controls.Add(this.thongTinCLB1);
            this.tabThongTin.HorizontalScrollbarBarColor = true;
            this.tabThongTin.HorizontalScrollbarHighlightOnWheel = false;
            this.tabThongTin.HorizontalScrollbarSize = 10;
            this.tabThongTin.Location = new System.Drawing.Point(4, 35);
            this.tabThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.tabThongTin.Name = "tabThongTin";
            this.tabThongTin.Padding = new System.Windows.Forms.Padding(1);
            this.tabThongTin.Size = new System.Drawing.Size(892, 401);
            this.tabThongTin.TabIndex = 4;
            this.tabThongTin.Text = "Thông tin";
            this.tabThongTin.VerticalScrollbarBarColor = true;
            this.tabThongTin.VerticalScrollbarHighlightOnWheel = false;
            this.tabThongTin.VerticalScrollbarSize = 10;
            // 
            // thongTinCLB1
            // 
            this.thongTinCLB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongTinCLB1.Location = new System.Drawing.Point(1, 1);
            this.thongTinCLB1.Margin = new System.Windows.Forms.Padding(0);
            this.thongTinCLB1.Name = "thongTinCLB1";
            this.thongTinCLB1.Padding = new System.Windows.Forms.Padding(32, 16, 32, 16);
            this.thongTinCLB1.Size = new System.Drawing.Size(890, 399);
            this.thongTinCLB1.TabIndex = 0;
            this.thongTinCLB1.UseSelectable = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ten-goi-va-hinh-anh-cac-loai-hoa-phong-lan-dep-pho-bien-nhat-1.jpg");
            // 
            // lTenCLB
            // 
            this.lTenCLB.AutoSize = true;
            this.lTenCLB.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.lTenCLB.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.lTenCLB.Location = new System.Drawing.Point(32, 3);
            this.lTenCLB.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lTenCLB.Name = "lTenCLB";
            this.lTenCLB.Size = new System.Drawing.Size(95, 25);
            this.lTenCLB.TabIndex = 1;
            this.lTenCLB.Text = "Câu lạc bộ";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.BackgroundImage = global::QuanLyCLB.Properties.Resources.arrow_left_3;
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bExit.Location = new System.Drawing.Point(0, 0);
            this.bExit.Margin = new System.Windows.Forms.Padding(0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(32, 32);
            this.bExit.TabIndex = 0;
            this.bExit.UseCustomBackColor = true;
            this.bExit.UseSelectable = true;
            this.bExit.Click += new System.EventHandler(this.bLayoutOrientation_Click);
            // 
            // CauLacBo
            // 
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.lTenCLB);
            this.Controls.Add(this.poisonTabControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CauLacBo";
            this.Size = new System.Drawing.Size(900, 473);
            this.poisonTabControl1.ResumeLayout(false);
            this.tabBaiViet.ResumeLayout(false);
            this.tabThanhVien.ResumeLayout(false);
            this.tabLuuTru.ResumeLayout(false);
            this.tabLich.ResumeLayout(false);
            this.tabThongTin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonTabControl poisonTabControl1;
        private ReaLTaiizor.Controls.PoisonTabPage tabBaiViet;
        private ReaLTaiizor.Controls.PoisonTabPage tabLich;
        private ReaLTaiizor.Controls.PoisonTabPage tabThanhVien;
        private System.Windows.Forms.ImageList imageList1;
        private ReaLTaiizor.Controls.PoisonTabPage tabThongTin;
        private ReaLTaiizor.Controls.PoisonTabPage tabLuuTru;
        private LuuTru.LuuTru luuTru1;
        private DanhSachThanhVien thanhVien1;
        private ThongTinCLB thongTinCLB1;
        private BaiViet.DanhSachBaiViet danhSachBaiViet1;
        private ReaLTaiizor.Controls.PoisonLabel lTenCLB;
        private ReaLTaiizor.Controls.PoisonButton bExit;
        private Lich.QuanLyLich quanLyLich1;
    }
}