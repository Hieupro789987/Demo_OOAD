using System;
using System.Collections.Generic;

namespace DemoOOAD.Entities
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHd = new HashSet<ChiTietHd>();
        }

        public string MaHd { get; set; }
        public double TongTien { get; set; }
        public DateTime NgayMua { get; set; }
        public byte[] TinhTrang { get; set; }

        public virtual ICollection<ChiTietHd> ChiTietHd { get; set; }
    }
}
