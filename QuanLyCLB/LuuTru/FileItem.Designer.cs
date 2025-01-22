
namespace QuanLyCLB.LuuTru
{
    partial class FileItem
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
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonCheckBox1 = new ReaLTaiizor.Controls.PoisonCheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.Location = new System.Drawing.Point(0, 109);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(128, 19);
            this.poisonLabel1.TabIndex = 0;
            this.poisonLabel1.Text = "poisonLabel12345678";
            this.poisonLabel1.Click += new System.EventHandler(this.File_Click);
            this.poisonLabel1.DoubleClick += new System.EventHandler(this.File_DoubleClick);
            // 
            // poisonCheckBox1
            // 
            this.poisonCheckBox1.Location = new System.Drawing.Point(114, 111);
            this.poisonCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.poisonCheckBox1.Name = "poisonCheckBox1";
            this.poisonCheckBox1.Size = new System.Drawing.Size(14, 14);
            this.poisonCheckBox1.TabIndex = 1;
            this.poisonCheckBox1.UseSelectable = true;
            this.poisonCheckBox1.CheckedChanged += new System.EventHandler(this.poisonCheckBox1_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QuanLyCLB.Properties.Resources.file;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 109);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.File_Click);
            this.pictureBox4.DoubleClick += new System.EventHandler(this.File_DoubleClick);
            // 
            // FileItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.poisonCheckBox1);
            this.Controls.Add(this.poisonLabel1);
            this.Controls.Add(this.pictureBox4);
            this.Name = "FileItem";
            this.Size = new System.Drawing.Size(128, 128);
            this.Load += new System.EventHandler(this.FileItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ReaLTaiizor.Controls.PoisonCheckBox poisonCheckBox1;
    }
}
