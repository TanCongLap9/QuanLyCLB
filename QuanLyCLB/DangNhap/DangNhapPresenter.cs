using QuanLyCLB.Commands.NguoiDung;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.DangNhap
{
    public class DangNhapPresenter
    {
        private readonly IDangNhapView View;

        public DangNhapPresenter(IDangNhapView view)
        {
            View = view;
        }
        
        public async Task<NguoiDungModel> TestDangNhap()
        {
            NguoiDungModel nguoiDung = await new DangNhapNguoiDung(View.Model.TenDangNhap, View.Model.MatKhau)
                .Execute(CancellationToken.None);
            if (nguoiDung == null)
            {
                View.SetError(Resources.SignInCredentialInvalid);
                return null;
            }
            else if (nguoiDung.Duyet == CheDoDuyet.ChuaDuyet)
            {
                View.TaiKhoanChuaDuyet();
                return null;
            }
            else if (nguoiDung.Duyet == CheDoDuyet.TuChoi)
            {
                View.TaiKhoanTuChoi();
                return null;
            }
            return nguoiDung;
        }

        public async Task DangNhap()
        {
            bool ok = false;
            NguoiDungModel nguoiDung = null;
            if (!View.TestNhap()) return;
            View.SetLoading(true);
            View.SetError(null);
            try
            {
                if ((nguoiDung = await TestDangNhap()) == null) return;
                Settings.Default.TenDangNhap = Settings.Default.NhoTenDangNhap ? View.Model.TenDangNhap : null;
                Settings.Default.Save();
                ok = true;
            }
            catch (Exception exc)
            {
                View.SetError(string.Format(Resources.DangNhap_Loi_1, exc.Message));
            }
            finally
            {
                View.SetLoading(false);
            }
            if (ok)
            {
                View.GiaoDienChinh(nguoiDung);
            }
        }
    }
}
