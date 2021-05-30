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
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    for (int x = 0; x < ram.Materijal().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }

                    break;



                case 1:
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    break;
                case 2:
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    break;
                case 3:
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    break;
                case 4:
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    break;
                case 5:
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    break;
                case 6:
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    break;
                case 7:
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    break;
                case 8:
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    break;
                case 9:
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        comboBox3.DataSource = null;

                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
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
