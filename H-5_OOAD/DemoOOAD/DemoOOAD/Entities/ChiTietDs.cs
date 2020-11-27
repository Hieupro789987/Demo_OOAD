using System;
using System.Collections.Generic;

namespace DemoOOAD.Entities
{
    public partial class ChiTietDs
    {
        public string MaCt { get; set; }
        public string MaMa { get; set; }
        public string MaDs { get; set; }

        public virtual DanhSachMa MaDsNavigation { get; set; }
        public virtual MonAn MaMaNavigation { get; set; }
    }
}
