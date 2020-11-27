using System;
using System.Collections.Generic;

namespace DemoOOAD.Entities
{
    public partial class ChiTietHd
    {
        public string MaCthd { get; set; }
        public string MaMa { get; set; }
        public int SoLuong { get; set; }
        public int TinhTrang { get; set; }
        public string MaHd { get; set; }

        public virtual HoaDon MaHdNavigation { get; set; }
        public virtual MonAn MaMaNavigation { get; set; }
    }
}
