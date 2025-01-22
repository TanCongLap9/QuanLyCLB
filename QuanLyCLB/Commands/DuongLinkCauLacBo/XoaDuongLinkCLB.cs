using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.DuongLinkCauLacBo
{
    public class XoaDuongLinkCLB : AsyncCommand
    {
        private readonly DuongLinkCLBModel DuongLinkCLB;
        private readonly Dictionary<string, object> Dict;

        public XoaDuongLinkCLB(DuongLinkCLBModel duongLinkClb)
        {
            DuongLinkCLB = duongLinkClb;
        }

        public XoaDuongLinkCLB(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.DuongLinkCauLacBo_Xoa, Dict ?? new Dictionary<string, object>
                {
                    ["MaCLB"] = DuongLinkCLB.MaCLB,
                    ["MaLienKet"] = DuongLinkCLB.MaLienKet
                },
                CommandType.StoredProcedure);
        }
    }
}
