namespace QuanLyCLB.TaskWindow
{
    partial class ThongBaoMoi
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
            this.components = new System.ComponentModel.Container();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.bXem = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonStyleManager1 = new ReaLTaiizor.Manager.PoisonStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel1.Location = new System.Drawing.Point(0, 0);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(159, 25);
            this.poisonLabel1.TabIndex = 0;
            this.poisonLabel1.Text = "Có thông báo mới";
            // 
            // bXem
            // 
            this.bXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bXem.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Medium;
            this.bXem.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            this.bXem.Location = new System.Drawing.Point(215, 126);
            this.bXem.Margin = new System.Windows.Forms.Padding(0);
            this.bXem.Name = "bXem";
            this.bXem.Size = new System.Drawing.Size(63, 23);
            this.bXem.TabIndex = 1;
            this.bXem.Text = "Xem";
            this.bXem.UseSelectable = true;
            this.bXem.Click += new System.EventHandler(this.Button_Click);
            // 
            // poisonStyleManager1
            // 
            this.poisonStyleManager1.Owner = this;
            this.poisonStyleManager1.Style = global::QuanLyCLB.Properties.Settings.Default.Style;
            this.poisonStyleManager1.Theme = global::QuanLyCLB.Properties.Settings.Default.Theme;
            // 
            // ThongBaoMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bXem);
            this.Controls.Add(this.poisonLabel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ThongBaoMoi";
            this.Size = new System.Drawing.Size(278, 149);
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonButton bXem;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager1;
    }
}
