using QuanLyCLB.Commands.LuuTru;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCLB.Commands;
using QuanLyCLB.TrinhDoc;
using ReaLTaiizor.Manager;
using System.Drawing;

namespace QuanLyCLB.LuuTru
{
    public partial class LuuTru : PoisonUserControl
    {
        private CheDoChonThuMuc _cheDoChonThuMuc;
        private bool loaded, readOnly;
        private ThanhVienModel ThanhVien;
        private CauLacBoModel CauLacBo;
        private CacChucNangLuuTru CacChucNang;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;
                bTapTinXoa.Visible = bTapTinSaoChep.Visible = bTapTinDiChuyen.Visible =
                    bThuMucChinh.Visible = bThuMucThem.Visible = bThuMucXoa.Visible = !value;
                miTapTinDiChuyen.Visible = miTapTinSaoChep.Visible = miTapTinXoa.Visible = miTapTinDoiTen.Visible = !value;
                danhSachTapTin.LabelEdit = !value;
                danhSachTapTin.AllowDrop = !value;
                if (ReadOnly) ctxThuMuc.Dispose();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CheDoChonThuMuc CheDoChonThuMuc
        {
            get { return _cheDoChonThuMuc; }
            set
            {
                if (ReadOnly) return;
                _cheDoChonThuMuc = value;
                switch (value)
                {
                    case CheDoChonThuMuc.Open:
                        pHanhDongThuMuc.Enabled = pHanhDongTapTin.Enabled = danhSachTapTin.Enabled = true;
                        break;
                    case CheDoChonThuMuc.MoveTo:
                        if (danhSachTapTin.SelectedItems.Count == 0)
                        {
                            _cheDoChonThuMuc = CheDoChonThuMuc.Open;
                            hopThongBao.Alert(LuuTruRes.TapTin_DiChuyen_LoiChon0);
                            break;
                        }
                        pHanhDongThuMuc.Enabled = pHanhDongTapTin.Enabled = danhSachTapTin.Enabled = false;
                        hopThongBao.Alert(LuuTruRes.DanhSachTapTin_DiChuyen_ChuanBi, 10000);
                        break;
                    case CheDoChonThuMuc.CopyTo:
                        if (danhSachTapTin.SelectedItems.Count == 0)
                        {
                            _cheDoChonThuMuc = CheDoChonThuMuc.Open;
                            hopThongBao.Alert(LuuTruRes.TapTin_SaoChep_LoiChon0);
                            break;
                        }
                        pHanhDongThuMuc.Enabled = pHanhDongTapTin.Enabled = danhSachTapTin.Enabled = false;
                        hopThongBao.Alert(LuuTruRes.DanhSachTapTin_SaoChep_ChuanBi, 10000);
                        break;
                }
            }
        }

        public LuuTru()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
            danhSachTapTin.Theme = e.Theme;
        }

        public void Init(PoisonStyleManager poisonStyleManager, ThanhVienModel thanhVien, CauLacBoModel cauLacBo)
        {
            if (loaded) return;
            loaded = true;
            ThanhVien = thanhVien;
            CauLacBo = cauLacBo;
            InitUtils.Init(poisonStyleManager, this, InitializeComponent);
            danhSachTapTin.Theme = poisonStyleManager.Theme;
            Program.ThemeChanged += OnThemeChanged;

            if (ThanhVien.ChucVu != ChucVu.PhoNhom && ThanhVien.ChucVu != ChucVu.TruongNhom && ThanhVien.MaQuyenHan != NguoiDungModel.QuyenHan_Admin)
                ReadOnly = true;

            CacChucNang = new CacChucNangLuuTru(this, danhSachTapTin, danhSachThuMuc, pThongTin, hopThongBao, () => RefreshAll(null, null), async () => await danhSachThuMuc.GetFolders(CauLacBo, hopThongBao, ctxThuMuc, poisonToolTip1));
            RefreshAll(null, null);
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private async void RefreshAll(object sender, System.EventArgs e)
        {
            await danhSachThuMuc.GetFolders(CauLacBo, hopThongBao, ctxThuMuc, poisonToolTip1);
            if (danhSachThuMuc.SelectedModel == null) return;
            await danhSachTapTin.Browse(danhSachThuMuc.SelectedModel, hopThongBao);
        }

        private async void ctxThuMuc_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (ReadOnly) return;
            if (!(ctxThuMuc.SourceControl is FolderItem)) return;
            FolderItem item = (FolderItem)ctxThuMuc.SourceControl;
            int index = danhSachThuMuc.Items.IndexOf(item);
            if (index == -1) return;

            if (e.ClickedItem == tuỳChỉnhToolStripMenuItem)
                CacChucNang.ChuanBiSuaThuMuc(danhSachThuMuc.Models[index], themSuaThuMuc);
            else if (e.ClickedItem == thêmToolStripMenuItem)
                CacChucNang.ChuanBiThemThuMuc(themSuaThuMuc);
            else if (e.ClickedItem == xoáToolStripMenuItem1)
                await CacChucNang.XoaThuMuc(danhSachThuMuc.Models[index], danhSachThuMuc.ThuMucGoc);
        }

