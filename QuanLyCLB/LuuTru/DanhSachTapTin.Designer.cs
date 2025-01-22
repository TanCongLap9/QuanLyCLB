
namespace QuanLyCLB.LuuTru
{
    partial class DanhSachTapTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachTapTin));
            this.ilDetails = new System.Windows.Forms.ImageList(this.components);
            this.spinner = new ReaLTaiizor.Controls.PoisonProgressSpinner();
            this.lText = new ReaLTaiizor.Controls.PoisonLabel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.lTaiLen = new ReaLTaiizor.Controls.PoisonLabel();
            this.SuspendLayout();
            // 
            // ilDetails
            // 
            this.ilDetails.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDetails.ImageStream")));
            this.ilDetails.TransparentColor = System.Drawing.Color.Transparent;
            this.ilDetails.Images.SetKeyName(0, "Class_16x.png");
            this.ilDetails.Images.SetKeyName(1, "Field_16x.png");
            this.ilDetails.Images.SetKeyName(2, "360_F_147396946_DEH26IJr8Sd0nabEMhjaAPF6XJxQQAFT.jpg");
            // 
            // spinner
            // 
            this.spinner.AllowDrop = true;
            this.spinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spinner.Location = new System.Drawing.Point(1044, 502);
            this.spinner.Margin = new System.Windows.Forms.Padding(8);
            this.spinner.Maximum = 100;
            this.spinner.Name = "spinner";
            this.spinner.Size = new System.Drawing.Size(32, 32);
            this.spinner.TabIndex = 2;
            this.spinner.UseSelectable = true;
            this.spinner.Value = 50;
            this.spinner.Visible = false;
            this.spinner.DragDrop += new System.Windows.Forms.DragEventHandler(this.Control_DragDrop);
            this.spinner.DragEnter += new System.Windows.Forms.DragEventHandler(this.Control_DragEnter);
            this.spinner.DragLeave += new System.EventHandler(this.Control_DragLeave);
            // 
            // lText
            // 
            this.lText.AllowDrop = true;
            this.lText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lText.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.lText.Location = new System.Drawing.Point(432, 252);
            this.lText.Margin = new System.Windows.Forms.Padding(0);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(220, 38);
            this.lText.TabIndex = 1;
            this.lText.Text = "Chọn thư mục cần duyệt.";
            this.lText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lText.WrapToLine = true;
            this.lText.DragDrop += new System.Windows.Forms.DragEventHandler(this.Control_DragDrop);
            this.lText.DragEnter += new System.Windows.Forms.DragEventHandler(this.Control_DragEnter);
            this.lText.DragLeave += new System.EventHandler(this.Control_DragLeave);
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.LabelEdit = true;
            this.listView.LargeImageList = this.ilLarge;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(0);
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(1084, 542);
            this.listView.SmallImageList = this.ilDetails;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView_AfterLabelEdit);
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DragDrop += new System.Windows.Forms.DragEventHandler(this.Control_DragDrop);
            this.listView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Control_DragEnter);
            this.listView.DragLeave += new System.EventHandler(this.Control_DragLeave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên ▴";
            this.columnHeader1.Width = 216;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kiểu tập tin";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời gian sửa đổi";
            this.columnHeader3.Width = 168;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thời gian tạo";
            this.columnHeader4.Width = 168;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dung lượng";
            this.columnHeader5.Width = 122;
            // 
            // ilLarge
            // 
            this.ilLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLarge.ImageStream")));
            this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ilLarge.Images.SetKeyName(0, "Class_16x.png");
            this.ilLarge.Images.SetKeyName(1, "Field_16x.png");
            this.ilLarge.Images.SetKeyName(2, "360_F_147396946_DEH26IJr8Sd0nabEMhjaAPF6XJxQQAFT.jpg");
            // 
            // lTaiLen
            // 
            this.lTaiLen.AllowDrop = true;
            this.lTaiLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTaiLen.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.lTaiLen.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.lTaiLen.Location = new System.Drawing.Point(0, 0);
            this.lTaiLen.Margin = new System.Windows.Forms.Padding(0);
            this.lTaiLen.Name = "lTaiLen";
            this.lTaiLen.Size = new System.Drawing.Size(1084, 542);
            this.lTaiLen.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            this.lTaiLen.TabIndex = 3;
            this.lTaiLen.Text = "Thả vào đây để tải tập tin lên.";
            this.lTaiLen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lTaiLen.UseStyleColors = true;
            this.lTaiLen.Visible = false;
            this.lTaiLen.DragDrop += new System.Windows.Forms.DragEventHandler(this.Control_DragDrop);
            this.lTaiLen.DragEnter += new System.Windows.Forms.DragEventHandler(this.Control_DragEnter);
            this.lTaiLen.DragLeave += new System.EventHandler(this.Control_DragLeave);
            // 
            // DanhSachTapTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lText);
            this.Controls.Add(this.spinner);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lTaiLen);
            this.Name = "DanhSachTapTin";
            this.Size = new System.Drawing.Size(1084, 542);
            this.Load += new System.EventHandler(this.DanhSachTapTin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ilDetails;
        private ReaLTaiizor.Controls.PoisonProgressSpinner spinner;
        private ReaLTaiizor.Controls.PoisonLabel lText;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList ilLarge;
        private ReaLTaiizor.Controls.PoisonLabel lTaiLen;
    }
}
