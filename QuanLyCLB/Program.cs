using QuanLyCLB.BaiViet;
using QuanLyCLB.TrinhDoc;
using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Properties;

namespace QuanLyCLB
{
    static class Program
    {
        public static event EventHandler<ThemeChangedEventArgs> ThemeChanged;

        public static void InvokeThemeChanged()
        {
            ThemeChanged?.Invoke(null, new ThemeChangedEventArgs(Settings.Default.Theme, Settings.Default.Style));
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Cef.IsInitialized)
            {
                CefSettings settings = new CefSettings();
                settings.RegisterScheme(new CefCustomScheme()
                {
                    SchemeName = HandlerFactories.LuuTruScheme,
                    DomainName = HandlerFactories.LuuTruDomain,
                    SchemeHandlerFactory = HandlerFactories.LuuTruHandlerFactory
                });
                settings.RegisterScheme(new CefCustomScheme()
                {
                    SchemeName = HandlerFactories.SoanBaiVietScheme,
                    DomainName = HandlerFactories.SoanBaiVietDomain,
                    SchemeHandlerFactory = HandlerFactories.SoanBaiVietHandlerFactory
                });
                Cef.Initialize(settings);
            }

            Application.Run(new DangNhap.DangNhap());
        }
    }

    public static class HandlerFactories
    {
        public const string LuuTruScheme = "luutru";
        public const string LuuTruDomain = "preview";
        public const string SoanBaiVietScheme = "soanbaiviet";
        public const string SoanBaiVietDomain = "preview";
        public const string LuuTruFullPath = LuuTruScheme + "://" + LuuTruDomain + "/";
        public const string SoanBaiVietFullPath = SoanBaiVietScheme + "://" + SoanBaiVietDomain + "/";

        public static LuuTruHandlerFactory LuuTruHandlerFactory { get; } = new LuuTruHandlerFactory();
        public static SoanBaiVietHandlerFactory SoanBaiVietHandlerFactory { get; } = new SoanBaiVietHandlerFactory();
    }
}
