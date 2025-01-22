using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.CauLacBo
{
    public class ThemCauLacBo : AsyncCommand
    {
        private readonly CauLacBoModel CauLacBo;
        private readonly Dictionary<string, object> Dict;

        public ThemCauLacBo(CauLacBoModel cauLacBo)
        {
            CauLacBo = cauLacBo;
        }

        public ThemCauLacBo(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.CauLacBo_Them, Dict ?? new Dictionary<string, object>
                {
                    ["MaCLB"] = CauLacBo.MaCLB,
                    ["TenCLB"] = (object)CauLacBo.TenCLB ?? DBNull.Value,
                    ["MoTa"] = (object)CauLacBo.MoTa ?? DBNull.Value,
                    ["AnhDaiDien"] = (object)CauLacBo.AnhDaiDien ?? DBNull.Value
                },
                CommandType.StoredProcedure);
        }
    }
}
