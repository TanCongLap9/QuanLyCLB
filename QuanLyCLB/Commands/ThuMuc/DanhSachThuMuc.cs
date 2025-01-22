using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.ThuMuc
{
    public class DanhSachThuMuc : AsyncIterCommand<ThuMucModel>
    {
        private readonly CauLacBoModel CauLacBo;
        private readonly Dictionary<string, object> Dict;

        public DanhSachThuMuc(CauLacBoModel cauLacBo)
        {
            CauLacBo = cauLacBo;
        }

        public DanhSachThuMuc(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<IEnumerable<ThuMucModel>> Execute(CancellationToken tok)
        {
            List<ThuMucModel> cacThuMuc = new List<ThuMucModel>();
            await SqlUtils.QueryReaderNew(
                SqlUtils.ThuMuc_DanhSach, Dict ?? new Dictionary<string, object>
                {
                    ["MaCLB"] = CauLacBo.MaCLB
                }, CommandType.StoredProcedure, cancellationToken: tok).ForEach(async reader =>
                {
                    ThuMucModel thuMuc = new ThuMucModel().FromDataReader(reader);
                    cacThuMuc.Add(thuMuc);
                    await InvokeNext(thuMuc);
                });
            return cacThuMuc;
        }
    }
}
