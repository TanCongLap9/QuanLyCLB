using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.LoaiLich
{
    public class DanhSachLoaiLich : AsyncIterCommand<LoaiLichModel>
    {
        public DanhSachLoaiLich()
        {

        }

        /// <exception cref="Exception" />
        public override async Task<IEnumerable<LoaiLichModel>> Execute(CancellationToken tok)
        {
            List<LoaiLichModel> cacLoaiLich = new List<LoaiLichModel>();
            await SqlUtils.QueryReaderNew(
                SqlUtils.LoaiLich_DanhSach, null,
                CommandType.StoredProcedure).ForEach(async reader =>
                {
                    LoaiLichModel loaiLich = new LoaiLichModel().FromDataReader(reader);
                    cacLoaiLich.Add(loaiLich);
                    await InvokeNext(loaiLich);
                });
            return cacLoaiLich;
        }
    }
}
