
namespace QuanLyCLB.LuuTru
{
    partial class AlertBox
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
            this.lAlert = new ReaLTaiizor.Controls.PoisonLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lAlert
            // 
            this.lAlert.AutoSize = true;
            this.lAlert.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.lAlert.Location = new System.Drawing.Point(16, 8);
            this.lAlert.Margin = new System.Windows.Forms.Padding(0);
            this.lAlert.Name = "lAlert";
            this.lAlert.Size = new System.Drawing.Size(75, 19);
            this.lAlert.TabIndex = 0;
            this.lAlert.Text = "Thông báo";
            this.lAlert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lAlert.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lAlert);
            this.Name = "AlertBox";
            this.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.Size = new System.Drawing.Size(107, 35);
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel lAlert;
        private System.Windows.Forms.Timer timer1;
    }
}
