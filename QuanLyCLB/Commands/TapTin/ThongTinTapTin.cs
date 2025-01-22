using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.LuuTru
{
    public class ThongTinTapTin : AsyncCommand, IDisposable
    {
        private Guid MaTapTin;
        private Func<TapTinModel, Task> OnResultAsync;
        private Action<TapTinModel> OnResultSync;
        private DataReaderNew Reader;
        private readonly bool Persistent;

        public ThongTinTapTin(TapTinModel model, bool persistent = false)
        {
            MaTapTin = model.MaTapTin;
            Persistent = persistent;
        }

        public ThongTinTapTin(Guid maTapTin, bool persistent = false)
        {
            MaTapTin = maTapTin;
            Persistent = persistent;
        }

        public ThongTinTapTin OnResult(Func<TapTinModel, Task> onResult)
        {
            OnResultAsync = onResult;
            return this;
        }

        public ThongTinTapTin OnResult(Action<TapTinModel> onResult)
        {
            OnResultSync = onResult;
            return this;
        }

        /// <exception cref="MyFault" />
        /// <exception cref="Exception" />
        public override async Task Execute(CancellationToken tok)
        {
            TapTinModel model = null;
            Reader = SqlUtils.QueryReaderNew(
                SqlUtils.TapTin_ThongTin,
                new Dictionary<string, object> { ["MaTapTin"] = MaTapTin },
                CommandType.StoredProcedure,
                CommandBehavior.SequentialAccess
            );
            await Reader.Then(async reader =>
            {
                if (!await reader.ReadAsync()) throw new MyFault(LuuTruRes.TapTin_Mo_LoiKhongTimThay);
                model = new TapTinModel().FromDataReader(reader);
                if (this.OnResultSync != null)
                    this.OnResultSync.Invoke(model);
                else if (OnResultAsync != null)
                    await OnResultAsync.Invoke(model);
            }, !Persistent);
        }

        public void Dispose()
        {
            Reader.Dispose();
        }
    }
}
