
namespace QuanLyCLB.LuuTru
{
    partial class TieuDeThongTin
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
            this.poisonLabel29 = new ReaLTaiizor.Controls.PoisonLabel();
            this.SuspendLayout();
            // 
            // poisonLabel29
            // 
            this.poisonLabel29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonLabel29.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel29.Location = new System.Drawing.Point(4, 4);
            this.poisonLabel29.Margin = new System.Windows.Forms.Padding(0);
            this.poisonLabel29.Name = "poisonLabel29";
            this.poisonLabel29.Size = new System.Drawing.Size(200, 25);
            this.poisonLabel29.TabIndex = 0;
            this.poisonLabel29.Text = "Siêu dữ liệu";
            // 
            // TieuDeThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.poisonLabel29);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TieuDeThongTin";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.Size = new System.Drawing.Size(208, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel poisonLabel29;
    }
}
