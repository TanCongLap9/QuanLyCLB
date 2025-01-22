using QuanLyCLB.Properties;
using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using QuanLyCLB.Models;
using System.ComponentModel;
using QuanLyCLB.Commands.SoanBaiViet;
using QuanLyCLB.Utils;
using ReaLTaiizor.Enum.Poison;
using QuanLyCLB.EventArgs;

namespace QuanLyCLB.BaiViet
{
    public partial class SoanBaiViet : PoisonForm
    {
        private bool unsaved;
        private readonly Previewer previewer;
        private readonly TextBoxHistory history;
        private readonly CauLacBoModel CauLacBo;
        // When in a undoing or redoing process, prevents DelayPush and Push to record changes
        private bool lockedState = false;

        public SoanBaiViet()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            chinhBaiViet1.BringToFront();
            previewer = new Previewer(chromiumWebBrowser1, tHtml);
            history = new TextBoxHistory();
        }

        public SoanBaiViet(CauLacBoModel model)
        {
            InitializeComponent();
            CauLacBo = model;
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            chinhBaiViet1.BringToFront();
            previewer = new Previewer(chromiumWebBrowser1, tHtml);
            history = new TextBoxHistory();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            poisonStyleManager1.Theme = e.Theme;
            poisonStyleManager1.Style = e.Style;
            ColorUtils.SetColor(this, e.Theme, e.Style);
            ColorUtils.SetColor(tCode, e.Theme);
            ColorUtils.SetColor(tHtml, e.Theme);
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            GiaoDienChinh.GiaoDienChinh.CacFormDangMo.Add(this);
            ColorUtils.SetColor(this, poisonStyleManager1.Theme, poisonStyleManager1.Style);
            ColorUtils.SetColor(tCode, poisonStyleManager1.Theme);
            ColorUtils.SetColor(tHtml, poisonStyleManager1.Theme);
            history.Push(new TextBoxHistory.HistoryEntry(tCode.Text, tCode.SelectionStart, tCode.SelectionLength));
            previewer.Load();
            chenBang1.BringToFront();
            Program.ThemeChanged += OnThemeChanged;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!unsaved) return;
            DialogResult result = PoisonMessageBox.Show(this,
                BaiVietRes.SoanBaiViet_ChuaLuu_NoiDung,
                BaiVietRes.SoanBaiViet_ChuaLuu_TieuDe,
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    bSave.PerformClick();
                    e.Cancel = true;
                    break;
                case DialogResult.No:
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            GiaoDienChinh.GiaoDienChinh.CacFormDangMo.Remove(this);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private void Control_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (sender == bCut)
                    tCode.Cut();
                else if (sender == bCopy)
                    tCode.Copy();
                else if (sender == bPaste)
                    tCode.Paste();
                else if (sender == bUndo)
                {
                    lockedState = true;
                    new Undo(tCode, history).Execute();
                    lockedState = false;
                }
                else if (sender == bRedo)
                {
                    lockedState = true;
                    new Redo(tCode, history).Execute();
                    lockedState = false;
                }
                else if (sender == bFormatBold)
                    new FormatText(tCode, FormatText.Bold).Execute();
                else if (sender == bFormatItalic)
                    new FormatText(tCode, FormatText.Italic).Execute();
                else if (sender == bFormatUnderline)
                    new FormatText(tCode, FormatText.UnderlineStart, FormatText.UnderlineEnd).Execute();
                else if (sender == bFormatStrike)
                    new FormatText(tCode, FormatText.Strike).Execute();
                else if (sender == bFormatSup)
                    new FormatText(tCode, FormatText.Sup).Execute();
                else if (sender == bFormatSub)
                    new FormatText(tCode, FormatText.Sub).Execute();
                else if (sender == bCite)
                    new Cite(tCode).Execute();
                else if (sender == bBulletedList)
                    new BulletedList(tCode).Execute();
                else if (sender == bNumberedList)
                    new NumberedList(tCode).Execute();
                else if (sender == bFormatHeading)
                    new Heading(tCode).Execute();
                else if (sender == bHRule)
                    new HRule(tCode).Execute();
                else if (sender == bCode)
                    new Code(tCode).Execute();
                else if (sender == bLink)
                    new Link(tCode).Execute();
                else if (sender == chenBang1)
                    new Table(tCode, chenBang1.TableSize.Width, chenBang1.TableSize.Height).Execute();
                else if (sender == bAlignLeft)
                    new AlignText(tCode, AlignText.Left).Execute();
                else if (sender == bAlignCenter)
                    new AlignText(tCode, AlignText.Center).Execute();
                else if (sender == bAlignRight)
                    new AlignText(tCode, AlignText.Right).Execute();
                else if (sender == bAlignJustify)
                    new AlignText(tCode, AlignText.Justify).Execute();
                else if (sender == bImage)
                    new Image(tCode).Execute();
                else if (sender == bTable)
                    chenBang1.Visible = !chenBang1.Visible;
                else if (sender == bLayoutOrientation)
                {
                    if (splitContainer1.Orientation == Orientation.Horizontal)
                    {
                        bLayoutOrientation.BackgroundImage = BaiVietRes.view_split_left_right_2_16;
                        splitContainer1.Orientation = Orientation.Vertical;
                        splitContainer1.SplitterDistance = splitContainer1.Width / 2;
                    }
                    else
                    {
                        bLayoutOrientation.BackgroundImage = BaiVietRes.view_split_top_bottom_2_16;
                        splitContainer1.Orientation = Orientation.Horizontal;
                        splitContainer1.SplitterDistance = splitContainer1.Height / 2;
                    }
                }
                else if (sender == bSave)
                {
                    chinhBaiViet1.Show(tTitle.Text, tCode.Text, CauLacBo, GiaoDienChinh.GiaoDienChinh.NguoiDung);
                }
                else if (sender == bFontSettings)
                {
                    if (fontDialog1.ShowDialog() != DialogResult.OK) return;
                    tCode.Font = fontDialog1.Font;
                }
            }
            catch (Exception exc)
            {
                System.Console.WriteLine(exc);
            }
        }

        private void tCode_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                switch (e.KeyData)
                {
                    case Keys.Control | Keys.B:
                        bFormatBold.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.I:
                        bFormatItalic.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.U:
                        bFormatUnderline.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Alt | Keys.Shift | Keys.D5:
                        bFormatStrike.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.Oemplus:
                        bFormatSub.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.Shift | Keys.Oemplus:
                        bFormatSup.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.L:
                        bAlignLeft.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.E:
                        bAlignCenter.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.R:
                        bAlignRight.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.H:
                        bFormatHeading.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.J:
                        bAlignJustify.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.Z:
                        lockedState = true;
                        new Undo(tCode, history).Execute();
                        lockedState = false;
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.Y:
                    case Keys.Control | Keys.Shift | Keys.Z:
                        lockedState = true;
                        new Redo(tCode, history).Execute();
                        lockedState = false;
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Tab:
                        new Tab(tCode).Execute();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Shift | Keys.Tab:
                        new Untab(tCode).Execute();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Control | Keys.K:
                        bLink.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Enter:
                        new Enter(tCode).Execute();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Shift | Keys.Enter:
                        new ShiftEnter(tCode).Execute();
                        e.SuppressKeyPress = true;
                        break;
                }
            }
            catch (Exception exc)
            {
                System.Console.WriteLine(exc);
            }
        }

        private void chromiumWebBrowser1_IsBrowserInitializedChanged(object sender, System.EventArgs e)
        {
            if (chromiumWebBrowser1.IsBrowserInitialized)
                previewer.Preview(tTitle.Text, tCode.Text);
        }

        private void Control_TextChanged(object sender, System.EventArgs e)
        {
            if (chinhBaiViet1.Visible) chinhBaiViet1.Update(tTitle.Text, tCode.Text);
            if (this.Text != tTitle.Text) this.Text = tTitle.Text;
            unsaved = true;
            previewer.DelayPreview(tTitle.Text, tCode.Text);
            if (!lockedState) history.DelayPush(new TextBoxHistory.HistoryEntry(tCode.Text, tCode.SelectionStart, tCode.SelectionLength));
        }

        private void chinhBaiViet1_GuiThanhCong(object sender, System.EventArgs e)
        {
            unsaved = false;
            Close();
        }
    }
}
