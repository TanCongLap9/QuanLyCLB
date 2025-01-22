using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.BaiViet
{
    public class DanhSachBaiViet : AsyncIterCommand<BaiVietModel>
    {
        private readonly CauLacBoModel CauLacBo;
        private readonly Dictionary<string, object> Dict;

        public DanhSachBaiViet(CauLacBoModel cauLacBo)
        {
            CauLacBo = cauLacBo;
        }

        public DanhSachBaiViet(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<IEnumerable<BaiVietModel>> Execute(CancellationToken tok)
        {
            List<BaiVietModel> cacBaiViet = new List<BaiVietModel>();
            await SqlUtils.QueryReaderNew(
                SqlUtils.BaiViet_DanhSach, Dict ?? new Dictionary<string, object>
                {
                    ["MaCLB"] = CauLacBo.MaCLB
                },
                CommandType.StoredProcedure).ForEach(async reader =>
                {
                    BaiVietModel loaiLich = new BaiVietModel().FromDataReader(reader);
                    cacBaiViet.Add(loaiLich);
                    await InvokeNext(loaiLich);
                });
            return cacBaiViet;
        }
    }
}
