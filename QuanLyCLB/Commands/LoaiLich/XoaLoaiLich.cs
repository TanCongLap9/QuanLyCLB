using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.LoaiLich
{
    public class XoaLoaiLich : AsyncCommand
    {
        private readonly LoaiLichModel LoaiLich;
        private readonly Dictionary<string, object> Dict;

        public XoaLoaiLich(LoaiLichModel loaiLich)
        {
            LoaiLich = loaiLich;
        }

        public XoaLoaiLich(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.LoaiLich_Xoa, Dict ?? new Dictionary<string, object>
                {
                    ["MaLoaiLich"] = LoaiLich.MaLoaiLich
                },
                CommandType.StoredProcedure);
        }
    }
}
