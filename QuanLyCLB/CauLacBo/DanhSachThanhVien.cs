using QuanLyCLB.Commands.NguoiDung;
using QuanLyCLB.Commands.ThanhVien;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.CauLacBo
{
    public partial class DanhSachThanhVien : PoisonUserControl
    {
        private readonly List<ThanhVienModel> CacThanhVien = new List<ThanhVienModel>();
        private readonly List<ThanhVienModel> CacThanhVienDuocLoc = new List<ThanhVienModel>();
        private readonly List<NguoiDungModel> CacNguoiDungTimDuoc = new List<NguoiDungModel>();
        private CauLacBoModel CauLacBo;
        private bool loaded;
        private bool addOnActivate;

        public DanhSachThanhVien()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
            ColorUtils.SetColor(listView, e.Theme);
        }

        public async void Init(PoisonStyleManager poisonStyleManager, ThanhVienModel thanhVien, CauLacBoModel cauLacBo)
        {
            if (loaded) return;
            loaded = true;
            InitUtils.Init(poisonStyleManager, this, InitializeComponent);
            CauLacBo = cauLacBo;
            ColorUtils.SetColor(listView, poisonStyleManager.Theme);
            Program.ThemeChanged += OnThemeChanged;

            if (thanhVien.ChucVu != ChucVu.TruongNhom && thanhVien.ChucVu != ChucVu.PhoNhom && GiaoDienChinh.GiaoDienChinh.NguoiDung.MaQuyenHan != NguoiDungModel.QuyenHan_Admin)
            {
                bThem.Visible = bXoa.Visible = false;
                ctxListView.Dispose();
            }
            await Tai();
        }
        
        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private async Task Tai()
        {
            try
            {
                tTimKiem.Clear();
                CacThanhVien.Clear();
                listView.Items.Clear();
                imageList.Images.Clear();
                int count = 0;
                await new Commands.ThanhVien.DanhSachThanhVien(CauLacBo).OnNext(model =>
                {
                    imageList.Images.Add(model.MaNguoiDung, ImageUtils.GetNguoiDungImage(model.AnhDaiDien, imageList.ImageSize));
                    CacThanhVien.Add(model);
                    CacThanhVienDuocLoc.Add(model);
                    AddLvi(model);
                    count++;
                }).Execute(CancellationToken.None);
                lStatus.Hide();
                lSoLuongThanhVien.Text = string.Format(Resources.DanhSachThanhVien_SoLuongThanhVien, count);
            }
            catch (Exception exc)
            {
                lStatus.BringToFront();
                lStatus.Text = exc.Message;
                lStatus.Show();
            }
        }

        private void AddLvi(ThanhVienModel thanhVien)
        {
            listView.Items.Add(new ListViewItem(new string[] {
                thanhVien.HoTen,
                thanhVien.MSSV +
                    (thanhVien.ChucVu == ChucVu.TruongNhom
                    ? ", Trưởng nhóm"
                    : thanhVien.ChucVu == ChucVu.PhoNhom
                    ? ", Phó nhóm"
                    : string.Empty)
            }, thanhVien.MaNguoiDung));
        }

        private void AddLvi(NguoiDungModel nguoiDung)
        {
            listView.Items.Add(new ListViewItem(new string[] {
                nguoiDung.HoTen,
                nguoiDung.MSSV
            }, nguoiDung.MaNguoiDung));
        }

        private async void Button_Click(object sender, System.EventArgs e)
        {
            if (sender == bThem) Them();
            if (sender == bXoa) await Xoa();
            if (sender == bTaiLai) await Tai();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    if (addOnActivate)
                    {
                        addOnActivate = false;
                        Tai();
                        return true;
                    }
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private async void ctxItem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == xoáToolStripMenuItem1)
            {
                if (!addOnActivate) await Xoa();
                else hopThongBao.Alert(Resources.DanhSachThanhVien_Xoa_LoiCheDoThem);
            }
            else if (e.ClickedItem == thêmToolStripMenuItem) Them();
            else if (e.ClickedItem == trưởngNhómToolStripMenuItem)
            {
                if (!addOnActivate) await DoiChucVu(ChucVu.TruongNhom);
                else hopThongBao.Alert(Resources.DanhSachThanhVien_DoiChucVu_LoiCheDoThem);
            }
            else if (e.ClickedItem == phóNhómToolStripMenuItem)
            {
                if (!addOnActivate) await DoiChucVu(ChucVu.PhoNhom);
                else hopThongBao.Alert(Resources.DanhSachThanhVien_DoiChucVu_LoiCheDoThem);
            }
            else if (e.ClickedItem == thànhViênToolStripMenuItem)
            {
                if (!addOnActivate) await DoiChucVu(ChucVu.Thuong);
                else hopThongBao.Alert(Resources.DanhSachThanhVien_DoiChucVu_LoiCheDoThem);
            }
        }

        private void Them()
        {
            hopThongBao.Alert(Resources.DanhSachThanhVien_ChuanBiThem_NoiDung, 5000);
            addOnActivate = true;
            listView.Items.Clear();
        }

        private async Task Xoa()
        {
            if (listView.SelectedItems.Count == 0) return;
            ThanhVienModel thanhVien = CacThanhVienDuocLoc[listView.SelectedIndices[0]];
            if (PoisonMessageBox.Show(this, string.Format(
                Resources.DanhSachThanhVien_XacNhanXoa_NoiDung_1,
                thanhVien.HoTen
            ), Resources.DanhSachThanhVien_XacNhanXoa_TieuDe, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                await new XoaThanhVien(thanhVien).Execute(CancellationToken.None);
                await Tai();
            }
            catch (Exception exc)
            {
                PoisonMessageBox.Show(this, string.Format(
                    Resources.DanhSachThanhVien_Xoa_Loi_NoiDung_1,
                    exc.Message
                ), Resources.DanhSachThanhVien_Xoa_Loi_TieuDe, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DoiChucVu(ChucVu chucVu)
        {
            if (listView.SelectedItems.Count == 0) return;
            ThanhVienModel thanhVien = CacThanhVienDuocLoc[listView.SelectedIndices[0]];
            if (PoisonMessageBox.Show(this, string.Format(
                Resources.DanhSachThanhVien_XacNhanDoiChucVu_NoiDung_2,
                thanhVien.HoTen,
                chucVu == ChucVu.TruongNhom ? "Trưởng nhóm" : chucVu == ChucVu.PhoNhom ? "Phó nhóm" : "Thành viên"
            ), Resources.DanhSachThanhVien_XacNhanDoiChucVu_TieuDe, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                await new SuaThanhVien(new Dictionary<string, object>
                {
                    ["MaNguoiDung"] = thanhVien.MaNguoiDung,
                    ["MaCLB"] = thanhVien.MaCLB,
                    ["ChucVu"] = chucVu
                }).Execute(CancellationToken.None);
                await Tai();
            }
            catch (Exception exc)
            {
                PoisonMessageBox.Show(this, string.Format(
                    Resources.DanhSachThanhVien_DoiChucVu_Loi_NoiDung_1,
                    exc.Message
                ), Resources.DanhSachThanhVien_DoiChucVu_Loi_TieuDe, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            bXoa.Enabled = listView.SelectedIndices.Count != 0;
        }

        private async void tTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    try
                    {
                        listView.BeginUpdate();
                        listView.Items.Clear();
                        CacThanhVienDuocLoc.Clear();
                        if (!addOnActivate)
                        {
                            foreach (ThanhVienModel thanhVien in CacThanhVien)
                                if (string.IsNullOrEmpty(tTimKiem.Text) ||
                                    thanhVien.HoTen.IndexOf(tTimKiem.Text, StringComparison.InvariantCultureIgnoreCase) != -1 ||
                                    thanhVien.MSSV.IndexOf(tTimKiem.Text, StringComparison.InvariantCultureIgnoreCase) != -1)
                                {
                                    CacThanhVienDuocLoc.Add(thanhVien);
                                    AddLvi(thanhVien);
                                }
                        }
                        else
                        {
                            CacNguoiDungTimDuoc.Clear();
                            imageList.Images.Clear();
                            await new TimKiemNguoiDung(new Dictionary<string, object>
                            {
                                ["Ho"] = tTimKiem.Text,
                                ["Lot"] = tTimKiem.Text,
                                ["Ten"] = tTimKiem.Text,
                                ["MSSV"] = tTimKiem.Text
                            }).OnNext(model =>
                            {
                                imageList.Images.Add(model.MaNguoiDung, ImageUtils.GetNguoiDungImage(model.AnhDaiDien, imageList.ImageSize));
                                CacNguoiDungTimDuoc.Add(model);
                                AddLvi(model);
                            }).Execute(CancellationToken.None);
                        }
                        lStatus.Hide();
                    }
                    catch (Exception exc)
                    {
                        lStatus.BringToFront();
                        lStatus.Text = exc.Message;
                        lStatus.Show();
                    }
                    finally
                    {
                        listView.EndUpdate();
                    }
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private async void listView_ItemActivate(object sender, System.EventArgs e)
        {
            if (!addOnActivate || listView.SelectedItems.Count == 0) return;
            NguoiDungModel nguoiDung = CacNguoiDungTimDuoc[listView.SelectedIndices[0]];
            if (PoisonMessageBox.Show(this, string.Format(
                    Resources.DanhSachThanhVien_XacNhanThem_NoiDung_1,
                    nguoiDung.HoTen
                ), Resources.DanhSachThanhVien_XacNhanThem_TieuDe, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                ThanhVienModel thanhVienMoi = new ThanhVienModel
                {
                    MaNguoiDung = nguoiDung.MaNguoiDung,
                    MaCLB = CauLacBo.MaCLB,
                    ChucVu = ChucVu.Thuong
                };
                await new ThemThanhVien(thanhVienMoi).Execute(CancellationToken.None);
                addOnActivate = false;
                await Tai();
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2627)
                    PoisonMessageBox.Show(this, string.Format(
                        Resources.DanhSachThanhVien_Them_LoiTrungKhop_NoiDung_1,
                        nguoiDung.HoTen
                    ), Resources.DanhSachThanhVien_Them_LoiTrungKhop_TieuDe, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else 
                    PoisonMessageBox.Show(this, string.Format(
                        Resources.DanhSachThanhVien_Them_Loi_NoiDung_1,
                        exc.Message
                    ), Resources.DanhSachThanhVien_Them_Loi_TieuDe, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                PoisonMessageBox.Show(this, string.Format(
                    Resources.DanhSachThanhVien_Them_Loi_NoiDung_1,
                    exc.Message
                ), Resources.DanhSachThanhVien_Them_Loi_TieuDe, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
