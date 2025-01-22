using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.DuongLinkCauLacBo
{
    public class DanhSachDuongLinkCLB : AsyncIterCommand<DuongLinkCLBModel>
    {
        private readonly CauLacBoModel CauLacBo;
        private readonly Dictionary<string, object> Dict;

        public DanhSachDuongLinkCLB(CauLacBoModel cauLacBo)
        {
            CauLacBo = cauLacBo;
        }

        public DanhSachDuongLinkCLB(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<IEnumerable<DuongLinkCLBModel>> Execute(CancellationToken tok)
        {
            List<DuongLinkCLBModel> cacDuongLinkClb = new List<DuongLinkCLBModel>();
            await SqlUtils.QueryReaderNew(
                SqlUtils.DuongLinkCauLacBo_DanhSach, Dict ?? new Dictionary<string, object>
                {
                    ["MaCLB"] = CauLacBo.MaCLB
                },
                CommandType.StoredProcedure).ForEach(async reader =>
                {
                    DuongLinkCLBModel duongLinkClb = new DuongLinkCLBModel().FromDataReader(reader);
                    cacDuongLinkClb.Add(duongLinkClb);
                    await InvokeNext(duongLinkClb);
                });
            return cacDuongLinkClb;
        }
    }
}
