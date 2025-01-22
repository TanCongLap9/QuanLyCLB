using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.DuongLinkCauLacBo
{
    public class ThemDuongLinkCLB : AsyncCommand
    {
        private readonly DuongLinkCLBModel DuongLinkCLB;
        private readonly Dictionary<string, object> Dict;

        public ThemDuongLinkCLB(DuongLinkCLBModel duongLinkClb)
        {
            DuongLinkCLB = duongLinkClb;
        }

        public ThemDuongLinkCLB(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.DuongLinkCauLacBo_Them, Dict ?? new Dictionary<string, object>
                {
                    ["MaCLB"] = DuongLinkCLB.MaCLB,
                    ["NenTang"] = DuongLinkCLB.NenTang,
                    ["DuongLienKet"] = DuongLinkCLB.DuongLienKet
                },
                CommandType.StoredProcedure);
        }
    }
}
