using QuanLyCLB.Commands.CauLacBo;
using QuanLyCLB.Commands.NguoiDung;
using QuanLyCLB.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Console
{
    public class NguoiDung
    {
        private readonly BangDieuKhien bdk;

        public NguoiDung(BangDieuKhien bangDieuKhien)
        {
            bdk = bangDieuKhien;
        }

        public async Task Xoa(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaCLB"] = typeof(string)
                });
            await new XoaNguoiDung(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }
        
        public async Task Them(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaNguoiDung"] = typeof(string),
                    ["Ho"] = typeof(string),
                    ["Lot"] = typeof(string),
                    ["Ten"] = typeof(string),
                    ["SDT"] = typeof(string),
                    ["GioiTinh"] = typeof(bool),
                    ["NgaySinh"] = typeof(DateTime),
                    ["Email"] = typeof(string),
                    ["MSSV"] = typeof(string),
                    ["TenDangNhap"] = typeof(string),
                    ["MatKhau"] = typeof(string),
                    ["MaBaoMat"] = typeof(string)
                });
            await new ThemNguoiDung(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }
        
        public async Task Sua(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaNguoiDung"] = typeof(string),
                    ["Ho"] = typeof(string),
                    ["Lot"] = typeof(string),
                    ["Ten"] = typeof(string),
                    ["SDT"] = typeof(string),
                    ["GioiTinh"] = typeof(bool),
                    ["NgaySinh"] = typeof(DateTime),
                    ["Email"] = typeof(string),
                    ["MSSV"] = typeof(string),
                    ["TenDangNhap"] = typeof(string),
                    ["MatKhau"] = typeof(string),
                    ["Duyet"] = typeof(CheDoDuyet),
                    ["MaBaoMat"] = typeof(string)
                }, false);
            await new SuaNguoiDung(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }
        
        public async Task TimKiem(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaNguoiDung"] = typeof(string),
                    ["Ho"] = typeof(string),
                    ["Lot"] = typeof(string),
                    ["Ten"] = typeof(string),
                    ["SDT"] = typeof(string),
                    ["GioiTinh"] = typeof(bool),
                    ["NgaySinh"] = typeof(DateTime),
                    ["Email"] = typeof(string),
                    ["MSSV"] = typeof(string),
                    ["TenDangNhap"] = typeof(string),
                    ["Duyet"] = typeof(CheDoDuyet)
                }, false);
            bdk.Output(await new TimKiemNguoiDung(dict).Execute(CancellationToken.None));
        }
    }
}
