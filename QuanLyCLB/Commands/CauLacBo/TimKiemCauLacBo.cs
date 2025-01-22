using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.CauLacBo
{
    public class TimKiemCauLacBo : AsyncIterCommand<CauLacBoModel>
    {
        private readonly Dictionary<string, object> Dict;

        public TimKiemCauLacBo(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<IEnumerable<CauLacBoModel>> Execute(CancellationToken tok)
        {
            if (Dict != null && Dict.Count == 0) throw new MyFault("Thiếu tham số.");

            List<CauLacBoModel> cacCauLacBo = new List<CauLacBoModel>();
            await SqlUtils.QueryReaderNew(
                SqlUtils.CauLacBo_TimKiem, Dict,
                CommandType.StoredProcedure).ForEach(async reader =>
                {
                    CauLacBoModel cauLacBo = new CauLacBoModel().FromDataReader(reader);
                    cacCauLacBo.Add(cauLacBo);
                    await InvokeNext(cauLacBo);
                });
            return cacCauLacBo;
        }
    }
}
