using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.Lich
{
    public class XoaLich : AsyncCommand
    {
        private readonly LichModel Lich;
        private readonly Dictionary<string, object> Dict;

        public XoaLich(LichModel loaiLich)
        {
            Lich = loaiLich;
        }

        public XoaLich(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.Lich_Xoa, Dict ?? new Dictionary<string, object>
                {
                    ["MaLich"] = Lich.MaLich
                },
                CommandType.StoredProcedure);
        }
    }
}
