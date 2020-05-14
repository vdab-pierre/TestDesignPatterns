using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns
{
    public class Zoogdier : Inwoner
    {
        public Zoogdier(string soort, string naam)
        : base(soort, naam) { }

        // reactie op vulkaanuitbarsting
        public override void ReageerOpUitbarsting()
        {
            Console.WriteLine($"Zoogdier{Naam} schuilt in zijn hol.");
        }
    }
}
