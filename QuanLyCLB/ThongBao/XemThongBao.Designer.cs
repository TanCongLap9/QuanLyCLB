namespace QuanLyCLB.ThongBao
{
    partial class XemThongBao
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
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.bExit = new ReaLTaiizor.Controls.PoisonButton();
            this.tTieuDe = new System.Windows.Forms.TextBox();
            this.tNoiDung = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(16, 48);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0, 16, 0, 8);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(145, 19);
            this.poisonLabel1.TabIndex = 2;
            this.poisonLabel1.Text = "Bởi tôi, ngày 11/9/2024";
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel3.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel3.Location = new System.Drawing.Point(32, 3);
            this.poisonLabel3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(137, 25);
            this.poisonLabel3.TabIndex = 1;
            this.poisonLabel3.Text = "Xem thông báo";
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
            this.bExit.Click += new System.EventHandler(this.Control_Click);
            // 
            // tTieuDe
            // 
            this.tTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tTieuDe.Cursor = System.Windows.Forms.Cursors.Default;
            this.tTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tTieuDe.Location = new System.Drawing.Point(20, 75);
            this.tTieuDe.Margin = new System.Windows.Forms.Padding(20, 0, 20, 8);
            this.tTieuDe.Name = "tTieuDe";
            this.tTieuDe.ReadOnly = true;
            this.tTieuDe.Size = new System.Drawing.Size(698, 22);
            this.tTieuDe.TabIndex = 3;
            this.tTieuDe.Enter += new System.EventHandler(this.Control_Enter);
            // 
            // tNoiDung
            // 
            this.tNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tNoiDung.Cursor = System.Windows.Forms.Cursors.Default;
            this.tNoiDung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tNoiDung.Location = new System.Drawing.Point(16, 105);
            this.tNoiDung.Margin = new System.Windows.Forms.Padding(16, 0, 16, 16);
            this.tNoiDung.Multiline = true;
            this.tNoiDung.Name = "tNoiDung";
            this.tNoiDung.ReadOnly = true;
            this.tNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tNoiDung.Size = new System.Drawing.Size(706, 326);
            this.tNoiDung.TabIndex = 4;
            this.tNoiDung.Enter += new System.EventHandler(this.Control_Enter);
            // 
            // XemThongBao
            // 
            this.Controls.Add(this.tNoiDung);
            this.Controls.Add(this.tTieuDe);
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.poisonLabel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "XemThongBao";
            this.Size = new System.Drawing.Size(738, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonButton bExit;
        private System.Windows.Forms.TextBox tTieuDe;
        private System.Windows.Forms.TextBox tNoiDung;
    }
}