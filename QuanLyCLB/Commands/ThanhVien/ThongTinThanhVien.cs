using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.ThanhVien
{
    public class ThongTinThanhVien : AsyncCommand<ThanhVienModel>
    {
        private readonly Dictionary<string, object> Dict;
        private readonly string MaCLB;
        private readonly string MaNguoiDung;

        public ThongTinThanhVien(string maClb, string maNguoiDung)
        {
            MaCLB = maClb;
            MaNguoiDung = maNguoiDung;
        }

        public ThongTinThanhVien(CauLacBoModel cauLacBo, NguoiDungModel nguoiDung)
        {
            MaCLB = cauLacBo.MaCLB;
            MaNguoiDung = nguoiDung.MaNguoiDung;
        }

        public ThongTinThanhVien(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<ThanhVienModel> Execute(CancellationToken tok)
        {
            ThanhVienModel thanhVien = null;
            await SqlUtils.QueryReaderNew(
                SqlUtils.ThanhVien_ThongTin, Dict ?? new Dictionary<string, object>
                {
                    ["MaCLB"] = MaCLB,
                    ["MaNguoiDung"] = MaNguoiDung
                },
                CommandType.StoredProcedure).Then(async reader =>
                {
                    if (await reader.ReadAsync())
                        thanhVien = new ThanhVienModel().FromDataReader(reader);
                });
            return thanhVien;
        }
    }
}
