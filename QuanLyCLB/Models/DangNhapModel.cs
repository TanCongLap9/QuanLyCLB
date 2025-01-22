using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Models
{
    public class DangNhapModel : Model<DangNhapModel>
    {
        public DangNhapModel() { }

        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
    }
}
