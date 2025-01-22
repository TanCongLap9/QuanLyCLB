using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.DuongLinkCauLacBo
{
    public class SuaDuongLinkCLB : AsyncCommand
    {
        private readonly Dictionary<string, object> Dict;


        public SuaDuongLinkCLB(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.DuongLinkCauLacBo_Sua, Dict,
                CommandType.StoredProcedure);
        }
    }
}
