using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.LoaiLich
{
    public class ThemLoaiLich : AsyncCommand
    {
        private readonly LoaiLichModel LoaiLich;
        private readonly Dictionary<string, object> Dict;

        public ThemLoaiLich(LoaiLichModel loaiLich)
        {
            LoaiLich = loaiLich;
        }

        public ThemLoaiLich(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.LoaiLich_Them, Dict ?? new Dictionary<string, object>
                {
                    ["MaLoaiLich"] = LoaiLich.MaLoaiLich,
                    ["TenLoaiLich"] = LoaiLich.TenLoaiLich,
                    ["MaMau"] = LoaiLich.MaMau
                },
                CommandType.StoredProcedure);
        }
    }
}
