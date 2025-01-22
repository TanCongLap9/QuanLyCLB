using System.ComponentModel;

namespace QuanLyCLB.Console
{
    public class HelpItem
    {
        [DisplayName("Lệnh")]
        public string Lenh { get; }
        [DisplayName("Cú pháp")]
        public string CuPhap { get; }
        [DisplayName("Mô tả")]
        public string MoTa { get; }
        [DisplayName("Ví dụ")]
        public string ViDu { get; }

        public HelpItem(string lenh, string cuPhap, string moTa, string viDu = null)
        {
            Lenh = lenh;
            CuPhap = cuPhap;
            MoTa = moTa;
            ViDu = viDu;
        }
    }
}
