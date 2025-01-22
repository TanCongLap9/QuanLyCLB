using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.ThongBao
{
    public class ThemThongBao : AsyncCommand
    {
        private readonly ThongBaoModel ThongBao;

        public ThemThongBao(ThongBaoModel thongBao)
        {
            ThongBao = thongBao;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.ThongBao_Them,
                new Dictionary<string, object>
                {
                    ["MaThongBao"] = ThongBao.MaThongBao,
                    ["TacGia"] = ThongBao.TacGia,
                    ["ThoiGianTao"] = ThongBao.ThoiGianTao,
                    ["TieuDe"] = ThongBao.TieuDe,
                    ["NoiDung"] = ThongBao.NoiDung,
                    ["MaCLB"] = ThongBao.MaCLB
                },
                CommandType.StoredProcedure);
        }
    }
}
