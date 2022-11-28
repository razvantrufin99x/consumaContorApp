using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumaContorApp
{
    public class consumator
    {
        public string nume;
        public string prenume;
        public List<contor> contoare = new List<contor>();

        public consumator() { }
        public consumator(string pnume, string pprenume) { nume = pnume;prenume = pprenume; }

    }
}
