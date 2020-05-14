using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns
{
    public class InwonerFactory
    {
        // ervoor zorgen dat de factory niet dubbel kan gemaakt worden
        // singleton design pattern
        private static InwonerFactory factory;
        private InwonerFactory() { }
        public static InwonerFactory GetFactory()
        {
            if (factory == null)
            {
                factory = new InwonerFactory();
            }
            return factory;
        }

        // de correctie inwoner maken via deze method
        // simple factory design pattern
        public Inwoner MaakInwoner(string soort, string naam)
        {
            switch (soort)
            {
                case "V":
                    return new Vogel(soort, naam);
                case "Z":
                    return new Zoogdier(soort, naam);
                default:
                    throw new Exception("Geen gekende soort inwoner.");
            }          
        }
    }
}
