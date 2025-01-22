using QuanLyCLB.Commands.CauLacBo;
using QuanLyCLB.Commands.ThanhVien;
using QuanLyCLB.Commands.ThongBao;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyCLB.ThongBao
{
    public partial class GuiThongBao : PoisonUserControl
    {
        private readonly PoisonStyleManager PoisonStyleManager;

        public GuiThongBao()
        {
            InitializeComponent();
        }

        public GuiThongBao(PoisonStyleManager poisonStyleManager)
        {
            InitializeComponent();
            PoisonStyleManager = poisonStyleManager;
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;
            PoisonStyleManager.Update();
            Program.ThemeChanged += OnThemeChanged;
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private bool TestNotEmpty()
        {
            lStatus.Hide();
            if (new TextValidator(lStatus).NotEmpty(tTieuDe).NotEmpty(tNoiDung).NotEmpty(cCauLacBo).Invalid)
                return false;
            return true;
        }

        private async void Button_Click(object sender, System.EventArgs e)
        {
            if (sender == poisonButton1)
            {
                if (!TestNotEmpty()) return;

                ThongBaoModel model = new ThongBaoModel
                {
                    MaThongBao = IDGenerator.Generate(IDGenerator.IDType.ThongBao),
                    MaCLB = (string)cCauLacBo.SelectedValue,
                    NoiDung = tNoiDung.Text,
                    TacGia = GiaoDienChinh.GiaoDienChinh.NguoiDung.MaNguoiDung,
                    ThoiGianTao = DateTime.Now,
                    TieuDe = tTieuDe.Text.Trim()
                };

                try
                {
                    poisonProgressSpinner1.Spinning = true;
                    poisonProgressSpinner1.Show();
                    poisonButton1.Enabled = false;
                    await new ThemThongBao(model).Execute(CancellationToken.None);
                    poisonProgressSpinner1.Spinning = false;
                    poisonProgressSpinner1.Hide();
                    PoisonMessageBox.Show(
                        this,
                        string.Format(Resources.GuiThongBao_HoanThanh_NoiDung_1, ((CauLacBoModel)cCauLacBo.SelectedItem).TenCLB),
                        Resources.GuiThongBao_HoanThanh_TieuDe,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    PoisonMessageBox.Show(
                        this,
                        string.Format(Resources.GuiThongBao_Loi_NoiDung_1, exc.Message),
                        Resources.GuiThongBao_Loi_TieuDe,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Dispose();
                }
                finally
                {
                    poisonProgressSpinner1.Spinning = false;
                    poisonProgressSpinner1.Hide();
                    poisonButton1.Enabled = true;
                }
            }
            else if (sender == bExit)
                Dispose();
        }

        private async void cCauLacBo_DropDown(object sender, System.EventArgs e)
        {
            if (cCauLacBo.Items.Count != 0) return;
            try
            {
                List<CauLacBoModel> cacCauLacBo = new List<CauLacBoModel>();
                await new DanhSachCauLacBo(GiaoDienChinh.GiaoDienChinh.NguoiDung)
                    .OnNext(async cauLacBo =>
                    {
                        ThanhVienModel thanhVien = await new ThongTinThanhVien(cauLacBo, GiaoDienChinh.GiaoDienChinh.NguoiDung)
                            .Execute(CancellationToken.None);
                        if (thanhVien.ChucVu == ChucVu.PhoNhom || thanhVien.ChucVu == ChucVu.TruongNhom || GiaoDienChinh.GiaoDienChinh.NguoiDung.MaQuyenHan == NguoiDungModel.QuyenHan_Admin)
                            cacCauLacBo.Add(cauLacBo);
                    })
                    .Execute(CancellationToken.None);
                cCauLacBo.DataSource = cacCauLacBo;
            }
            catch
            {

            }
        }
    }
}
