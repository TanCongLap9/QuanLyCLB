using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.ThuMuc
{
    public class SuaThuMuc : AsyncCommand
    {
        private readonly ThuMucModel ThuMuc;
        private readonly CauLacBoModel CauLacBo;
        public SuaThuMuc(ThuMucModel thuMuc, CauLacBoModel cauLacBo)
        {
            ThuMuc = thuMuc;
            CauLacBo = cauLacBo;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(SqlUtils.ThuMuc_Sua, new Dictionary<string, object>
            {
                ["MaThuMuc"] = ThuMuc.MaThuMuc,
                ["TenThuMuc"] = ThuMuc.TenThuMuc,
                ["MaMau"] = ThuMuc.MaMau.ToArgb() & 0xffffff,
                ["MaCLB"] = CauLacBo.MaCLB
            }, CommandType.StoredProcedure);
        }
    }
}
