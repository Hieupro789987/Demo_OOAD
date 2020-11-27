using System;
using System.Collections.Generic;

namespace DemoOOAD.Entities
{
    public partial class Hinh
    {
        public string MaHinh { get; set; }
        public string MaMa { get; set; }
        public string DuongDan { get; set; }

        public virtual MonAn MaMaNavigation { get; set; }
    }
}
