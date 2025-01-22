using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.ThuMuc
{
    public class XoaThuMuc : AsyncCommand
    {
        private readonly ThuMucModel ThuMuc;
        private readonly ThuMucModel ThuMucGoc;
        private readonly IWin32Window Owner;
        public XoaThuMuc(ThuMucModel thuMuc, ThuMucModel thuMucGoc, IWin32Window owner)
        {
            ThuMuc = thuMuc;
            ThuMucGoc = thuMucGoc;
            Owner = owner;
        }

        /// <exception cref="OperationCanceledException" />
        /// <exception cref="MyFault" />
        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            if (ThuMuc == null)
                throw new MyFault(LuuTruRes.ThuMuc_Xoa_LoiChon0);
            else if (ThuMuc.ThuMucGoc)
                throw new MyFault(string.Format(LuuTruRes.ThuMuc_Xoa_LoiThuMucGoc_1, ThuMuc.TenThuMuc));

            await SqlUtils.QueryReaderNew(SqlUtils.ThuMuc_ThongTin, new Dictionary<string, object>
            {
                ["MaThuMuc"] = ThuMuc.MaThuMuc
            }, CommandType.StoredProcedure).Then(async reader =>
            {
                if (!await reader.ReadAsync())
                    throw new MyFault(LuuTruRes.ThuMuc_Xoa_LoiKhongTimThay);
                ThuMucModel model = new ThuMucModel().FromDataReader(reader);

                string msg = model.SoLuongFile > 0
                    ? string.Format(LuuTruRes.ThuMuc_Xoa_XacNhanKhongTrong_NoiDung_1, ThuMucGoc.TenThuMuc)
                    : LuuTruRes.ThuMuc_Xoa_XacNhan_NoiDung;
                if (PoisonMessageBox.Show(Owner, msg, LuuTruRes.ThuMuc_Xoa_XacNhan_TieuDe, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    throw new OperationCanceledException();

                await SqlUtils.ExecuteAsync(SqlUtils.ThuMuc_Xoa, new Dictionary<string, object>
                {
                    ["MaThuMuc"] = model.MaThuMuc,
                    ["MaThuMucGoc"] = ThuMucGoc.MaThuMuc
                }, CommandType.StoredProcedure);
            });
        }
    }
}
