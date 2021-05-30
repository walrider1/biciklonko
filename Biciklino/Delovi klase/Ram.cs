using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciklino
{
    class Ram
    {


        public string[] velicina = {"XS", "S", "M", "L", "XL", "XXL"};
        public string[] materijal = {"Celik", "Aluminijum", "Karbon", "Aluminijum-Karbon", "Cr-mo"};
        public string[] vrstaVrata = {"Tapered", "Straight 1 1/8", "Straight 1.5"};
        public string[] zadnjaOsovina = {"135", "142", "148", "150", "157"};
        public string[] debljinaZO = { "9mm", "10mm", "12mm"};
        public string[] debljinaSticne = { "25.4", "27.2", "30.8", "31.6" };

        #region
        public string[] Materijal()
        {
            return materijal;
        }
        public string[] Velicina()
        {
            return velicina;
        }
        public string[] VrstaVrata() {
            return vrstaVrata;
        }
        public string[] ZadnjaOsovina() {
            return zadnjaOsovina;
        }

        public string[] DebljinaZO() {
            return debljinaZO;
        }

        public string[] DebljinaSticne() {
            return debljinaSticne;
        }
        #endregion
    }
}
/*
 * 5, 4, 10, 11, 12, 13
 * 
 * 
 * */