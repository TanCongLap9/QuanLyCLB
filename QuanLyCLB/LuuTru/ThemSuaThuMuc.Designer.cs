
namespace QuanLyCLB.LuuTru
{
    partial class ThemSuaThuMuc
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
            this.pColor = new System.Windows.Forms.Panel();
            this.lMaMau = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.bHuy = new ReaLTaiizor.Controls.PoisonButton();
            this.bOk = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonTextBox2 = new ReaLTaiizor.Controls.PoisonTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lLoi = new ReaLTaiizor.Controls.PoisonLabel();
            this.lTitle = new ReaLTaiizor.Controls.PoisonLabel();
            this.SuspendLayout();
            // 
            // pColor
            // 
            this.pColor.BackColor = System.Drawing.Color.Goldenrod;
            this.pColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(41, 58);
            this.pColor.Margin = new System.Windows.Forms.Padding(0);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(20, 20);
            this.pColor.TabIndex = 4;
            this.pColor.Click += new System.EventHandler(this.panel1_Click);
            this.pColor.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.pColor.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // lMaMau
            // 
            this.lMaMau.AutoSize = true;
            this.lMaMau.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.lMaMau.Location = new System.Drawing.Point(65, 60);
            this.lMaMau.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lMaMau.Name = "lMaMau";
            this.lMaMau.Size = new System.Drawing.Size(51, 15);
            this.lMaMau.TabIndex = 5;
            this.lMaMau.Text = "#daa520";
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.poisonLabel2.Location = new System.Drawing.Point(4, 60);
            this.poisonLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(29, 15);
            this.poisonLabel2.TabIndex = 3;
            this.poisonLabel2.Text = "Màu";
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.poisonLabel1.Location = new System.Drawing.Point(4, 35);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(25, 15);
            this.poisonLabel1.TabIndex = 1;
            this.poisonLabel1.Text = "Tên";
            // 
            // bHuy
            // 
            this.bHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bHuy.Location = new System.Drawing.Point(130, 111);
            this.bHuy.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bHuy.Name = "bHuy";
            this.bHuy.Size = new System.Drawing.Size(40, 23);
            this.bHuy.TabIndex = 8;
            this.bHuy.Text = "Huỷ";
            this.bHuy.UseSelectable = true;
            this.bHuy.Click += new System.EventHandler(this.bHuy_Click);
            // 
            // bOk
            // 
            this.bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOk.Location = new System.Drawing.Point(86, 111);
            this.bOk.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(40, 23);
            this.bOk.TabIndex = 7;
            this.bOk.Text = "OK";
            this.bOk.UseSelectable = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // poisonTextBox2
            // 
            this.poisonTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.poisonTextBox2.CustomButton.Image = null;
            this.poisonTextBox2.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.poisonTextBox2.CustomButton.Name = "";
            this.poisonTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.poisonTextBox2.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonTextBox2.CustomButton.TabIndex = 1;
            this.poisonTextBox2.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.poisonTextBox2.CustomButton.UseSelectable = true;
            this.poisonTextBox2.CustomButton.Visible = false;
            this.poisonTextBox2.Lines = new string[0];
            this.poisonTextBox2.Location = new System.Drawing.Point(41, 31);
            this.poisonTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.poisonTextBox2.MaxLength = 32767;
            this.poisonTextBox2.Name = "poisonTextBox2";
            this.poisonTextBox2.PasswordChar = '\0';
            this.poisonTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.poisonTextBox2.SelectedText = "";
            this.poisonTextBox2.SelectionLength = 0;
            this.poisonTextBox2.SelectionStart = 0;
            this.poisonTextBox2.ShortcutsEnabled = true;
            this.poisonTextBox2.Size = new System.Drawing.Size(129, 23);
            this.poisonTextBox2.TabIndex = 2;
            this.poisonTextBox2.UseSelectable = true;
            this.poisonTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.poisonTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.poisonTextBox2.TextChanged += new System.EventHandler(this.poisonTextBox2_TextChanged);
            // 
            // lLoi
            // 
            this.lLoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lLoi.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.lLoi.Location = new System.Drawing.Point(4, 83);
            this.lLoi.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.lLoi.Name = "lLoi";
            this.lLoi.Size = new System.Drawing.Size(166, 15);
            this.lLoi.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Red;
            this.lLoi.TabIndex = 6;
            this.lLoi.Text = "Tên thư mục không được trống.";
            this.lLoi.UseStyleColors = true;
            this.lLoi.Visible = false;
            this.lLoi.WrapToLine = true;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.lTitle.Location = new System.Drawing.Point(4, 4);
            this.lTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(98, 19);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Thêm thư mục";
            // 
            // ThemSuaThuMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bHuy);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.lLoi);
            this.Controls.Add(this.lMaMau);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.poisonLabel2);
            this.Controls.Add(this.poisonTextBox2);
            this.Controls.Add(this.poisonLabel1);
            this.Controls.Add(this.lTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ThemSuaThuMuc";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(174, 138);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pColor;
        private ReaLTaiizor.Controls.PoisonLabel lMaMau;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonButton bHuy;
        private ReaLTaiizor.Controls.PoisonButton bOk;
        private ReaLTaiizor.Controls.PoisonTextBox poisonTextBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private ReaLTaiizor.Controls.PoisonLabel lLoi;
        private ReaLTaiizor.Controls.PoisonLabel lTitle;
    }
}
