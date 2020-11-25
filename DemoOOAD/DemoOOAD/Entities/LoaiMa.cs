using System;
using System.Collections.Generic;

namespace DemoOOAD.Entities
{
    public partial class LoaiMa
    {
        public LoaiMa()
        {
            MonAn = new HashSet<MonAn>();
        }

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<MonAn> MonAn { get; set; }
    }
}
