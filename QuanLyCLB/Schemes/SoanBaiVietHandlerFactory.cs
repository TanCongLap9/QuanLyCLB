using CefSharp;

namespace QuanLyCLB.BaiViet
{
    public class SoanBaiVietHandlerFactory : ISchemeHandlerFactory
    {
        public string NoiDung { get; set; }

        public IResourceHandler Create(IBrowser browser, IFrame frame, string schemeName, IRequest request)
        {
            if (request.Url == HandlerFactories.SoanBaiVietFullPath)
                return ResourceHandler.FromString(NoiDung);
            throw new System.ArgumentException("Invalid schemeName: " + schemeName);
        }
    }
}
