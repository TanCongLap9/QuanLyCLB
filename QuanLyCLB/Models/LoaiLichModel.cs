using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Models
{
    public class LoaiLichModel : Model<LoaiLichModel>
    {
        public LoaiLichModel() { }

        public string MaLoaiLich { get; set; }
        public string TenLoaiLich { get; set; }
        public int MaMau { get; set; }

        public override string ToString()
        {
            return MaLoaiLich;
        }

        public override LoaiLichModel FromDataReader(SqlDataReader reader)
        {
            List<string> columns = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
                columns.Add(reader.GetName(i));
            if (columns.Contains("MaLoaiLich"))
                MaLoaiLich = reader.GetString(reader.GetOrdinal("MaLoaiLich"));
            if (columns.Contains("TenLoaiLich"))
                TenLoaiLich = reader.GetString(reader.GetOrdinal("TenLoaiLich"));
            if (columns.Contains("MaMau"))
                MaMau = reader.GetInt32(reader.GetOrdinal("MaMau"));
            return this;
        }
    }
}
