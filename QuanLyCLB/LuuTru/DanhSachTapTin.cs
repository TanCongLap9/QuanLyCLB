using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.TrinhDoc;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.LuuTru
{
    public partial class DanhSachTapTin : PoisonUserControl
    {
        public const string ImageIcon = "image_x_generic";
        public const string VideoIcon = "video_x_generic";
        public const string TextIcon = "text_x_generic";
        public const string ChromeIcon = "chromium_2";
        public const string FileIcon = "file";
        public const int ColumnTen = 0;
        public const int ColumnKieuTapTin = 1;
        public const int ColumnThoiGianSuaDoi = 2;
        public const int ColumnThoiGianTao = 3;
        public const int ColumnDungLuong = 4;
        public const string AscArrow = " \x25b4";
        public const string DescArrow = " \x25be";

        private int oldColumnIndex = -1;
        private Task<IEnumerable<TapTinModel>> Browsing;
        private CancellationTokenSource Cts;
        private ThemeStyle theme;

        public DanhSachTapTin()
        {
            InitializeComponent();
        }

        public new event DragEventHandler DragDrop;
        public event LabelEditEventHandler AfterLabelEdit;
        public event EventHandler SelectedModelsChanged;
        public event EventHandler ItemActivate;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCancelling
        {
            get
            {
                return Browsing != null && !Browsing.IsCompleted && !Browsing.IsFaulted &&
                    Cts != null && Cts.IsCancellationRequested;
            }
        }

        public View View
        {
            get { return listView.View; }
            set { listView.View = value; }
        }

        public new ThemeStyle Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                ColorUtils.SetColor(listView, value);
            }
        }

        public bool LabelEdit
        {
            get { return listView.LabelEdit; }
            set { listView.LabelEdit = value; }
        }

        public new bool AllowDrop
        {
            get { return base.AllowDrop; }
            set
            {
                base.AllowDrop = value;
                if (value)
                {
                    spinner.DragEnter += Control_DragEnter;
                    lText.DragEnter += Control_DragEnter;
                    listView.DragEnter += Control_DragEnter;
                    lTaiLen.DragEnter += Control_DragEnter;

                    spinner.DragLeave += Control_DragLeave;
                    lText.DragLeave += Control_DragLeave;
                    listView.DragLeave += Control_DragLeave;
                    lTaiLen.DragLeave += Control_DragLeave;

                    spinner.DragDrop += Control_DragDrop;
                    lText.DragDrop += Control_DragDrop;
                    listView.DragDrop += Control_DragDrop;
                    lTaiLen.DragDrop += Control_DragDrop;
                }
                else
                {
                    spinner.DragEnter -= Control_DragEnter;
                    lText.DragEnter -= Control_DragEnter;
                    listView.DragEnter -= Control_DragEnter;
                    lTaiLen.DragEnter -= Control_DragEnter;

                    spinner.DragLeave -= Control_DragLeave;
                    lText.DragLeave -= Control_DragLeave;
                    listView.DragLeave -= Control_DragLeave;
                    lTaiLen.DragLeave -= Control_DragLeave;

                    spinner.DragDrop -= Control_DragDrop;
                    lText.DragDrop -= Control_DragDrop;
                    listView.DragDrop -= Control_DragDrop;
                    lTaiLen.DragDrop -= Control_DragDrop;
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ListView.SelectedIndexCollection SelectedIndices
        {
            get { return listView.SelectedIndices; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ListView.SelectedListViewItemCollection SelectedItems
        {
            get { return listView.SelectedItems; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<TapTinModel> SelectedModels { get; } = new List<TapTinModel>();

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<TapTinModel> Models { get; } = new List<TapTinModel>();

        private void DanhSachTapTin_Load(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            lTaiLen.BringToFront();
        }

        private string GetFallbackImage(TapTinModel model)
        {
            if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.HinhAnh.Contains(model.PhanMoRong))
                return ImageIcon;
            else if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.TruyenThong.Contains(model.PhanMoRong))
                return VideoIcon;
            else if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.VanBan.Contains(model.PhanMoRong))
                return TextIcon;
            else if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.TrinhDuyet.Contains(model.PhanMoRong))
                return ChromeIcon;
            else
                return FileIcon;
        }

        /// <exception cref="OperationCanceledException" />
        public async Task Browse(ThuMucModel thuMuc, AlertBox hopThongBao)
        {
            if (IsCancelling) return;
            try
            {
                if (Browsing != null && !Browsing.IsCompleted && !Browsing.IsFaulted) await Cancel();
            }
            catch (OperationCanceledException) { }

            Cts = new CancellationTokenSource();
            Cts.Token.ThrowIfCancellationRequested();

            Clear();
            spinner.Spinning = true;
            spinner.Show();
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lText.Hide();

            // ImageList
            Cts.Token.ThrowIfCancellationRequested();
            foreach (ImageList il in new ImageList[] { ilDetails, ilLarge })
            {
                il.Images.Clear();
                il.Images.Add(ImageIcon, Resources.image_x_generic);
                il.Images.Add(VideoIcon, Resources.video_x_generic);
                il.Images.Add(TextIcon, Resources.text_x_generic);
                il.Images.Add(ChromeIcon, Resources.chromium_2);
                il.Images.Add(FileIcon, Resources.file);
            }

            // Thumbnail size
            Size thumbSize = Size.Empty;
            Size thumbSizeLarge = Size.Empty;
            if (IsHandleCreated) Invoke(new Action(() =>
            {
                thumbSize = ilDetails.ImageSize;
                thumbSizeLarge = ilLarge.ImageSize;
            }));

            try
            {
                Browsing = new Commands.LuuTru.DanhSachTapTin(thuMuc).OnNext(model =>
                {
                    // Lvi
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        model.TenTapTin,
                        model.MimeType,
                        model.ThoiGianSuaDoi.ToString("dd/MM/yyyy"),
                        model.ThoiGianTao.ToString("dd/MM/yyyy"),
                        HumanizeBytes(model.DungLuong)
                    });

                    // Thumbnail
                    Image thumb = null;
                    string thumbKey = null;
                    Image thumbLarge = null;
                    if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.Bitmap.Contains(model.PhanMoRong))
                    {
                        List<Image> thumbnails = ImageUtils.GetThumbnailImages(
                            model.NoiDung,
                            new List<Size> { thumbSize, thumbSizeLarge },
                            new List<Image>
                            {
                                ilDetails.Images[GetFallbackImage(model)],
                                ilLarge.Images[GetFallbackImage(model)]
                            });
                        thumb = thumbnails[0];
                        thumbLarge = thumbnails[1];
                    }
                    else thumbKey = GetFallbackImage(model);

                    // Add item
                    Cts.Token.ThrowIfCancellationRequested();
                    if (IsHandleCreated) Invoke(new Action(() =>
                    {
                        if (thumb != null)
                        {
                            ilDetails.Images.Add(model.MaTapTin.ToString(), thumb);
                            ilLarge.Images.Add(model.MaTapTin.ToString(), thumbLarge);
                            item.ImageKey = model.MaTapTin.ToString();
                        }
                        else item.ImageKey = thumbKey;
                        Models.Add(model);
                        listView.Items.Add(item);
                    }));
                }).Execute(Cts.Token);
                
                await Browsing;
                Cts.Token.ThrowIfCancellationRequested();
                if (Models.Count == 0)
                {
                    lText.Text = LuuTruRes.DanhSachTapTin_Trong;
                    lText.Show();
                }
            }
            catch (OperationCanceledException) { }
            catch (Exception exc)
            {
                hopThongBao.Alert(LuuTruRes.DanhSachTapTin_Duyet_Loi_1, exc.Message);
            }
            finally
            {
                spinner.Spinning = false;
                spinner.Hide();
                listView.HeaderStyle = ColumnHeaderStyle.Clickable;
            }
        }

        public void Sort(int columnIndex)
        {
            listView_ColumnClick(listView, new ColumnClickEventArgs(columnIndex));
        }

        public async Task Cancel()
        {
            if (Browsing == null) return;
            Cts.Cancel();
            listView.Items.Clear();
            await Browsing;
            Cts.Dispose();
        }

        public void Clear(bool trong = false)
        {
            Models.Clear();
            SelectedModels.Clear();
            listView.Items.Clear();
            oldColumnIndex = -1;
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                ColumnHeader header = listView.Columns[i];
                SetSortArrow(header, i == 0 ? SortOrder.Ascending : SortOrder.None);
            }
            lText.Text = trong ? LuuTruRes.DanhSachTapTin_Chon0 : string.Empty;
            lText.Visible = trong;
        }

        public static string HumanizeBytes(long bytes)
        {
            return bytes > 1073741824L
                ? (bytes / 1073741824F).ToString("n2") + " GB"
                : bytes > 1048576L
                ? (bytes / 1048576F).ToString("n2") + " MB"
                : bytes > 1024L
                ? (bytes / 1024F).ToString("n2") + " KB"
                : bytes + " byte";
        }

        private void Control_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            // Chỉ được tải file lên, ko cho tải thư mục
            if (((string[])e.Data.GetData(DataFormats.FileDrop))
                .Any(fileDrop => !File.Exists(fileDrop)))
                return;
            e.Effect = DragDropEffects.Copy;
            lTaiLen.Show();
        }

        private void Control_DragLeave(object sender, System.EventArgs e)
        {
            lTaiLen.Hide();
        }

        private void Control_DragDrop(object sender, DragEventArgs e)
        {
            Control_DragLeave(null, null);
            DragDrop?.Invoke(this, e);
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Cancel();
        }

        private void listView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            AfterLabelEdit?.Invoke(this, e);
        }

        private void listView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SelectedModels.Clear();
            foreach (int index in listView.SelectedIndices)
                SelectedModels.Add(Models[index]);
            SelectedModelsChanged?.Invoke(this, e);
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortOrder order = e.Column == oldColumnIndex ? SortOrder.Descending : SortOrder.Ascending;
            Comparer<TapTinModel> c = null;
            switch (e.Column)
            {
                case ColumnTen:
                    c = Comparer<TapTinModel>.Create((model1, model2) =>
                        order == SortOrder.Ascending
                            ? model1.TenTapTin.CompareTo(model2.TenTapTin)
                            : order == SortOrder.Descending
                            ? model2.TenTapTin.CompareTo(model1.TenTapTin)
                            : 0
                    );
                    break;
                case ColumnKieuTapTin:
                    c = Comparer<TapTinModel>.Create((model1, model2) =>
                    {
                        if (order == SortOrder.Ascending)
                        {
                            int compare = model1.MimeType.CompareTo(model2.MimeType);
                            if (compare == 0) return model1.TenTapTin.CompareTo(model2.TenTapTin);
                            return compare;
                        }
                        else if (order == SortOrder.Descending)
                        {
                            int compare = model2.MimeType.CompareTo(model1.MimeType);
                            if (compare == 0) return model2.TenTapTin.CompareTo(model1.TenTapTin);
                            return compare;
                        }
                        return 0;
                    });
                    break;
                case ColumnThoiGianTao:
                    c = Comparer<TapTinModel>.Create((model1, model2) =>
                    {
                        if (order == SortOrder.Ascending)
                        {
                            int compare = model1.ThoiGianTao.CompareTo(model2.ThoiGianTao);
                            if (compare == 0) return model1.TenTapTin.CompareTo(model2.TenTapTin);
                            return compare;
                        }
                        else if (order == SortOrder.Descending)
                        {
                            int compare = model2.ThoiGianTao.CompareTo(model1.ThoiGianTao);
                            if (compare == 0) return model2.TenTapTin.CompareTo(model1.TenTapTin);
                            return compare;
                        }
                        return 0;
                    });
                    break;
                case ColumnThoiGianSuaDoi:
                    c = Comparer<TapTinModel>.Create((model1, model2) =>
                    {
                        if (order == SortOrder.Ascending)
                        {
                            int compare = model1.ThoiGianSuaDoi.CompareTo(model2.ThoiGianSuaDoi);
                            if (compare == 0) return model1.TenTapTin.CompareTo(model2.TenTapTin);
                            return compare;
                        }
                        else if (order == SortOrder.Descending)
                        {
                            int compare = model2.ThoiGianSuaDoi.CompareTo(model1.ThoiGianSuaDoi);
                            if (compare == 0) return model2.TenTapTin.CompareTo(model1.TenTapTin);
                            return compare;
                        }
                        return 0;
                    });
                    break;
                case ColumnDungLuong:
                    c = Comparer<TapTinModel>.Create((model1, model2) =>
                    {
                        if (order == SortOrder.Ascending)
                        {
                            int compare = model1.DungLuong.CompareTo(model2.DungLuong);
                            if (compare == 0) return model1.TenTapTin.CompareTo(model2.TenTapTin);
                            return compare;
                        }
                        else if (order == SortOrder.Descending)
                        {
                            int compare = model2.DungLuong.CompareTo(model1.DungLuong);
                            if (compare == 0) return model2.TenTapTin.CompareTo(model1.TenTapTin);
                            return compare;
                        }
                        return 0;
                    });
                    break;
            }

            if (c == null) return;

            foreach (ColumnHeader header in listView.Columns)
                SetSortArrow(header, SortOrder.None);
            SetSortArrow(listView.Columns[e.Column], order);
            oldColumnIndex = order == SortOrder.Descending ? -1 : e.Column;

            // Image key
            Dictionary<Guid, string> imageKeysDict = new Dictionary<Guid, string>();
            for (int i = 0; i < Models.Count; i++)
            {
                ListViewItem item = listView.Items[i];
                TapTinModel model = Models[i];
                imageKeysDict.Add(model.MaTapTin, item.ImageKey);
            }

            Models.Sort(c);

            listView.BeginUpdate();
            listView.Items.Clear();
            for (int i = 0; i < Models.Count; i++)
            {
                TapTinModel model = Models[i];
                ListViewItem item = new ListViewItem(new string[]
                {
                    model.TenTapTin,
                    model.MimeType,
                    model.ThoiGianSuaDoi.ToString("dd/MM/yyyy"),
                    model.ThoiGianTao.ToString("dd/MM/yyyy"),
                    HumanizeBytes(model.DungLuong)
                }, imageKeysDict[model.MaTapTin]);
                listView.Items.Add(item);
            }
            listView.EndUpdate();
        }

        private void SetSortArrow(ColumnHeader header, SortOrder order)
        {
            // Remove arrow
            if (header.Text.EndsWith(AscArrow) || header.Text.EndsWith(DescArrow))
                header.Text = header.Text.Substring(0, header.Text.Length - AscArrow.Length);

            // Add arrow
            switch (order)
            {
                case SortOrder.Ascending:
                    header.Text += AscArrow;
                    break;
                case SortOrder.Descending:
                    header.Text += DescArrow;
                    break;
            }
        }

        private void listView_ItemActivate(object sender, System.EventArgs e)
        {
            ItemActivate?.Invoke(this, e);
        }
    }
}
