using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.LuuTru
{
    public class DanhSachTapTin : AsyncIterCommand<TapTinModel>
    {
        private readonly ThuMucModel ThuMuc;
        private readonly Dictionary<string, object> Dict;

        public DanhSachTapTin(ThuMucModel thuMuc)
        {
            ThuMuc = thuMuc;
        }

        public DanhSachTapTin(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<IEnumerable<TapTinModel>> Execute(CancellationToken tok)
        {
            List<TapTinModel> cacTapTin = new List<TapTinModel>();
            await SqlUtils.QueryReaderNew(
                SqlUtils.TapTin_DanhSach, Dict ?? new Dictionary<string, object>
                {
                    ["MaThuMuc"] = ThuMuc.MaThuMuc
                }, CommandType.StoredProcedure, CommandBehavior.SequentialAccess, cancellationToken: tok).ForEach(async reader =>
                {
                    TapTinModel tapTin = new TapTinModel().FromDataReader(reader);
                    cacTapTin.Add(tapTin);
                    await InvokeNext(tapTin);
                });
            return cacTapTin;
        }
    }
}
