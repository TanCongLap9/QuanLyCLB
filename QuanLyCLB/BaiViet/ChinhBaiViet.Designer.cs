namespace QuanLyCLB.BaiViet
{
    partial class ChinhBaiViet
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
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.tTieuDe = new ReaLTaiizor.Controls.PoisonTextBox();
            this.bTaiLen = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonToolTip1 = new ReaLTaiizor.Controls.PoisonToolTip();
            this.poisonLabel5 = new ReaLTaiizor.Controls.PoisonLabel();
            this.tTacGia = new ReaLTaiizor.Controls.PoisonTextBox();
            this.bHuy = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonLabel6 = new ReaLTaiizor.Controls.PoisonLabel();
            this.tCacNhan = new ReaLTaiizor.Controls.PoisonTextBox();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.tCauLacBo = new ReaLTaiizor.Controls.PoisonTextBox();
            this.SuspendLayout();
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel1.Location = new System.Drawing.Point(219, 16);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(149, 25);
            this.poisonLabel1.TabIndex = 0;
            this.poisonLabel1.Text = "Tùy chỉnh bài viết";
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.Location = new System.Drawing.Point(16, 59);
            this.poisonLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(52, 19);
            this.poisonLabel2.TabIndex = 1;
            this.poisonLabel2.Text = "Tiêu đề";
            // 
            // tTieuDe
            // 
            this.tTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tTieuDe.CustomButton.Image = null;
            this.tTieuDe.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.tTieuDe.CustomButton.Name = "";
            this.tTieuDe.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tTieuDe.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tTieuDe.CustomButton.TabIndex = 1;
            this.tTieuDe.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tTieuDe.CustomButton.UseSelectable = true;
            this.tTieuDe.CustomButton.Visible = false;
            this.tTieuDe.Enabled = false;
            this.tTieuDe.Lines = new string[0];
            this.tTieuDe.Location = new System.Drawing.Point(133, 57);
            this.tTieuDe.Margin = new System.Windows.Forms.Padding(0);
            this.tTieuDe.MaxLength = 32767;
            this.tTieuDe.Name = "tTieuDe";
            this.tTieuDe.PasswordChar = '\0';
            this.tTieuDe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tTieuDe.SelectedText = "";
            this.tTieuDe.SelectionLength = 0;
            this.tTieuDe.SelectionStart = 0;
            this.tTieuDe.ShortcutsEnabled = true;
            this.tTieuDe.Size = new System.Drawing.Size(437, 23);
            this.tTieuDe.TabIndex = 2;
            this.tTieuDe.UseSelectable = true;
            this.tTieuDe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tTieuDe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bTaiLen
            // 
            this.bTaiLen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bTaiLen.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.bTaiLen.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            this.bTaiLen.Location = new System.Drawing.Point(214, 397);
            this.bTaiLen.Margin = new System.Windows.Forms.Padding(0);
            this.bTaiLen.Name = "bTaiLen";
            this.bTaiLen.Size = new System.Drawing.Size(75, 23);
            this.bTaiLen.TabIndex = 9;
            this.bTaiLen.Text = "Tải lên";
            this.bTaiLen.UseSelectable = true;
            this.bTaiLen.Click += new System.EventHandler(this.Button_Click);
            // 
            // poisonToolTip1
            // 
            this.poisonToolTip1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonToolTip1.StyleManager = null;
            this.poisonToolTip1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // poisonLabel5
            // 
            this.poisonLabel5.AutoSize = true;
            this.poisonLabel5.Location = new System.Drawing.Point(16, 129);
            this.poisonLabel5.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel5.Name = "poisonLabel5";
            this.poisonLabel5.Size = new System.Drawing.Size(51, 19);
            this.poisonLabel5.TabIndex = 5;
            this.poisonLabel5.Text = "Tác giả";
            // 
            // tTacGia
            // 
            this.tTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tTacGia.CustomButton.Image = null;
            this.tTacGia.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.tTacGia.CustomButton.Name = "";
            this.tTacGia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tTacGia.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tTacGia.CustomButton.TabIndex = 1;
            this.tTacGia.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tTacGia.CustomButton.UseSelectable = true;
            this.tTacGia.CustomButton.Visible = false;
            this.tTacGia.Enabled = false;
            this.tTacGia.Lines = new string[0];
            this.tTacGia.Location = new System.Drawing.Point(133, 127);
            this.tTacGia.Margin = new System.Windows.Forms.Padding(0);
            this.tTacGia.MaxLength = 32767;
            this.tTacGia.Name = "tTacGia";
            this.tTacGia.PasswordChar = '\0';
            this.tTacGia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tTacGia.SelectedText = "";
            this.tTacGia.SelectionLength = 0;
            this.tTacGia.SelectionStart = 0;
            this.tTacGia.ShortcutsEnabled = true;
            this.tTacGia.Size = new System.Drawing.Size(437, 23);
            this.tTacGia.TabIndex = 6;
            this.tTacGia.UseSelectable = true;
            this.tTacGia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tTacGia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bHuy
            // 
            this.bHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bHuy.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.bHuy.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            this.bHuy.Location = new System.Drawing.Point(297, 397);
            this.bHuy.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bHuy.Name = "bHuy";
            this.bHuy.Size = new System.Drawing.Size(75, 23);
            this.bHuy.TabIndex = 10;
            this.bHuy.Text = "Huỷ";
            this.bHuy.UseSelectable = true;
            this.bHuy.Click += new System.EventHandler(this.Button_Click);
            // 
            // poisonLabel6
            // 
            this.poisonLabel6.AutoSize = true;
            this.poisonLabel6.Location = new System.Drawing.Point(16, 164);
            this.poisonLabel6.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel6.Name = "poisonLabel6";
            this.poisonLabel6.Size = new System.Drawing.Size(63, 19);
            this.poisonLabel6.TabIndex = 7;
            this.poisonLabel6.Text = "Các nhãn";
            // 
            // tCacNhan
            // 
            this.tCacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tCacNhan.CustomButton.Image = null;
            this.tCacNhan.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.tCacNhan.CustomButton.Name = "";
            this.tCacNhan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tCacNhan.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tCacNhan.CustomButton.TabIndex = 1;
            this.tCacNhan.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tCacNhan.CustomButton.UseSelectable = true;
            this.tCacNhan.CustomButton.Visible = false;
            this.tCacNhan.Lines = new string[0];
            this.tCacNhan.Location = new System.Drawing.Point(133, 162);
            this.tCacNhan.Margin = new System.Windows.Forms.Padding(0);
            this.tCacNhan.MaxLength = 32767;
            this.tCacNhan.Name = "tCacNhan";
            this.tCacNhan.PasswordChar = '\0';
            this.tCacNhan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tCacNhan.SelectedText = "";
            this.tCacNhan.SelectionLength = 0;
            this.tCacNhan.SelectionStart = 0;
            this.tCacNhan.ShortcutsEnabled = true;
            this.tCacNhan.Size = new System.Drawing.Size(437, 23);
            this.tCacNhan.TabIndex = 8;
            this.tCacNhan.UseSelectable = true;
            this.tCacNhan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tCacNhan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.Location = new System.Drawing.Point(16, 94);
            this.poisonLabel3.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(72, 19);
            this.poisonLabel3.TabIndex = 3;
            this.poisonLabel3.Text = "Câu lạc bộ";
            // 
            // tCauLacBo
            // 
            this.tCauLacBo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tCauLacBo.CustomButton.Image = null;
            this.tCauLacBo.CustomButton.Location = new System.Drawing.Point(415, 1);
            this.tCauLacBo.CustomButton.Name = "";
            this.tCauLacBo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tCauLacBo.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tCauLacBo.CustomButton.TabIndex = 1;
            this.tCauLacBo.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tCauLacBo.CustomButton.UseSelectable = true;
            this.tCauLacBo.CustomButton.Visible = false;
            this.tCauLacBo.Enabled = false;
            this.tCauLacBo.Lines = new string[0];
            this.tCauLacBo.Location = new System.Drawing.Point(133, 92);
            this.tCauLacBo.Margin = new System.Windows.Forms.Padding(0);
            this.tCauLacBo.MaxLength = 32767;
            this.tCauLacBo.Name = "tCauLacBo";
            this.tCauLacBo.PasswordChar = '\0';
            this.tCauLacBo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tCauLacBo.SelectedText = "";
            this.tCauLacBo.SelectionLength = 0;
            this.tCauLacBo.SelectionStart = 0;
            this.tCauLacBo.ShortcutsEnabled = true;
            this.tCauLacBo.Size = new System.Drawing.Size(437, 23);
            this.tCauLacBo.TabIndex = 4;
            this.tCauLacBo.UseSelectable = true;
            this.tCauLacBo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tCauLacBo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChinhBaiViet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bHuy);
            this.Controls.Add(this.bTaiLen);
            this.Controls.Add(this.tCacNhan);
            this.Controls.Add(this.tTacGia);
            this.Controls.Add(this.tCauLacBo);
            this.Controls.Add(this.tTieuDe);
            this.Controls.Add(this.poisonLabel6);
            this.Controls.Add(this.poisonLabel5);
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.poisonLabel2);
            this.Controls.Add(this.poisonLabel1);
            this.Name = "ChinhBaiViet";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(586, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.PoisonTextBox tTieuDe;
        private ReaLTaiizor.Controls.PoisonButton bTaiLen;
        private ReaLTaiizor.Controls.PoisonToolTip poisonToolTip1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel5;
        private ReaLTaiizor.Controls.PoisonTextBox tTacGia;
        private ReaLTaiizor.Controls.PoisonButton bHuy;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel6;
        private ReaLTaiizor.Controls.PoisonTextBox tCacNhan;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonTextBox tCauLacBo;
    }
}
