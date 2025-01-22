namespace QuanLyCLB.TrinhDoc
{
    partial class GiaoDienTrinhDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienTrinhDoc));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lTitle = new ReaLTaiizor.Controls.PoisonLabel();
            this.pLoading = new ReaLTaiizor.Controls.PoisonPanel();
            this.poisonProgressSpinner1 = new ReaLTaiizor.Controls.PoisonProgressSpinner();
            this.pActions = new ReaLTaiizor.Controls.PoisonPanel();
            this.bTaiVe = new ReaLTaiizor.Controls.PoisonButton();
            this.bThongTin = new ReaLTaiizor.Controls.PoisonButton();
            this.picError = new System.Windows.Forms.PictureBox();
            this.poisonToolTip1 = new ReaLTaiizor.Controls.PoisonToolTip();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.pError = new ReaLTaiizor.Controls.PoisonPanel();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonStyleManager1 = new ReaLTaiizor.Manager.PoisonStyleManager(this.components);
            this.thongTinFile = new QuanLyCLB.LuuTru.ThongTinFile();
            this.pLoading.SuspendLayout();
            this.pActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.pError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Tất cả|*.*";
            // 
            // lTitle
            // 
            this.lTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTitle.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.lTitle.Location = new System.Drawing.Point(3, 30);
            this.lTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(502, 25);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Title";
            // 
            // pLoading
            // 
            this.pLoading.Controls.Add(this.poisonProgressSpinner1);
            this.pLoading.HorizontalScrollbarBarColor = true;
            this.pLoading.HorizontalScrollbarHighlightOnWheel = false;
            this.pLoading.HorizontalScrollbarSize = 10;
            this.pLoading.Location = new System.Drawing.Point(0, 30);
            this.pLoading.Margin = new System.Windows.Forms.Padding(0);
            this.pLoading.Name = "pLoading";
            this.pLoading.Size = new System.Drawing.Size(676, 442);
            this.pLoading.TabIndex = 5;
            this.pLoading.VerticalScrollbarBarColor = true;
            this.pLoading.VerticalScrollbarHighlightOnWheel = false;
            this.pLoading.VerticalScrollbarSize = 10;
            // 
            // poisonProgressSpinner1
            // 
            this.poisonProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.poisonProgressSpinner1.Location = new System.Drawing.Point(274, 157);
            this.poisonProgressSpinner1.Margin = new System.Windows.Forms.Padding(0);
            this.poisonProgressSpinner1.Maximum = 100;
            this.poisonProgressSpinner1.Name = "poisonProgressSpinner1";
            this.poisonProgressSpinner1.Size = new System.Drawing.Size(128, 128);
            this.poisonProgressSpinner1.TabIndex = 0;
            this.poisonProgressSpinner1.UseSelectable = true;
            this.poisonProgressSpinner1.Value = 40;
            // 
            // pActions
            // 
            this.pActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pActions.Controls.Add(this.bTaiVe);
            this.pActions.Controls.Add(this.bThongTin);
            this.pActions.HorizontalScrollbarBarColor = true;
            this.pActions.HorizontalScrollbarHighlightOnWheel = false;
            this.pActions.HorizontalScrollbarSize = 10;
            this.pActions.Location = new System.Drawing.Point(505, 30);
            this.pActions.Margin = new System.Windows.Forms.Padding(0);
            this.pActions.Name = "pActions";
            this.pActions.Size = new System.Drawing.Size(171, 28);
            this.pActions.TabIndex = 1;
            this.pActions.VerticalScrollbarBarColor = true;
            this.pActions.VerticalScrollbarHighlightOnWheel = false;
            this.pActions.VerticalScrollbarSize = 10;
            // 
            // bTaiVe
            // 
            this.bTaiVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTaiVe.BackgroundImage = global::QuanLyCLB.Properties.Resources.document_save_2;
            this.bTaiVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bTaiVe.Location = new System.Drawing.Point(107, 0);
            this.bTaiVe.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bTaiVe.Name = "bTaiVe";
            this.bTaiVe.Size = new System.Drawing.Size(28, 28);
            this.bTaiVe.TabIndex = 0;
            this.poisonToolTip1.SetToolTip(this.bTaiVe, "Tải về");
            this.bTaiVe.UseSelectable = true;
            this.bTaiVe.Click += new System.EventHandler(this.Button_OnClick);
            // 
            // bThongTin
            // 
            this.bThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bThongTin.BackgroundImage = global::QuanLyCLB.Properties.Resources.dialog_information_3;
            this.bThongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bThongTin.Location = new System.Drawing.Point(143, 0);
            this.bThongTin.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bThongTin.Name = "bThongTin";
            this.bThongTin.Size = new System.Drawing.Size(28, 28);
            this.bThongTin.TabIndex = 1;
            this.poisonToolTip1.SetToolTip(this.bThongTin, "Thông tin");
            this.bThongTin.UseSelectable = true;
            this.bThongTin.Click += new System.EventHandler(this.Button_OnClick);
            // 
            // picError
            // 
            this.picError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picError.Image = global::QuanLyCLB.Properties.Resources.file_broken;
            this.picError.Location = new System.Drawing.Point(162, 126);
            this.picError.Margin = new System.Windows.Forms.Padding(0);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(128, 128);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picError.TabIndex = 0;
            this.picError.TabStop = false;
            // 
            // poisonToolTip1
            // 
            this.poisonToolTip1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonToolTip1.StyleManager = null;
            this.poisonToolTip1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel1.Location = new System.Drawing.Point(122, 262);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(209, 25);
            this.poisonLabel1.TabIndex = 0;
            this.poisonLabel1.Text = "Không thể mở tập tin này.";
            this.poisonLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pError
            // 
            this.pError.Controls.Add(this.picError);
            this.pError.Controls.Add(this.poisonLabel1);
            this.pError.Controls.Add(this.poisonLabel2);
            this.pError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pError.HorizontalScrollbarBarColor = true;
            this.pError.HorizontalScrollbarHighlightOnWheel = false;
            this.pError.HorizontalScrollbarSize = 10;
            this.pError.Location = new System.Drawing.Point(3, 60);
            this.pError.Margin = new System.Windows.Forms.Padding(0);
            this.pError.Name = "pError";
            this.pError.Size = new System.Drawing.Size(453, 412);
            this.pError.TabIndex = 4;
            this.pError.VerticalScrollbarBarColor = true;
            this.pError.VerticalScrollbarHighlightOnWheel = false;
            this.pError.VerticalScrollbarSize = 10;
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.Location = new System.Drawing.Point(44, 287);
            this.poisonLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(365, 19);
            this.poisonLabel2.TabIndex = 1;
            this.poisonLabel2.Text = "Nếu máy bạn đọc được định dạng này, hãy tải tập tin này về.";
            this.poisonLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // poisonStyleManager1
            // 
            this.poisonStyleManager1.Owner = this;
            this.poisonStyleManager1.Style = global::QuanLyCLB.Properties.Settings.Default.Style;
            this.poisonStyleManager1.Theme = global::QuanLyCLB.Properties.Settings.Default.Theme;
            // 
            // thongTinFile
            // 
            this.thongTinFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.thongTinFile.Location = new System.Drawing.Point(456, 60);
            this.thongTinFile.Margin = new System.Windows.Forms.Padding(0);
            this.thongTinFile.Name = "thongTinFile";
            this.thongTinFile.Size = new System.Drawing.Size(220, 412);
            this.thongTinFile.TabIndex = 3;
            this.thongTinFile.UseSelectable = true;
            this.thongTinFile.Visible = false;
            // 
            // GiaoDienTrinhDoc
            // 
            this.ClientSize = new System.Drawing.Size(679, 475);
            this.Controls.Add(this.pActions);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.pError);
            this.Controls.Add(this.thongTinFile);
            this.Controls.Add(this.pLoading);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiaoDienTrinhDoc";
            this.Padding = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.Text = "Trình đọc";
            this.pLoading.ResumeLayout(false);
            this.pActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.pError.ResumeLayout(false);
            this.pError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picError;
        private ReaLTaiizor.Controls.PoisonButton bTaiVe;
        private ReaLTaiizor.Controls.PoisonButton bThongTin;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ReaLTaiizor.Controls.PoisonLabel lTitle;
        private ReaLTaiizor.Controls.PoisonPanel pLoading;
        private ReaLTaiizor.Controls.PoisonProgressSpinner poisonProgressSpinner1;
        private ReaLTaiizor.Controls.PoisonPanel pActions;
        private ReaLTaiizor.Controls.PoisonToolTip poisonToolTip1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonPanel pError;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private LuuTru.ThongTinFile thongTinFile;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager1;
    }
}