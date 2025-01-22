using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Models
{
    public class CauLacBoModel : Model<CauLacBoModel>
    {
        public CauLacBoModel() { }

        public string MaCLB { get; set; }
        public string TenCLB { get; set; }
        public string MoTa { get; set; }
        public Stream AnhDaiDien { get; set; } // nullable

        public override string ToString()
        {
            return MaCLB.ToString();
        }

        /// <summary>
        /// Gets model from <see cref="SqlDataReader"/>.
        /// </summary>
        public override CauLacBoModel FromDataReader(SqlDataReader reader)
        {
            List<string> columns = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
                columns.Add(reader.GetName(i));
            if (columns.Contains("MaCLB"))
                MaCLB = reader.GetString(reader.GetOrdinal("MaCLB"));
            if (columns.Contains("TenCLB"))
                TenCLB = reader.GetString(reader.GetOrdinal("TenCLB"));
            if (columns.Contains("MoTa"))
                MoTa = reader.GetString(reader.GetOrdinal("MoTa"));
            if (columns.Contains("AnhDaiDien"))
                AnhDaiDien = reader.IsDBNull(reader.GetOrdinal("AnhDaiDien")) ? null : reader.GetStream(reader.GetOrdinal("AnhDaiDien"));
            return this;
        }
    }
}
