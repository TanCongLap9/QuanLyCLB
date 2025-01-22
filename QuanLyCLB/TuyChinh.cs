using QuanLyCLB.EventArgs;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCLB
{
    public partial class TuyChinh : PoisonForm
    {
        private bool reloading, cancel, mauChuDeThayDoi, cheDoToiThayDoi, noiTaiVeThayDoi, hoiNoiTaiVeThayDoi, ketNoiThayDoi;
        private SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public TuyChinh()
        {
            InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            poisonStyleManager1.Style = e.Style;
            poisonStyleManager1.Theme = e.Theme;
            ColorUtils.SetColor(this, e.Theme, e.Style);
        }

        private void TuyChinh_Load(object sender, System.EventArgs e)
        {
            poisonStyleManager1.Style = Settings.Default.Style;
            poisonStyleManager1.Theme = Settings.Default.Theme;
            ColorUtils.SetColor(this, poisonStyleManager1.Theme, poisonStyleManager1.Style);
            Program.ThemeChanged += OnThemeChanged;

            cSQLMode.DataSource = new string[] { "SQL Server", "Windows" };
            builder.ConnectionString = Settings.Default.ConnectionString;
            propertyGrid1.SelectedObject = builder;
            cMauChuDe.DataSource = new KeyValuePair<ColorStyle, string>[]
            {
                new KeyValuePair<ColorStyle, string> (ColorStyle.Default, "Mặc định"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Black, "Đen"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Blue, "Xanh dương"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Brown, "Nâu"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Green, "Xanh lá"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Lime, "Vàng chanh"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Magenta, "Hồng sẫm"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Orange, "Cam"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Pink, "Hồng"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Purple, "Tím"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Red, "Đỏ"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Silver, "Bạc"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Teal, "Xanh lam"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.White, "Trắng"),
                new KeyValuePair<ColorStyle, string> (ColorStyle.Yellow, "Vàng")
            };
            
            ReloadCoBan();
            ReloadNangCao();
            ReloadTaiVe();
            ReloadGiaoDien();

            cMauChuDe.SelectionChangeCommitted += OnChanged;
            bToi.CheckedChanged += OnChanged;
            tDownloadsPath.TextChanged += OnChanged;
            bAskDownloadsPath.CheckedChanged += OnChanged;
            propertyGrid1.PropertyValueChanged += propertyGrid1_PropertyValueChanged;
            tSQLPass.KeyDown += OnChanged;
            tSQLUser.KeyDown += OnChanged;
            tSQLAddress.KeyDown += OnChanged;
            cSQLMode.SelectionChangeCommitted += OnChanged;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private void OnChanged(object sender, System.EventArgs e)
        {
            if (reloading) return;
            if (sender == bAskDownloadsPath)
            {
                hoiNoiTaiVeThayDoi = true;
                tDownloadsPath.Enabled = !bAskDownloadsPath.Checked;
            }
            else if (sender == tDownloadsPath)
                noiTaiVeThayDoi = true;
            else if (sender == bToi)
                cheDoToiThayDoi = true;
            else if (sender == cMauChuDe)
                mauChuDeThayDoi = true;
            else if (sender == tSQLPass || sender == tSQLUser || sender == tSQLAddress)
            {
                ketNoiThayDoi = true;
                builder.DataSource = tSQLAddress.Text;
                builder.UserID = tSQLUser.Text;
                builder.Password = tSQLPass.Text;
                ReloadNangCao();
            }
            else if (sender == cSQLMode)
            {
                ketNoiThayDoi = true;
                builder.IntegratedSecurity = cSQLMode.SelectedIndex == 1;
                tSQLUser.Enabled = tSQLPass.Enabled = !builder.IntegratedSecurity;
                ReloadNangCao();
            }
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            ketNoiThayDoi = true;
            ReloadCoBan();
        }

        private void ReloadCoBan()
        {
            reloading = true;
            tSQLAddress.Text = builder.DataSource;
            cSQLMode.SelectedIndex = builder.IntegratedSecurity ? 1 : 0;
            tSQLUser.Enabled = tSQLPass.Enabled = !builder.IntegratedSecurity;
            tSQLUser.Text = builder.UserID;
            tSQLPass.Text = builder.Password;
            reloading = false;
        }

        private void ReloadNangCao()
        {
            reloading = true;
            propertyGrid1.Refresh();
            reloading = false;
        }

        private void ReloadTaiVe()
        {
            reloading = true;
            tDownloadsPath.Text = StringUtils.Expand(Settings.Default.DownloadsPath);
            bAskDownloadsPath.Checked = Settings.Default.AskDownloadsPath;
            tDownloadsPath.Enabled = !bAskDownloadsPath.Checked;
            reloading = false;
        }

        private void ReloadGiaoDien()
        {
            reloading = true;
            cMauChuDe.SelectedValue = Settings.Default.Style;
            bToi.Checked = Settings.Default.Theme == ThemeStyle.Dark;
            reloading = false;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            if (sender == bOk)
            {
                Save();
                Close();
            }
            else if (sender == bApply)
                Save();
            else if (sender == bCancel)
            {
                cancel = true;
                Close();
            }
        }

        private void tDownloadsPath_ButtonClick(object sender, System.EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;
            tDownloadsPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Save()
        {
            bool alertRestart = false;
            if (mauChuDeThayDoi)
            {
                alertRestart = true;
                Settings.Default.Style = (ColorStyle)cMauChuDe.SelectedValue;
            }
            if (cheDoToiThayDoi)
            {
                alertRestart = true;
                Settings.Default.Theme = bToi.Checked ? ThemeStyle.Dark : ThemeStyle.Default;
            }
            if (Settings.Default.ConnectionString != builder.ToString())
            {
                Settings.Default.ConnectionString = builder.ToString();
            }
            if (noiTaiVeThayDoi)
                Settings.Default.DownloadsPath = tDownloadsPath.Text;
            if (hoiNoiTaiVeThayDoi)
                Settings.Default.AskDownloadsPath = bAskDownloadsPath.Checked;
            Settings.Default.Save();
            cheDoToiThayDoi = hoiNoiTaiVeThayDoi = mauChuDeThayDoi = noiTaiVeThayDoi = ketNoiThayDoi = false;
            if (alertRestart) /*PoisonMessageBox.Show(this,
                "Một số tuỳ chỉnh chỉ thay đổi khi bạn khởi động lại phần mềm này.",
                "Tuỳ chỉnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
                Program.InvokeThemeChanged();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancel || !cheDoToiThayDoi && !hoiNoiTaiVeThayDoi && !mauChuDeThayDoi && !noiTaiVeThayDoi && !ketNoiThayDoi)
                return;

            if (PoisonMessageBox.Show(this,
                "Bạn có muốn huỷ bỏ tất cả các thay đổi tuỳ chỉnh không?",
                "Tuỳ chỉnh chưa được lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Save();
            else e.Cancel = true;
        }
    }
}
