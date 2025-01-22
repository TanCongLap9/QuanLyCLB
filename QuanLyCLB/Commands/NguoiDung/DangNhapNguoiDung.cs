using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.NguoiDung
{
    public class DangNhapNguoiDung : AsyncCommand<NguoiDungModel>
    {
        private readonly string TenDangNhap;
        private readonly string MatKhau;
        private readonly Dictionary<string, object> Dict;

        public DangNhapNguoiDung(string tenDangNhap, string matKhau)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }

        public DangNhapNguoiDung(Dictionary<string, object> dict)
        {
            Dict = dict;
        }

        /// <exception cref="Exception" />
        public override async Task<NguoiDungModel> Execute(CancellationToken tok)
        {
            NguoiDungModel model = null;
            await SqlUtils.QueryReaderNew(
                SqlUtils.NguoiDung_DangNhap,
                Dict ?? new Dictionary<string, object>
                {
                    ["TenDangNhap"] = TenDangNhap,
                    ["MatKhau"] = MatKhau
                }, CommandType.StoredProcedure).Then(reader =>
                {
                    if (reader.Read())
                        model = new NguoiDungModel().FromDataReader(reader);
                });
            return model;
        }
    }
}
