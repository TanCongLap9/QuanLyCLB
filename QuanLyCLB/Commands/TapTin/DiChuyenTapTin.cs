using System;
using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
using QuanLyCLB.Properties;

namespace QuanLyCLB.Commands.LuuTru
{
    public class DiChuyenTapTin : AsyncProgressCommand<int>
    {
        private readonly List<TapTinModel> CacTapTin;
        private readonly ThuMucModel ThuMuc;

        public DiChuyenTapTin(List<TapTinModel> tapTins, ThuMucModel thuMuc)
        {
            CacTapTin = tapTins;
            ThuMuc = thuMuc;
        }

        /// <exception cref="OperationCanceledException" />
        /// <exception cref="MyFault" />
        public override async Task Execute(CancellationToken tok)
        {
            if (CacTapTin == null || CacTapTin.Count == 0)
                throw new MyFault(LuuTruRes.TapTin_DiChuyen_LoiChon0);
            if (ThuMuc.MaThuMuc == CacTapTin[0].MaThuMuc)
                throw new MyFault(LuuTruRes.TapTin_DiChuyen_LoiCungThuMuc);

            int count = 0;
            foreach (TapTinModel model in CacTapTin)
            {
                try
                {
                    await SqlUtils.ExecuteAsync(SqlUtils.TapTin_DiChuyen, new Dictionary<string, object>
                    {
                        ["MaTapTin"] = model.MaTapTin,
                        ["MaThuMuc"] = ThuMuc.MaThuMuc
                    }, CommandType.StoredProcedure);
                    count++;
                    IProgress.Report(count);
                }
                catch (Exception exc)
                {
                    System.Console.WriteLine(exc);
                }
            }
            IPostProgress.Report(count);
        }
    }
}
