using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.BaiViet
{
    public class ThongTinBaiViet : AsyncCommand<BaiVietModel>
    {
        private readonly string MaBaiViet;
        private readonly Dictionary<string, object> Dict;

        public ThongTinBaiViet(string maBaiViet)
        {
            MaBaiViet = maBaiViet;
        }

        public ThongTinBaiViet(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<BaiVietModel> Execute(CancellationToken tok)
        {
            BaiVietModel model = null;
            await SqlUtils.QueryReaderNew(
                SqlUtils.BaiViet_ThongTin,
                Dict ?? new Dictionary<string, object>
                {
                    ["MaBaiViet"] = MaBaiViet
                }, CommandType.StoredProcedure).Then(reader =>
                {
                    reader.Read();
                    model = new BaiVietModel().FromDataReader(reader);
                });
            return model;
        }
    }
}
