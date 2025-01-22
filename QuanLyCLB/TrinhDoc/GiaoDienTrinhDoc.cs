using ReaLTaiizor.Forms;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using System.Threading;
using QuanLyCLB.Models;
using QuanLyCLB.Commands.LuuTru;
using QuanLyCLB.Commands;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Enum.Poison;
using QuanLyCLB.EventArgs;

namespace QuanLyCLB.TrinhDoc
{
    public partial class GiaoDienTrinhDoc : PoisonForm
    {
        public GiaoDienTrinhDoc()
        {
            InitializeComponent();
        }

        public GiaoDienTrinhDoc(TapTinModel model)
        {
            InitializeComponent();
            Model = model;
        }

        public TapTinModel Model { get; }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            poisonStyleManager1.Theme = e.Theme;
            poisonStyleManager1.Style = e.Style;
            ColorUtils.SetColor(this, e.Theme, e.Style);
        }

        protected override async void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            GiaoDienChinh.GiaoDienChinh.CacFormDangMo.Add(this);
            ColorUtils.SetColor(this, poisonStyleManager1.Theme, poisonStyleManager1.Style);
            pLoading.BringToFront();
            poisonProgressSpinner1.Spinning = true;
            pLoading.Show();
            pActions.Enabled = false;
            Program.ThemeChanged += OnThemeChanged;

            saveFileDialog1.FileName = Model.TenTapTin;
            lTitle.Text = Model.TenTapTin;
            thongTinFile.Model = Model;
            Text += " - " + Model.TenTapTin;

            try
            {
                if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.HinhAnh.Contains(Path.GetExtension(Model.TenTapTin.ToLower())))
                    await OpenAs(new TrinhDocHinhAnh(poisonStyleManager1, thongTinFile, Model));
                else if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.TruyenThong.Contains(Path.GetExtension(Model.TenTapTin.ToLower())))
                    await OpenAs(new TrinhDocVideo(poisonStyleManager1, thongTinFile, Model));
                else if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.VanBan.Contains(Path.GetExtension(Model.TenTapTin.ToLower())))
                    await OpenAs(new TrinhDocVanBan(poisonStyleManager1, thongTinFile, Model));
                else if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.TrinhDuyet.Contains(Path.GetExtension(Model.TenTapTin.ToLower())))
                    await OpenAs(new TrinhDuyet(poisonStyleManager1, thongTinFile, Model));
                else
                {
                    ChonTrinhDoc choosePreview = new ChonTrinhDoc();
                    if (choosePreview.ShowDialog() != DialogResult.OK)
                    {
                        Close();
                        return;
                    }

                    switch (choosePreview.LoaiTrinhDoc)
                    {
                        case LoaiTrinhDoc.HinhAnh:
                            await OpenAs(new TrinhDocHinhAnh(poisonStyleManager1, thongTinFile, Model));
                            break;
                        case LoaiTrinhDoc.Video:
                            await OpenAs(new TrinhDocVideo(poisonStyleManager1, thongTinFile, Model));
                            break;
                        case LoaiTrinhDoc.VanBan:
                            await OpenAs(new TrinhDocVanBan(poisonStyleManager1, thongTinFile, Model));
                            break;
                        case LoaiTrinhDoc.TrinhDuyet:
                            await OpenAs(new TrinhDuyet(poisonStyleManager1, thongTinFile, Model));
                            break;
                        default:
                            Close();
                            return;
                    }
                }
                pActions.Enabled = true;
            }
            catch (FileNotFoundException)
            {
                PoisonMessageBox.Show(this, LuuTruRes.TrinhDoc_Loi_KhongTonTai_NoiDung, LuuTruRes.TrinhDoc_Loi_KhongTonTai_TieuDe, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            catch (Exception exc)
            {
                PoisonMessageBox.Show(this, string.Format(LuuTruRes.TrinhDoc_Loi_NoiDung_1, exc.Message), LuuTruRes.TrinhDoc_Loi_TieuDe, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            finally
            {
                if (!IsDisposed)
                {
                    poisonProgressSpinner1.Spinning = false;
                    pLoading.Hide();
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            GiaoDienChinh.GiaoDienChinh.CacFormDangMo.Remove(this);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private async void Button_OnClick(object sender, System.EventArgs e)
        {
            if (sender == bTaiVe)
                try
                {
                    await new TaiVe(Model, saveFileDialog1)
                        .Execute(CancellationToken.None);
                }
                catch (OperationCanceledException) { }
                catch (MyFault exc)
                {
                    PoisonMessageBox.Show(this, exc.Message,
                        LuuTruRes.GiaoDienTrinhDoc_TaiVe_Loi_TieuDe,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else if (sender == bThongTin)
                thongTinFile.Visible = !thongTinFile.Visible;
        }

        private async Task OpenAs(TrinhDoc trinhDoc)
        {
            thongTinFile.Add("Phần mềm trình đọc", trinhDoc.ApplicationName);
            trinhDoc.Dock = DockStyle.Fill;
            this.Controls.Add(trinhDoc);
            await trinhDoc.Init();
            poisonStyleManager1.Update();
            if (!trinhDoc.IsDisposed) trinhDoc.BringToFront();
        }
    }
}
