using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.TaskWindow;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.LuuTru
{
    public class TaiVe : AsyncProgressCommand<int>
    {
        private readonly IEnumerable<TapTinModel> CacTapTin;
        private readonly SaveFileDialog SaveFileDialog;

        public TaiVe(IEnumerable<TapTinModel> cacTapTin, SaveFileDialog saveFileDialog)
        {
            CacTapTin = cacTapTin;
            SaveFileDialog = saveFileDialog;
        }

        public TaiVe(TapTinModel cacTapTin, SaveFileDialog saveFileDialog)
        {
            CacTapTin = new List<TapTinModel>() { cacTapTin };
            SaveFileDialog = saveFileDialog;
        }

        public async Task TaiVeNhieu(CancellationToken tok)
        {
            PoisonTaskWindow poisonTaskWindow1 = null;
            UploadMultipleWindow downloading = null;
            CancellationTokenSource source = null;

            int count = 0;

            List<string> filePaths = new List<string>();
            foreach (TapTinModel tapTin in CacTapTin)
                filePaths.Add(GetFilePath(tapTin));

            downloading = new UploadMultipleWindow(filePaths);
            downloading.CancelClicked += (sender, e) => source.Cancel();
            poisonTaskWindow1 = TaskWindowUtils.Show(downloading, LuuTruRes.TapTin_TaiVe_DangTaiVe, 0);
            for (int i = 0; i < filePaths.Count(); i++)
            {
                string filePath = filePaths[i];
                TapTinModel model = CacTapTin.ElementAt(i);
                try
                {
                    downloading.Invoke(new Action(() => downloading.Items[i].TinhTrang = TinhTrang.DangTaiVe));
                    await new ThongTinTapTin(model)
                        .OnResult(async model2 =>
                        {
                            using (source = new CancellationTokenSource())
                            using (FileStream2 fs = new FileStream2(filePath, FileMode.Create))
                            {
                                fs.LengthChanged += (s, length) => downloading.Invoke(new Action(() => downloading.Progress = (int)(length * 100L / model2.DungLuong)));
                                await model2.NoiDung.CopyToAsync(fs);
                            }
                            File.SetCreationTime(filePath, model.ThoiGianTao);
                            File.SetLastWriteTime(filePath, model.ThoiGianSuaDoi);
                            File.SetLastAccessTime(filePath, model.ThoiGianTruyCap);
                            count++;
                            downloading.Items[i].TinhTrang = TinhTrang.HoanThanh;
                            IProgress.Report(count);
                        })
                        .Execute(tok);
                }
                catch (OperationCanceledException exc)
                {
                    downloading.Items[i].Loi = exc;
                }
                catch (FileNotFoundException)
                {
                    downloading.Items[i].Loi = new MyFault(LuuTruRes.TapTin_TaiVe_LoiKhongTimThay);
                }
                catch (Exception exc)
                {
                    downloading.Items[i].Loi = exc;
                }
            }
            downloading.Done();
            IPostProgress.Report(count);
        }

        public string GetFilePath(TapTinModel model)
        {
            if (Settings.Default.AskDownloadsPath)
            {
                SaveFileDialog.FileName = model.TenTapTin;
                if (SaveFileDialog.ShowDialog() != DialogResult.OK)
                    throw new OperationCanceledException();
                return SaveFileDialog.FileName;
            }
            else
            {
                string filePath = Path.Combine(StringUtils.Expand(Settings.Default.DownloadsPath), model.TenTapTin);
                int i = 0;
                // Đổi tên file nếu file có tồn tại
                while (File.Exists(filePath))
                {
                    i++;
                    filePath = Path.Combine(StringUtils.Expand(Settings.Default.DownloadsPath), $"{Path.GetFileNameWithoutExtension(model.TenTapTin)} ({i}){Path.GetExtension(model.TenTapTin)}");
                }
                return filePath;
            }
        }

        /// <exception cref="MyFault" />
        public override async Task Execute(CancellationToken tok)
        {
            if (CacTapTin.Count() == 0)
                throw new MyFault(LuuTruRes.TapTin_TaiVe_LoiChon0);

            await TaiVeNhieu(tok);
        }
    }
}
