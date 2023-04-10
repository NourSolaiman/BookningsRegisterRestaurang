using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookningsRegisterRestaurang
{
    internal class Restaurang
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public string Adress { get; set; }
        public string Telefonnummer { get; set; }
        public Restaurang(int id, string namn, string adress, string telefonnummer)
        {
            Id = id;
            Namn = namn;
            Adress = adress;
            Telefonnummer = telefonnummer;
        }

    }
}
