
namespace QuanLyCLB.LuuTru
{
    partial class MucThongTin
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
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.lFileName = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonToolTip1 = new ReaLTaiizor.Controls.PoisonToolTip();
            this.SuspendLayout();
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonLabel3.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel3.Location = new System.Drawing.Point(4, 0);
            this.poisonLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(200, 19);
            this.poisonLabel3.TabIndex = 0;
            this.poisonLabel3.Text = "Tên tập tin";
            // 
            // lFileName
            // 
            this.lFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lFileName.Location = new System.Drawing.Point(4, 19);
            this.lFileName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lFileName.Name = "lFileName";
            this.lFileName.Size = new System.Drawing.Size(200, 19);
            this.lFileName.TabIndex = 1;
            this.lFileName.Text = "abc123";
            // 
            // poisonToolTip1
            // 
            this.poisonToolTip1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonToolTip1.StyleManager = null;
            this.poisonToolTip1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // MucThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.lFileName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MucThongTin";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Size = new System.Drawing.Size(208, 38);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonLabel lFileName;
        private ReaLTaiizor.Controls.PoisonToolTip poisonToolTip1;
    }
}
