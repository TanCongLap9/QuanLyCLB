using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.NguoiDung
{
    public class ThongTinNguoiDung : AsyncCommand<NguoiDungModel>
    {
        private readonly Dictionary<string, object> Dict;
        private readonly string MaNguoiDung;

        public ThongTinNguoiDung(string maNguoiDung)
        {
            MaNguoiDung = maNguoiDung;
        }
        
        public ThongTinNguoiDung(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<NguoiDungModel> Execute(CancellationToken tok)
        {
            NguoiDungModel nguoiDung = null;
            await SqlUtils.QueryReaderNew(
                SqlUtils.NguoiDung_ThongTin, Dict ?? new Dictionary<string, object>
                {
                    ["MaNguoiDung"] = MaNguoiDung
                },
                CommandType.StoredProcedure).Then(async reader =>
                {
                    if (!await reader.ReadAsync()) return;
                    nguoiDung = new NguoiDungModel().FromDataReader(reader);
                });
            return nguoiDung;
        }
    }
}
