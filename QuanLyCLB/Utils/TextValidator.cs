using QuanLyCLB.Properties;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.Utils
{
    public class TextValidator
    {
        public bool Result { get; private set; } = true;
        public bool Invalid { get { return !Result; } }
        private readonly Control Status;
        private readonly TabControl TabControl;

        public TextValidator(Control status)
        {
            Status = status;
        }

        public TextValidator(Control status, TabControl tabControl)
        {
            Status = status;
            TabControl = tabControl;
        }

        private TextValidator Error(PoisonTextBox tb, string error, bool focus = true)
        {
            tb.WithError = true;
            if (focus)
                tb.Select();
            if (Result)
            {
                Status.Text = error;
                Status.Show();
            }
            Result = false;
            return this;
        }

        private TextValidator Error(Control ctl, string error)
        {
            ctl.Focus();
            if (Result)
            {
                Status.Text = error;
                Status.Show();
            }
            Result = false;
            return this;
        }

        public TextValidator NotEmpty(PoisonTextBox tb)
        {
            if (!string.IsNullOrWhiteSpace(tb.Text)) return this;
            return Error(tb, Resources.TextValidator_Trong, false);
        }

        public TextValidator NotEmpty(PoisonComboBox cb)
        {
            if (cb.SelectedIndex != -1) return this;
            return Error(cb, Resources.TextValidator_Trong);
        }

        public TextValidator Matches(Regex re, PoisonTextBox tb, string errorMessage)
        {
            if (re.IsMatch(tb.Text)) return this;
            return Error(tb, errorMessage);
        }

        public TextValidator Matches(MaskedTextBox m, string errorText)
        {
            if (m.ValidateText() != null) return this;
            return Error(m, errorText);
        }


        public TextValidator If(bool cond, Control ctl, string errorMessage)
        {
            if (cond) return this;
            return Error(ctl, errorMessage);
        }

        public TextValidator NgaySinh(PoisonDateTime dt)
        {
            if (dt.Value < DateTime.Today) return this;
            return Error(dt, Resources.TextValidator_NgaySinh_LoiKhongHopLe);
        }
        public TextValidator XacNhanMatKhau(PoisonTextBox password, PoisonTextBox confirmPassword)
        {
            if (password.Text == confirmPassword.Text) return this;
            return Error(confirmPassword, Resources.TextValidator_XacNhanMatKhau_LoiKhongTrungKhop);
        }

        public TextValidator TenDangNhap(PoisonTextBox tb)
        {
            if (tb.Text.Length < 6)
                return Error(tb, Resources.TextValidator_TenDangNhap_LoiDoDaiKhongHopLe);
            else if (!Regex.IsMatch(tb.Text, @"^\w*$", RegexOptions.ECMAScript))
                return Error(tb, Resources.TextValidator_TenDangNhap_LoiKyTuKhongHopLe);
            else if (!Regex.IsMatch(tb.Text, @"^[a-zA-Z]\w*$", RegexOptions.ECMAScript))
                return Error(tb, Resources.TextValidator_TenDangNhap_LoiKyTuDauKhongHopLe);
            return this;
        }

        public TextValidator Email(PoisonTextBox tb)
        {
            if (Regex.IsMatch(tb.Text, @"^[\w\.\-]+@[\w\.\-]+\.[a-z]{2,4}$")) return this;
            return Error(tb, Resources.TextValidator_Email_LoiKhongHopLe);
        }

        public TextValidator Ten(PoisonTextBox tb)
        {
            // Họ, tên: Chỉ chứa 1 từ (trừ tên lót)
            if (!tb.Text.Contains(" ")) return this;
            return Error(tb, Resources.TextValidator_Ten_LoiKhongHopLe);
        }

        public TextValidator Ho(PoisonTextBox tb)
        {
            // Họ, tên: Chỉ chứa 1 từ (trừ tên lót)
            if (!tb.Text.Contains(" ")) return this;
            return Error(tb, Resources.TextValidator_Ho_LoiKhongHopLe);
        }

        public TextValidator SDT(PoisonTextBox tb)
        {
            // Số điện thoại: 9 - 11 chữ số, có đầu số trong khoảng 010 - 019, 030 - 059, 070 - 099
            if (tb.Text.Length >= 9 && tb.Text.Length <= 11 && tb.Text[0] == '0' &&
                new char[] { '1', '3', '4', '5', '7', '8', '9' }.Contains(tb.Text[1]))
                return this;
            return Error(tb, Resources.TextValidator_SDT_LoiKhongHopLe);
        }

        public TextValidator GoToIfInvalid(System.Windows.Forms.TabPage tab)
        {
            if (Invalid) TabControl.SelectTab(tab);
            return this;
        }

        public TextValidator MatKHau(PoisonTextBox tb)
        {
            // Mật khẩu: Dài 10 ký tự trở lên, bao gồm cả chữ cái, chữ số và ký hiệu
            if (tb.Text.Length < 10)
                return Error(tb, Resources.TextValidator_MatKhau_LoiDoDaiKhongHopLe);
            bool hasLetter = tb.Text.Any(char.IsLetter);
            bool hasNumber = tb.Text.Any(char.IsDigit);
            bool hasSymbol = tb.Text.Any(c => !char.IsDigit(c) && !char.IsLetter(c));
            if (!hasLetter || !hasNumber || !hasSymbol)
                return Error(tb, Resources.TextValidator_MatKhau_LoiKyTuKhongHopLe);
            return this;
        }
    }
}
