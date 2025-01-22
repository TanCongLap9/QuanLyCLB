using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.ThanhVien
{
    public class SuaThanhVien : AsyncCommand
    {
        private readonly Dictionary<string, object> Dict;

        public SuaThanhVien(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.ThanhVien_Sua, Dict,
                CommandType.StoredProcedure);
        }
    }
}
