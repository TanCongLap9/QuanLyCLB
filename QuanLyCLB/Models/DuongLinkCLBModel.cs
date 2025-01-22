using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Models
{
    public class DuongLinkCLBModel : Model<DuongLinkCLBModel>
    {
        public DuongLinkCLBModel() { }

        public string MaCLB { get; set; }
        public int MaLienKet { get; set; }
        public string NenTang { get; set; }
        public string DuongLienKet { get; set; }

        public override string ToString()
        {
            return MaLienKet.ToString();
        }

        /// <summary>
        /// Gets model from <see cref="SqlDataReader"/>.
        /// </summary>
        public override DuongLinkCLBModel FromDataReader(SqlDataReader reader)
        {
            MaCLB = reader.GetString(reader.GetOrdinal("MaCLB"));
            MaLienKet = reader.GetInt32(reader.GetOrdinal("MaLienKet"));
            NenTang = reader.GetString(reader.GetOrdinal("NenTang"));
            DuongLienKet = reader.GetString(reader.GetOrdinal("DuongLienKet"));
            return this;
        }
    }
}
