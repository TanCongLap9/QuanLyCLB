using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Models
{
    public class ThuMucModel : Model<ThuMucModel>
    {
        public string MaThuMuc { get; set; }
        public string TenThuMuc { get; set; }
        public bool ThuMucGoc { get; set; }
        public string MaCLB { get; set; }
        public Color MaMau { get; set; }
        public int SoLuongFile { get; private set; }

        public override string ToString()
        {
            return MaThuMuc.ToString();
        }

        public TapTinModel Clone()
        {
            return (TapTinModel)this.MemberwiseClone();
        }

        public override ThuMucModel FromDataReader(SqlDataReader reader)
        {
            List<string> columns = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
                columns.Add(reader.GetName(i));
            if (columns.Contains("MaThuMuc"))
                MaThuMuc = reader.GetString(reader.GetOrdinal("MaThuMuc"));
            if (columns.Contains("TenThuMuc"))
                TenThuMuc = reader.GetString(reader.GetOrdinal("TenThuMuc"));
            if (columns.Contains("MaMau"))
                MaMau = Color.FromArgb((0xff << 24) + reader.GetInt32(reader.GetOrdinal("MaMau")));
            if (columns.Contains("MaCLB"))
                MaCLB = reader.GetString(reader.GetOrdinal("MaCLB"));
            if (columns.Contains("ThuMucGoc"))
                ThuMucGoc = reader.GetBoolean(reader.GetOrdinal("ThuMucGoc"));
            if (columns.Contains("SoLuongFile"))
                SoLuongFile = reader.GetInt32(reader.GetOrdinal("SoLuongFile"));
            return this;
        }
    }
}
