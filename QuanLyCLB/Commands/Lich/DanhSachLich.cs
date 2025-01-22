using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.Lich
{
    public class DanhSachLich : AsyncIterCommand<LichModel>
    {
        private readonly CauLacBoModel CauLacBo;
        private readonly Dictionary<string, object> Dict;

        public DanhSachLich(CauLacBoModel cauLacBo)
        {
            CauLacBo = cauLacBo;
        }

        public DanhSachLich(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<IEnumerable<LichModel>> Execute(CancellationToken tok)
        {
            List<LichModel> cacLich = new List<LichModel>();
            await SqlUtils.QueryReaderNew(
                SqlUtils.Lich_DanhSach, Dict ?? new Dictionary<string, object>
                {
                    ["MaCLB"] = CauLacBo.MaCLB
                },
                CommandType.StoredProcedure).ForEach(async reader =>
                {
                    LichModel lich = new LichModel().FromDataReader(reader);
                    cacLich.Add(lich);
                    await InvokeNext(lich);
                });
            return cacLich;
        }
    }
}
