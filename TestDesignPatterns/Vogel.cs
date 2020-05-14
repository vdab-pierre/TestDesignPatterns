using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns
{
    public class Vogel : Inwoner
    {
        public Vogel(string soort, string naam)
            : base(soort, naam) { }

        // reactie op vulkaanuitbarsting
        public override void ReageerOpUitbarsting()
        {
            Console.WriteLine($"Vogel{Naam} vliegt hoger.");
        }
    }
}
