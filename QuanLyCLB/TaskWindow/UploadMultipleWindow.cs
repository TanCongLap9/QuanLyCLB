using QuanLyCLB.Properties;
using ReaLTaiizor.Controls;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using QuanLyCLB.Utils;
using ReaLTaiizor.Forms;

namespace QuanLyCLB.TaskWindow
{
    public partial class UploadMultipleWindow : PoisonUserControl
    {
        public const string HoanThanh = "done";
        public const string Loi = "error";
        public const string DangCho = "waiting";
        public const string DangTaiLen = "upload";
        public const string DangTaiVe = "download";

        public event EventHandler CancelClicked;

        private IEnumerable<string> FilePaths;

        public UploadMultipleWindow()
        {
            InitializeComponent();
        }

        public UploadMultipleWindow(IEnumerable<string> filePaths)
        {
            FilePaths = filePaths;
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items { get; } = new List<Item>();

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Progress
        {
            get { return pbProgress.Value; }
            set
            {
                pbProgress.Value = value;
                lProgress.Text = $"{value}%";
            }
        }

        protected override void OnParentChanged(System.EventArgs e)
        {
            base.OnParentChanged(e);
            if (!(ParentForm is PoisonForm)) return;
            PoisonForm form = (PoisonForm)ParentForm;
            poisonStyleManager1.Owner = form;
            ColorUtils.SetColor(form, poisonStyleManager1.Theme, poisonStyleManager1.Style);
            ColorUtils.SetColor(listView, poisonStyleManager1.Theme);
        }

        public void Done()
        {
            bHuy.Enabled = false;
            listView.ContextMenuStrip = ctxTapTin;
        }

        private void UploadMultipleWindow_Load(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            if (FilePaths == null) return;
            Items.Clear();
            listView.BeginUpdate();
            listView.Items.Clear();
            foreach (string filePath in FilePaths)
            {
                ListViewItem lvi = new ListViewItem(new string[] { Path.GetFileName(filePath), LuuTruRes.TapTin_TaiLenTaiXuongNhieu_TinhTrang_DangCho }, DangCho);
                listView.Items.Add(lvi);
                Items.Add(new Item(lvi));
            }
            listView.EndUpdate();
        }

        private void bHuyClick(object sender, System.EventArgs e)
        {
            CancelClicked?.Invoke(this, e);
        }

        private void poisonContextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (FilePaths.Count() == 0 || listView.SelectedItems.Count == 0) return;
            if (e.ClickedItem == xemToolStripMenuItem)
                Process.Start("explorer.exe", $"/select,\"{FilePaths.ElementAt(listView.SelectedIndices[0])}\"");
            if (e.ClickedItem == mởToolStripMenuItem)
                Process.Start(FilePaths.ElementAt(listView.SelectedIndices[0]));
        }
    }
}
