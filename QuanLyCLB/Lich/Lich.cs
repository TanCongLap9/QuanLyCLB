using QuanLyCLB.EventArgs;
using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Drawing.Poison;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCLB.Lich
{
    public partial class Lich : PoisonUserControl
    {
        private int gioStart, gioEnd;
        private Size gioSize;
        private List<LichModel> models;
        private DateTime date;
        private Color dropBackColor = SystemColors.Control;
        private bool readOnly;
        public event EventHandler<LichEventArgs> ItemClick;
        public event EventHandler<LichEventArgs> LichMoi;

        public Size LichSize
        {
            get { return new Size((int)((this.Width - GioSize.Width) / 7.0), GioSize.Height); }
        }

        [DefaultValue(6)]
        public int GioStart
        {
            get { return gioStart; }
            set {
                gioStart = value;
                UpdateGio();
            }
        }

        [DefaultValue(21)]
        public int GioEnd
        {
            get { return gioEnd; }
            set {
                gioEnd = value;
                UpdateGio();
            }
        }
        
        [DefaultValue(typeof(Size), "60, 72")]
        public Size GioSize
        {
            get { return gioSize; }
            set {
                gioSize = value;
                UpdateGio();
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Date
        {
            get { return date; }
            set {
                date = DateUtils.GetMonday(value);
                UpdateDate();
            }
        }

        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<LichModel> Models
        {
            get { return models; }
            set {
                models = value;
                UpdateDate();
            }
        }

        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool ReadOnly
        {
            get { return readOnly; }
            set {
                readOnly = value;
                pLich.AllowDrop = !readOnly;
            }
        }

        public Lich()
        {
            InitializeComponent();
            GioStart = 6;
            GioEnd = 21;
            GioSize = new Size(60, 72);
            Models = new List<LichModel>();
        }

        protected override void OnParentChanged(System.EventArgs e)
        {
            base.OnParentChanged(e);
            if (!(ParentForm is PoisonForm)) return;
            PoisonForm form = (PoisonForm)ParentForm;
            dropBackColor = PoisonPaint.BackColor.Button.Normal(form.Theme);
        }

        private void ThemLich(int thuIndex, LichModel model)
        {
            LichItem lich = new LichItem(model)
            {
                Bounds = new Rectangle(
                    thuIndex * LichSize.Width,
                    (int)(GioSize.Height * (model.ThoiGianBatDau.TotalHours - GioStart)),
                    LichSize.Width,
                    (int)(GioSize.Height * (model.ThoiGianKetThuc.TotalHours - model.ThoiGianBatDau.TotalHours))
                ),
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                ThuIndex = thuIndex
            };
            if (!ReadOnly) lich.ItemClick += Lich_ItemClick;
            pLich.Controls.Add(lich);
        }

        private void Lich_ItemClick(object sender, LichEventArgs e)
        {
            ItemClick?.Invoke(sender, e);
        }

        private void poisonPanel2_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(LoaiLichModel).FullName)) return;
            LoaiLichModel model = (LoaiLichModel)e.Data.GetData(typeof(LoaiLichModel).FullName);

            Point dragPoint = GetDragPoint(e);
            LichModel lich = new LichModel()
            {
                MaLoaiLich = model.MaLoaiLich,
                TenLoaiLich = model.TenLoaiLich,
                MaMau = model.MaMau,
                NgayBatDau = Date.AddDays(dragPoint.X / LichSize.Width),
                NgayKetThuc = Date.AddDays(dragPoint.X / LichSize.Width),
                ThoiGianBatDau = TimeSpan.FromHours(dragPoint.Y / LichSize.Height + GioStart),
                ThoiGianKetThuc = TimeSpan.FromHours(dragPoint.Y / LichSize.Height + GioStart + 1),
            };

            LichMoi?.Invoke(this, new LichEventArgs(lich));
            poisonPanel2_DragLeave(this, e);
        }

        private void poisonPanel2_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(LoaiLichModel).FullName)) return;
            e.Effect = DragDropEffects.Copy;
            LoaiLichModel model = (LoaiLichModel)e.Data.GetData(typeof(LoaiLichModel).FullName);
            pKeoVaoLich.Size = LichSize;
            pLich.BackColor = dropBackColor;
            if (pKeoVaoLich.Parent != pLich) pKeoVaoLich.Parent = pLich;
            pKeoVaoLich.Model = model;
            pKeoVaoLich.Show();
            pKeoVaoLich.BringToFront();
        }

        private void poisonPanel2_DragOver(object sender, DragEventArgs e)
        {
            Point dragPoint = GetDragPoint(e);
            pKeoVaoLich.Location = new Point(
                dragPoint.X / LichSize.Width * LichSize.Width,
                dragPoint.Y / LichSize.Height * LichSize.Height
            );
        }

        private Point GetDragPoint(DragEventArgs e)
        {
            Point clientPoint = this.PointToClient(new Point(e.X, e.Y));
            return new Point(
                clientPoint.X - GioSize.Width - this.AutoScrollPosition.X,
                clientPoint.Y - this.AutoScrollPosition.Y
            );
        }

        private void poisonPanel2_DragLeave(object sender, System.EventArgs e)
        {
            pLich.BackColor = Color.Transparent;
            pKeoVaoLich.Model = null;
            pKeoVaoLich.Parent = this;
            pKeoVaoLich.Hide();
        }

        public void UpdateGio()
        {
            fpGio.Width = GioSize.Width;
            fpGio.Height = pLich.Height = GioSize.Height * (GioEnd - GioStart + 1);
            fpGio.SuspendLayout();
            fpGio.Controls.Clear();
            // Thêm các giờ
            for (int i = GioStart; i <= GioEnd; i++)
                fpGio.Controls.Add(new Gio(i)
                {
                    Size = GioSize
                });
            fpGio.ResumeLayout();
        }

        public void UpdateCacLichSize()
        {
            foreach (Control c in pLich.Controls)
            {
                if (!(c is LichItem)) continue;
                LichItem item = (LichItem)c;
                c.Left = item.ThuIndex * LichSize.Width;
                c.Width = LichSize.Width;
            }
        }

        public void UpdateDate()
        {
            // Xoá các lịch
            for (int i = pLich.Controls.Count - 1; i >= 0; i--)
            {
                if (pLich.Controls[i] is LichItem)
                    pLich.Controls.RemoveAt(i);
            }

            // Thêm các lịch
            foreach (LichModel model in Models)
            {
                if (model.LapLai == CheDoLapLai.KhongLap)
                {
                    int off = (model.NgayBatDau - Date).Days;
                    if (off < 0 || off >= 7) continue;
                    ThemLich(off, model);
                }
                else if ((byte)model.LapLai >= 1 && (byte)model.LapLai <= 6)
                    for (int j = 0; j < 7; j++)
                    {
                        DateTime offDate = Date.AddDays(j);
                        if (offDate > model.NgayKetThuc) break;
                        if (offDate < model.NgayBatDau) continue;
                        if ((offDate - model.NgayBatDau).Days % (byte)model.LapLai != 0) continue;
                        ThemLich(j, model);
                    }
                else if (model.LapLai == CheDoLapLai.MoiTuan)
                    for (int j = 0; j < 7; j++)
                    {
                        DateTime offDate = Date.AddDays(j);
                        if (offDate > model.NgayKetThuc) break;
                        if (offDate < model.NgayBatDau) continue;
                        if ((offDate - model.NgayBatDau).Days % 7 != 0) continue;
                        ThemLich(j, model);
                    }
                else if (model.LapLai == CheDoLapLai.MoiThang)
                    for (int j = 0; j < 7; j++)
                    {
                        DateTime offDate = Date.AddDays(j);
                        if (offDate > model.NgayKetThuc) break;
                        if (offDate < model.NgayBatDau) continue;
                        if (offDate.Day != model.NgayBatDau.Day) continue;
                        ThemLich(j, model);
                    }
            }
        }

        public void UpdateTatCa()
        {
            UpdateGio();
            UpdateDate();
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            UpdateCacLichSize();
        }
    }
}
