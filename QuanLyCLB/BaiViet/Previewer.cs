using CefSharp;
using CefSharp.WinForms;
using Markdig;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdown.ColorCode;

namespace QuanLyCLB.BaiViet
{
    public class Previewer
    {
        private readonly ChromiumWebBrowser Browser;
        private readonly MarkdownPipeline Pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .UseSoftlineBreakAsHardlineBreak()
            .UseColorCode()
            .Build();
        private Timer timer;
        private readonly TextBox TextOutput;
        private int browserScroll;
        private string template;
        private string delayPreviewTitle;
        private string delayPreviewBody;

        public Previewer(ChromiumWebBrowser browser, TextBox textOutput)
        {
            Browser = browser;
            TextOutput = textOutput;
            timer = new Timer()
            {
                Interval = 1000
            };
            template = File.ReadAllText(@"BaiViet\template.html");
        }

        public void Load(bool events = true)
        {
            if (!events) return;
            timer.Tick += Timer_Tick;
            Browser.FrameLoadEnd += chromiumWebBrowser1_FrameLoadEnd;
        }

        public void DelayPreview(string title, string body)
        {
            delayPreviewTitle = title;
            delayPreviewBody = body;
            timer.Stop();
            timer.Start();
        }

        public void Preview(string title, string body)
        {
            delayPreviewTitle = title;
            delayPreviewBody = body;
            Timer_Tick(null, null);
        }

        private string GetHtmlOutput(string title, string body)
        {
            return template
                .Replace("{post.title}", title)
                .Replace("{post.body}", body)
                .Replace("{post.date}", DateTime.Today.ToString("dd/MM/yyyy"))
                .Replace("{post.author}", GiaoDienChinh.GiaoDienChinh.NguoiDung.HoTen);
        }

        private async void Timer_Tick(object sender, System.EventArgs e)
        {
            timer.Stop();
            string res = GetHtmlOutput(delayPreviewTitle, Markdig.Markdown.ToHtml(delayPreviewBody, Pipeline));
            TextOutput.Text = res;
            if (Browser.IsLoading) return;
            if (Browser.GetBrowser().MainFrame.Url != string.Empty)
                browserScroll = (int)(await Browser.GetMainFrame().EvaluateScriptAsync("window.scrollY")).Result;
            HandlerFactories.SoanBaiVietHandlerFactory.NoiDung = res;
            Browser.Load(HandlerFactories.SoanBaiVietFullPath);
        }

        private void chromiumWebBrowser1_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            e.Frame.EvaluateScriptAsync($"window.scroll(0, {browserScroll});");
        }
    }
}
