
namespace QuanLyCLB.Lich
{
    partial class SuaLich
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
            this.bHuy = new ReaLTaiizor.Controls.PoisonButton();
            this.bOk = new ReaLTaiizor.Controls.PoisonButton();
            this.cLoaiLich = new ReaLTaiizor.Controls.PoisonComboBox();
            this.cLapLai = new ReaLTaiizor.Controls.PoisonComboBox();
            this.poisonLabel5 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel6 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.tDiaDiem = new ReaLTaiizor.Controls.PoisonTextBox();
            this.tChuDe = new ReaLTaiizor.Controls.PoisonTextBox();
            this.bXoa = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonLabel9 = new ReaLTaiizor.Controls.PoisonLabel();
            this.dNgayBatDau = new ReaLTaiizor.Controls.PoisonDateTime();
            this.lStatus = new ReaLTaiizor.Controls.PoisonLabel();
            this.tNoiDung = new ReaLTaiizor.Controls.PoisonTextBox();
            this.poisonLabel10 = new ReaLTaiizor.Controls.PoisonLabel();
            this.lNgayKetThuc = new ReaLTaiizor.Controls.PoisonLabel();
            this.dNgayKetThuc = new ReaLTaiizor.Controls.PoisonDateTime();
            this.mThoiGianBatDau = new System.Windows.Forms.MaskedTextBox();
            this.mThoiGianKetThuc = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bThongBao = new ReaLTaiizor.Controls.PoisonCheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bHuy
            // 
            this.bHuy.BackgroundImage = global::QuanLyCLB.Properties.Resources.dialog_cancel_2;
            this.bHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bHuy.Location = new System.Drawing.Point(278, 0);
            this.bHuy.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.bHuy.Name = "bHuy";
            this.bHuy.Size = new System.Drawing.Size(28, 28);
            this.bHuy.TabIndex = 1;
            this.bHuy.UseSelectable = true;
            this.bHuy.Click += new System.EventHandler(this.Control_Click);
            // 
            // bOk
            // 
            this.bOk.BackgroundImage = global::QuanLyCLB.Properties.Resources.dialog_ok_2;
            this.bOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bOk.Location = new System.Drawing.Point(244, 0);
            this.bOk.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(28, 28);
            this.bOk.TabIndex = 0;
            this.bOk.UseSelectable = true;
            this.bOk.Click += new System.EventHandler(this.Control_Click);
            // 
            // cLoaiLich
            // 
            this.cLoaiLich.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cLoaiLich.DisplayMember = "TenLoaiLich";
            this.cLoaiLich.FormattingEnabled = true;
            this.cLoaiLich.ItemHeight = 23;
            this.cLoaiLich.Location = new System.Drawing.Point(457, 8);
            this.cLoaiLich.Margin = new System.Windows.Forms.Padding(0);
            this.cLoaiLich.Name = "cLoaiLich";
            this.cLoaiLich.Size = new System.Drawing.Size(188, 29);
            this.cLoaiLich.TabIndex = 3;
            this.cLoaiLich.UseSelectable = true;
            this.cLoaiLich.SelectionChangeCommitted += new System.EventHandler(this.Input_ValueChanged);
            // 
            // cLapLai
            // 
            this.cLapLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cLapLai.DisplayMember = "Value";
            this.cLapLai.FormattingEnabled = true;
            this.cLapLai.ItemHeight = 23;
            this.cLapLai.Location = new System.Drawing.Point(166, 43);
            this.cLapLai.Margin = new System.Windows.Forms.Padding(0);
            this.cLapLai.Name = "cLapLai";
            this.cLapLai.Size = new System.Drawing.Size(188, 29);
            this.cLapLai.TabIndex = 5;
            this.cLapLai.UseSelectable = true;
            this.cLapLai.ValueMember = "Key";
            this.cLapLai.SelectionChangeCommitted += new System.EventHandler(this.Input_ValueChanged);
            // 
            // poisonLabel5
            // 
            this.poisonLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonLabel5.AutoSize = true;
            this.poisonLabel5.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel5.Location = new System.Drawing.Point(386, 117);
            this.poisonLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.poisonLabel5.Name = "poisonLabel5";
            this.poisonLabel5.Size = new System.Drawing.Size(25, 19);
            this.poisonLabel5.TabIndex = 14;
            this.poisonLabel5.Text = "tới";
            // 
            // poisonLabel4
            // 
            this.poisonLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonLabel4.AutoSize = true;
            this.poisonLabel4.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel4.Location = new System.Drawing.Point(93, 117);
            this.poisonLabel4.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel4.Name = "poisonLabel4";
            this.poisonLabel4.Size = new System.Drawing.Size(65, 19);
            this.poisonLabel4.TabIndex = 12;
            this.poisonLabel4.Text = "Thời gian";
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel3.Location = new System.Drawing.Point(386, 47);
            this.poisonLabel3.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(63, 19);
            this.poisonLabel3.TabIndex = 6;
            this.poisonLabel3.Text = "Địa điểm";
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel2.Location = new System.Drawing.Point(93, 47);
            this.poisonLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(48, 19);
            this.poisonLabel2.TabIndex = 4;
            this.poisonLabel2.Text = "Lặp lại";
            // 
            // poisonLabel6
            // 
            this.poisonLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonLabel6.AutoSize = true;
            this.poisonLabel6.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel6.Location = new System.Drawing.Point(386, 12);
            this.poisonLabel6.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel6.Name = "poisonLabel6";
            this.poisonLabel6.Size = new System.Drawing.Size(58, 19);
            this.poisonLabel6.TabIndex = 2;
            this.poisonLabel6.Text = "Loại lịch";
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel1.Location = new System.Drawing.Point(93, 12);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(53, 19);
            this.poisonLabel1.TabIndex = 0;
            this.poisonLabel1.Text = "Chủ đề";
            // 
            // tDiaDiem
            // 
            this.tDiaDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tDiaDiem.CustomButton.Image = null;
            this.tDiaDiem.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.tDiaDiem.CustomButton.Name = "";
            this.tDiaDiem.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tDiaDiem.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tDiaDiem.CustomButton.TabIndex = 1;
            this.tDiaDiem.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tDiaDiem.CustomButton.UseSelectable = true;
            this.tDiaDiem.CustomButton.Visible = false;
            this.tDiaDiem.Lines = new string[0];
            this.tDiaDiem.Location = new System.Drawing.Point(457, 45);
            this.tDiaDiem.Margin = new System.Windows.Forms.Padding(0);
            this.tDiaDiem.MaxLength = 32767;
            this.tDiaDiem.Name = "tDiaDiem";
            this.tDiaDiem.PasswordChar = '\0';
            this.tDiaDiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tDiaDiem.SelectedText = "";
            this.tDiaDiem.SelectionLength = 0;
            this.tDiaDiem.SelectionStart = 0;
            this.tDiaDiem.ShortcutsEnabled = true;
            this.tDiaDiem.Size = new System.Drawing.Size(189, 23);
            this.tDiaDiem.TabIndex = 7;
            this.tDiaDiem.UseSelectable = true;
            this.tDiaDiem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tDiaDiem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tDiaDiem.TextChanged += new System.EventHandler(this.Input_ValueChanged);
            // 
            // tChuDe
            // 
            this.tChuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tChuDe.CustomButton.Image = null;
            this.tChuDe.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.tChuDe.CustomButton.Name = "";
            this.tChuDe.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tChuDe.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tChuDe.CustomButton.TabIndex = 1;
            this.tChuDe.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tChuDe.CustomButton.UseSelectable = true;
            this.tChuDe.CustomButton.Visible = false;
            this.tChuDe.Lines = new string[0];
            this.tChuDe.Location = new System.Drawing.Point(166, 10);
            this.tChuDe.Margin = new System.Windows.Forms.Padding(0);
            this.tChuDe.MaxLength = 32767;
            this.tChuDe.Name = "tChuDe";
            this.tChuDe.PasswordChar = '\0';
            this.tChuDe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tChuDe.SelectedText = "";
            this.tChuDe.SelectionLength = 0;
            this.tChuDe.SelectionStart = 0;
            this.tChuDe.ShortcutsEnabled = true;
            this.tChuDe.Size = new System.Drawing.Size(189, 23);
            this.tChuDe.TabIndex = 1;
            this.tChuDe.UseSelectable = true;
            this.tChuDe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tChuDe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tChuDe.TextChanged += new System.EventHandler(this.Input_ValueChanged);
            // 
            // bXoa
            // 
            this.bXoa.BackgroundImage = global::QuanLyCLB.Properties.Resources.list_remove_5;
            this.bXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bXoa.Location = new System.Drawing.Point(312, 0);
            this.bXoa.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(28, 28);
            this.bXoa.TabIndex = 2;
            this.bXoa.UseSelectable = true;
            this.bXoa.Click += new System.EventHandler(this.Control_Click);
            // 
            // poisonLabel9
            // 
            this.poisonLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonLabel9.AutoSize = true;
            this.poisonLabel9.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel9.Location = new System.Drawing.Point(93, 82);
            this.poisonLabel9.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel9.Name = "poisonLabel9";
            this.poisonLabel9.Size = new System.Drawing.Size(58, 19);
            this.poisonLabel9.TabIndex = 8;
            this.poisonLabel9.Text = "Từ ngày";
            // 
            // dNgayBatDau
            // 
            this.dNgayBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgayBatDau.Location = new System.Drawing.Point(166, 76);
            this.dNgayBatDau.Margin = new System.Windows.Forms.Padding(0);
            this.dNgayBatDau.MinimumSize = new System.Drawing.Size(0, 29);
            this.dNgayBatDau.Name = "dNgayBatDau";
            this.dNgayBatDau.Size = new System.Drawing.Size(188, 29);
            this.dNgayBatDau.TabIndex = 9;
            this.dNgayBatDau.CloseUp += new System.EventHandler(this.Input_ValueChanged);
            // 
            // lStatus
            // 
            this.lStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lStatus.AutoSize = true;
            this.lStatus.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.lStatus.Location = new System.Drawing.Point(93, 165);
            this.lStatus.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(91, 19);
            this.lStatus.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Red;
            this.lStatus.TabIndex = 20;
            this.lStatus.Text = "Không hợp lệ";
            this.lStatus.UseStyleColors = true;
            this.lStatus.Visible = false;
            // 
            // tNoiDung
            // 
            this.tNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.tNoiDung.CustomButton.Image = null;
            this.tNoiDung.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.tNoiDung.CustomButton.Name = "";
            this.tNoiDung.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.tNoiDung.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tNoiDung.CustomButton.TabIndex = 1;
            this.tNoiDung.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tNoiDung.CustomButton.UseSelectable = true;
            this.tNoiDung.CustomButton.Visible = false;
            this.tNoiDung.Lines = new string[0];
            this.tNoiDung.Location = new System.Drawing.Point(746, 10);
            this.tNoiDung.Margin = new System.Windows.Forms.Padding(0);
            this.tNoiDung.MaxLength = 32767;
            this.tNoiDung.Multiline = true;
            this.tNoiDung.Name = "tNoiDung";
            this.tNoiDung.PasswordChar = '\0';
            this.tNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tNoiDung.SelectedText = "";
            this.tNoiDung.SelectionLength = 0;
            this.tNoiDung.SelectionStart = 0;
            this.tNoiDung.ShortcutsEnabled = true;
            this.tNoiDung.Size = new System.Drawing.Size(256, 97);
            this.tNoiDung.TabIndex = 17;
            this.tNoiDung.UseSelectable = true;
            this.tNoiDung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tNoiDung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tNoiDung.TextChanged += new System.EventHandler(this.Input_ValueChanged);
            // 
            // poisonLabel10
            // 
            this.poisonLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonLabel10.AutoSize = true;
            this.poisonLabel10.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel10.Location = new System.Drawing.Point(672, 12);
            this.poisonLabel10.Margin = new System.Windows.Forms.Padding(16, 0, 8, 16);
            this.poisonLabel10.Name = "poisonLabel10";
            this.poisonLabel10.Size = new System.Drawing.Size(66, 19);
            this.poisonLabel10.TabIndex = 16;
            this.poisonLabel10.Text = "Nội dung";
            // 
            // lNgayKetThuc
            // 
            this.lNgayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lNgayKetThuc.AutoSize = true;
            this.lNgayKetThuc.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.lNgayKetThuc.Location = new System.Drawing.Point(386, 82);
            this.lNgayKetThuc.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.lNgayKetThuc.Name = "lNgayKetThuc";
            this.lNgayKetThuc.Size = new System.Drawing.Size(25, 19);
            this.lNgayKetThuc.TabIndex = 10;
            this.lNgayKetThuc.Text = "tới";
            // 
            // dNgayKetThuc
            // 
            this.dNgayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgayKetThuc.Location = new System.Drawing.Point(457, 76);
            this.dNgayKetThuc.Margin = new System.Windows.Forms.Padding(0);
            this.dNgayKetThuc.MinimumSize = new System.Drawing.Size(0, 29);
            this.dNgayKetThuc.Name = "dNgayKetThuc";
            this.dNgayKetThuc.Size = new System.Drawing.Size(188, 29);
            this.dNgayKetThuc.TabIndex = 11;
            this.dNgayKetThuc.CloseUp += new System.EventHandler(this.Input_ValueChanged);
            // 
            // mTuThoiGian
            // 
            this.mThoiGianBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mThoiGianBatDau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mThoiGianBatDau.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mThoiGianBatDau.Location = new System.Drawing.Point(166, 111);
            this.mThoiGianBatDau.Margin = new System.Windows.Forms.Padding(0);
            this.mThoiGianBatDau.Mask = "90 : 00";
            this.mThoiGianBatDau.Name = "mTuThoiGian";
            this.mThoiGianBatDau.Size = new System.Drawing.Size(80, 29);
            this.mThoiGianBatDau.TabIndex = 13;
            this.mThoiGianBatDau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mThoiGianBatDau.ValidatingType = typeof(System.DateTime);
            this.mThoiGianBatDau.TextChanged += new System.EventHandler(this.Input_ValueChanged);
            // 
            // mToiThoiGian
            // 
            this.mThoiGianKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mThoiGianKetThuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mThoiGianKetThuc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mThoiGianKetThuc.Location = new System.Drawing.Point(457, 111);
            this.mThoiGianKetThuc.Margin = new System.Windows.Forms.Padding(0);
            this.mThoiGianKetThuc.Mask = "90 : 00";
            this.mThoiGianKetThuc.Name = "mToiThoiGian";
            this.mThoiGianKetThuc.Size = new System.Drawing.Size(80, 29);
            this.mThoiGianKetThuc.TabIndex = 15;
            this.mThoiGianKetThuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mThoiGianKetThuc.ValidatingType = typeof(System.DateTime);
            this.mThoiGianKetThuc.TextChanged += new System.EventHandler(this.Input_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.bXoa);
            this.flowLayoutPanel1.Controls.Add(this.bHuy);
            this.flowLayoutPanel1.Controls.Add(this.bOk);
            this.flowLayoutPanel1.Controls.Add(this.bThongBao);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(746, 164);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 28);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // bThongBao
            // 
            this.bThongBao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bThongBao.AutoSize = true;
            this.bThongBao.Checked = true;
            this.bThongBao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bThongBao.Location = new System.Drawing.Point(136, 6);
            this.bThongBao.Name = "bThongBao";
            this.bThongBao.Size = new System.Drawing.Size(99, 15);
            this.bThongBao.TabIndex = 18;
            this.bThongBao.Text = "Gửi thông báo";
            this.bThongBao.UseSelectable = true;
            // 
            // SuaLich
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mThoiGianKetThuc);
            this.Controls.Add(this.mThoiGianBatDau);
            this.Controls.Add(this.dNgayKetThuc);
            this.Controls.Add(this.dNgayBatDau);
            this.Controls.Add(this.cLapLai);
            this.Controls.Add(this.poisonLabel5);
            this.Controls.Add(this.lNgayKetThuc);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.poisonLabel9);
            this.Controls.Add(this.poisonLabel4);
            this.Controls.Add(this.poisonLabel10);
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.poisonLabel2);
            this.Controls.Add(this.tNoiDung);
            this.Controls.Add(this.tDiaDiem);
            this.Controls.Add(this.cLoaiLich);
            this.Controls.Add(this.poisonLabel6);
            this.Controls.Add(this.tChuDe);
            this.Controls.Add(this.poisonLabel1);
            this.Name = "SuaLich";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1094, 200);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonButton bHuy;
        private ReaLTaiizor.Controls.PoisonButton bOk;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel5;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel4;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel6;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonButton bXoa;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel9;
        private ReaLTaiizor.Controls.PoisonLabel lStatus;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel10;
        private ReaLTaiizor.Controls.PoisonComboBox cLoaiLich;
        private ReaLTaiizor.Controls.PoisonComboBox cLapLai;
        private ReaLTaiizor.Controls.PoisonTextBox tDiaDiem;
        private ReaLTaiizor.Controls.PoisonTextBox tChuDe;
        private ReaLTaiizor.Controls.PoisonDateTime dNgayBatDau;
        private ReaLTaiizor.Controls.PoisonTextBox tNoiDung;
        private ReaLTaiizor.Controls.PoisonLabel lNgayKetThuc;
        private ReaLTaiizor.Controls.PoisonDateTime dNgayKetThuc;
        private System.Windows.Forms.MaskedTextBox mThoiGianBatDau;
        private System.Windows.Forms.MaskedTextBox mThoiGianKetThuc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.PoisonCheckBox bThongBao;
    }
}

