
namespace QuanLyCLB.BaiViet
{
    partial class DanhSachBaiViet
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
            "fasds",
            "gsdfas"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "fsdasf",
            "fdassgasdgs"}, -1);
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.bBaiVietMoi = new ReaLTaiizor.Controls.PoisonButton();
            this.metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            this.lStatus = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bTaiLai = new ReaLTaiizor.Controls.PoisonButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.poisonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel1.Location = new System.Drawing.Point(0, 4);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(75, 25);
            this.poisonLabel1.TabIndex = 0;
            this.poisonLabel1.Text = "Gần đây";
            // 
            // bBaiVietMoi
            // 
            this.bBaiVietMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBaiVietMoi.AutoSize = true;
            this.bBaiVietMoi.BackgroundImage = global::QuanLyCLB.Properties.Resources.edit_add;
            this.bBaiVietMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bBaiVietMoi.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            this.bBaiVietMoi.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            this.bBaiVietMoi.Location = new System.Drawing.Point(168, 0);
            this.bBaiVietMoi.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bBaiVietMoi.Name = "bBaiVietMoi";
            this.bBaiVietMoi.Size = new System.Drawing.Size(32, 32);
            this.bBaiVietMoi.TabIndex = 1;
            this.bBaiVietMoi.UseSelectable = true;
            this.bBaiVietMoi.Click += new System.EventHandler(this.Button_Click);
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
            this.metroDivider1.Size = new System.Drawing.Size(802, 4);
            this.metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroDivider1.StyleManager = null;
            this.metroDivider1.TabIndex = 2;
            this.metroDivider1.Text = "metroDivider1";
            this.metroDivider1.ThemeAuthor = "Taiizor";
            this.metroDivider1.ThemeName = "MetroLight";
            this.metroDivider1.Thickness = 1;
            // 
            // lStatus
            // 
            this.lStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lStatus.Location = new System.Drawing.Point(264, 177);
            this.lStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(275, 51);
            this.lStatus.TabIndex = 1;
            this.lStatus.Text = "Hiện chưa có bài viết nào.";
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lStatus.Visible = false;
            // 
            // poisonPanel1
            // 
            this.poisonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonPanel1.Controls.Add(this.lStatus);
            this.poisonPanel1.Controls.Add(this.listView1);
            this.poisonPanel1.HorizontalScrollbarBarColor = true;
            this.poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.HorizontalScrollbarSize = 10;
            this.poisonPanel1.Location = new System.Drawing.Point(0, 37);
            this.poisonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.poisonPanel1.Name = "poisonPanel1";
            this.poisonPanel1.Size = new System.Drawing.Size(802, 405);
            this.poisonPanel1.TabIndex = 3;
            this.poisonPanel1.VerticalScrollbarBarColor = true;
            this.poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(802, 405);
            this.listView1.TabIndex = 0;
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
            this.columnHeader2.Text = "Tác giả";
            // 
            // bTaiLai
            // 
            this.bTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTaiLai.AutoSize = true;
            this.bTaiLai.BackgroundImage = global::QuanLyCLB.Properties.Resources.view_refresh_4;
            this.bTaiLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bTaiLai.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            this.bTaiLai.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            this.bTaiLai.Location = new System.Drawing.Point(132, 0);
            this.bTaiLai.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bTaiLai.Name = "bTaiLai";
            this.bTaiLai.Size = new System.Drawing.Size(32, 32);
            this.bTaiLai.TabIndex = 0;
            this.bTaiLai.UseSelectable = true;
            this.bTaiLai.Click += new System.EventHandler(this.Button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.bBaiVietMoi);
            this.flowLayoutPanel1.Controls.Add(this.bTaiLai);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(602, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 33);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // DanhSachBaiViet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroDivider1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.poisonPanel1);
            this.Controls.Add(this.poisonLabel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DanhSachBaiViet";
            this.Size = new System.Drawing.Size(802, 442);
            this.poisonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonButton bBaiVietMoi;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private ReaLTaiizor.Controls.PoisonLabel lStatus;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private ReaLTaiizor.Controls.PoisonButton bTaiLai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
