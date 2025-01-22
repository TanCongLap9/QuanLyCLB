using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.NguoiDung
{
    public class TimKiemNguoiDung : AsyncIterCommand<NguoiDungModel>
    {
        private readonly Dictionary<string, object> Dict;

        public TimKiemNguoiDung(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<IEnumerable<NguoiDungModel>> Execute(CancellationToken tok)
        {
            if (Dict != null && Dict.Count == 0) throw new MyFault("Thiếu tham số.");

            List<NguoiDungModel> cacNguoiDung = new List<NguoiDungModel>();
            await SqlUtils.QueryReaderNew(
                SqlUtils.NguoiDung_TimKiem, Dict,
                CommandType.StoredProcedure).ForEach(async reader =>
                {
                    NguoiDungModel nguoiDung = new NguoiDungModel().FromDataReader(reader);
                    cacNguoiDung.Add(nguoiDung);
                    await InvokeNext(nguoiDung);
                });
            return cacNguoiDung;
        }
    }
}
