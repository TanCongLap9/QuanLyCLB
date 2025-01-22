using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Utils
{
    public static class ImageUtils
    {
        public static Image GetThumbnailImage(Stream stream, Size size, Image fallback)
        {
            try
            {
                using (Image image = Image.FromStream(stream))
                {
                    return GetThumbnailImage(image, size, fallback);
                }
            }
            catch { return fallback; }
        }
        
        public static Image GetThumbnailImage(Image image, Size size)
        {
            Image.GetThumbnailImageAbort abort = new Image.GetThumbnailImageAbort(() => false);
            double pictureAspectRatio = image.Width / (double)image.Height;
            Image thumb;
            if (pictureAspectRatio >= 1)
                thumb = image.GetThumbnailImage((int)(size.Width * pictureAspectRatio), size.Height, abort, IntPtr.Zero);
            else
                thumb = image.GetThumbnailImage(size.Width, (int)(size.Height / pictureAspectRatio), abort, IntPtr.Zero);
            Bitmap thumbnail = new Bitmap(size.Width, size.Height);
            Graphics graphics = Graphics.FromImage(thumbnail);
            graphics.DrawImage(thumb, new Point((size.Width - thumb.Width) / 2, (size.Height - thumb.Height) / 2));
            return thumbnail;
        }
        
        public static Image GetThumbnailImage(Image image, Size size, Image fallback)
        {
            try
            {
                return GetThumbnailImage(image, size);
            }
            catch { return fallback; }
        }

        public static List<Image> GetThumbnailImages(Stream stream, List<Size> sizes, List<Image> fallbacks)
        {
            List<Image> thumbs = new List<Image>();
            try
            {
                using (Image image = Image.FromStream(stream))
                {
                    for (int i = 0; i < sizes.Count; i++)
                    {
                        Size size = sizes[i];
                        thumbs.Add(GetThumbnailImage(image, size, fallbacks[i]));
                    }
                }
            }
            catch { return fallbacks; }
            return thumbs;
        }

        public static Image GetNguoiDungImage(NguoiDungModel model, Size size)
        {
            return GetNguoiDungImage(model.AnhDaiDien, size);
        }

        public static Image GetNguoiDungImage(Stream anhDaiDien, Size size)
        {
            if (anhDaiDien == null) return Resources.user_info_2;
            else return GetThumbnailImage(anhDaiDien, size, Resources.user_info_2);
        }

        public static Image GetCauLacBoImage(CauLacBoModel model, Size size)
        {
            if (model.AnhDaiDien == null) return Resources.edit_group;
            else return GetThumbnailImage(model.AnhDaiDien, size, Resources.edit_group);
        }
    }
}
