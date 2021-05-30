using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklino
{
    class Grupa
    {
        public string[] brojBrzinaZadnjiMenjac = { "7s", "8s", "9s", "10s", "11s", "12s" };
        public string[] brojBrzinaNapred = { "1", "2", "3" };

        public string[] BrojBRZnapred()
        {
            return brojBrzinaNapred;
        }

        public string[] BrojBRZnazad()
        {
            return brojBrzinaZadnjiMenjac;
        }
    }
}
