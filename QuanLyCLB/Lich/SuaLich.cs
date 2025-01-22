using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using QuanLyCLB.Utils;
using System.Windows.Forms;
using QuanLyCLB.Models;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Properties;
using ReaLTaiizor.Forms;

namespace QuanLyCLB.Lich
{
    public partial class SuaLich : PoisonUserControl
    {
        private List<LoaiLichModel> CacLoaiLich;
        private bool hasChanged, Them, fireInputChanged = true;
        private LichModel model, oldModel;
        public event EventHandler InputChanged;
        public event EventHandler<SuaLichEventArgs> OnFinished;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LichModel Model
        {
            get { return model; }
            private set
            {
                model = value;
                if (value == null) return;
                hasChanged = false;
                fireInputChanged = false;
                if (value.MaLoaiLich == null && CacLoaiLich.Count > 0)
                {
                    value.MaLoaiLich = CacLoaiLich[0].MaLoaiLich;
                    value.TenLoaiLich = CacLoaiLich[0].TenLoaiLich;
                }

                for (int i = 0; i < CacLoaiLich.Count; i++)
                {
                    if (CacLoaiLich[i].MaLoaiLich == value.MaLoaiLich)
                    {
                        cLoaiLich.SelectedIndex = i;
                        break;
                    }
                }
                tChuDe.Text = value.ChuDe;
                cLapLai.SelectedValue = value.LapLai;
                tDiaDiem.Text = value.DiaDiem;
                dNgayBatDau.Value = value.NgayBatDau.Date;
                dNgayKetThuc.Value = value.NgayBatDau.Date;
                lNgayKetThuc.Visible = dNgayKetThuc.Visible = value.LapLai != CheDoLapLai.KhongLap;
                mThoiGianBatDau.Text = value.ThoiGianBatDau.ToString("hhmm");
                mThoiGianKetThuc.Text = value.ThoiGianKetThuc.ToString("hhmm");
                tNoiDung.Text = value.NoiDung;

                fireInputChanged = true;
            }
        }

        public SuaLich()
        {
            InitializeComponent();
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;
            cLapLai.DataSource = new KeyValuePair<CheDoLapLai, string>[]
            {
                new KeyValuePair<CheDoLapLai, string>(CheDoLapLai.KhongLap, "Không lặp"),
                new KeyValuePair<CheDoLapLai, string>(CheDoLapLai.MoiNgay, "Mỗi ngày"),
                new KeyValuePair<CheDoLapLai, string>(CheDoLapLai.Moi2Ngay, "Mỗi 2 ngày"),
                new KeyValuePair<CheDoLapLai, string>(CheDoLapLai.Moi3Ngay, "Mỗi 3 ngày"),
                new KeyValuePair<CheDoLapLai, string>(CheDoLapLai.Moi4Ngay, "Mỗi 4 ngày"),
                new KeyValuePair<CheDoLapLai, string>(CheDoLapLai.Moi5Ngay, "Mỗi 5 ngày"),
                new KeyValuePair<CheDoLapLai, string>(CheDoLapLai.Moi6Ngay, "Mỗi 6 ngày"),
                new KeyValuePair<CheDoLapLai, string>(CheDoLapLai.MoiTuan, "Mỗi tuần"),
                new KeyValuePair<CheDoLapLai, string>(CheDoLapLai.MoiThang, "Mỗi tháng")
            };
        }

        public void SetCacLoaiLich(List<LoaiLichModel> loaiLiches)
        {
            CacLoaiLich = loaiLiches;
            cLoaiLich.DataSource = loaiLiches;
        }

        protected override void OnParentChanged(System.EventArgs e)
        {
            base.OnParentChanged(e);
            if (!(this.ParentForm is PoisonForm)) return;
            PoisonForm form = (PoisonForm)ParentForm;
            if (form != null) form.FormClosing += Form_FormClosing;
            ColorUtils.SetColor(mThoiGianBatDau, form.Theme);
            ColorUtils.SetColor(mThoiGianKetThuc, form.Theme);
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Form form = FindForm();
            if (form != null) form.FormClosing -= Form_FormClosing;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!hasChanged) return;
            PoisonMessageBox.Show(
                this,
                Resources.SuaLich_Dong_LoiDangSua_NoiDung,
                Resources.SuaLich_Dong_LoiDangSua_TieuDe,
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            e.Cancel = true;
        }

