using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.LuuTru
{
    public partial class DanhSachThuMuc : PoisonUserControl
    {
        private Task<IEnumerable<ThuMucModel>> Browsing;
        private CancellationTokenSource Cts;
        private ThuMucModel selectedModel;
        private FolderItem folderItem;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ThuMucModel SelectedModel
        {
            get { return selectedModel; }
            set
            {
                selectedModel = value;
                foreach (Control control in flowLayoutPanel2.Controls)
                {
                    if (!(control is FolderItem)) continue;
                    FolderItem item = (FolderItem)control;
                    if (item.Model != null && value != null && item.Model.MaThuMuc == value.MaThuMuc)
                        item.Open = true;
                    else item.Open = false;
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FolderItem SelectedItem
        {
            get { return folderItem; }
            set
            {
                folderItem = value;
                int index = flowLayoutPanel2.Controls.IndexOf(value);
                if (index != -1) SelectedModel = Models[index];
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<ThuMucModel> Models { get; } = new List<ThuMucModel>();
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<FolderItem> Items
        {
            get
            {
                List<FolderItem> items = new List<FolderItem>();
                foreach (Control ctl in flowLayoutPanel2.Controls)
                    if (ctl is FolderItem)
                        items.Add((FolderItem)ctl);
                return items;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ThuMucModel ThuMucGoc { get; set; }

        public event EventHandler<ThuMucEventArgs> ItemClick;

        public DanhSachThuMuc()
        {
            InitializeComponent();
        }

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

        public async Task GetFolders(CauLacBoModel cauLacBo, AlertBox hopThongBao, ContextMenuStrip ctxThuMuc, PoisonToolTip toolTip)
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

            try
            {
                int i = 0;
                Browsing = new Commands.ThuMuc.DanhSachThuMuc(cauLacBo).OnNext(model =>
                {
                    if (model.ThuMucGoc) ThuMucGoc = model;

                    FolderItem thuMuc = new FolderItem(model, ctxThuMuc, toolTip, i);
                    if (SelectedModel != null)
                        thuMuc.Open = model.MaThuMuc == SelectedModel.MaThuMuc;
                    thuMuc.Click += ThuMuc_Click;

                    Cts.Token.ThrowIfCancellationRequested();
                    if (IsHandleCreated) Invoke(new Action(() =>
                    {
                        Models.Add(model);
                        flowLayoutPanel2.Controls.Add(thuMuc);
                    }));
                    i++;
                }).Execute(Cts.Token);
                await Browsing;
            }
            catch (OperationCanceledException) { }
            catch (Exception exc)
            {
                hopThongBao.Alert(LuuTruRes.DanhSachThuMuc_Duyet_Loi_1, exc.Message);
            }
            finally
            {
                Cts.Dispose();
            }
        }

        public async Task Cancel()
        {
            if (Browsing == null) return;
            Cts.Cancel();
            flowLayoutPanel2.Controls.Clear();
            await Browsing;
            Cts.Dispose();
        }

        public void Clear(bool clearSelection = false)
        {
            Models.Clear();
            if (clearSelection) SelectedModel = null;
            flowLayoutPanel2.Controls.Clear();
        }

        private void ThuMuc_Click(object sender, ThuMucEventArgs e)
        {
            SelectedModel = e.Model;
            ItemClick?.Invoke(this, e);
        }
    }
}
