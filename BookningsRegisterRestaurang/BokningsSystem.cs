using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookningsRegisterRestaurang
{
    internal class BokningsSystem
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public TimeSpan Tid { get; set; }
        public int AntalGäster { get; set; }

        public static List<BokningsSystem> bokningsSystems = new List<BokningsSystem>();

        public BokningsSystem(int id, DateTime DateTime, TimeSpan tid, int antalGäster)
        {
            Id = id;
            Datum = DateTime.Now;
            Tid = tid;
            AntalGäster = antalGäster;
        }
    }
}
