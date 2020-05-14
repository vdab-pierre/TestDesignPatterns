using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns
{
    public abstract class Inwoner
    {
        public string Soort { get; set; }
        public string Naam { get; set; }

        protected Inwoner(string soort, string naam)
        {
            Soort = soort;
            Naam = naam;
        }

        // reactie op vulkaanuitbarsting
        public abstract void ReageerOpUitbarsting();
    }
}
