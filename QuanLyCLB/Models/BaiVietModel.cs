using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCLB.Models
{
    public class BaiVietModel : Model<BaiVietModel>
    {
        public string MaBaiViet { get; set; }
        public string MaTacGia { get; set; }
        public string Ho { get; private set; }
        public string Lot { get; private set; }
        public string Ten { get; private set; }
        public string MaCLB { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public string CacNhan { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }

        [Browsable(false)]
        public string HoTen { get { return $"{Ho}{(string.IsNullOrEmpty(Lot) ? "" : $" {Lot}")} {Ten}"; } }
        [Browsable(false)]
        public string NgayTaoChuoi { get { return ThoiGianTao.ToString("dd/MM/yyyy"); } }

        public override string ToString()
        {
            return MaBaiViet.ToString();
        }

        public override BaiVietModel FromDataReader(SqlDataReader reader)
        {
            List<string> columns = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
                columns.Add(reader.GetName(i));
            if (columns.Contains("MaBaiViet"))
                MaBaiViet = reader.GetString(reader.GetOrdinal("MaBaiViet"));
            if (columns.Contains("MaTacGia"))
                MaTacGia = reader.GetString(reader.GetOrdinal("MaTacGia"));
            if (columns.Contains("Ho"))
                Ho = reader.GetString(reader.GetOrdinal("Ho"));
            if (columns.Contains("Lot"))
                Lot = reader.GetString(reader.GetOrdinal("Lot"));
            if (columns.Contains("Ten"))
                Ten = reader.GetString(reader.GetOrdinal("Ten"));
            if (columns.Contains("MaCLB"))
                MaCLB = reader.GetString(reader.GetOrdinal("MaCLB"));
            if (columns.Contains("ThoiGianTao"))
                ThoiGianTao = reader.GetDateTime(reader.GetOrdinal("ThoiGianTao"));
            if (columns.Contains("CacNhan"))
                CacNhan = reader.GetString(reader.GetOrdinal("CacNhan"));
            if (columns.Contains("TieuDe"))
                TieuDe = reader.GetString(reader.GetOrdinal("TieuDe"));
            if (columns.Contains("NoiDung"))
                NoiDung = reader.GetString(reader.GetOrdinal("NoiDung"));
            return this;
        }
    }
}
