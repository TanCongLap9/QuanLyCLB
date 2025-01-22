using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.ThongBao
{
    public class DanhSachThongBao : AsyncIterCommand<ThongBaoModel>
    {
        private readonly NguoiDungModel NguoiDung;

        public DanhSachThongBao(NguoiDungModel nguoiDung)
        {
            NguoiDung = nguoiDung;
        }

        /// <exception cref="Exception" />
        public override async Task<IEnumerable<ThongBaoModel>> Execute(CancellationToken tok)
        {
            List<ThongBaoModel> cacThongBao = new List<ThongBaoModel>();
            await SqlUtils.QueryReaderNew(
                SqlUtils.ThongBao_DanhSach, NguoiDung == null ? null : new Dictionary<string, object>
                {
                    ["MaNguoiDung"] = NguoiDung.MaNguoiDung
                },
                CommandType.StoredProcedure).ForEach(async reader =>
                {
                    ThongBaoModel thongBao = new ThongBaoModel().FromDataReader(reader);
                    cacThongBao.Add(thongBao);
                    await InvokeNext(thongBao);
                });
            return cacThongBao;
        }
    }
}
