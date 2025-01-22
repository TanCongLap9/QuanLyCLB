using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System.Collections.Generic;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.CauLacBo
{
    public class DanhSachCauLacBo : AsyncIterCommand<CauLacBoModel>
    {
        private readonly NguoiDungModel NguoiDung;

        public DanhSachCauLacBo(NguoiDungModel nguoiDung = null)
        {
            NguoiDung = nguoiDung;
        }

        /// <exception cref="Exception" />
        public override async Task<IEnumerable<CauLacBoModel>> Execute(CancellationToken tok)
        {
            List<CauLacBoModel> cacCauLacBo = new List<CauLacBoModel>();
            await SqlUtils.QueryReaderNew(
                SqlUtils.CauLacBo_DanhSach, NguoiDung == null ? null : new Dictionary<string, object>
                {
                    ["MaNguoiDung"] = NguoiDung.MaNguoiDung
                },
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
