using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookningsRegisterRestaurang
{
    internal class Kund
    {
        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Telefonnummer { get; set; }
        public string Epost { get; set; }
        public Kund(int id, string förnamn, string efternamn, string telefonnummer, string epost)
        {
            Id = id;
            Förnamn = förnamn;
            Efternamn = efternamn;
            Telefonnummer = telefonnummer;
            Epost = epost;
        }
    }
}
