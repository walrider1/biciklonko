using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklino
{
    class Korman
    {
        string[] sirinaKorman = {"720mm", "730mm", "740mm", "750mm", "760mm", "770mm", "780mm", "790mm", "800mm" };
        string[] debljinaKormana = { "25.4mm", "31.8mm", "35mm" };
        string[] materijal = { "Celik", "Aluminijum", "Karbon" };

        public string[] SirinaKormana()
        {
            return sirinaKorman;
        }

        public string[] Debljina()
        {
            return debljinaKormana;
        }
        public string[] Materijal()
        {
            return materijal;
        }
    }
}
