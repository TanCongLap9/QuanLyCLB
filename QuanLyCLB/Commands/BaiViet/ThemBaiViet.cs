using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.BaiViet
{
    public class ThemBaiViet : AsyncCommand
    {
        private readonly BaiVietModel BaiViet;
        private readonly Dictionary<string, object> Dict;

        public ThemBaiViet(BaiVietModel baiViet)
        {
            BaiViet = baiViet;
        }

        public ThemBaiViet(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.BaiViet_Them, Dict ?? new Dictionary<string, object>
                {
                    ["MaBaiViet"] = BaiViet.MaBaiViet,
                    ["MaTacGia"] = BaiViet.MaTacGia,
                    ["MaCLB"] = BaiViet.MaCLB,
                    ["ThoiGianTao"] = BaiViet.ThoiGianTao,
                    ["CacNhan"] = BaiViet.CacNhan,
                    ["TieuDe"] = BaiViet.TieuDe,
                    ["NoiDung"] = BaiViet.NoiDung
                },
                CommandType.StoredProcedure);
        }
    }
}
