using QuanLyCLB.Commands;
using QuanLyCLB.Commands.NguoiDung;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using System;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.DangKy
{
    public class DangKyPresenter
    {
        private readonly IDangKyView View;

        public DangKyPresenter(IDangKyView view)
        {
            View = view;
        }

        public async Task DangKy()
        {
            if (!View.TestInput()) return;
            View.SetLoading(true);
            NguoiDungModel nguoiDungModel = View.Model;
            try
            {
                await new ThemNguoiDung(nguoiDungModel).Execute(CancellationToken.None);
                View.OnSignUpSuccess();
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2627)
                    View.OnSignUpFailed(new MyFault(
                        DangKyRes.DangKy_LoiTrungKhop_TieuDe,
                        string.Format(DangKyRes.DangKy_LoiTrungKhop_NoiDung_1, nguoiDungModel.TenDangNhap)));
                else View.OnSignUpFailed(exc);
            }
            catch (Exception exc)
            {
                View.OnSignUpFailed(exc);
            }
            View.SetLoading(false);
        }
    }
}
