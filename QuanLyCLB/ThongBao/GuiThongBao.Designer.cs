namespace QuanLyCLB.ThongBao
{
    partial class GuiThongBao
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
            this.poisonButton1 = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.tNoiDung = new ReaLTaiizor.Controls.PoisonTextBox();
            this.lStatus = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonProgressSpinner1 = new ReaLTaiizor.Controls.PoisonProgressSpinner();
            this.tTieuDe = new ReaLTaiizor.Controls.PoisonTextBox();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.bExit = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            this.cCauLacBo = new ReaLTaiizor.Controls.PoisonComboBox();
            this.SuspendLayout();
            // 
            // poisonButton1
            // 
            this.poisonButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.poisonButton1.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.poisonButton1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            this.poisonButton1.Location = new System.Drawing.Point(301, 376);
            this.poisonButton1.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.poisonButton1.Name = "poisonButton1";
            this.poisonButton1.Size = new System.Drawing.Size(136, 23);
            this.poisonButton1.TabIndex = 8;
            this.poisonButton1.Text = "Gửi thông báo";
            this.poisonButton1.UseSelectable = true;
            this.poisonButton1.Click += new System.EventHandler(this.Button_Click);
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(16, 84);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(52, 19);
            this.poisonLabel1.TabIndex = 4;
            this.poisonLabel1.Text = "Tiêu đề";
            // 
            // tNoiDung
            // 
            this.tNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tNoiDung.CustomButton.Image = null;
            this.tNoiDung.CustomButton.Location = new System.Drawing.Point(394, 1);
            this.tNoiDung.CustomButton.Name = "";
            this.tNoiDung.CustomButton.Size = new System.Drawing.Size(239, 239);
            this.tNoiDung.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tNoiDung.CustomButton.TabIndex = 1;
            this.tNoiDung.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tNoiDung.CustomButton.UseSelectable = true;
            this.tNoiDung.CustomButton.Visible = false;
            this.tNoiDung.Lines = new string[0];
            this.tNoiDung.Location = new System.Drawing.Point(88, 119);
            this.tNoiDung.Margin = new System.Windows.Forms.Padding(0);
            this.tNoiDung.MaxLength = 32767;
            this.tNoiDung.Multiline = true;
            this.tNoiDung.Name = "tNoiDung";
            this.tNoiDung.PasswordChar = '\0';
            this.tNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tNoiDung.SelectedText = "";
            this.tNoiDung.SelectionLength = 0;
            this.tNoiDung.SelectionStart = 0;
            this.tNoiDung.ShortcutsEnabled = true;
            this.tNoiDung.Size = new System.Drawing.Size(634, 241);
            this.tNoiDung.TabIndex = 7;
            this.tNoiDung.UseSelectable = true;
            this.tNoiDung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tNoiDung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lStatus
            // 
            this.lStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(16, 412);
            this.lStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(170, 19);
            this.lStatus.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Red;
            this.lStatus.TabIndex = 10;
            this.lStatus.Text = "Mật khẩu nhập không đúng";
            this.lStatus.UseStyleColors = true;
            this.lStatus.Visible = false;
            // 
            // poisonProgressSpinner1
            // 
            this.poisonProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.poisonProgressSpinner1.Location = new System.Drawing.Point(445, 376);
            this.poisonProgressSpinner1.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.poisonProgressSpinner1.Maximum = 100;
            this.poisonProgressSpinner1.Name = "poisonProgressSpinner1";
            this.poisonProgressSpinner1.Size = new System.Drawing.Size(24, 24);
            this.poisonProgressSpinner1.TabIndex = 9;
            this.poisonProgressSpinner1.UseSelectable = true;
            this.poisonProgressSpinner1.Visible = false;
            // 
            // tTieuDe
            // 
            this.tTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tTieuDe.CustomButton.Image = null;
            this.tTieuDe.CustomButton.Location = new System.Drawing.Point(612, 1);
            this.tTieuDe.CustomButton.Name = "";
            this.tTieuDe.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tTieuDe.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tTieuDe.CustomButton.TabIndex = 1;
            this.tTieuDe.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tTieuDe.CustomButton.UseSelectable = true;
            this.tTieuDe.CustomButton.Visible = false;
            this.tTieuDe.Lines = new string[0];
            this.tTieuDe.Location = new System.Drawing.Point(88, 82);
            this.tTieuDe.Margin = new System.Windows.Forms.Padding(0);
            this.tTieuDe.MaxLength = 32767;
            this.tTieuDe.Name = "tTieuDe";
            this.tTieuDe.PasswordChar = '\0';
            this.tTieuDe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tTieuDe.SelectedText = "";
            this.tTieuDe.SelectionLength = 0;
            this.tTieuDe.SelectionStart = 0;
            this.tTieuDe.ShortcutsEnabled = true;
            this.tTieuDe.Size = new System.Drawing.Size(634, 23);
            this.tTieuDe.TabIndex = 5;
            this.tTieuDe.UseSelectable = true;
            this.tTieuDe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tTieuDe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.Location = new System.Drawing.Point(16, 119);
            this.poisonLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(64, 19);
            this.poisonLabel2.TabIndex = 6;
            this.poisonLabel2.Text = "Nội dung";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.BackgroundImage = global::QuanLyCLB.Properties.Resources.arrow_left_3;
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bExit.Location = new System.Drawing.Point(0, 0);
            this.bExit.Margin = new System.Windows.Forms.Padding(0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(32, 32);
            this.bExit.TabIndex = 0;
            this.bExit.UseCustomBackColor = true;
            this.bExit.UseSelectable = true;
            this.bExit.Click += new System.EventHandler(this.Button_Click);
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel3.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel3.Location = new System.Drawing.Point(32, 3);
            this.poisonLabel3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(128, 25);
            this.poisonLabel3.TabIndex = 1;
            this.poisonLabel3.Text = "Gửi thông báo";
            // 
            // poisonLabel4
            // 
            this.poisonLabel4.AutoSize = true;
            this.poisonLabel4.Location = new System.Drawing.Point(16, 49);
            this.poisonLabel4.Margin = new System.Windows.Forms.Padding(0, 0, 8, 16);
            this.poisonLabel4.Name = "poisonLabel4";
            this.poisonLabel4.Size = new System.Drawing.Size(32, 19);
            this.poisonLabel4.TabIndex = 2;
            this.poisonLabel4.Text = "Đến";
            // 
            // cCauLacBo
            // 
            this.cCauLacBo.DisplayMember = "TenCLB";
            this.cCauLacBo.FormattingEnabled = true;
            this.cCauLacBo.ItemHeight = 23;
            this.cCauLacBo.Location = new System.Drawing.Point(88, 44);
            this.cCauLacBo.Margin = new System.Windows.Forms.Padding(0);
            this.cCauLacBo.Name = "cCauLacBo";
            this.cCauLacBo.Size = new System.Drawing.Size(349, 29);
            this.cCauLacBo.TabIndex = 3;
            this.cCauLacBo.UseSelectable = true;
            this.cCauLacBo.ValueMember = "MaCLB";
            this.cCauLacBo.DropDown += new System.EventHandler(this.cCauLacBo_DropDown);
            // 
            // GuiThongBao
            // 
            this.Controls.Add(this.cCauLacBo);
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.poisonButton1);
            this.Controls.Add(this.poisonLabel4);
            this.Controls.Add(this.poisonLabel1);
            this.Controls.Add(this.poisonLabel2);
            this.Controls.Add(this.tNoiDung);
            this.Controls.Add(this.tTieuDe);
            this.Controls.Add(this.poisonProgressSpinner1);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bExit);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GuiThongBao";
            this.Size = new System.Drawing.Size(738, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonButton poisonButton1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonTextBox tNoiDung;
        private ReaLTaiizor.Controls.PoisonProgressSpinner poisonProgressSpinner1;
        private ReaLTaiizor.Controls.PoisonTextBox tTieuDe;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.PoisonLabel lStatus;
        private ReaLTaiizor.Controls.PoisonButton bExit;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel4;
        private ReaLTaiizor.Controls.PoisonComboBox cCauLacBo;
    }
}