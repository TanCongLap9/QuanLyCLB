using QuanLyCLB.Commands;
using QuanLyCLB.Commands.LuuTru;
using QuanLyCLB.Commands.ThuMuc;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.TrinhDoc;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.LuuTru
{
    public class CacChucNangLuuTru
    {
        private readonly DanhSachTapTin DanhSachTapTin;
        private readonly DanhSachThuMuc DanhSachThuMuc;
        private readonly Action RefreshAll;
        private readonly Func<Task> GetFolders;
        private readonly AlertBox HopThongBao;
        private readonly IWin32Window Owner;
        private readonly ThongTinFile ThongTinFile;

        public CacChucNangLuuTru(IWin32Window owner, DanhSachTapTin danhSachTapTin, DanhSachThuMuc danhSachThuMuc, ThongTinFile thongTinFile, AlertBox hopThongBao, Action refreshAll, Func<Task> getFolders)
        {
            Owner = owner;
            ThongTinFile = thongTinFile;
            DanhSachTapTin = danhSachTapTin;
            DanhSachThuMuc = danhSachThuMuc;
            HopThongBao = hopThongBao;
            RefreshAll = refreshAll;
            GetFolders = getFolders;
        }

        public async Task RenameFile(LabelEditEventArgs e)
        {
            try
            {
                TapTinModel model = DanhSachTapTin.SelectedModels[0];
                await new DoiTenTapTin(model, e.Label).Execute(CancellationToken.None);
                HopThongBao.Alert(LuuTruRes.TapTin_DoiTen_HoanThanh_2, model.TenTapTin, e.Label);
                model.TenTapTin = e.Label;
            }
            catch (OperationCanceledException)
            {
                e.CancelEdit = true;
            }
            catch (MyFault exc)
            {
                HopThongBao.Alert(exc.Message);
                e.CancelEdit = true;
            }
            catch (Exception exc)
            {
                HopThongBao.Alert(LuuTruRes.TapTin_DoiTen_Loi_1, exc.Message);
                e.CancelEdit = true;
            }
        }

        public void GetFileInfo()
        {
            if (!ThongTinFile.Visible && DanhSachTapTin.SelectedModels.Count != 0)
                ThongTinFile.Model = DanhSachTapTin.SelectedModels[0];
            ThongTinFile.Visible = true;
        }

        public void ToggleFileInfo()
        {
            ThongTinFile.Visible = !ThongTinFile.Visible;
            if (ThongTinFile.Visible && DanhSachTapTin.SelectedModels.Count != 0)
                ThongTinFile.Model = DanhSachTapTin.SelectedModels[0];
        }

        public async Task XoaTapTin(List<TapTinModel> selectedModels)
        {
            try
            {
                int max = selectedModels.Count;
                await new XoaTapTin(selectedModels, Owner)
                    .OnPost((sender, count) =>
                    {
                        HopThongBao.Alert(LuuTruRes.TapTin_Xoa_HoanThanh_2, count, max);
                        RefreshAll();
                    })
                    .Execute(CancellationToken.None);
            }
            catch (OperationCanceledException) { }
            catch (MyFault exc) { HopThongBao.Alert(exc.Message); }
        }

        public async Task DiChuyenTapTin(ThuMucModel thuMuc)
        {
            try
            {
                int max = DanhSachTapTin.SelectedModels.Count;
                await new DiChuyenTapTin(DanhSachTapTin.SelectedModels, thuMuc)
                    .OnPost((sender, count) =>
                    {
                        HopThongBao.Alert(LuuTruRes.TapTin_DiChuyen_HoanThanh_3, count, max, thuMuc.TenThuMuc);
                        RefreshAll();
                    })
                    .Execute(CancellationToken.None);
            }
            catch (OperationCanceledException) { }
            catch (MyFault exc) { HopThongBao.Alert(exc.Message); }
        }

        public async Task SaoChepTapTin(ThuMucModel thuMuc)
        {
            try
            {
                int max = DanhSachTapTin.SelectedModels.Count;
                await new SaoChepTapTin(DanhSachTapTin.SelectedModels, thuMuc)
                    .OnPost((sender, count) =>
                    {
                        HopThongBao.Alert(LuuTruRes.TapTin_SaoChep_HoanThanh_3, count, max, thuMuc.TenThuMuc);
                        RefreshAll();
                    })
                    .Execute(CancellationToken.None);
            }
            catch (OperationCanceledException) { }
            catch (MyFault exc) { HopThongBao.Alert(exc.Message); }
        }

        public void ChuanBiDoiTenTapTin(List<TapTinModel> selectedModels)
        {
            if (selectedModels.Count == 0)
            {
                HopThongBao.Alert(LuuTruRes.TapTin_DoiTen_LoiChon0);
                return;
            }
            else if (selectedModels.Count > 1)
            {
                HopThongBao.Alert(LuuTruRes.TapTin_DoiTen_LoiChonNhieu);
                return;
            }
            ListViewItem fileItem = DanhSachTapTin.SelectedItems[0];
            fileItem.BeginEdit();
        }

        public void MoTapTin(List<TapTinModel> selectedModels)
        {
            if (selectedModels.Count == 0)
            {
                HopThongBao.Alert(LuuTruRes.TapTin_Mo_LoiChon0);
                return;
            }
            else if (selectedModels.Count > 1)
            {
                HopThongBao.Alert(LuuTruRes.TapTin_Mo_LoiChonNhieu_NoiDung);
                return;
            }
            TapTinModel model = selectedModels[0];
            try
            {
                new GiaoDienTrinhDoc(model).Show();
            }
            catch (Exception exc)
            {

            }
        }

        public async Task ThemThuMuc(ThuMucModel model, CauLacBoModel cauLacBo, Control pThemXoaSuaThuMuc)
        {
            try
            {
                pThemXoaSuaThuMuc.Enabled = false;
                await new ThemThuMuc(model, cauLacBo).Execute(CancellationToken.None);
                HopThongBao.Alert(LuuTruRes.ThuMuc_Them_HoanThanh);
                await GetFolders();
            }
            catch (Exception exc) { HopThongBao.Alert(LuuTruRes.ThuMuc_Them_Loi_1, exc.Message); }
            finally { pThemXoaSuaThuMuc.Enabled = true; }
        }

        public async Task XoaThuMuc(ThuMucModel model, ThuMucModel thuMucGoc)
        {
            try
            {
                await new XoaThuMuc(model, thuMucGoc, Owner)
                    .Execute(CancellationToken.None);
                HopThongBao.Alert(LuuTruRes.ThuMuc_Xoa_HoanThanh_1, model.TenThuMuc);
                await GetFolders();
                DanhSachThuMuc.SelectedModel = null;
                DanhSachTapTin.Clear(true);
            }
            catch (OperationCanceledException) { }
            catch (MyFault exc)
            {
                HopThongBao.Alert(exc.Message);
            }
            catch (Exception exc)
            {
                HopThongBao.Alert(LuuTruRes.ThuMuc_Xoa_Loi_1, exc.Message);
            }
        }

        public async Task SuaThuMuc(ThuMucModel model, CauLacBoModel cauLacBo, Control pThemXoaSuaThuMuc)
        {
            try
            {
                pThemXoaSuaThuMuc.Enabled = false;
                await new SuaThuMuc(model, cauLacBo).Execute(CancellationToken.None);
                HopThongBao.Alert(LuuTruRes.ThuMuc_SuaDoi_HoanThanh);
                await GetFolders();
            }
            catch (Exception exc) { HopThongBao.Alert(LuuTruRes.ThuMuc_SuaDoi_Loi_1, exc.Message); }
            finally { pThemXoaSuaThuMuc.Enabled = true; }
        }

        public void ChuanBiThemThuMuc(ThemSuaThuMuc themSuaThuMuc)
        {
            themSuaThuMuc.Model = new ThuMucModel()
            {
                MaThuMuc = IDGenerator.Generate(IDGenerator.IDType.ThuMuc),
                TenThuMuc = LuuTruRes.ThuMuc_Them_ThuMucMoi,
                MaMau = Color.Goldenrod
            };
            themSuaThuMuc.Them = true;
            themSuaThuMuc.Show();
        }

        public void ChuanBiSuaThuMuc(ThuMucModel thuMuc, ThemSuaThuMuc themSuaThuMuc)
        {
            if (thuMuc == null)
            {
                HopThongBao.Alert(LuuTruRes.ThuMuc_SuaDoi_LoiChon0);
                return;
            }
            themSuaThuMuc.Them = false;
            themSuaThuMuc.Model = thuMuc;
            themSuaThuMuc.Show();
        }

        public async Task TaiVe(List<TapTinModel> cacTapTin, SaveFileDialog saveFileDialog)
        {
            try
            {
                await new TaiVe(cacTapTin, saveFileDialog)
                    .Execute(CancellationToken.None);
            }
            catch (OperationCanceledException) { }
            catch (MyFault exc)
            {
                HopThongBao.Alert(exc.Message);
            }
        }
    }
}
