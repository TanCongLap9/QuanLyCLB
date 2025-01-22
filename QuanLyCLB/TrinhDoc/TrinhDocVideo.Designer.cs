
namespace QuanLyCLB.TrinhDoc
{
    partial class TrinhDocVideo
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
            this.pMediaControls = new ReaLTaiizor.Controls.PoisonPanel();
            this.seekbar = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.pVolume = new System.Windows.Forms.Panel();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.lLength = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.lTime = new ReaLTaiizor.Controls.PoisonLabel();
            this.bVolume = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonButton2 = new ReaLTaiizor.Controls.PoisonButton();
            this.bFastForward = new ReaLTaiizor.Controls.PoisonButton();
            this.bStop = new ReaLTaiizor.Controls.PoisonButton();
            this.bSpeed = new ReaLTaiizor.Controls.PoisonButton();
            this.bPlayPause = new ReaLTaiizor.Controls.PoisonButton();
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.volumeTimer = new System.Windows.Forms.Timer(this.components);
            this.poisonToolTip1 = new ReaLTaiizor.Controls.PoisonToolTip();
            this.pMediaControls.SuspendLayout();
            this.pVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pMediaControls
            // 
            this.pMediaControls.Controls.Add(this.seekbar);
            this.pMediaControls.Controls.Add(this.pVolume);
            this.pMediaControls.Controls.Add(this.lLength);
            this.pMediaControls.Controls.Add(this.poisonLabel2);
            this.pMediaControls.Controls.Add(this.lTime);
            this.pMediaControls.Controls.Add(this.bVolume);
            this.pMediaControls.Controls.Add(this.poisonButton2);
            this.pMediaControls.Controls.Add(this.bFastForward);
            this.pMediaControls.Controls.Add(this.bStop);
            this.pMediaControls.Controls.Add(this.bSpeed);
            this.pMediaControls.Controls.Add(this.bPlayPause);
            this.pMediaControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMediaControls.HorizontalScrollbarBarColor = true;
            this.pMediaControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pMediaControls.HorizontalScrollbarSize = 10;
            this.pMediaControls.Location = new System.Drawing.Point(0, 341);
            this.pMediaControls.Margin = new System.Windows.Forms.Padding(0);
            this.pMediaControls.Name = "pMediaControls";
            this.pMediaControls.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.pMediaControls.Size = new System.Drawing.Size(600, 59);
            this.pMediaControls.TabIndex = 1;
            this.pMediaControls.UseCustomBackColor = true;
            this.pMediaControls.VerticalScrollbarBarColor = true;
            this.pMediaControls.VerticalScrollbarHighlightOnWheel = false;
            this.pMediaControls.VerticalScrollbarSize = 10;
            // 
            // seekbar
            // 
            this.seekbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seekbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.seekbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seekbar.DrawValueString = false;
            this.seekbar.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.seekbar.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(127)))), ((int)(((byte)(207)))));
            this.seekbar.JumpToMouse = false;
            this.seekbar.Location = new System.Drawing.Point(34, 0);
            this.seekbar.Margin = new System.Windows.Forms.Padding(0);
            this.seekbar.Maximum = 5000;
            this.seekbar.Minimum = 0;
            this.seekbar.MinimumSize = new System.Drawing.Size(47, 22);
            this.seekbar.Name = "seekbar";
            this.seekbar.Size = new System.Drawing.Size(528, 22);
            this.seekbar.TabIndex = 1;
            this.seekbar.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.seekbar.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.seekbar.Value = 0;
            this.seekbar.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
            this.seekbar.ValueToSet = 0F;
            this.seekbar.ValueChanged += new ReaLTaiizor.Controls.DungeonTrackBar.ValueChangedEventHandler(this.seekbar_ValueChanged);
            this.seekbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.seekbar_MouseDown);
            this.seekbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.seekbar_MouseUp);
            // 
            // pVolume
            // 
            this.pVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pVolume.Controls.Add(this.poisonLabel1);
            this.pVolume.Location = new System.Drawing.Point(496, 27);
            this.pVolume.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pVolume.Name = "pVolume";
            this.pVolume.Size = new System.Drawing.Size(84, 28);
            this.pVolume.TabIndex = 10;
            this.pVolume.Paint += new System.Windows.Forms.PaintEventHandler(this.pVolume_Paint);
            this.pVolume.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pVolume_MouseMove);
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.poisonLabel1.Location = new System.Drawing.Point(0, 0);
            this.poisonLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(34, 15);
            this.poisonLabel1.TabIndex = 0;
            this.poisonLabel1.Text = "100%";
            this.poisonLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.poisonLabel1.UseCustomBackColor = true;
            // 
            // lLength
            // 
            this.lLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lLength.AutoSize = true;
            this.lLength.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.lLength.Location = new System.Drawing.Point(562, 4);
            this.lLength.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lLength.Name = "lLength";
            this.lLength.Size = new System.Drawing.Size(34, 15);
            this.lLength.TabIndex = 2;
            this.lLength.Text = "00:00";
            this.lLength.UseCustomBackColor = true;
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.poisonLabel2.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.poisonLabel2.Location = new System.Drawing.Point(150, 31);
            this.poisonLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 0, 9);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(33, 15);
            this.poisonLabel2.TabIndex = 8;
            this.poisonLabel2.Text = "1x";
            this.poisonLabel2.UseCustomBackColor = true;
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Small;
            this.lTime.Location = new System.Drawing.Point(0, 4);
            this.lTime.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(34, 15);
            this.lTime.TabIndex = 0;
            this.lTime.Text = "00:00";
            this.lTime.UseCustomBackColor = true;
            // 
            // bVolume
            // 
            this.bVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVolume.BackgroundImage = global::QuanLyCLB.Properties.LuuTruRes.audio_volume_high;
            this.bVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bVolume.Location = new System.Drawing.Point(468, 31);
            this.bVolume.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.bVolume.Name = "bVolume";
            this.bVolume.Size = new System.Drawing.Size(24, 24);
            this.bVolume.TabIndex = 9;
            this.poisonToolTip1.SetToolTip(this.bVolume, "Âm lượng");
            this.bVolume.UseSelectable = true;
            this.bVolume.Click += new System.EventHandler(this.Button_Click);
            // 
            // poisonButton2
            // 
            this.poisonButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.poisonButton2.BackgroundImage = global::QuanLyCLB.Properties.LuuTruRes.skip_previous_16dp_5f6368_fill1_wght400_grad0_opsz201;
            this.poisonButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.poisonButton2.Enabled = false;
            this.poisonButton2.Location = new System.Drawing.Point(42, 27);
            this.poisonButton2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.poisonButton2.Name = "poisonButton2";
            this.poisonButton2.Size = new System.Drawing.Size(24, 24);
            this.poisonButton2.TabIndex = 4;
            this.poisonButton2.UseSelectable = true;
            // 
            // bFastForward
            // 
            this.bFastForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bFastForward.BackgroundImage = global::QuanLyCLB.Properties.LuuTruRes.skip_next_16dp_5f6368_fill1_wght400_grad0_opsz201;
            this.bFastForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bFastForward.Enabled = false;
            this.bFastForward.Location = new System.Drawing.Point(90, 27);
            this.bFastForward.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.bFastForward.Name = "bFastForward";
            this.bFastForward.Size = new System.Drawing.Size(24, 24);
            this.bFastForward.TabIndex = 6;
            this.bFastForward.UseSelectable = true;
            // 
            // bStop
            // 
            this.bStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bStop.BackgroundImage = global::QuanLyCLB.Properties.LuuTruRes.stop_16dp_5f6368_fill1_wght400_grad0_opsz201;
            this.bStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bStop.Location = new System.Drawing.Point(66, 27);
            this.bStop.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(24, 24);
            this.bStop.TabIndex = 5;
            this.poisonToolTip1.SetToolTip(this.bStop, "Dừng");
            this.bStop.UseSelectable = true;
            this.bStop.Click += new System.EventHandler(this.Button_Click);
            // 
            // bSpeed
            // 
            this.bSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSpeed.BackgroundImage = global::QuanLyCLB.Properties.LuuTruRes.speed_16dp_5f6368_fill1_wght400_grad0_opsz201;
            this.bSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bSpeed.Location = new System.Drawing.Point(122, 27);
            this.bSpeed.Margin = new System.Windows.Forms.Padding(8, 0, 0, 4);
            this.bSpeed.Name = "bSpeed";
            this.bSpeed.Size = new System.Drawing.Size(24, 24);
            this.bSpeed.TabIndex = 7;
            this.poisonToolTip1.SetToolTip(this.bSpeed, "Tốc độ");
            this.bSpeed.UseCustomBackColor = true;
            this.bSpeed.UseSelectable = true;
            this.bSpeed.Click += new System.EventHandler(this.Button_Click);
            // 
            // bPlayPause
            // 
            this.bPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPlayPause.BackgroundImage = global::QuanLyCLB.Properties.LuuTruRes.pause_16dp_5f6368_fill1_wght400_grad0_opsz201;
            this.bPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPlayPause.Location = new System.Drawing.Point(4, 23);
            this.bPlayPause.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.bPlayPause.Name = "bPlayPause";
            this.bPlayPause.Size = new System.Drawing.Size(32, 32);
            this.bPlayPause.TabIndex = 3;
            this.poisonToolTip1.SetToolTip(this.bPlayPause, "Phát/Tạm dừng");
            this.bPlayPause.UseSelectable = true;
            this.bPlayPause.Click += new System.EventHandler(this.Button_Click);
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.BackgroundImage = global::QuanLyCLB.Properties.Resources.favicon_WPS_Photos_3;
            this.videoView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.videoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView1.Location = new System.Drawing.Point(0, 0);
            this.videoView1.Margin = new System.Windows.Forms.Padding(0);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(600, 341);
            this.videoView1.TabIndex = 0;
            // 
            // volumeTimer
            // 
            this.volumeTimer.Interval = 200;
            this.volumeTimer.Tick += new System.EventHandler(this.volumeTimer_Tick);
            // 
            // poisonToolTip1
            // 
            this.poisonToolTip1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonToolTip1.StyleManager = null;
            this.poisonToolTip1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // TrinhDocTruyenThong
            // 
            this.Controls.Add(this.videoView1);
            this.Controls.Add(this.pMediaControls);
            this.Name = "TrinhDocTruyenThong";
            this.Size = new System.Drawing.Size(600, 400);
            this.pMediaControls.ResumeLayout(false);
            this.pMediaControls.PerformLayout();
            this.pVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LibVLCSharp.WinForms.VideoView videoView1;
        private ReaLTaiizor.Controls.PoisonButton bStop;
        private ReaLTaiizor.Controls.PoisonButton bPlayPause;
        private ReaLTaiizor.Controls.PoisonButton bVolume;
        private ReaLTaiizor.Controls.PoisonPanel pMediaControls;
        private ReaLTaiizor.Controls.PoisonLabel lLength;
        private ReaLTaiizor.Controls.PoisonLabel lTime;
        private System.Windows.Forms.Panel pVolume;
        private ReaLTaiizor.Controls.DungeonTrackBar seekbar;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonButton bSpeed;
        private ReaLTaiizor.Controls.PoisonButton poisonButton2;
        private ReaLTaiizor.Controls.PoisonButton bFastForward;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private System.Windows.Forms.Timer volumeTimer;
        private ReaLTaiizor.Controls.PoisonToolTip poisonToolTip1;
    }
}

