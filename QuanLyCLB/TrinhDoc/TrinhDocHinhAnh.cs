using QuanLyCLB.Commands.LuuTru;
using QuanLyCLB.Exif;
using QuanLyCLB.LuuTru;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using ReaLTaiizor.Manager;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.TrinhDoc
{
    public partial class TrinhDocHinhAnh : TrinhDoc, IMessageFilter
    {
        public const int WM_MOUSEWHEEL = 0x20a;
        public const int WHEEL_DELTA = 120;
        private bool holding, zooming = true;
        private Point transformPoint2 = Point.Empty, down, oldPictureBoxLocation;
        private Size originalSize;
        private Cursor originalCursor;

        public TrinhDocHinhAnh()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        public TrinhDocHinhAnh(PoisonStyleManager poisonStyleManager, ThongTinFile container, TapTinModel model) : base(poisonStyleManager, container, model)
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        public override string ApplicationName { get { return "Image Viewer"; } }

        public override async Task Init()
        {
            try
            {
                await base.Init();
                MoTapTin = new ThongTinTapTin(Model, true).OnResult(model => Model = model);
                await MoTapTin.Execute(CancellationToken.None);
                originalCursor = pbImage.Cursor;
                originalSize = pbImage.Size;
                Image image = Image.FromStream(Model.NoiDung);
                pbImage.Image = image;

                MetadataContainer.Add(LuuTruRes.TrinhDocHinhAnh_TieuDe);
                MetadataContainer.Add(LuuTruRes.TrinhDocHinhAnh_KichThuoc_TieuDe, string.Format(LuuTruRes.TrinhDocHinhAnh_KinhThuoc_NoiDung_2, image.Width, image.Height));
                MetadataContainer.Add(LuuTruRes.TrinhDocHinhAnh_DinhDangPixel_TieuDe, image.PixelFormat.ToString());

                PropertyItemReader propertyItemReader = new PropertyItemReader();
                foreach (PropertyItem item in image.PropertyItems)
                {
                    if (!propertyItemReader.Contains(item))
                    {
                        System.Console.WriteLine($"Property [0x{item.Id:X4}] is unknown and has been ignored.");
                        continue;
                    }
                    string name = propertyItemReader.GetName(item);
                    string val = propertyItemReader.GetValue(item);
                    MetadataContainer.Add(name, val);
                }
                scZoom.Value = scZoom.Maximum;
                bZoom.PerformClick();

            }
            catch { this.Dispose(); }
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_MOUSEWHEEL)
            {
                int modifiers = m.WParam.ToInt32() & 0xffff;
                int delta = (m.WParam.ToInt32() >> 16) / WHEEL_DELTA;
                if (modifiers == 0) scZoom.Value = Math.Max(0, Math.Min(scZoom.Maximum, scZoom.Value - delta * 4));
                return true;
            }
            return false;
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            holding = true;
            pbImage.Cursor = pImage.Cursor = Cursors.SizeAll;
            down = e.Location;
            oldPictureBoxLocation = pbImage.Location;
        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!holding) return;
            Size transform = new Size(e.X - down.X, e.Y - down.Y);
            Point offsetTransform = transformPoint2 + transform;
            if (offsetTransform.X >= pbImage.Width / 2 && transform.Width > 0 ||
                offsetTransform.X <= -pbImage.Width / 2 && transform.Width < 0) return;
            if (offsetTransform.Y >= pbImage.Height / 2 && transform.Height > 0 ||
                offsetTransform.Y <= -pbImage.Height / 2 && transform.Height < 0) return;
            pbImage.Left = pbImage.Left + transform.Width;
            pbImage.Top = pbImage.Top + transform.Height;
            transformPoint2.Offset(transform.Width, transform.Height);
        }

        private void pImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!holding) return;
            Size transform = new Size(e.X - down.X, e.Y - down.Y);
            Point offsetTransform = transformPoint2 + transform;
            if (offsetTransform.X >= pbImage.Width / 2 && transform.Width > 0 ||
                offsetTransform.X <= -pbImage.Width / 2 && transform.Width < 0) return;
            if (offsetTransform.Y >= pbImage.Height / 2 && transform.Height > 0 ||
                offsetTransform.Y <= -pbImage.Height / 2 && transform.Height < 0) return;
            pbImage.Left = oldPictureBoxLocation.X + transform.Width;
            pbImage.Top = oldPictureBoxLocation.Y + transform.Height;
            transformPoint2.Offset(transform.Width, transform.Height);
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            holding = false;
            pbImage.Cursor = pImage.Cursor = originalCursor;
        }

        private float GetZoom(int value)
        {
            return 10.0f - (float)value / scZoom.Maximum * 9.0f;
        }

        private void scZoom_ValueChanged(object sender, int newValue)
        {
            pbImage.Width = (int)(originalSize.Width * GetZoom(newValue));
            pbImage.Left = -(pbImage.Width - originalSize.Width) / 2 + transformPoint2.X;
            pbImage.Height = (int)(originalSize.Height * GetZoom(newValue));
            pbImage.Top = -(pbImage.Height - originalSize.Height) / 2 + transformPoint2.Y;
        }

        private void bZoom_Click(object sender, System.EventArgs e)
        {
            zooming = !zooming;
            scZoom.Region = zooming
                ? new Region(scZoom.ClientRectangle)
                : new Region(new Rectangle(0, 0, 0, 0));
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Application.RemoveMessageFilter(this);
        }
    }
}
