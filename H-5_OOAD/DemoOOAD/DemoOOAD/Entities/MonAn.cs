using System;
using System.Collections.Generic;

namespace DemoOOAD.Entities
{
    public partial class MonAn
    {
        public MonAn()
        {
            ChiTietDs = new HashSet<ChiTietDs>();
            ChiTietHd = new HashSet<ChiTietHd>();
            Hinh = new HashSet<Hinh>();
        }

        public string MaMa { get; set; }
        public string Ten { get; set; }
        public int Gia { get; set; }
        public string MaLoai { get; set; }
        public string Mota { get; set; }
        public string MaDs { get; set; }

        public virtual LoaiMa MaLoaiNavigation { get; set; }
        public virtual ICollection<ChiTietDs> ChiTietDs { get; set; }
        public virtual ICollection<ChiTietHd> ChiTietHd { get; set; }
        public virtual ICollection<Hinh> Hinh { get; set; }
    }
}
