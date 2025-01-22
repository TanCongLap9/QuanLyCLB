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

namespace QuanLyCLB.Commands.LuuTru
{
    public class XoaTapTin : AsyncProgressCommand<int>
    {
        private readonly List<TapTinModel> CacTapTin;
        private readonly IWin32Window Owner;
        public XoaTapTin(List<TapTinModel> tapTins, IWin32Window owner)
        {
            CacTapTin = tapTins;
            Owner = owner;
        }

        public XoaTapTin(ListView.SelectedListViewItemCollection collection, IWin32Window owner)
        {
            CacTapTin = new List<TapTinModel>();
            foreach (ListViewItem item in collection)
                CacTapTin.Add((TapTinModel)item.Tag);
            Owner = owner;
        }

        /// <exception cref="OperationCanceledException" />
        /// <exception cref="MyFault" />
        public override async Task Execute(CancellationToken tok)
        {
            if (CacTapTin.Count == 0)
                throw new MyFault(LuuTruRes.TapTin_Xoa_LoiChon0);

            string msg = CacTapTin.Count == 1
                ? string.Format(LuuTruRes.TapTin_Xoa_XacNhanMot_NoiDung_1, CacTapTin[0].TenTapTin)
                : string.Format(LuuTruRes.TapTin_Xoa_XacNhanNhieu_NoiDung_1, CacTapTin.Count);
            if (PoisonMessageBox.Show(Owner,
                msg,
                LuuTruRes.TapTin_Xoa_XacNhan_TieuDe,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes) throw new OperationCanceledException();

            int count = 0;
            foreach (TapTinModel tapTin in CacTapTin)
            {
                try
                {
                    await SqlUtils.ExecuteAsync(SqlUtils.TapTin_Xoa, new Dictionary<string, object>
                    {
                        ["MaTapTin"] = tapTin.MaTapTin
                    }, CommandType.StoredProcedure, tok);
                    count++;
                    IProgress.Report(count);
                }
                catch (Exception exc)
                {
                    System.Console.WriteLine(exc);
                }
            }
            IPostProgress.Report(count);
        }
    }
}
