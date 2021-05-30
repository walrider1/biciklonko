using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklino
{
    class Kurble
    {
        public string[] duzinaKurble = {"165mm", "170mm", "175mm"};
        public string[] brojBrzina = { "1x", "2x", "3x" };
        public string[] materijal = {"Aluminijum", "Karbon" };

        public string[] Duzina()
        {
            return duzinaKurble;
        }

        public string[] BrojBrz()
        {
            return brojBrzina;
        }

        public string[] Materijal()
        {
            return materijal;
        }
    }
}
