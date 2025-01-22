
namespace QuanLyCLB.TaskWindow
{
    partial class UploadMultipleWindow
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "wefdafasgsdgasdgasdf",
            "Hoàn thành"}, "done");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "gsdfdasfasfasdfasdfasdfasdfdasdfasdfasdf",
            "Lỗi: abc"}, "error");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "gdsafdasfasfdasfasddfasfasfas",
            "Đang tải"}, "upload");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "gdfdasfasfasdfasdfasfasfasf",
            "Đang chờ"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "fd",
            "Đang chờ"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "fasd",
            "Đang chờ"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadMultipleWindow));
            this.pbProgress = new ReaLTaiizor.Controls.PoisonProgressBar();
            this.lProgress = new ReaLTaiizor.Controls.PoisonLabel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bHuy = new ReaLTaiizor.Controls.PoisonButton();
            this.ctxTapTin = new ReaLTaiizor.Controls.PoisonContextMenuStrip(this.components);
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poisonStyleManager1 = new ReaLTaiizor.Manager.PoisonStyleManager(this.components);
            this.ctxTapTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(34, 142);
            this.pbProgress.Margin = new System.Windows.Forms.Padding(0);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pbProgress.Size = new System.Drawing.Size(276, 15);
            this.pbProgress.TabIndex = 2;
            // 
            // lProgress
            // 
            this.lProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lProgress.AutoSize = true;
            this.lProgress.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.lProgress.Location = new System.Drawing.Point(0, 142);
            this.lProgress.Margin = new System.Windows.Forms.Padding(0);
            this.lProgress.Name = "lProgress";
            this.lProgress.Size = new System.Drawing.Size(34, 15);
            this.lProgress.TabIndex = 1;
            this.lProgress.Text = "100%";
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
            this.listView.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView.LargeImageList = this.imageList1;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(360, 129);
            this.listView.SmallImageList = this.imageList1;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tập tin";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tình trạng";
            this.columnHeader2.Width = 196;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "done");
            this.imageList1.Images.SetKeyName(1, "error");
            this.imageList1.Images.SetKeyName(2, "waiting");
            this.imageList1.Images.SetKeyName(3, "upload");
            this.imageList1.Images.SetKeyName(4, "download");
            // 
            // bHuy
            // 
            this.bHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bHuy.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            this.bHuy.Location = new System.Drawing.Point(314, 137);
            this.bHuy.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bHuy.Name = "bHuy";
            this.bHuy.Size = new System.Drawing.Size(46, 23);
            this.bHuy.TabIndex = 3;
            this.bHuy.Text = "Huỷ";
            this.bHuy.UseSelectable = true;
            this.bHuy.Click += new System.EventHandler(this.bHuyClick);
            // 
            // ctxTapTin
            // 
            this.ctxTapTin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemToolStripMenuItem,
            this.mởToolStripMenuItem});
            this.ctxTapTin.Name = "poisonContextMenuStrip1";
            this.ctxTapTin.Size = new System.Drawing.Size(137, 48);
            this.ctxTapTin.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.poisonContextMenuStrip1_ItemClicked);
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.xemToolStripMenuItem.Text = "Xem địa chỉ";
            // 
            // mởToolStripMenuItem
            // 
            this.mởToolStripMenuItem.Name = "mởToolStripMenuItem";
            this.mởToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.mởToolStripMenuItem.Text = "Mở";
            // 
            // poisonStyleManager1
            // 
            this.poisonStyleManager1.Owner = this;
            this.poisonStyleManager1.Style = global::QuanLyCLB.Properties.Settings.Default.Style;
            this.poisonStyleManager1.Theme = global::QuanLyCLB.Properties.Settings.Default.Theme;
            // 
            // UploadMultipleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bHuy);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lProgress);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UploadMultipleWindow";
            this.Size = new System.Drawing.Size(360, 160);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Default;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Default;
            this.Load += new System.EventHandler(this.UploadMultipleWindow_Load);
            this.ctxTapTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonProgressBar pbProgress;
        private ReaLTaiizor.Controls.PoisonLabel lProgress;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private ReaLTaiizor.Controls.PoisonButton bHuy;
        private ReaLTaiizor.Controls.PoisonContextMenuStrip ctxTapTin;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởToolStripMenuItem;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager1;
    }
}
