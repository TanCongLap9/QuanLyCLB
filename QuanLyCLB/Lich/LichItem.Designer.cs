
namespace QuanLyCLB.Lich
{
    partial class LichItem
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
            this.poisonTile8 = new ReaLTaiizor.Controls.PoisonTile();
            this.lDiaDiem = new ReaLTaiizor.Controls.PoisonLabel();
            this.lThoiGian = new ReaLTaiizor.Controls.PoisonLabel();
            this.lChuDe = new ReaLTaiizor.Controls.PoisonLabel();
            this.SuspendLayout();
            // 
            // poisonTile8
            // 
            this.poisonTile8.ActiveControl = null;
            this.poisonTile8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonTile8.Location = new System.Drawing.Point(0, 0);
            this.poisonTile8.Margin = new System.Windows.Forms.Padding(0);
            this.poisonTile8.Name = "poisonTile8";
            this.poisonTile8.Size = new System.Drawing.Size(119, 89);
            this.poisonTile8.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            this.poisonTile8.TabIndex = 0;
            this.poisonTile8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.poisonTile8.TileTextFontSize = ReaLTaiizor.Extension.Poison.PoisonTileTextSize.Small;
            this.poisonTile8.TileTextFontWeight = ReaLTaiizor.Extension.Poison.PoisonTileTextWeight.Regular;
            this.poisonTile8.UseCustomBackColor = true;
            this.poisonTile8.UseCustomForeColor = true;
            this.poisonTile8.UseSelectable = true;
            this.poisonTile8.Click += new System.EventHandler(this.Control_Click);
            // 
            // lDiaDiem
            // 
            this.lDiaDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lDiaDiem.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.lDiaDiem.Location = new System.Drawing.Point(4, 51);
            this.lDiaDiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDiaDiem.Name = "lDiaDiem";
            this.lDiaDiem.Size = new System.Drawing.Size(111, 30);
            this.lDiaDiem.TabIndex = 3;
            this.lDiaDiem.Text = "Địa điểm";
            this.lDiaDiem.UseCustomBackColor = true;
            this.lDiaDiem.UseCustomForeColor = true;
            this.lDiaDiem.WrapToLine = true;
            this.lDiaDiem.Click += new System.EventHandler(this.Control_Click);
            this.lDiaDiem.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            // 
            // lThoiGian
            // 
            this.lThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lThoiGian.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.lThoiGian.Location = new System.Drawing.Point(4, 35);
            this.lThoiGian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lThoiGian.Name = "lThoiGian";
            this.lThoiGian.Size = new System.Drawing.Size(111, 15);
            this.lThoiGian.TabIndex = 2;
            this.lThoiGian.Text = "Thời gian";
            this.lThoiGian.UseCustomBackColor = true;
            this.lThoiGian.UseCustomForeColor = true;
            this.lThoiGian.WrapToLine = true;
            this.lThoiGian.Click += new System.EventHandler(this.Control_Click);
            this.lThoiGian.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            // 
            // lChuDe
            // 
            this.lChuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lChuDe.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.lChuDe.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.lChuDe.Location = new System.Drawing.Point(4, 4);
            this.lChuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.lChuDe.Name = "lChuDe";
            this.lChuDe.Size = new System.Drawing.Size(111, 30);
            this.lChuDe.TabIndex = 1;
            this.lChuDe.Text = "Chủ đề fdsaf adsfda fasasdffasf af adfas fas asfsa fdafdas dfas fasfas";
            this.lChuDe.UseCustomBackColor = true;
            this.lChuDe.UseCustomForeColor = true;
            this.lChuDe.WrapToLine = true;
            this.lChuDe.Click += new System.EventHandler(this.Control_Click);
            this.lChuDe.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            // 
            // LichItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lChuDe);
            this.Controls.Add(this.lThoiGian);
            this.Controls.Add(this.lDiaDiem);
            this.Controls.Add(this.poisonTile8);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LichItem";
            this.Size = new System.Drawing.Size(119, 89);
            this.UseCustomBackColor = true;
            this.UseCustomForeColor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTile poisonTile8;
        private ReaLTaiizor.Controls.PoisonLabel lDiaDiem;
        private ReaLTaiizor.Controls.PoisonLabel lThoiGian;
        private ReaLTaiizor.Controls.PoisonLabel lChuDe;
    }
}
