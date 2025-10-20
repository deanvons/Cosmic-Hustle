using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Models
{
    public class Ledger
    {
        public Ledger(int id)
        {
            Id = id;
            LedgerEntries = new List<LedgerEntry>(); // same situation composition
        }

        public int Id { get; set; }
        public List<LedgerEntry> LedgerEntries { get; set; }


    }
}
