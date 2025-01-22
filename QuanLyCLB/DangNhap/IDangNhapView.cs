using QuanLyCLB.Models;

namespace QuanLyCLB.DangNhap
{
    public interface IDangNhapView
    {
        void SetLoading(bool loading);
        void GiaoDienChinh(NguoiDungModel nguoiDung);
        DangNhapModel Model { get; }
        bool TestNhap();
        void SetError(string error);
        void TaiKhoanChuaDuyet();
        void TaiKhoanTuChoi();
    }
}
