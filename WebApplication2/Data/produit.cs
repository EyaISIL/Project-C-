using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data
{
    public class produit
    {
        public int computerID { get; set;}
        public string Brand { get; set; }
        public int Processor { get; set; }

        public int HardDisk { get; set; }
        public int MemoryRAM { get; set; }

        public int Size { get; set; }

        public int Weight { get; set; }

        public string? OS { get; set; }

        public string? Price { get; set; }

        public string? color { get; set; }
    }
}
