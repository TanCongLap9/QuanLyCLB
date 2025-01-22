using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.Lich
{
    public class ThemLich : AsyncCommand
    {
        private readonly LichModel Lich;
        private readonly Dictionary<string, object> Dict;

        public ThemLich(LichModel loaiLich)
        {
            Lich = loaiLich;
        }

        public ThemLich(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.Lich_Them, Dict ?? new Dictionary<string, object>
                {
                    ["MaLich"] = Lich.MaLich,
                    ["MaLoaiLich"] = Lich.MaLoaiLich,
                    ["ChuDe"] = Lich.ChuDe,
                    ["DiaDiem"] = Lich.DiaDiem,
                    ["LapLai"] = Lich.LapLai,
                    ["NgayBatDau"] = Lich.NgayBatDau,
                    ["NgayKetThuc"] = Lich.NgayKetThuc,
                    ["ThoiGianBatDau"] = Lich.ThoiGianBatDau,
                    ["ThoiGianKetThuc"] = Lich.ThoiGianKetThuc,
                    ["NoiDung"] = Lich.NoiDung,
                    ["MaCLB"] = Lich.MaCLB
                },
                CommandType.StoredProcedure);
        }
    }
}
