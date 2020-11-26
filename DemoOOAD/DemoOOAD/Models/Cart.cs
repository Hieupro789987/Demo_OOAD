using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DemoOOAD.Models
{
    public class Cart
    {
        public string MaMA { get; set; }
        public string Ten { get; set; }
        public string Hinh { get; set; }
        public int Gia { get; set; }
        public int soluong { get; set; }
        public double ThanhTien => soluong * Gia;
    }
    
}
