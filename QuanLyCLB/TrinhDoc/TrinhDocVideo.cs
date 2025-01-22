using LibVLCSharp.Shared;
using QuanLyCLB.Commands.LuuTru;
using QuanLyCLB.LuuTru;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using ReaLTaiizor.Manager;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.TrinhDoc
{
    public partial class TrinhDocVideo : TrinhDoc
    {
        private bool seeking, opened, volumeChanged = true;
        private int rateIndex;
        private float[] rateValues = { 1f, 1.25f, 1.5f, 1.75f, 2f, 0.25f, 0.5f, 0.75f };
        private MediaPlayer player;
        private StreamMediaInput smi;
        private Media media;
        private LibVLC libVLC;
        private Form form;

        public TrinhDocVideo()
        {
            InitializeComponent();
        }

        public TrinhDocVideo(PoisonStyleManager poisonStyleManager, ThongTinFile container, TapTinModel model) : base(poisonStyleManager, container, model)
        {
            InitializeComponent();
        }

        public override string ApplicationName { get { return "VLC Media Player"; } }

        public override async Task Init()
        {
            try
            {
                await base.Init();
                MoTapTin = new ThongTinTapTin(Model, true).OnResult(model => Model = model);
                await MoTapTin.Execute(CancellationToken.None);
                // Copying to ms is faster than non-sequential access
                MemoryStream ms = new MemoryStream();
                await Model.NoiDung.CopyToAsync(ms);
                ms.Seek(0, SeekOrigin.Begin);
                Model.NoiDung = ms;

                await Task.Run(() =>
                {
                    Core.Initialize();
                    libVLC = new string[] { ".gif" }.Contains(Path.GetExtension(Model.TenTapTin)) ? new LibVLC("--demux=avformat") : new LibVLC();
                    smi = new StreamMediaInput(Model.NoiDung);
                    media = new Media(libVLC, smi);
                    player = new MediaPlayer(media);
                });
                seekbar.Select();
                player.Paused += Player_Paused;
                player.Playing += Player_Playing;
                player.Stopped += Player_Stopped;
                player.VolumeChanged += Player_VolumeChanged;
                player.TimeChanged += Player_TimeChanged;
                player.EncounteredError += Player_EncounteredError;
                videoView1.MediaPlayer = player;

                volumeTimer.Enabled = true;
                player.Play();
                pVolume.Invalidate();
            }
            catch { this.Dispose(); }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Alt | Keys.Control | Keys.Enter:
                    this.ParentForm.WindowState = this.ParentForm.WindowState == FormWindowState.Maximized
                        ? FormWindowState.Normal
                        : FormWindowState.Maximized;
                    return true;
                case Keys.Space:
                    bPlayPause.PerformClick();
                    return true;
                case Keys.Left:
                    player.SeekTo(TimeSpan.FromMilliseconds(Math.Max(0, player.Time - 10000)));
                    return true;
                case Keys.Right:
                    player.SeekTo(TimeSpan.FromMilliseconds(Math.Min(player.Length, player.Time + 10000)));
                    return true;
            }
            return false;
        }

        private void Player_EncounteredError(object sender, System.EventArgs e)
        {
            this.Dispose();
            System.Console.WriteLine(e);
        }

        private void Player_TimeChanged(object sender, MediaPlayerTimeChangedEventArgs e)
        {
            if (!IsDisposed && !seeking) Invoke(new Action(() =>
            {
                TimeSpan time = TimeSpan.FromMilliseconds(player.Time);
                TimeSpan length = TimeSpan.FromMilliseconds(player.Length);
                lTime.Text = string.Format(time.ToString("mm':'ss"));
                lLength.Text = string.Format(length.ToString("mm':'ss"));
                seekbar.Value = (int)(player.Time / (float)player.Length * seekbar.Maximum);
            }));
        }

        private void Player_VolumeChanged(object sender, MediaPlayerVolumeChangedEventArgs e)
        {
            if (!IsDisposed && !seeking) Invoke(new Action(() =>
            {
                volumeChanged = true;
            }));
        }

        private void SafeSetText(string control, Func<string> value)
        {
            try
            {
                string returned = value.Invoke();
                if (returned != null) MetadataContainer.Add(control, returned);
            }
            catch (NotSupportedException) { }
        }

        private void Player_Playing(object sender, System.EventArgs e)
        {
            if (!IsDisposed) Invoke(new Action(() =>
            {
                seekbar.Enabled = true;
                try
                {
                    bPlayPause.BackgroundImage = LuuTruRes.pause_16dp_5f6368_fill1_wght400_grad0_opsz201;
                    if (opened) return;
                    
                    opened = true;
                    MetadataContainer.Add(player.VideoTrack != -1 ? LuuTruRes.TrinhDocVideo_TieuDe_Video : LuuTruRes.TrinhDocVideo_TieuDe_Audio);
                    MetadataContainer.Add(LuuTruRes.TrinhDocVideo_ThoiLuong_TieuDe, TimeSpan.FromMilliseconds(media.Duration).ToString("hh':'mm':'ss"));

                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Actors, () => media.Meta(MetadataType.Actors));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Album, () => media.Meta(MetadataType.Album));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_AlbumArtist, () => media.Meta(MetadataType.AlbumArtist));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Artist, () => media.Meta(MetadataType.Artist));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_ArtworkURL, () => media.Meta(MetadataType.ArtworkURL));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Copyright, () => media.Meta(MetadataType.Copyright));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Date, () => media.Meta(MetadataType.Date));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Description, () => media.Meta(MetadataType.Description));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Director, () => media.Meta(MetadataType.Director));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_DiscNumber, () => media.Meta(MetadataType.DiscNumber));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_DiscTotal, () => media.Meta(MetadataType.DiscTotal));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_EncodedBy, () => media.Meta(MetadataType.EncodedBy));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Episode, () => media.Meta(MetadataType.Episode));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Genre, () => media.Meta(MetadataType.Genre));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Language, () => media.Meta(MetadataType.Language));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_NowPlaying, () => media.Meta(MetadataType.NowPlaying));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Publisher, () => media.Meta(MetadataType.Publisher));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Rating, () => media.Meta(MetadataType.Rating));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Season, () => media.Meta(MetadataType.Season));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Setting, () => media.Meta(MetadataType.Setting));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_ShowName, () => media.Meta(MetadataType.ShowName));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_Title, () => media.Meta(MetadataType.Title));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_TrackID, () => media.Meta(MetadataType.TrackID));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_TrackNumber, () => media.Meta(MetadataType.TrackNumber));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_TrackTotal, () => media.Meta(MetadataType.TrackTotal));
                    SafeSetText(LuuTruRes.TrinhDocVideo_Metadata_URL, () => media.Meta(MetadataType.URL));
                }
                catch { this.Dispose(); }
                finally { PoisonStyleManager.Update(); }
            }));
        }

        private void Player_Stopped(object sender, System.EventArgs e)
        {
            if (!IsDisposed) Invoke(new Action(() =>
            {
                bPlayPause.BackgroundImage = LuuTruRes.play_arrow_16dp_5f6368_fill1_wght400_grad0_opsz201;
                seekbar.Enabled = false;
                Player_TimeChanged(sender, null);
            }));
        }

        private void Player_Paused(object sender, System.EventArgs e)
        {
            if (!IsDisposed) Invoke(new Action(() =>
            {
                bPlayPause.BackgroundImage = LuuTruRes.play_arrow_16dp_5f6368_fill1_wght400_grad0_opsz201;
            }));
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            if (sender == bPlayPause)
                if (player.State == VLCState.Ended)
                {
                    player.Stop();
                    player.Play();
                }
                else if (player.IsPlaying) player.Pause();
                else player.Play();
            else if (sender == bVolume)
                player.ToggleMute();
            else if (sender == bSpeed)
            {
                rateIndex++;
                rateIndex %= rateValues.Length;
                poisonLabel2.Text = rateValues[rateIndex].ToString("g3") + "x";
                player.SetRate(rateValues[rateIndex]);
            }
            else if (sender == bStop)
                player.Stop();
        }

        private void seekbar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || player.State != VLCState.Playing) return;
            seeking = false;
            player.SeekTo(TimeSpan.FromMilliseconds(seekbar.Value / (float)seekbar.Maximum * player.Length));
        }

        private void seekbar_ValueChanged()
        {
            if (!seeking) return;
            TimeSpan time = TimeSpan.FromMilliseconds(seekbar.Value / (float)seekbar.Maximum * player.Length);
            TimeSpan length = TimeSpan.FromMilliseconds(player.Length);
            lTime.Text = string.Format(time.ToString("mm':'ss"));
            lLength.Text = string.Format(length.ToString("mm':'ss"));
        }

        private void seekbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || !player.IsPlaying) return;
            seeking = true;
        }

        private void volumeTimer_Tick(object sender, System.EventArgs e)
        {
            if (!volumeChanged) return;
            volumeChanged = false;
            if (!IsDisposed) Invoke(new Action(() => {
                float volume = player.Volume / 100f;
                poisonLabel1.Text = player.Volume + "%";
                pVolume.Invalidate();
                if (player.Mute)
                    bVolume.BackgroundImage = LuuTruRes.audio_volume_muted;
                else if (volume >= 2 / 3f)
                    bVolume.BackgroundImage = LuuTruRes.audio_volume_high;
                else if (volume >= 1 / 3f)
                    bVolume.BackgroundImage = LuuTruRes.audio_volume_medium;
                else if (volume > 0)
                    bVolume.BackgroundImage = LuuTruRes.audio_volume_low;
                else
                    bVolume.BackgroundImage = LuuTruRes.audio_volume_muted;
            }));
        }

        private void pVolume_Paint(object sender, PaintEventArgs e)
        {
            if (player == null) return;
            float volume = player.Volume / 100f;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Brush b = new SolidBrush(Color.FromArgb(50, 210, 50));
            Pen p = new Pen(Color.FromArgb(95, 99, 104), 1.5f);

            if (volume > 0)
            {
                e.Graphics.FillPolygon(b, new PointF[] {
                    new PointF(4, pVolume.Height - 4),
                    new PointF((pVolume.Width - 4) * volume, (pVolume.Height - 4) * (1f - volume) + 4),
                    new PointF((pVolume.Width - 4) * volume, pVolume.Height - 4)
                });
            }
            
            e.Graphics.DrawPolygon(p, new PointF[] {
                new PointF(3, pVolume.Height - 3),
                new PointF(pVolume.Width - 3, 3),
                new PointF(pVolume.Width - 3, pVolume.Height - 3)
            });
        }

        private void pVolume_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            float volume = Math.Max(0, Math.Min(pVolume.Width, e.X)) / (float)pVolume.Width;
            player.Volume = (int)(volume * 100);
        }

        protected override void OnParentChanged(System.EventArgs e)
        {
            base.OnParentChanged(e);
            if (ParentForm != null)
            {
                form = ParentForm;
                ParentForm.FormClosing += ParentForm_FormClosing;
            }
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Dispose();
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            form.FormClosing -= ParentForm_FormClosing;
            Model.NoiDung.Dispose();
            // player.Stop();
            // player?.Stop();
        }
    }
}
