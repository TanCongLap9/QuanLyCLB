
namespace QuanLyCLB.LuuTru
{
    partial class DanhSachThuMuc
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
            this.poisonPanel4 = new ReaLTaiizor.Controls.PoisonPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.poisonTile1 = new ReaLTaiizor.Controls.PoisonTile();
            this.poisonPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // poisonPanel4
            // 
            this.poisonPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonPanel4.AutoScroll = true;
            this.poisonPanel4.BackColor = System.Drawing.Color.Transparent;
            this.poisonPanel4.Controls.Add(this.flowLayoutPanel2);
            this.poisonPanel4.HorizontalScrollbar = true;
            this.poisonPanel4.HorizontalScrollbarBarColor = true;
            this.poisonPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonPanel4.HorizontalScrollbarSize = 10;
            this.poisonPanel4.Location = new System.Drawing.Point(0, 0);
            this.poisonPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.poisonPanel4.Name = "poisonPanel4";
            this.poisonPanel4.Size = new System.Drawing.Size(138, 484);
            this.poisonPanel4.TabIndex = 0;
            this.poisonPanel4.VerticalScrollbar = true;
            this.poisonPanel4.VerticalScrollbarBarColor = true;
            this.poisonPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.poisonPanel4.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.poisonTile1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(128, 132);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // poisonTile1
            // 
            this.poisonTile1.ActiveControl = null;
            this.poisonTile1.DisplayFocusBorder = false;
            this.poisonTile1.Location = new System.Drawing.Point(0, 0);
            this.poisonTile1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.poisonTile1.Name = "poisonTile1";
            this.poisonTile1.Size = new System.Drawing.Size(128, 128);
            this.poisonTile1.TabIndex = 0;
            this.poisonTile1.Text = "poisonTile1";
            this.poisonTile1.TileCount = 5;
            this.poisonTile1.TileTextFontSize = ReaLTaiizor.Extension.Poison.PoisonTileTextSize.Small;
            this.poisonTile1.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Regular;
            this.poisonTile1.UseSelectable = true;
            // 
            // DanhSachThuMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.poisonPanel4);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DanhSachThuMuc";
            this.Size = new System.Drawing.Size(138, 484);
            this.poisonPanel4.ResumeLayout(false);
            this.poisonPanel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonPanel poisonPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ReaLTaiizor.Controls.PoisonTile poisonTile1;
    }
}
