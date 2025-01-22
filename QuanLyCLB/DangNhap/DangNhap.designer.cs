namespace QuanLyCLB.DangNhap
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.tPass = new ReaLTaiizor.Controls.PoisonTextBox();
            this.bDangNhap = new ReaLTaiizor.Controls.PoisonButton();
            this.tUser = new ReaLTaiizor.Controls.PoisonTextBox();
            this.spinner = new ReaLTaiizor.Controls.PoisonProgressSpinner();
            this.bRemember = new ReaLTaiizor.Controls.PoisonCheckBox();
            this.lStatus = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.lDangKy = new ReaLTaiizor.Controls.PoisonLinkLabel();
            this.poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            this.bSettings = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonPanel2 = new ReaLTaiizor.Controls.PoisonPanel();
            this.coverPictureBox1 = new QuanLyCLB.CoverPictureBox();
            this.bQuit = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.poisonStyleManager1 = new ReaLTaiizor.Manager.PoisonStyleManager(this.components);
            this.poisonPanel1.SuspendLayout();
            this.poisonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tPass
            // 
            this.tPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tPass.CustomButton.Image = null;
            this.tPass.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.tPass.CustomButton.Name = "";
            this.tPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tPass.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tPass.CustomButton.TabIndex = 1;
            this.tPass.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tPass.CustomButton.UseSelectable = true;
            this.tPass.CustomButton.Visible = false;
            this.tPass.Lines = new string[0];
            this.tPass.Location = new System.Drawing.Point(64, 100);
            this.tPass.Margin = new System.Windows.Forms.Padding(64, 0, 64, 16);
            this.tPass.MaxLength = 32767;
            this.tPass.Name = "tPass";
            this.tPass.PasswordChar = '●';
            this.tPass.PromptText = "Mật khẩu";
            this.tPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tPass.SelectedText = "";
            this.tPass.SelectionLength = 0;
            this.tPass.SelectionStart = 0;
            this.tPass.ShortcutsEnabled = true;
            this.tPass.Size = new System.Drawing.Size(279, 23);
            this.tPass.TabIndex = 2;
            this.tPass.UseSelectable = true;
            this.tPass.UseSystemPasswordChar = true;
            this.tPass.WaterMark = "Mật khẩu";
            this.tPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bDangNhap
            // 
            this.bDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDangNhap.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.bDangNhap.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            this.bDangNhap.Location = new System.Drawing.Point(64, 206);
            this.bDangNhap.Margin = new System.Windows.Forms.Padding(64, 0, 0, 8);
            this.bDangNhap.Name = "bDangNhap";
            this.bDangNhap.Size = new System.Drawing.Size(117, 23);
            this.bDangNhap.TabIndex = 5;
            this.bDangNhap.Text = "Đăng nhập";
            this.bDangNhap.UseSelectable = true;
            this.bDangNhap.Click += new System.EventHandler(this.Control_Click);
            // 
            // tUser
            // 
            this.tUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tUser.CustomButton.Image = null;
            this.tUser.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.tUser.CustomButton.Name = "";
            this.tUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tUser.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tUser.CustomButton.TabIndex = 1;
            this.tUser.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tUser.CustomButton.UseSelectable = true;
            this.tUser.CustomButton.Visible = false;
            this.tUser.Lines = new string[0];
            this.tUser.Location = new System.Drawing.Point(64, 61);
            this.tUser.Margin = new System.Windows.Forms.Padding(64, 0, 64, 16);
            this.tUser.MaxLength = 32767;
            this.tUser.Name = "tUser";
            this.tUser.PasswordChar = '\0';
            this.tUser.PromptText = "Tên đăng nhập";
            this.tUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tUser.SelectedText = "";
            this.tUser.SelectionLength = 0;
            this.tUser.SelectionStart = 0;
            this.tUser.ShortcutsEnabled = true;
            this.tUser.Size = new System.Drawing.Size(279, 23);
            this.tUser.TabIndex = 1;
            this.tUser.UseSelectable = true;
            this.tUser.WaterMark = "Tên đăng nhập";
            this.tUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // spinner
            // 
            this.spinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinner.Location = new System.Drawing.Point(189, 206);
            this.spinner.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.spinner.Maximum = 100;
            this.spinner.Name = "spinner";
            this.spinner.Size = new System.Drawing.Size(24, 24);
            this.spinner.TabIndex = 8;
            this.spinner.UseSelectable = true;
            this.spinner.Value = 50;
            this.spinner.Visible = false;
            // 
            // bRemember
            // 
            this.bRemember.AutoSize = true;
            this.bRemember.Location = new System.Drawing.Point(64, 139);
            this.bRemember.Margin = new System.Windows.Forms.Padding(64, 0, 0, 4);
            this.bRemember.Name = "bRemember";
            this.bRemember.Size = new System.Drawing.Size(126, 15);
            this.bRemember.TabIndex = 3;
            this.bRemember.Text = "Nhớ tên đăng nhập";
            this.bRemember.UseSelectable = true;
            this.bRemember.Click += new System.EventHandler(this.Control_Click);
            // 
            // lStatus
            // 
            this.lStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatus.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.lStatus.Location = new System.Drawing.Point(64, 237);
            this.lStatus.Margin = new System.Windows.Forms.Padding(64, 0, 0, 8);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(279, 42);
            this.lStatus.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Red;
            this.lStatus.TabIndex = 7;
            this.lStatus.Text = "Mật khẩu nhập không đúng";
            this.lStatus.UseStyleColors = true;
            this.lStatus.Visible = false;
            this.lStatus.WrapToLine = true;
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel1.Location = new System.Drawing.Point(97, 18);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(212, 25);
            this.poisonLabel1.TabIndex = 0;
            this.poisonLabel1.Text = "Chào mừng bạn đã trở lại.";
            // 
            // lDangKy
            // 
            this.lDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lDangKy.Location = new System.Drawing.Point(226, 139);
            this.lDangKy.Margin = new System.Windows.Forms.Padding(0, 0, 64, 4);
            this.lDangKy.Name = "lDangKy";
            this.lDangKy.Size = new System.Drawing.Size(117, 15);
            this.lDangKy.TabIndex = 4;
            this.lDangKy.Text = "Chưa có tài khoản?";
            this.lDangKy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lDangKy.UseSelectable = true;
            this.lDangKy.Click += new System.EventHandler(this.Control_Click);
            // 
            // poisonPanel1
            // 
            this.poisonPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.poisonPanel1.Controls.Add(this.lStatus);
            this.poisonPanel1.Controls.Add(this.bSettings);
            this.poisonPanel1.Controls.Add(this.spinner);
            this.poisonPanel1.Controls.Add(this.bDangNhap);
            this.poisonPanel1.Controls.Add(this.lDangKy);
            this.poisonPanel1.Controls.Add(this.bRemember);
            this.poisonPanel1.Controls.Add(this.tPass);
            this.poisonPanel1.Controls.Add(this.tUser);
            this.poisonPanel1.Controls.Add(this.poisonLabel1);
            this.poisonPanel1.HorizontalScrollbarBarColor = true;
            this.poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.HorizontalScrollbarSize = 10;
            this.poisonPanel1.Location = new System.Drawing.Point(171, 12);
            this.poisonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.poisonPanel1.Name = "poisonPanel1";
            this.poisonPanel1.Size = new System.Drawing.Size(407, 287);
            this.poisonPanel1.TabIndex = 1;
            this.poisonPanel1.VerticalScrollbarBarColor = true;
            this.poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // bSettings
            // 
            this.bSettings.BackgroundImage = global::QuanLyCLB.Properties.Resources.system_settings;
            this.bSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bSettings.Location = new System.Drawing.Point(311, 197);
            this.bSettings.Margin = new System.Windows.Forms.Padding(0);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(32, 32);
            this.bSettings.TabIndex = 6;
            this.bSettings.UseSelectable = true;
            this.bSettings.Click += new System.EventHandler(this.Control_Click);
            // 
            // poisonPanel2
            // 
            this.poisonPanel2.Controls.Add(this.poisonPanel1);
            this.poisonPanel2.Controls.Add(this.coverPictureBox1);
            this.poisonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonPanel2.HorizontalScrollbarBarColor = true;
            this.poisonPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonPanel2.HorizontalScrollbarSize = 10;
            this.poisonPanel2.Location = new System.Drawing.Point(3, 60);
            this.poisonPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.poisonPanel2.Name = "poisonPanel2";
            this.poisonPanel2.Size = new System.Drawing.Size(749, 310);
            this.poisonPanel2.TabIndex = 0;
            this.poisonPanel2.VerticalScrollbarBarColor = true;
            this.poisonPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.poisonPanel2.VerticalScrollbarSize = 10;
            // 
            // coverPictureBox1
            // 
            this.coverPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coverPictureBox1.Image = global::QuanLyCLB.Properties.Resources._737963dd93d62b8872c7;
            this.coverPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.coverPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.coverPictureBox1.Name = "coverPictureBox1";
            this.coverPictureBox1.Size = new System.Drawing.Size(749, 310);
            this.coverPictureBox1.SizeMode = QuanLyCLB.CoverPictureBoxSizeMode.Cover;
            this.coverPictureBox1.TabIndex = 0;
            // 
            // bQuit
            // 
            this.bQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bQuit.Location = new System.Drawing.Point(0, 0);
            this.bQuit.Margin = new System.Windows.Forms.Padding(0);
            this.bQuit.Name = "bQuit";
            this.bQuit.Size = new System.Drawing.Size(0, 0);
            this.bQuit.TabIndex = 2;
            this.bQuit.TabStop = false;
            this.bQuit.Text = "Thoát";
            this.bQuit.UseVisualStyleBackColor = true;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(0, 0);
            this.bLogin.Margin = new System.Windows.Forms.Padding(0);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(0, 0);
            this.bLogin.TabIndex = 1;
            this.bLogin.TabStop = false;
            this.bLogin.Text = "Đăng nhập";
            this.bLogin.UseVisualStyleBackColor = true;
            // 
            // poisonStyleManager1
            // 
            this.poisonStyleManager1.Owner = this;
            this.poisonStyleManager1.Style = global::QuanLyCLB.Properties.Settings.Default.Style;
            this.poisonStyleManager1.Theme = global::QuanLyCLB.Properties.Settings.Default.Theme;
            // 
            // DangNhap
            // 
            this.AcceptButton = this.bDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bQuit;
            this.ClientSize = new System.Drawing.Size(755, 373);
            this.Controls.Add(this.bQuit);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.poisonPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(420, 360);
            this.Name = "DangNhap";
            this.Padding = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.Text = "Phần mềm quản lý câu lạc bộ";
            this.poisonPanel1.ResumeLayout(false);
            this.poisonPanel1.PerformLayout();
            this.poisonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonTextBox tUser;
        private ReaLTaiizor.Controls.PoisonTextBox tPass;
        private ReaLTaiizor.Controls.PoisonButton bDangNhap;
        private ReaLTaiizor.Controls.PoisonCheckBox bRemember;
        private ReaLTaiizor.Controls.PoisonProgressSpinner spinner;
        private ReaLTaiizor.Controls.PoisonLabel lStatus;
        private ReaLTaiizor.Controls.PoisonLinkLabel lDangKy;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel2;
        private ReaLTaiizor.Controls.PoisonButton bSettings;
        private System.Windows.Forms.Button bQuit;
        private System.Windows.Forms.Button bLogin;
        private CoverPictureBox coverPictureBox1;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager1;
    }
}