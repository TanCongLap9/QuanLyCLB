
namespace QuanLyCLB.TrinhDoc
{
    partial class TrinhDocHinhAnh
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
            this.bZoom = new ReaLTaiizor.Controls.PoisonButton();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.scZoom = new ReaLTaiizor.Controls.PoisonScrollBar();
            this.pImage = new ReaLTaiizor.Controls.PoisonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bZoom
            // 
            this.bZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bZoom.BackgroundImage = global::QuanLyCLB.Properties.Resources.zoom_3;
            this.bZoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bZoom.Location = new System.Drawing.Point(619, 314);
            this.bZoom.Margin = new System.Windows.Forms.Padding(0, 0, 16, 16);
            this.bZoom.Name = "bZoom";
            this.bZoom.Size = new System.Drawing.Size(32, 32);
            this.bZoom.TabIndex = 1;
            this.bZoom.UseSelectable = true;
            this.bZoom.Click += new System.EventHandler(this.bZoom_Click);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(667, 362);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseMove);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // scZoom
            // 
            this.scZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scZoom.LargeChange = 10;
            this.scZoom.Location = new System.Drawing.Point(630, 210);
            this.scZoom.Margin = new System.Windows.Forms.Padding(0);
            this.scZoom.Maximum = 100;
            this.scZoom.Minimum = 0;
            this.scZoom.MouseWheelBarPartitions = 10;
            this.scZoom.Name = "scZoom";
            this.scZoom.Orientation = ReaLTaiizor.Enum.Poison.ScrollOrientationType.Vertical;
            this.scZoom.ScrollbarSize = 10;
            this.scZoom.Size = new System.Drawing.Size(10, 104);
            this.scZoom.TabIndex = 2;
            this.scZoom.UseBarColor = true;
            this.scZoom.UseSelectable = true;
            this.scZoom.ValueChanged += new ReaLTaiizor.Controls.PoisonScrollBar.ScrollValueChangedDelegate(this.scZoom_ValueChanged);
            // 
            // pImage
            // 
            this.pImage.HorizontalScrollbarBarColor = true;
            this.pImage.HorizontalScrollbarHighlightOnWheel = false;
            this.pImage.HorizontalScrollbarSize = 10;
            this.pImage.Location = new System.Drawing.Point(0, 0);
            this.pImage.Margin = new System.Windows.Forms.Padding(0);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(667, 362);
            this.pImage.TabIndex = 0;
            this.pImage.VerticalScrollbarBarColor = true;
            this.pImage.VerticalScrollbarHighlightOnWheel = false;
            this.pImage.VerticalScrollbarSize = 10;
            this.pImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.pImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pImage_MouseMove);
            this.pImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // TrinhDocHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scZoom);
            this.Controls.Add(this.bZoom);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pImage);
            this.Name = "TrinhDocHinhAnh";
            this.Size = new System.Drawing.Size(667, 362);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private ReaLTaiizor.Controls.PoisonButton bZoom;
        private ReaLTaiizor.Controls.PoisonScrollBar scZoom;
        private ReaLTaiizor.Controls.PoisonPanel pImage;
    }
}
