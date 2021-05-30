using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklino
{
    class PrednjiAmortizer
    {
        public string[] vrsta = { "Opruga", "Vazduh" };
        public string[] velicinaTocka = { "24", "26", "27.5", "28", "29" };
        public string[] dimezijaPNable = { "15x100", "15x110 Boost", "20x110 Non-Boost", "20x110 Boost" };
        public string[] hodAmortizera = {"100mm", "110mm", "120mm", "130mm", "140mm", "150mm", "160mm", "170mm", "180mm", "190mm", "200mm" };
        public double duzinaVrata;
        public string[] vrstaVrata = { "Tapered", "Straight 1 1/8", "Straight 1.5" };

        #region
        public string[] Vrsta()
        {
            return vrsta;
        }

        public string[] VelicinaTocka()
        {
            return velicinaTocka;
        }

        public string[] Pnabla()
        {
            return dimezijaPNable;
        }

        public string[] Hod()
        {
            return hodAmortizera;
        }

        public string[] Vrat()
        {
            return vrstaVrata;
        }
        #endregion
    }
}
