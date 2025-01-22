using ReaLTaiizor.Controls;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using QuanLyCLB.Models;
using System.Windows.Forms;
using QuanLyCLB.Utils;
using QuanLyCLB.Properties;
using QuanLyCLB.EventArgs;
using ReaLTaiizor.Manager;
using System.Threading;
using QuanLyCLB.Commands.Lich;
using QuanLyCLB.Commands.LoaiLich;
using QuanLyCLB.Commands.ThongBao;

namespace QuanLyCLB.Lich
{
    public partial class QuanLyLich : PoisonUserControl
    {
        private DateTime _date;
        private bool loaded;
        private CauLacBoModel CauLacBo;
        private bool readOnly;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = lich.Date = cacThu1.Date = DateUtils.GetMonday(value);
                poisonLabel1.Text = $"{value:dd/MM/yyyy} - {value.AddDays(6):dd/MM/yyyy}";
            }
        }

        public QuanLyLich()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
        }

        public async void Init(PoisonStyleManager poisonStyleManager, ThanhVienModel thanhVien, CauLacBoModel cauLacBo)
        {
            if (loaded) return;
            loaded = true;
            CauLacBo = cauLacBo;
            InitUtils.Init(poisonStyleManager, this, InitializeComponent);
            Program.ThemeChanged += OnThemeChanged;

            if (thanhVien.ChucVu != ChucVu.TruongNhom && thanhVien.ChucVu != ChucVu.PhoNhom && GiaoDienChinh.GiaoDienChinh.NguoiDung.MaQuyenHan != NguoiDungModel.QuyenHan_Admin)
            {
                lich.ReadOnly = true;
                readOnly = true;
            }

            Date = DateTime.Today;
            
            try
            {
                // Loại lịch
                lpCacLoaiLich.Controls.Clear();
                List<LoaiLichModel> cacLoaiLich = (await new DanhSachLoaiLich().OnNext(model =>
                {
                    LoaiLichItem item = new LoaiLichItem(model)
                    {
                        Width = lpCacLoaiLich.Width - 20
                    };
                    if (!readOnly) item.MouseDown += Item_MouseDown;
                    lpCacLoaiLich.Controls.Add(item);
                }).Execute(CancellationToken.None)).ToList();
                suaLich1.SetCacLoaiLich(cacLoaiLich);

                // Lịch
                lich.Models = (await new DanhSachLich(cauLacBo).Execute(CancellationToken.None)).ToList();
            }
            catch (Exception exc)
            {
                alertBox1.Alert(Resources.QuanLyLich_Loi_1, exc.Message);
            }
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private void lich_ItemClick(object sender, LichEventArgs e)
        {
            suaLich1.Show(e.Model, false);
        }

        private void Item_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            LoaiLichItem item = (LoaiLichItem)sender;
            DragDropEffects dragDropResult = DoDragDrop(item.Model, DragDropEffects.Copy);
            if (dragDropResult == DragDropEffects.None)
                alertBox1.Alert(Resources.QuanLyLich_HuongDanKeoTha);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Date = e.Start;
            monthCalendar1.Hide();
        }

        private void lich_LichMoi(object sender, LichEventArgs e)
        {
            suaLich1.Show(e.Model, true);

            /*DateTime date = DateTime.Today;
            PoisonPanel p = (PoisonPanel)sender;
            int gioBatDau = p.PointToClient(new Point(e.X, e.Y)).Y / 72 + 6;
            NewDragDrop?.Invoke(this, new LichModel()
            {
                ThoiGianBatDau = date.AddHours(gioBatDau).TimeOfDay,
                ThoiGianKetThuc = date.AddHours(gioBatDau + 1).TimeOfDay
            });
            p.BackColor = Color.FromArgb(255, 255, 255);*/
        }

        private void Control_Click(object sender, System.EventArgs e)
        {
            if (sender == bTuanTruoc)
                Date = Date.AddDays(-7);
            else if (sender == bTuanSau)
                Date = Date.AddDays(7);
            else if (sender == bHomNay)
                Date = DateTime.Today;
            else if (sender == bChonNgay)
            {
                monthCalendar1.SelectionStart = Date;
                monthCalendar1.Visible = !monthCalendar1.Visible;
            }
        }

        private async void suaLich1_OnFinished(object sender, SuaLichEventArgs e)
        {
            // Lịch
            try
            {
                switch (e.HanhDongSuaLich)
                {
                    case HanhDongSuaLich.Them:
                        e.Model.MaLich = IDGenerator.Generate(IDGenerator.IDType.Lich);
                        e.Model.MaCLB = CauLacBo.MaCLB;
                        if (e.Model.LapLai == CheDoLapLai.KhongLap) e.Model.NgayKetThuc = e.Model.NgayBatDau;
                        await new ThemLich(e.Model).Execute(CancellationToken.None);
                        alertBox1.Alert(Resources.QuanLyLich_Them_HoanThanh);
                        break;
                    case HanhDongSuaLich.Sua:
                        await new Commands.Lich.SuaLich(e.Model).Execute(CancellationToken.None);
                        alertBox1.Alert(Resources.QuanLyLich_Sua_HoanThanh);
                        break;
                    case HanhDongSuaLich.Xoa:
                        await new XoaLich(e.Model).Execute(CancellationToken.None);
                        alertBox1.Alert(Resources.QuanLyLich_Xoa_HoanThanh);
                        break;
                    default:
                        return;
                }
            }
            catch (Exception exc)
            {
                switch (e.HanhDongSuaLich)
                {
                    case HanhDongSuaLich.Them:
                        alertBox1.Alert(Resources.QuanLyLich_Them_Loi_1, exc.Message);
                        break;
                    case HanhDongSuaLich.Sua:
                        alertBox1.Alert(Resources.QuanLyLich_Sua_Loi_1, exc.Message);
                        break;
                    case HanhDongSuaLich.Xoa:
                        alertBox1.Alert(Resources.QuanLyLich_Xoa_Loi_1, exc.Message);
                        break;
                }
            }

            // Thông báo
            if (e.GuiThongBao)
            {
                try
                {
                    switch (e.HanhDongSuaLich)
                    {
                        case HanhDongSuaLich.Them:
                            await new ThemThongBao(new ThongBaoModel
                            {
                                MaCLB = CauLacBo.MaCLB,
                                TacGia = GiaoDienChinh.GiaoDienChinh.NguoiDung.MaNguoiDung,
                                TieuDe = string.Format(Resources.QuanLyLich_ThongBao_Them_TieuDe_1, e.Model.ChuDe),
                                NoiDung = string.Format(
                                    Resources.QuanLyLich_ThongBao_Them_NoiDung_7,
                                    CauLacBo.TenCLB,
                                    e.Model.ChuDe,
                                    e.Model.DiaDiem,
                                    e.Model.NoiDung,
                                    e.Model.NgayBatDau,
                                    e.Model.ThoiGianBatDau,
                                    e.Model.ThoiGianKetThuc
                                ),
                                ThoiGianTao = DateTime.Now,
                                MaThongBao = IDGenerator.Generate(IDGenerator.IDType.ThongBao)
                            }).Execute(CancellationToken.None);
                            break;
                        case HanhDongSuaLich.Sua:
                            await new ThemThongBao(new ThongBaoModel
                            {
                                MaCLB = CauLacBo.MaCLB,
                                TacGia = GiaoDienChinh.GiaoDienChinh.NguoiDung.MaNguoiDung,
                                TieuDe = string.Format(Resources.QuanLyLich_ThongBao_Sua_TieuDe_1, e.OldModel.ChuDe),
                                NoiDung = string.Format(
                                    Resources.QuanLyLich_ThongBao_Sua_NoiDung_8,
                                    CauLacBo.TenCLB,
                                    e.OldModel.ChuDe,
                                    e.Model.ChuDe,
                                    e.Model.DiaDiem,
                                    e.Model.NoiDung,
                                    e.Model.NgayBatDau,
                                    e.Model.ThoiGianBatDau,
                                    e.Model.ThoiGianKetThuc
                                ),
                                ThoiGianTao = DateTime.Now,
                                MaThongBao = IDGenerator.Generate(IDGenerator.IDType.ThongBao)
                            }).Execute(CancellationToken.None);
                            break;
                        case HanhDongSuaLich.Xoa:
                            await new ThemThongBao(new ThongBaoModel
                            {
                                MaCLB = CauLacBo.MaCLB,
                                TacGia = GiaoDienChinh.GiaoDienChinh.NguoiDung.MaNguoiDung,
                                TieuDe = string.Format(Resources.QuanLyLich_ThongBao_Xoa_TieuDe_1, e.Model.ChuDe),
                                NoiDung = string.Format(
                                    Resources.QuanLyLich_ThongBao_Xoa_NoiDung_2,
                                    CauLacBo.TenCLB,
                                    e.Model.ChuDe
                                ),
                                ThoiGianTao = DateTime.Now,
                                MaThongBao = IDGenerator.Generate(IDGenerator.IDType.ThongBao)
                            }).Execute(CancellationToken.None);
                            break;
                    }
                }
                catch (Exception exc)
                {
                    alertBox1.Alert(Resources.QuanLyLich_GuiThongBao_Loi_1, exc.Message);
                }
            }

            // Cập nhật lịch
            try
            {
                lich.Models = (await new DanhSachLich(CauLacBo).Execute(CancellationToken.None)).ToList();
            }
            catch (Exception exc)
            {
                alertBox1.Alert(Resources.QuanLyLich_TaiLaiSauCapNhat_Loi_1, exc.Message);
            }
        }
    }
}
