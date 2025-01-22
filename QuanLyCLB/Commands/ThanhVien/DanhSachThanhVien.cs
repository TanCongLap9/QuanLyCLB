using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.ThanhVien
{
    public class DanhSachThanhVien : AsyncIterCommand<ThanhVienModel>
    {
        private readonly CauLacBoModel CauLacBo;
        private readonly Dictionary<string, object> Dict;

        public DanhSachThanhVien(CauLacBoModel cauLacBo)
        {
            CauLacBo = cauLacBo;
        }

        public DanhSachThanhVien(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<IEnumerable<ThanhVienModel>> Execute(CancellationToken tok)
        {
            List<ThanhVienModel> cacThanhVien = new List<ThanhVienModel>();
            await SqlUtils.QueryReaderNew(
                SqlUtils.ThanhVien_DanhSach, Dict ?? new Dictionary<string, object>
                {
                    ["MaCLB"] = CauLacBo.MaCLB
                },
                CommandType.StoredProcedure).ForEach(async reader =>
                {
                    ThanhVienModel thanhVien = new ThanhVienModel().FromDataReader(reader);
                    cacThanhVien.Add(thanhVien);
                    await InvokeNext(thanhVien);
                });
            return cacThanhVien;
        }
    }
}
