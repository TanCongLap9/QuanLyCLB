using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.CauLacBo
{
    public class ThongTinCauLacBo : AsyncCommand<CauLacBoModel>
    {
        private readonly string MaCLB;
        private readonly Dictionary<string, object> Dict;

        public ThongTinCauLacBo(string maClb)
        {
            MaCLB = maClb;
        }

        public ThongTinCauLacBo(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<CauLacBoModel> Execute(CancellationToken tok)
        {
            CauLacBoModel model = null;
            await SqlUtils.QueryReaderNew(
                SqlUtils.CauLacBo_ThongTin, Dict ?? new Dictionary<string, object>
                {
                    ["MaCLB"] = MaCLB
                },
                CommandType.StoredProcedure).Then(reader =>
                {
                    reader.Read();
                    model = new CauLacBoModel().FromDataReader(reader);
                });
            return model;
        }
    }
}
