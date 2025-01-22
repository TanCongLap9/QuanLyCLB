using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.CauLacBo
{
    public class SuaCauLacBo : AsyncCommand
    {
        private readonly CauLacBoModel CauLacBo;
        private readonly Dictionary<string, object> Dict;

        public SuaCauLacBo(CauLacBoModel cauLacBo)
        {
            CauLacBo = cauLacBo;
        }

        public SuaCauLacBo(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.CauLacBo_Sua, Dict ?? new Dictionary<string, object>
                {
                    ["MaCLB"] = CauLacBo.MaCLB,
                    ["TenCLB"] = CauLacBo.TenCLB,
                    ["MoTa"] = CauLacBo.MoTa,
                    ["AnhDaiDien"] = CauLacBo.AnhDaiDien
                },
                CommandType.StoredProcedure);
        }
    }
}
