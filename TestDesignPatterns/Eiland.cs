using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns
{
    public class Eiland
    {
        public List<Inwoner> InwonersEiland;
        InwonerFactory deInwonerFactory = InwonerFactory.GetFactory();

        // ervoor zorgen dat het eiland niet dubbel kan gemaakt worden
        // singleton design pattern
        private static Eiland diertjesEiland;
        private Eiland()
        {
            InwonersEiland = InlezenInwoners();
            Console.WriteLine("Welkom op Diertjeseiland.");
        }
        public static Eiland GetEiland()
        {
            if (diertjesEiland == null)
            {
                diertjesEiland = new Eiland();
            }
            return diertjesEiland;
        }

        public List<Inwoner> InlezenInwoners()
        {
            var inwoners = new List<Inwoner>();
            // De textfile inlezen, de inwoner aanmaken en toevoegen aan de lijst
            using(System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\saart\Documents\Cursussen en opleidingen\C# opleiding_VDAB\8 Design Patterns\Inwoners.txt"))
            {
                string lijnInwoner;
                while ((lijnInwoner = reader.ReadLine()) != null)
                {
                    string[] values = lijnInwoner.Split(',');
                    inwoners.Add(deInwonerFactory.MaakInwoner(values[0], values[1]));
                }
            }
            return inwoners;
        }

        public void Uitbarsting()
        {
            foreach (Inwoner inwoner in InwonersEiland)
            {
                inwoner.ReageerOpUitbarsting();
            }
        }
    }
}
