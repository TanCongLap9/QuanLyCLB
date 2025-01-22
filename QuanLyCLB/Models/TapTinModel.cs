using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Models
{
    public class TapTinModel : Model<TapTinModel>
    {
        public Guid MaTapTin { get; set; }
        public string TenTapTin { get; set; }
        public Stream NoiDung { get; set; }
        public string MimeType { get; private set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianSuaDoi { get; set; }
	    public DateTime ThoiGianTruyCap { get; set; }
        public string PhanMoRong { get; private set; }
        public long DungLuong { get; private set; }
        public string MaThuMuc { get; set; }

        public override string ToString()
        {
            return MaTapTin.ToString();
        }

        /// <summary>
        /// Gets model from <see cref="SqlDataReader"/>.
        /// </summary>
        public override TapTinModel FromDataReader(SqlDataReader reader)
        {
            List<string> columns = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
                columns.Add(reader.GetName(i));
            if (columns.Contains("MaTapTin"))
                MaTapTin = reader.GetGuid(reader.GetOrdinal("MaTapTin"));
            if (columns.Contains("TenTapTin"))
                TenTapTin = reader.GetString(reader.GetOrdinal("TenTapTin"));
            if (columns.Contains("ThoiGianTao"))
                ThoiGianTao = reader.GetDateTime(reader.GetOrdinal("ThoiGianTao"));
            if (columns.Contains("ThoiGianSuaDoi"))
                ThoiGianSuaDoi = reader.GetDateTime(reader.GetOrdinal("ThoiGianSuaDoi"));
            if (columns.Contains("ThoiGianTruyCap"))
                ThoiGianTruyCap = reader.GetDateTime(reader.GetOrdinal("ThoiGianTruyCap"));
            if (columns.Contains("PhanMoRong"))
                PhanMoRong = reader.GetString(reader.GetOrdinal("PhanMoRong"));
            if (columns.Contains("MimeType"))
                MimeType = reader.GetString(reader.GetOrdinal("MimeType"));
            if (columns.Contains("DungLuong"))
                DungLuong = reader.GetInt64(reader.GetOrdinal("DungLuong"));
            if (columns.Contains("MaThuMuc"))
                MaThuMuc = reader.GetString(reader.GetOrdinal("MaThuMuc"));
            if (columns.Contains("NoiDung"))
                NoiDung = reader.GetStream(reader.GetOrdinal("NoiDung"));
            return this;
        }
    }
}
