using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.NguoiDung
{
    public class SuaNguoiDung : AsyncCommand
    {
        private readonly NguoiDungModel NguoiDung;
        private readonly Dictionary<string, object> Dict;

        public SuaNguoiDung(NguoiDungModel nguoiDung)
        {
            NguoiDung = nguoiDung;
        }

        public SuaNguoiDung(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.NguoiDung_Sua, Dict ?? new Dictionary<string, object>
                {
                    ["MaNguoiDung"] = NguoiDung.MaNguoiDung,
                    ["Ho"] = NguoiDung.Ho,
                    ["Lot"] = NguoiDung.Lot,
                    ["Ten"] = NguoiDung.Ten,
                    ["SDT"] = NguoiDung.SDT,
                    ["GioiTinh"] = NguoiDung.GioiTinh,
                    ["NgaySinh"] = NguoiDung.NgaySinh,
                    ["Email"] = NguoiDung.Email,
                    ["MSSV"] = NguoiDung.MSSV,
                    ["TenDangNhap"] = NguoiDung.TenDangNhap,
                    ["MatKhau"] = NguoiDung.MatKhau,
                    ["MaBaoMat"] = NguoiDung.MaBaoMat,
                    ["AnhDaiDien"] = (object)NguoiDung.AnhDaiDien ?? DBNull.Value
                },
                CommandType.StoredProcedure);
        }
    }
}
