using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Models
{
    public class LichModel : Model<LichModel>
    {
        public LichModel() { }

        public string MaLich { get; set; }
        public string MaCLB { get; set; }
        public string MaLoaiLich { get; set; }
        public string TenLoaiLich { get; set; }
        public string ChuDe { get; set; }
        public string DiaDiem { get; set; }
        public CheDoLapLai LapLai { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public TimeSpan ThoiGianBatDau { get; set; }
        public TimeSpan ThoiGianKetThuc { get; set; }
        public string NoiDung { get; set; }
        public int MaMau { get; set; }

        public override string ToString()
        {
            return MaLich;
        }

        public override LichModel FromDataReader(SqlDataReader reader)
        {
            List<string> columns = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
                columns.Add(reader.GetName(i));
            if (columns.Contains("MaLich"))
                MaLich = reader.GetString(reader.GetOrdinal("MaLich"));
            if (columns.Contains("MaLoaiLich"))
                MaLoaiLich = reader.GetString(reader.GetOrdinal("MaLoaiLich"));
            if (columns.Contains("TenLoaiLich"))
                TenLoaiLich = reader.GetString(reader.GetOrdinal("TenLoaiLich"));
            if (columns.Contains("ChuDe"))
                ChuDe = reader.GetString(reader.GetOrdinal("ChuDe"));
            if (columns.Contains("DiaDiem"))
                DiaDiem = reader.GetString(reader.GetOrdinal("DiaDiem"));
            if (columns.Contains("LapLai"))
                LapLai = (CheDoLapLai)reader.GetByte(reader.GetOrdinal("LapLai"));
            if (columns.Contains("NgayBatDau"))
                NgayBatDau = reader.GetDateTime(reader.GetOrdinal("NgayBatDau"));
            if (columns.Contains("NgayKetThuc"))
                NgayKetThuc = reader.GetDateTime(reader.GetOrdinal("NgayKetThuc"));
            if (columns.Contains("ThoiGianBatDau"))
                ThoiGianBatDau = reader.GetTimeSpan(reader.GetOrdinal("ThoiGianBatDau"));
            if (columns.Contains("ThoiGianKetThuc"))
                ThoiGianKetThuc = reader.GetTimeSpan(reader.GetOrdinal("ThoiGianKetThuc"));
            if (columns.Contains("NoiDung"))
                NoiDung = reader.GetString(reader.GetOrdinal("NoiDung"));
            if (columns.Contains("MaMau"))
                MaMau = reader.GetInt32(reader.GetOrdinal("MaMau"));
            return this;
        }
    }

    public enum CheDoLapLai : byte
    {
        KhongLap, MoiNgay, Moi2Ngay, Moi3Ngay, Moi4Ngay, Moi5Ngay, Moi6Ngay, MoiTuan, MoiThang
    }
}
