using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.ThongBao
{
    public class ThongTinThongBao : AsyncCommand<ThongBaoModel>
    {
        private readonly string MaThongBao;

        public ThongTinThongBao(string maThongBao)
        {
            MaThongBao = maThongBao;
        }

        /// <exception cref="Exception" />
        public override async Task<ThongBaoModel> Execute(CancellationToken tok)
        {
            ThongBaoModel model = null;
            await SqlUtils.QueryReaderNew(
                SqlUtils.ThongBao_ThongTin,
                new Dictionary<string, object>
                {
                    ["MaThongBao"] = MaThongBao
                },
                CommandType.StoredProcedure).Then(async reader =>
                {
                    if (await reader.ReadAsync())
                        model = new ThongBaoModel().FromDataReader(reader);
                });
            return model;
        }
    }
}
