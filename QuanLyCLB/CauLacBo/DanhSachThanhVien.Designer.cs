
namespace QuanLyCLB.CauLacBo
{
    partial class DanhSachThanhVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachThanhVien));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2", 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3", 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("4", 0);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("5", 0);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("6", 0);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("7", 0);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("8", 0);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("9", 0);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("10", 0);
            this.lSoLuongThanhVien = new ReaLTaiizor.Controls.PoisonLabel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxListView = new ReaLTaiizor.Controls.PoisonContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiChứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trưởngNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phóNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTimKiem = new ReaLTaiizor.Controls.PoisonTextBox();
            this.bThem = new ReaLTaiizor.Controls.PoisonButton();
            this.bXoa = new ReaLTaiizor.Controls.PoisonButton();
            this.lStatus = new ReaLTaiizor.Controls.PoisonLabel();
            this.hopThongBao = new QuanLyCLB.LuuTru.AlertBox();
            this.bTaiLai = new ReaLTaiizor.Controls.PoisonButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ctxListView.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lSoLuongThanhVien
            // 
            this.lSoLuongThanhVien.AutoSize = true;
            this.lSoLuongThanhVien.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.lSoLuongThanhVien.Location = new System.Drawing.Point(0, 0);
            this.lSoLuongThanhVien.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lSoLuongThanhVien.Name = "lSoLuongThanhVien";
            this.lSoLuongThanhVien.Size = new System.Drawing.Size(124, 25);
            this.lSoLuongThanhVien.TabIndex = 0;
            this.lSoLuongThanhVien.Text = "123 thành viên";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ten-goi-va-hinh-anh-cac-loai-hoa-phong-lan-dep-pho-bien-nhat-1.jpg");
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.ContextMenuStrip = this.ctxListView;
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(0, 51);
            this.listView.Margin = new System.Windows.Forms.Padding(0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(649, 289);
            this.listView.SmallImageList = this.imageList;
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Tile;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MSSV, Chức vụ";
            // 
            // ctxListView
            // 
            this.ctxListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xoáToolStripMenuItem1,
            this.đổiChứcVụToolStripMenuItem});
            this.ctxListView.Name = "ctxListView";
            this.ctxListView.Size = new System.Drawing.Size(138, 70);
            this.ctxListView.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxItem_ItemClicked);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Image = global::QuanLyCLB.Properties.Resources.list_add_4;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // xoáToolStripMenuItem1
            // 
            this.xoáToolStripMenuItem1.Image = global::QuanLyCLB.Properties.Resources.dialog_cancel_2;
            this.xoáToolStripMenuItem1.Name = "xoáToolStripMenuItem1";
            this.xoáToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.xoáToolStripMenuItem1.Text = "Xoá";
            // 
            // đổiChứcVụToolStripMenuItem
            // 
            this.đổiChứcVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trưởngNhómToolStripMenuItem,
            this.phóNhómToolStripMenuItem,
            this.thànhViênToolStripMenuItem});
            this.đổiChứcVụToolStripMenuItem.Name = "đổiChứcVụToolStripMenuItem";
            this.đổiChứcVụToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.đổiChứcVụToolStripMenuItem.Text = "Đổi chức vụ";
            this.đổiChứcVụToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxItem_ItemClicked);
            // 
            // trưởngNhómToolStripMenuItem
            // 
            this.trưởngNhómToolStripMenuItem.Name = "trưởngNhómToolStripMenuItem";
            this.trưởngNhómToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.trưởngNhómToolStripMenuItem.Text = "Trưởng nhóm";
            // 
            // phóNhómToolStripMenuItem
            // 
            this.phóNhómToolStripMenuItem.Name = "phóNhómToolStripMenuItem";
            this.phóNhómToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.phóNhómToolStripMenuItem.Text = "Phó nhóm";
            // 
            // thànhViênToolStripMenuItem
            // 
            this.thànhViênToolStripMenuItem.Name = "thànhViênToolStripMenuItem";
            this.thànhViênToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.thànhViênToolStripMenuItem.Text = "Thành viên";
            // 
            // tTimKiem
            // 
            this.tTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tTimKiem.CustomButton.Image = null;
            this.tTimKiem.CustomButton.Location = new System.Drawing.Point(627, 1);
            this.tTimKiem.CustomButton.Name = "";
            this.tTimKiem.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tTimKiem.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tTimKiem.CustomButton.TabIndex = 1;
            this.tTimKiem.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tTimKiem.CustomButton.UseSelectable = true;
            this.tTimKiem.CustomButton.Visible = false;
            this.tTimKiem.Lines = new string[0];
            this.tTimKiem.Location = new System.Drawing.Point(0, 28);
            this.tTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.tTimKiem.MaxLength = 32767;
            this.tTimKiem.Name = "tTimKiem";
            this.tTimKiem.PasswordChar = '\0';
            this.tTimKiem.PromptText = "Tìm kiếm";
            this.tTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tTimKiem.SelectedText = "";
            this.tTimKiem.SelectionLength = 0;
            this.tTimKiem.SelectionStart = 0;
            this.tTimKiem.ShortcutsEnabled = true;
            this.tTimKiem.Size = new System.Drawing.Size(649, 23);
            this.tTimKiem.TabIndex = 2;
            this.tTimKiem.UseSelectable = true;
            this.tTimKiem.WaterMark = "Tìm kiếm";
            this.tTimKiem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tTimKiem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tTimKiem_KeyDown);
            // 
            // bThem
            // 
            this.bThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bThem.BackColor = System.Drawing.Color.Transparent;
            this.bThem.BackgroundImage = global::QuanLyCLB.Properties.Resources.edit_add;
            this.bThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bThem.Location = new System.Drawing.Point(136, 0);
            this.bThem.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bThem.Name = "bThem";
            this.bThem.Size = new System.Drawing.Size(28, 28);
            this.bThem.TabIndex = 1;
            this.bThem.UseSelectable = true;
            this.bThem.Click += new System.EventHandler(this.Button_Click);
            // 
            // bXoa
            // 
            this.bXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bXoa.BackColor = System.Drawing.Color.Transparent;
            this.bXoa.BackgroundImage = global::QuanLyCLB.Properties.Resources.edit_delete_6;
            this.bXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bXoa.Enabled = false;
            this.bXoa.Location = new System.Drawing.Point(172, 0);
            this.bXoa.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(28, 28);
            this.bXoa.TabIndex = 2;
            this.bXoa.UseSelectable = true;
            this.bXoa.Click += new System.EventHandler(this.Button_Click);
            // 
            // lStatus
            // 
            this.lStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatus.Location = new System.Drawing.Point(0, 51);
            this.lStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(649, 289);
            this.lStatus.TabIndex = 4;
            this.lStatus.Text = "Trống";
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lStatus.Visible = false;
            // 
            // hopThongBao
            // 
            this.hopThongBao.AutoSize = true;
            this.hopThongBao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hopThongBao.Location = new System.Drawing.Point(271, 28);
            this.hopThongBao.Margin = new System.Windows.Forms.Padding(0);
            this.hopThongBao.Name = "hopThongBao";
            this.hopThongBao.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.hopThongBao.Size = new System.Drawing.Size(107, 35);
            this.hopThongBao.TabIndex = 5;
            this.hopThongBao.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.hopThongBao.UseSelectable = true;
            this.hopThongBao.Visible = false;
            // 
            // bTaiLai
            // 
            this.bTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTaiLai.BackColor = System.Drawing.Color.Transparent;
            this.bTaiLai.BackgroundImage = global::QuanLyCLB.Properties.Resources.view_refresh_4;
            this.bTaiLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bTaiLai.Location = new System.Drawing.Point(100, 0);
            this.bTaiLai.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bTaiLai.Name = "bTaiLai";
            this.bTaiLai.Size = new System.Drawing.Size(28, 28);
            this.bTaiLai.TabIndex = 0;
            this.bTaiLai.UseSelectable = true;
            this.bTaiLai.Click += new System.EventHandler(this.Button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.bXoa);
            this.flowLayoutPanel1.Controls.Add(this.bThem);
            this.flowLayoutPanel1.Controls.Add(this.bTaiLai);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(449, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 28);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // DanhSachThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hopThongBao);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tTimKiem);
            this.Controls.Add(this.lSoLuongThanhVien);
            this.Controls.Add(this.lStatus);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DanhSachThanhVien";
            this.Size = new System.Drawing.Size(649, 340);
            this.ctxListView.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel lSoLuongThanhVien;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView listView;
        private ReaLTaiizor.Controls.PoisonTextBox tTimKiem;
        private ReaLTaiizor.Controls.PoisonButton bThem;
        private ReaLTaiizor.Controls.PoisonButton bXoa;
        private ReaLTaiizor.Controls.PoisonLabel lStatus;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private ReaLTaiizor.Controls.PoisonContextMenuStrip ctxListView;
        private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private LuuTru.AlertBox hopThongBao;
        private System.Windows.Forms.ToolStripMenuItem đổiChứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phóNhómToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thànhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trưởngNhómToolStripMenuItem;
        private ReaLTaiizor.Controls.PoisonButton bTaiLai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
