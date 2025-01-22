using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Models
{
    public class ThongBaoModel : Model<ThongBaoModel>
    {
        public ThongBaoModel() { }

        public string MaThongBao { get; set; }
        public string TacGia { get; set; }
        public string Ho { get; private set; }
        public string Lot { get; private set; }
        public string Ten { get; private set; }
        public DateTime ThoiGianTao { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string MaCLB { get; set; }
        public string TenCLB { get; private set; }

        [Browsable(false)]
        public string HoTen { get { return $"{Ho}{(string.IsNullOrEmpty(Lot) ? "" : $" {Lot}")} {Ten}"; } }
        [Browsable(false)]
        public string ThoiGianTaoChuoi { get { return ThoiGianTao.ToString("dd/MM/yyyy HH:mm"); } }

        public override string ToString()
        {
            return MaThongBao;
        }

        public override ThongBaoModel FromDataReader(SqlDataReader reader)
        {
            List<string> columns = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
                columns.Add(reader.GetName(i));
            if (columns.Contains("MaThongBao"))
                MaThongBao = reader.GetString(reader.GetOrdinal("MaThongBao"));
            if (columns.Contains("TacGia"))
                TacGia = reader.GetString(reader.GetOrdinal("TacGia"));
            if (columns.Contains("Ho"))
                Ho = reader.GetString(reader.GetOrdinal("Ho"));
            if (columns.Contains("Lot"))
                Lot = reader.GetString(reader.GetOrdinal("Lot"));
            if (columns.Contains("Ten"))
                Ten = reader.GetString(reader.GetOrdinal("Ten"));
            if (columns.Contains("ThoiGianTao"))
                ThoiGianTao = reader.GetDateTime(reader.GetOrdinal("ThoiGianTao"));
            if (columns.Contains("TieuDe"))
                TieuDe = reader.GetString(reader.GetOrdinal("TieuDe"));
            if (columns.Contains("NoiDung"))
                NoiDung = reader.GetString(reader.GetOrdinal("NoiDung"));
            if (columns.Contains("MaCLB"))
                MaCLB = reader.GetString(reader.GetOrdinal("MaCLB"));
            if (columns.Contains("TenCLB"))
                TenCLB = reader.GetString(reader.GetOrdinal("TenCLB"));
            return this;
        }
    }
}
