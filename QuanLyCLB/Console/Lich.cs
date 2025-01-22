using QuanLyCLB.Commands.Lich;
using QuanLyCLB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Console
{
    public class Lich
    {
        private readonly BangDieuKhien bdk;

        public Lich(BangDieuKhien bangDieuKhien)
        {
            bdk = bangDieuKhien;
        }

        public async Task DanhSach(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaCLB"] = typeof(string)
                });
            bdk.Output(await new DanhSachLich(dict).Execute(CancellationToken.None));
        }

        public async Task Xoa(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaLich"] = typeof(string)
                });
            await new XoaLich(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }

        public async Task Them(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaLich"] = typeof(string),
                    ["MaLoaiLich"] = typeof(string),
                    ["ChuDe"] = typeof(string),
                    ["DiaDiem"] = typeof(string),
                    ["LapLai"] = typeof(CheDoLapLai),
                    ["NgayBatDau"] = typeof(DateTime),
                    ["NgayKetThuc"] = typeof(DateTime),
                    ["ThoiGianBatDau"] = typeof(DateTime),
                    ["ThoiGianKetThuc"] = typeof(DateTime),
                    ["NoiDung"] = typeof(string)
                });
            await new ThemLich(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }

        public async Task Sua(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaLich"] = typeof(string),
                    ["MaLoaiLich"] = typeof(string),
                    ["ChuDe"] = typeof(string),
                    ["DiaDiem"] = typeof(string),
                    ["LapLai"] = typeof(CheDoLapLai),
                    ["NgayBatDau"] = typeof(DateTime),
                    ["NgayKetThuc"] = typeof(DateTime),
                    ["ThoiGianBatDau"] = typeof(DateTime),
                    ["ThoiGianKetThuc"] = typeof(DateTime),
                    ["NoiDung"] = typeof(string)
                }, false);
            await new SuaLich(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }
    }
}
