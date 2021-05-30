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
                        label5.Text = "Velicina:";
                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                    for (int x = 0; x < ram.Materijal().Length; x++)
                    {
                        comboBox2.DataSource = null;
                        label4.Text = "Materijal:";
                        comboBox2.Items.Add(ram.materijal.GetValue(x));
                    }
                    for (int x = 0; x < ram.VrstaVrata().Length; x++)
                    {
                        comboBox4.DataSource = null;
                        label10.Text = "Vrsta vrata:";
                        comboBox4.Items.Add(ram.vrstaVrata.GetValue(x));
                    }
                    for (int x = 0; x < ram.ZadnjaOsovina().Length; x++)
                    {
                        comboBox5.DataSource = null;
                        label11.Text = "Zadnja osovina:";
                        comboBox5.Items.Add(ram.zadnjaOsovina.GetValue(x));
                    }
                    for (int x = 0; x < ram.DebljinaZO().Length; x++)
                    {
                        comboBox6.DataSource = null;
                        label12.Text = "Debljina zadnje osovine:";
                        comboBox6.Items.Add(ram.debljinaZO.GetValue(x));
                    }
                    for (int x = 0; x < ram.DebljinaSticne().Length; x++)
                    {
                        comboBox7.DataSource = null;
                        label13.Text = "Debljina sticne:";
                        comboBox7.Items.Add(ram.debljinaSticne.GetValue(x));
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
}
