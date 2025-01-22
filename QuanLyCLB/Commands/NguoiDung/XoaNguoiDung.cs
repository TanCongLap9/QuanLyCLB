using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.NguoiDung
{
    public class XoaNguoiDung : AsyncCommand
    {
        private readonly NguoiDungModel NguoiDung;
        private readonly Dictionary<string, object> Dict;

        public XoaNguoiDung(NguoiDungModel nguoiDung)
        {
            NguoiDung = nguoiDung;
        }

        public XoaNguoiDung(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.NguoiDung_Xoa, Dict ?? new Dictionary<string, object>
                {
                    ["MaNguoiDung"] = NguoiDung.MaNguoiDung
                },
                CommandType.StoredProcedure);
        }
    }
}
