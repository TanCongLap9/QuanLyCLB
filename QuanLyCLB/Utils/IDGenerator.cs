using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Utils
{
    public static class IDGenerator
    {
        private static Random random = new Random();
        private static string pattern = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string Generate(IDType kieuID)
        {
            switch (kieuID)
            {
                case IDType.ThuMuc:
                    return GetRandomString(9) + "P";
                case IDType.NguoiDung:
                    return GetRandomString(9) + "U";
                case IDType.DiemDanh:
                    return GetRandomString(9) + "D";
                case IDType.Lich:
                    return GetRandomString(9) + "L";
                case IDType.File:
                    return GetRandomString(9) + "F";
                case IDType.QuyenHan:
                    return GetRandomString(9) + "Q";
                case IDType.ThongBao:
                    return GetRandomString(9) + "T";
                case IDType.BaiViet:
                    return GetRandomString(9) + "V";
                case IDType.KieuLich:
                    return GetRandomString(8) + "KL";
                case IDType.TheLoaiBaiViet:
                    return GetRandomString(19) + "M";
                case IDType.CauLacBo:
                    return GetRandomString(7) + "CLB";
            }
            return "";
        }

        private static string GetRandomString(int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < length; i++)
                result.Append(pattern[random.Next(pattern.Length)]);
            return result.ToString();
        }

        public enum IDType
        {
            ThuMuc, NguoiDung, DiemDanh, Lich, File, QuyenHan, ThongBao, CauLacBo, BaiViet, TheLoaiBaiViet, KieuLich
        }
    }
}
