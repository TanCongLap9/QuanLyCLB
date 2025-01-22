
namespace QuanLyCLB.LuuTru
{
    partial class FolderItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderItem));
            this.poisonTile1 = new ReaLTaiizor.Controls.PoisonTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonTile1
            // 
            this.poisonTile1.ActiveControl = null;
            this.poisonTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonTile1.DisplayFocusBorder = false;
            this.poisonTile1.Location = new System.Drawing.Point(0, 0);
            this.poisonTile1.Margin = new System.Windows.Forms.Padding(0);
            this.poisonTile1.Name = "poisonTile1";
            this.poisonTile1.Size = new System.Drawing.Size(128, 128);
            this.poisonTile1.TabIndex = 0;
            this.poisonTile1.Text = "poisonTile1";
            this.poisonTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("poisonTile1.TileImage")));
            this.poisonTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.poisonTile1.TileTextFontSize = ReaLTaiizor.Extension.Poison.PoisonTileTextSize.Small;
            this.poisonTile1.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Regular;
            this.poisonTile1.UseCustomBackColor = true;
            this.poisonTile1.UseCustomForeColor = true;
            this.poisonTile1.UseSelectable = true;
            this.poisonTile1.UseTileImage = true;
            this.poisonTile1.Click += new System.EventHandler(this.poisonTile1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QuanLyCLB.Properties.Resources.key;
            this.pictureBox1.Location = new System.Drawing.Point(102, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FolderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.poisonTile1);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Name = "FolderItem";
            this.Size = new System.Drawing.Size(128, 128);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTile poisonTile1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
