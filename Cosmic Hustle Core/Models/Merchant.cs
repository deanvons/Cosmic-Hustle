using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Models
{
    public class Merchant
    {
        public Merchant()
        {

        }
        public Merchant(int id, string name)
        {
            Id = id;
            Name = name;
            Ledger = new Ledger(id); // this form of coupling is ok, composition, but could defer to factory pattern for SOC
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Ledger Ledger { get; set; }

    }
}
