using CefSharp.WinForms;
using Markdig;
using Markdown.ColorCode;
using QuanLyCLB.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.BaiViet
{
    public class Loader
    {
        private readonly ChromiumWebBrowser Browser;
        private readonly MarkdownPipeline Pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .UseSoftlineBreakAsHardlineBreak()
            .UseColorCode()
            .Build();
        private readonly BaiVietModel BaiViet;
        private string template;

        public Loader(ChromiumWebBrowser browser, BaiVietModel model)
        {
            Browser = browser;
            BaiViet = model;
        }

        public void Preview()
        {
            template = File.ReadAllText(@"BaiViet\template.html");
            string res = GetHtmlOutput();
            if (Browser.IsLoading) return;
            HandlerFactories.SoanBaiVietHandlerFactory.NoiDung = res;
            Browser.Load(HandlerFactories.SoanBaiVietFullPath);
        }

        private string GetHtmlOutput()
        {
            return template
                .Replace("{post.title}", BaiViet.TieuDe)
                .Replace("{post.body}", Markdig.Markdown.ToHtml(BaiViet.NoiDung, Pipeline))
                .Replace("{post.date}", BaiViet.ThoiGianTao.ToString("dd/MM/yyyy"))
                .Replace("{post.author}", BaiViet.HoTen);
        }
    }
}
