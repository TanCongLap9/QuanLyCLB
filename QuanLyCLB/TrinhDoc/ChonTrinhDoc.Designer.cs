namespace QuanLyCLB.TrinhDoc
{
    partial class ChonTrinhDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonTrinhDoc));
            this.bImage = new ReaLTaiizor.Controls.PoisonTile();
            this.bText = new ReaLTaiizor.Controls.PoisonTile();
            this.bVideo = new ReaLTaiizor.Controls.PoisonTile();
            this.bDocument = new ReaLTaiizor.Controls.PoisonTile();
            this.poisonStyleManager1 = new ReaLTaiizor.Manager.PoisonStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // bImage
            // 
            this.bImage.ActiveControl = null;
            this.bImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bImage.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bImage.DisplayFocusBorder = false;
            this.bImage.Location = new System.Drawing.Point(23, 60);
            this.bImage.Margin = new System.Windows.Forms.Padding(20, 0, 8, 8);
            this.bImage.Name = "bImage";
            this.bImage.Size = new System.Drawing.Size(128, 128);
            this.bImage.TabIndex = 0;
            this.bImage.Text = "Hình ảnh";
            this.bImage.TileImage = global::QuanLyCLB.Properties.Resources.image_x_generic;
            this.bImage.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.bImage.UseSelectable = true;
            this.bImage.UseTileImage = true;
            this.bImage.Click += new System.EventHandler(this.Control_Click);
            // 
            // bText
            // 
            this.bText.ActiveControl = null;
            this.bText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bText.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bText.DisplayFocusBorder = false;
            this.bText.Location = new System.Drawing.Point(167, 60);
            this.bText.Margin = new System.Windows.Forms.Padding(8, 0, 20, 8);
            this.bText.Name = "bText";
            this.bText.Size = new System.Drawing.Size(128, 128);
            this.bText.TabIndex = 1;
            this.bText.Text = "Văn bản";
            this.bText.TileImage = global::QuanLyCLB.Properties.Resources.accessories_text_editor_8;
            this.bText.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.bText.UseSelectable = true;
            this.bText.UseTileImage = true;
            this.bText.Click += new System.EventHandler(this.Control_Click);
            // 
            // bVideo
            // 
            this.bVideo.ActiveControl = null;
            this.bVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bVideo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bVideo.DisplayFocusBorder = false;
            this.bVideo.Location = new System.Drawing.Point(23, 204);
            this.bVideo.Margin = new System.Windows.Forms.Padding(20, 8, 8, 16);
            this.bVideo.Name = "bVideo";
            this.bVideo.Size = new System.Drawing.Size(128, 128);
            this.bVideo.TabIndex = 2;
            this.bVideo.Text = "Âm thanh/Video";
            this.bVideo.TileImage = global::QuanLyCLB.Properties.Resources.multimedia_player_mp3player_alt;
            this.bVideo.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.bVideo.UseSelectable = true;
            this.bVideo.UseTileImage = true;
            this.bVideo.Click += new System.EventHandler(this.Control_Click);
            // 
            // bDocument
            // 
            this.bDocument.ActiveControl = null;
            this.bDocument.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bDocument.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bDocument.DisplayFocusBorder = false;
            this.bDocument.Location = new System.Drawing.Point(167, 204);
            this.bDocument.Margin = new System.Windows.Forms.Padding(8, 8, 20, 16);
            this.bDocument.Name = "bDocument";
            this.bDocument.Size = new System.Drawing.Size(128, 128);
            this.bDocument.TabIndex = 3;
            this.bDocument.Text = "Trình duyệt";
            this.bDocument.TileImage = global::QuanLyCLB.Properties.Resources.chromium_2;
            this.bDocument.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Bold;
            this.bDocument.UseSelectable = true;
            this.bDocument.UseTileImage = true;
            this.bDocument.Click += new System.EventHandler(this.Control_Click);
            // 
            // poisonStyleManager1
            // 
            this.poisonStyleManager1.Owner = this;
            this.poisonStyleManager1.Style = global::QuanLyCLB.Properties.Settings.Default.Style;
            this.poisonStyleManager1.Theme = global::QuanLyCLB.Properties.Settings.Default.Theme;
            // 
            // ChonTrinhDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 351);
            this.Controls.Add(this.bImage);
            this.Controls.Add(this.bText);
            this.Controls.Add(this.bVideo);
            this.Controls.Add(this.bDocument);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChonTrinhDoc";
            this.Padding = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mở bằng...";
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTile bImage;
        private ReaLTaiizor.Controls.PoisonTile bDocument;
        private ReaLTaiizor.Controls.PoisonTile bVideo;
        private ReaLTaiizor.Controls.PoisonTile bText;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager1;
    }
}