namespace QuanLyCLB.BaiViet
{
    partial class ChenBang
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
            this.flowLayoutPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.crownSeparator1 = new ReaLTaiizor.Controls.CrownSeparator();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.HorizontalScrollbarBarColor = true;
            this.flowLayoutPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.flowLayoutPanel1.HorizontalScrollbarSize = 10;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 192);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.VerticalScrollbarBarColor = true;
            this.flowLayoutPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.flowLayoutPanel1.VerticalScrollbarSize = 10;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poisonLabel1.Location = new System.Drawing.Point(4, 204);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(192, 19);
            this.poisonLabel1.TabIndex = 2;
            this.poisonLabel1.Text = "Chọn kích thước bảng";
            this.poisonLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // crownSeparator1
            // 
            this.crownSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.crownSeparator1.Location = new System.Drawing.Point(4, 19);
            this.crownSeparator1.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.crownSeparator1.Name = "crownSeparator1";
            this.crownSeparator1.Size = new System.Drawing.Size(192, 2);
            this.crownSeparator1.TabIndex = 1;
            this.crownSeparator1.Text = "crownSeparator1";
            // 
            // ChenBang
            // 
            this.Controls.Add(this.crownSeparator1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.poisonLabel1);
            this.DoubleBuffered = true;
            this.Name = "ChenBang";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(200, 227);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.CrownSeparator crownSeparator1;
    }
}