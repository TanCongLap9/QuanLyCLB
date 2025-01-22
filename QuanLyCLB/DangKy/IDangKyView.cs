using QuanLyCLB.Models;
using System;
using System.Windows.Forms;

namespace QuanLyCLB.DangKy
{
    public interface IDangKyView : IWin32Window
    {
        bool TestInput();
        NguoiDungModel Model { get; }
        void OnSignUpSuccess();
        void OnSignUpFailed(Exception exc);
        void SetLoading(bool loading);
    }
}
