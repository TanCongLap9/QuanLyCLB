using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.BaiViet
{
    public class SuaBaiViet : AsyncCommand
    {
        private readonly Dictionary<string, object> Dict;

        public SuaBaiViet(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.BaiViet_Sua, Dict,
                CommandType.StoredProcedure);
        }
    }
}
