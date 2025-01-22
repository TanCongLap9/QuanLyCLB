using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.ThanhVien
{
    public class XoaThanhVien : AsyncCommand
    {
        private readonly ThanhVienModel ThanhVien;
        private readonly Dictionary<string, object> Dict;

        public XoaThanhVien(ThanhVienModel thanhVien)
        {
            ThanhVien = thanhVien;
        }

        public XoaThanhVien(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            await SqlUtils.ExecuteAsync(
                SqlUtils.ThanhVien_Xoa, Dict ?? new Dictionary<string, object>
                {
                    ["MaNguoiDung"] = ThanhVien.MaNguoiDung,
                    ["MaCLB"] = ThanhVien.MaCLB
                },
                CommandType.StoredProcedure);
        }
    }
}