        private async void ctxFile_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == miTapTinMo)
                CacChucNang.MoTapTin(danhSachTapTin.SelectedModels);
            else if (e.ClickedItem == miTapTinTaiVe)
                await CacChucNang.TaiVe(danhSachTapTin.SelectedModels, saveFileDialog1);
            else if (!ReadOnly && e.ClickedItem == miTapTinDiChuyen)
                CheDoChonThuMuc = CheDoChonThuMuc.MoveTo;
            else if (!ReadOnly && e.ClickedItem == miTapTinSaoChep)
                CheDoChonThuMuc = CheDoChonThuMuc.CopyTo;
            else if (!ReadOnly && e.ClickedItem == miTapTinXoa)
                await CacChucNang.XoaTapTin(danhSachTapTin.SelectedModels);
            else if (!ReadOnly && e.ClickedItem == miTapTinDoiTen)
                CacChucNang.ChuanBiDoiTenTapTin(danhSachTapTin.SelectedModels);
            else if (e.ClickedItem == miTapTinThongTin)
                CacChucNang.GetFileInfo();
            else if (e.ClickedItem == miTapTinBoCucLuoi)
            {
                miTapTinBoCucBang.Checked = false;
                miTapTinBoCucLuoi.Checked = true;
                danhSachTapTin.View = View.LargeIcon;
            }
            else if (e.ClickedItem == miTapTinBoCucBang)
            {
                miTapTinBoCucBang.Checked = true;
                miTapTinBoCucLuoi.Checked = false;
                danhSachTapTin.View = View.Details;
            }
            else if (e.ClickedItem == miSapXepTen) danhSachTapTin.Sort(DanhSachTapTin.ColumnTen);
            else if (e.ClickedItem == miSapXepKieuTapTin) danhSachTapTin.Sort(DanhSachTapTin.ColumnKieuTapTin);
            else if (e.ClickedItem == miSapXepThoiGianSuaDoi) danhSachTapTin.Sort(DanhSachTapTin.ColumnThoiGianSuaDoi);
            else if (e.ClickedItem == miSapXepThoiGianTao) danhSachTapTin.Sort(DanhSachTapTin.ColumnThoiGianTao);
            else if (e.ClickedItem == miSapXepDungLuong) danhSachTapTin.Sort(DanhSachTapTin.ColumnDungLuong);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    CheDoChonThuMuc = CheDoChonThuMuc.Open;
                    return true;
                case Keys.Delete:
                    if (ReadOnly) return false;
                    if (danhSachTapTin.SelectedItems.Count != 0)
                    {
                        Task _ = CacChucNang.XoaTapTin(danhSachTapTin.SelectedModels);
                    }
                    return true;
                case Keys.Control | Keys.Shift | Keys.N:
                    if (ReadOnly) return false;
                    CacChucNang.ChuanBiThemThuMuc(themSuaThuMuc);
                    return true;
                case Keys.Control | Keys.C:
                    if (ReadOnly) return false;
                    if (danhSachTapTin.SelectedItems.Count != 0)
                        CheDoChonThuMuc = CheDoChonThuMuc.CopyTo;
                    return true;
                case Keys.Control | Keys.X:
                    if (ReadOnly) return false;
                    if (danhSachTapTin.SelectedItems.Count != 0)
                        CheDoChonThuMuc = CheDoChonThuMuc.MoveTo;
                    return true;
                case Keys.F5:
                    RefreshAll(null, null);
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public async void OnClick(object sender, System.EventArgs e)
        {
            if (!ReadOnly && sender == bTapTinDiChuyen) CheDoChonThuMuc = CheDoChonThuMuc.MoveTo;
            else if (!ReadOnly && sender == bTapTinSaoChep) CheDoChonThuMuc = CheDoChonThuMuc.CopyTo;
            else if (!ReadOnly && sender == bTapTinXoa) await CacChucNang.XoaTapTin(danhSachTapTin.SelectedModels);
            else if (sender == bTapTinTaiVe) await CacChucNang.TaiVe(danhSachTapTin.SelectedModels, saveFileDialog1);
            else if (sender == bTapTinThongTin) CacChucNang.ToggleFileInfo();
            else if (!ReadOnly && sender == bThuMucThem) CacChucNang.ChuanBiThemThuMuc(themSuaThuMuc);
            else if (!ReadOnly && sender == bThuMucChinh) CacChucNang.ChuanBiSuaThuMuc(danhSachThuMuc.SelectedModel, themSuaThuMuc);
            else if (!ReadOnly && sender == bThuMucXoa) await CacChucNang.XoaThuMuc(danhSachThuMuc.SelectedModel, danhSachThuMuc.ThuMucGoc);
        }

        private async void danhSachTapTin1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (ReadOnly)
            {
                e.CancelEdit = true;
                return;
            }
            await CacChucNang.RenameFile(e);
        }

        private void danhSachTapTin1_SelectedModelsChanged(object sender, System.EventArgs e)
        {
            if (!pThongTin.Visible) return;
            pThongTin.Model = danhSachTapTin.SelectedModels.Count != 0
                ? danhSachTapTin.SelectedModels[0]
                : null;
        }

        private async void danhSachThuMuc1_ItemClick(object sender, ThuMucEventArgs e)
        {
            if (CheDoChonThuMuc == CheDoChonThuMuc.CopyTo)
            {
                CheDoChonThuMuc = CheDoChonThuMuc.Open;
                await CacChucNang.SaoChepTapTin(e.Model);
                return;
            }
            else if (CheDoChonThuMuc == CheDoChonThuMuc.MoveTo)
            {
                CheDoChonThuMuc = CheDoChonThuMuc.Open;
                await CacChucNang.DiChuyenTapTin(e.Model);
                return;
            }
            await danhSachTapTin.Browse(e.Model, hopThongBao);
        }

        private async void themSuaThuMuc1_Ok(object sender, System.EventArgs e)
        {
            if (ReadOnly) return;
            if (themSuaThuMuc.Them)
                await CacChucNang.ThemThuMuc(themSuaThuMuc.Model, CauLacBo, pHanhDongThuMuc);
            else await CacChucNang.SuaThuMuc(themSuaThuMuc.Model, CauLacBo, pHanhDongThuMuc);
        }

        private async void danhSachTapTin1_DragDrop(object sender, DragEventArgs e)
        {
            if (ReadOnly) return;
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
            {
                await new TaiLen(filePaths, danhSachThuMuc.SelectedModel).OnPost(async (sender2, count) =>
                {
                    await danhSachThuMuc.GetFolders(CauLacBo, hopThongBao, ctxThuMuc, poisonToolTip1);
                    await danhSachTapTin.Browse(danhSachThuMuc.SelectedModel, hopThongBao);
                }).Execute(CancellationToken.None);
            }
            catch (MyFault exc)
            {
                hopThongBao.Alert(exc.Message);
            }
        }

        private void danhSachTapTin_ItemActivate(object sender, System.EventArgs e)
        {
            CacChucNang.MoTapTin(danhSachTapTin.SelectedModels);
        }
    }
}
