using System;
using System.Collections.Generic;

namespace DemoOOAD.Entities
{
    public partial class DanhSachMa
    {
        public DanhSachMa()
        {
            ChiTietDs = new HashSet<ChiTietDs>();
        }

        public string MaDs { get; set; }
        public DateTime Ngay { get; set; }
        public string ChiNhanh { get; set; }

        public virtual ICollection<ChiTietDs> ChiTietDs { get; set; }
    }
}
