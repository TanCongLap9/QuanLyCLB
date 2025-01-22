
namespace QuanLyCLB.ThongBao
{
    partial class DanhSachThongBao
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "dsfasfas",
            "fdsfassg"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "fdasghasgs",
            "fdfasdfasf"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "fasdfasfasd",
            "fasdfasdg"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "fsdafasf",
            "fasdgasas"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "dfasasdg",
            "gdfasdfasd"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "fasddgsa",
            "gasdfasfasd"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "fasdfads",
            "fasdfas"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lStatus = new ReaLTaiizor.Controls.PoisonLabel();
            this.metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            this.bThongBaoMoi = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.bTaiLai = new ReaLTaiizor.Controls.PoisonButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listView1.Location = new System.Drawing.Point(0, 37);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(723, 423);
            this.listView1.TabIndex = 3;
            this.listView1.TileSize = new System.Drawing.Size(168, 40);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tiêu đề";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thời gian";
            // 
            // lStatus
            // 
            this.lStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lStatus.Location = new System.Drawing.Point(233, 183);
            this.lStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(257, 94);
            this.lStatus.TabIndex = 4;
            this.lStatus.Text = "Chưa có thông báo nào";
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lStatus.Visible = false;
            this.lStatus.WrapToLine = true;
            // 
            // metroDivider1
            // 
            this.metroDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDivider1.IsDerivedStyle = true;
            this.metroDivider1.Location = new System.Drawing.Point(0, 33);
            this.metroDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.metroDivider1.Name = "metroDivider1";
            this.metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            this.metroDivider1.Size = new System.Drawing.Size(723, 4);
            this.metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroDivider1.StyleManager = null;
            this.metroDivider1.TabIndex = 5;
            this.metroDivider1.Text = "metroDivider1";
            this.metroDivider1.ThemeAuthor = "Taiizor";
            this.metroDivider1.ThemeName = "MetroLight";
            this.metroDivider1.Thickness = 1;
            // 
            // bThongBaoMoi
            // 
            this.bThongBaoMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bThongBaoMoi.AutoSize = true;
            this.bThongBaoMoi.BackColor = System.Drawing.Color.Transparent;
            this.bThongBaoMoi.BackgroundImage = global::QuanLyCLB.Properties.Resources.edit_add;
            this.bThongBaoMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bThongBaoMoi.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            this.bThongBaoMoi.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            this.bThongBaoMoi.Location = new System.Drawing.Point(168, 0);
            this.bThongBaoMoi.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bThongBaoMoi.Name = "bThongBaoMoi";
            this.bThongBaoMoi.Size = new System.Drawing.Size(32, 32);
            this.bThongBaoMoi.TabIndex = 2;
            this.bThongBaoMoi.UseSelectable = true;
            this.bThongBaoMoi.Click += new System.EventHandler(this.Button_Click);
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel3.Location = new System.Drawing.Point(0, 4);
            this.poisonLabel3.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(95, 25);
            this.poisonLabel3.TabIndex = 0;
            this.poisonLabel3.Text = "Thông báo";
            // 
            // bTaiLai
            // 
            this.bTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTaiLai.AutoSize = true;
            this.bTaiLai.BackColor = System.Drawing.Color.Transparent;
            this.bTaiLai.BackgroundImage = global::QuanLyCLB.Properties.Resources.view_refresh_4;
            this.bTaiLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bTaiLai.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            this.bTaiLai.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            this.bTaiLai.Location = new System.Drawing.Point(132, 0);
            this.bTaiLai.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bTaiLai.Name = "bTaiLai";
            this.bTaiLai.Size = new System.Drawing.Size(32, 32);
            this.bTaiLai.TabIndex = 1;
            this.bTaiLai.UseSelectable = true;
            this.bTaiLai.Click += new System.EventHandler(this.Button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.bThongBaoMoi);
            this.flowLayoutPanel1.Controls.Add(this.bTaiLai);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(523, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 33);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // DanhSachThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.metroDivider1);
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DanhSachThongBao";
            this.Size = new System.Drawing.Size(723, 460);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private ReaLTaiizor.Controls.PoisonLabel lStatus;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private ReaLTaiizor.Controls.PoisonButton bThongBaoMoi;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private ReaLTaiizor.Controls.PoisonButton bTaiLai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
