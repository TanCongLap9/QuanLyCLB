using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.LuuTru
{
    public class DoiTenTapTin : AsyncCommand
    {
        private readonly TapTinModel TapTin;
        private readonly string TenMoi;

        public DoiTenTapTin(TapTinModel tapTin, string tenMoi)
        {
            TapTin = tapTin;
            TenMoi = tenMoi;
        }

        /// <exception cref="OperationCanceledException" />
        /// <exception cref="MyFault" />
        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            if (TapTin == null)
                throw new MyFault(LuuTruRes.TapTin_DoiTen_LoiChon0);
            else if (string.IsNullOrWhiteSpace(TenMoi))
                throw new OperationCanceledException();
            else if (Regex.IsMatch(TenMoi, @"\\|/|:|\*|\?|""|<|>|\|"))
                throw new MyFault(LuuTruRes.TapTin_DoiTen_LoiTenChuaKyHieu);

            await SqlUtils.ExecuteAsync(SqlUtils.TapTin_DoiTen, new Dictionary<string, object>
            {
                ["MaTapTin"] = TapTin.MaTapTin,
                ["TenTapTin"] = TenMoi
            }, CommandType.StoredProcedure);
        }
    }
}
