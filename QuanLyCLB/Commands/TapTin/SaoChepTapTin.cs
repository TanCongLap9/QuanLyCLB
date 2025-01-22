using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.LuuTru
{
    public class SaoChepTapTin : AsyncProgressCommand<int>
    {
        private readonly List<TapTinModel> CacTapTin;
        private readonly ThuMucModel ThuMuc;

        public SaoChepTapTin(List<TapTinModel> cacTapTin, ThuMucModel thuMuc)
        {
            CacTapTin = cacTapTin;
            ThuMuc = thuMuc;
        }

        /// <exception cref="OperationCanceledException" />
        /// <exception cref="MyFault" />
        public override async Task Execute(CancellationToken tok)
        {
            if (CacTapTin == null || CacTapTin.Count == 0)
                throw new MyFault(LuuTruRes.TapTin_SaoChep_LoiChon0);

            int count = 0;
            foreach (TapTinModel model in CacTapTin)
            {
                try
                {
                    await SqlUtils.ExecuteAsync(SqlUtils.TapTin_SaoChep, new Dictionary<string, object>
                    {
                        ["MaTapTin"] = model.MaTapTin,
                        ["MaTapTinMoi"] = Guid.NewGuid(),
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