        public bool TestNhap()
        {
            if (new TextValidator(lStatus)
                .NotEmpty(tChuDe)
                .NotEmpty(tDiaDiem)
                .NotEmpty(tNoiDung).Invalid) return false;

            if (new TextValidator(lStatus)
                .Matches(mThoiGianBatDau, Resources.SuaLich_ThoiGian_LoiKhongHopLe).Invalid) return false;
            if (new TextValidator(lStatus)
                .Matches(mThoiGianKetThuc, Resources.SuaLich_ThoiGian_LoiKhongHopLe).Invalid) return false;
            if ((CheDoLapLai)cLapLai.SelectedValue != CheDoLapLai.KhongLap && new TextValidator(lStatus)
                .If(dNgayBatDau.Value.Date < dNgayKetThuc.Value.Date, dNgayKetThuc, Resources.SuaLich_Ngay_Hon).Invalid) return false;
            DateTime tuNgay = (DateTime)mThoiGianBatDau.ValidateText();
            DateTime toiNgay = (DateTime)mThoiGianKetThuc.ValidateText();
            if (new TextValidator(lStatus)
                .If(tuNgay < toiNgay, mThoiGianKetThuc, Resources.SuaLich_ThoiGian_Hon).Invalid) return false;
            return true;
        }

        private void Control_Click(object sender, System.EventArgs e)
        {
            lStatus.Hide();
            HanhDongSuaLich hanhDongSuaLich = HanhDongSuaLich.Sua;
            if (sender == bOk)
            {
                if (!TestNhap()) return;
                hanhDongSuaLich = Them ? HanhDongSuaLich.Them : HanhDongSuaLich.Sua;
            }
            else if (sender == bHuy)
                hanhDongSuaLich = HanhDongSuaLich.Huy;
            else if (sender == bXoa)
            {
                if (PoisonMessageBox.Show(this,
                    string.Format(Resources.SuaLich_XacNhanXoa_NoiDung_1, model.ChuDe),
                    Resources.SuaLich_XacNhanXoa_TieuDe,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes) return;
                hanhDongSuaLich = HanhDongSuaLich.Xoa;
            }
            hasChanged = false;
            OnFinished?.Invoke(this, new SuaLichEventArgs(oldModel, Model, hanhDongSuaLich, hasChanged, bThongBao.Checked));
            this.Hide();
        }

        public void Show(LichModel lichModel, bool them)
        {
            lStatus.Hide();
            Them = them;
            bXoa.Visible = !them;
            oldModel = lichModel;
            Model = lichModel.Clone();
            Show();
        }

        private void Input_ValueChanged(object sender, System.EventArgs e)
        {
            if (!fireInputChanged) return;
            if (sender == cLoaiLich)
            {
                LoaiLichModel loaiLichModel = (LoaiLichModel)cLoaiLich.SelectedValue;
                Model.MaLoaiLich = loaiLichModel.MaLoaiLich;
                Model.TenLoaiLich = loaiLichModel.TenLoaiLich;
                Model.MaMau = loaiLichModel.MaMau;
            }
            else if (sender == tChuDe)
                Model.ChuDe = tChuDe.Text;
            else if (sender == cLapLai)
            {
                Model.LapLai = (CheDoLapLai)cLapLai.SelectedValue;
                lNgayKetThuc.Visible = dNgayKetThuc.Visible = Model.LapLai != CheDoLapLai.KhongLap;
            }
            else if (sender == tDiaDiem)
                Model.DiaDiem = tDiaDiem.Text;
            else if (sender == dNgayBatDau)
                Model.NgayBatDau = dNgayBatDau.Value.Date;
            else if (sender == dNgayKetThuc)
                Model.NgayKetThuc = dNgayKetThuc.Value.Date;
            else if (sender == tNoiDung)
                Model.NoiDung = tNoiDung.Text;
            else if (sender == mThoiGianBatDau)
            {
                object obj = mThoiGianBatDau.ValidateText();
                if (obj != null) Model.ThoiGianBatDau = ((DateTime)obj).TimeOfDay;
            }
            else if (sender == mThoiGianKetThuc)
            {
                object obj = mThoiGianKetThuc.ValidateText();
                if (obj != null) Model.ThoiGianKetThuc = ((DateTime)obj).TimeOfDay;
            }
            InputChanged?.Invoke(sender, e);
            hasChanged = true;
        }
    }
}
