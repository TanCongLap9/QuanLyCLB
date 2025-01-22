using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.TaskWindow;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Commands.LuuTru
{
    public class TaiLen : AsyncProgressCommand<int>
    {
        private readonly IEnumerable<string> FilePaths;
        private readonly ThuMucModel ThuMuc;

        public TaiLen(IEnumerable<string> filePaths, ThuMucModel thuMuc) : base()
        {
            FilePaths = filePaths;
            ThuMuc = thuMuc;
        }

        public async Task TaiLenNhieu()
        {
            PoisonTaskWindow poisonTaskWindow1 = null;
            UploadMultipleWindow uploading = null;
            CancellationTokenSource source = null;

            int count = 0;
            uploading = new UploadMultipleWindow(FilePaths);
            uploading.CancelClicked += (sender, e) => source.Cancel();
            poisonTaskWindow1 = TaskWindowUtils.Show(uploading, LuuTruRes.TapTin_TaiLen_DangTaiLen, 0);
            for (int i = 0; i < FilePaths.Count(); i++)
            {
                string filePath = FilePaths.ElementAt(i);
                try
                {
                    uploading.Invoke(new Action(() => uploading.Items[i].TinhTrang = TinhTrang.DangTaiLen));
                    using (source = new CancellationTokenSource())
                        using (FileStream2 fs2 = new FileStream2(filePath, FileMode.Open))
                        {
                            fs2.PositionChanged += (s, pos) => uploading.Invoke(new Action(() => uploading.Progress = (int)(pos * 100L / fs2.Length)));
                            TapTinModel model = new TapTinModel()
                            {
                                MaTapTin = Guid.NewGuid(),
                                TenTapTin = Path.GetFileName(filePath),
                                NoiDung = fs2,
                                ThoiGianTao = File.GetCreationTime(filePath),
                                ThoiGianSuaDoi = File.GetLastWriteTime(filePath),
                                ThoiGianTruyCap = File.GetLastAccessTime(filePath),
                                MaThuMuc = ThuMuc.MaThuMuc
                            };
                            await SqlUtils.ExecuteAsync(SqlUtils.TapTin_Them, new Dictionary<string, object>
                            {
                                ["MaTapTin"] = model.MaTapTin,
                                ["TenTapTin"] = model.TenTapTin,
                                ["NoiDung"] = model.NoiDung,
                                ["ThoiGianTao"] = model.ThoiGianTao,
                                ["ThoiGianSuaDoi"] = model.ThoiGianSuaDoi,
                                ["ThoiGianTruyCap"] = model.ThoiGianTruyCap,
                                ["MaThuMuc"] = model.MaThuMuc
                            }, CommandType.StoredProcedure, source.Token);
                        }
                    count++;
                    uploading.Items[i].TinhTrang = TinhTrang.HoanThanh;
                    IProgress.Report(count);
                }
                catch (OperationCanceledException exc)
                {
                    uploading.Items[i].Loi = exc;
                }
                catch (FileNotFoundException)
                {
                    uploading.Items[i].Loi = new MyFault(LuuTruRes.TapTin_TaiLen_LoiKhongTimThay);
                }
                catch (Exception exc)
                {
                    uploading.Items[i].Loi = exc;
                }
            }
            uploading.Done();
            IPostProgress.Report(count);
        }

        /// <exception cref="MyFault" />
        public override async Task Execute(CancellationToken tok)
        {
            if (ThuMuc == null)
                throw new MyFault(LuuTruRes.TapTin_TaiLen_LoiKhongChonThuMuc);
            if (FilePaths.Count() == 0)
                throw new MyFault(LuuTruRes.TapTin_TaiLen_LoiChon0);

            await TaiLenNhieu();
        }
    }
}
