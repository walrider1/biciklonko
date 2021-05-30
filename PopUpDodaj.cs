using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biciklino
{
    public partial class PopUpDodaj : Form
    {
        int selectedItem;
        Ram ram = new Ram();

        string[] velicina = { "XS", "S", "M", "L", "XL", "XXL" };


        public PopUpDodaj()
        {
            InitializeComponent();

            biciklino = new BiciklinoEntities1();
        }

        private readonly BiciklinoEntities1 biciklino;

        private void PopUpDodaj_Load(object sender, EventArgs e)
        {
            var vrsta = biciklino.Delovis.ToList();
            comboBoxKategorija.DisplayMember = "Deo";
            comboBoxKategorija.ValueMember = "id";
            comboBoxKategorija.DataSource = vrsta;
        }



        private void comboBoxProizvodjac_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddNewMajek(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = comboBoxKategorija.SelectedIndex;

            
            switch (selectedItem)
            {
                case 0:
                    foreach (string x in ram.Velicina)
                    {
                        comboBoxKategorija.Items.Add(x);
                    }
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:

                    break;
                case 12:

                    break;

            }
            
        }
    }
}
