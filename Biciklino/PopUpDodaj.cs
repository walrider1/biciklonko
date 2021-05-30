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
        Tockovi tockovi = new Tockovi();
        Grupa grupa = new Grupa();
        Gume gume = new Gume();
        Kaseta kaseta = new Kaseta();
        Korman korman = new Korman();

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
                        comboBox3.Items.Clear();
                    for (int x = 0; x < ram.Velicina().Length; x++)
                    {
                        label5.Text = "Velicina:";
                        comboBox3.Items.Add(ram.velicina.GetValue(x));
                    }
                        comboBox2.Items.Clear();
                    for (int x = 0; x < ram.Materijal().Length; x++)
                    {
                        label4.Text = "Materijal:";
                        comboBox2.Items.Add(ram.materijal.GetValue(x));
                    }
                        comboBox4.Items.Clear();
                    for (int x = 0; x < ram.VrstaVrata().Length; x++)
                    {
                        label10.Text = "Vrsta vrata:";
                        comboBox4.Items.Add(ram.vrstaVrata.GetValue(x));
                    }
                        comboBox5.Items.Clear();
                    for (int x = 0; x < ram.ZadnjaOsovina().Length; x++)
                    {
                        label11.Text = "Zadnja osovina:";
                        comboBox5.Items.Add(ram.zadnjaOsovina.GetValue(x));
                    }
                        comboBox6.Items.Clear();
                    for (int x = 0; x < ram.DebljinaZO().Length; x++)
                    {
                        label12.Text = "Debljina zadnje osovine:";
                        comboBox6.Items.Add(ram.debljinaZO.GetValue(x));
                    }
                        comboBox7.Items.Clear();
                    for (int x = 0; x < ram.DebljinaSticne().Length; x++)
                    {
                        label13.Text = "Debljina sticne:";
                        comboBox7.Items.Add(ram.debljinaSticne.GetValue(x));
                    }


                    break;



                case 1:
                        comboBox3.Items.Clear();
                    for (int x = 0; x < tockovi.Precnik().Length; x++)
                    {
                        label3.Text = "Precnik:";
                        comboBox3.Items.Add(tockovi.precnikTocka.GetValue(x));
                    }
                        comboBox2.Items.Clear();
                    for (int x = 0; x < tockovi.Kolicina().Length; x++)
                    {
                        label4.Text = "Kolicina:";
                        comboBox2.Items.Add(tockovi.kolicina.GetValue(x));
                    }
                        comboBox4.Items.Clear();
                    for (int x = 0; x < tockovi.Pnabla().Length; x++)
                    {
                        label10.Text = "Prednja nabla:";
                        comboBox4.Items.Add(tockovi.dimezijaPNable.GetValue(x));
                    }
                        comboBox5.Items.Clear();
                    for (int x = 0; x < tockovi.Znabla().Length; x++)
                    {
                        label11.Text = "Zadnja nabla:";
                        comboBox5.Items.Add(tockovi.dimezijeZNable.GetValue(x));
                    }
                        comboBox6.Items.Clear();
                    for (int x = 0; x < tockovi.DebljinaZO().Length; x++)
                    {
                        label12.Text = "Deblja zadnje osnovine:";
                        comboBox6.Items.Add(tockovi.debljinaZOsovine.GetValue(x));
                    }
                        comboBox7.Items.Clear();
                    for (int x = 0; x < tockovi.BrojZ().Length; x++)
                    {
                        label13.Text = "Broj zbica:";
                        comboBox7.Items.Add(tockovi.brojZbica.GetValue(x));
                    }

                    break;











                case 2:
                    comboBox3.Items.Clear();
                    for (int x = 0; x < grupa.BrojBRZnapred().Length; x++)
                    {
                        label3.Text = "Precnik:";
                        comboBox3.Items.Add(grupa.brojBrzinaZadnjiMenjac.GetValue(x));
                    }
                    comboBox2.Items.Clear();
                    for (int x = 0; x < grupa.BrojBRZnazad().Length; x++)
                    {
                        label4.Text = "Kolicina:";
                        comboBox2.Items.Add(grupa.brojBrzinaZadnjiMenjac.GetValue(x));
                    }

                    comboBox4.Visible = false;
                    label10.Visible = false;
                    comboBox5.Visible = false;
                    label11.Visible = false;
                    comboBox6.Visible = false;
                    label12.Visible = false;
                    comboBox7.Visible = false;
                    label13.Visible = false;
                    break;





                case 3:
                    comboBox3.Items.Clear();
                    for (int x = 0; x < gume.PrecnikTocka().Length; x++)
                    {
                        label3.Text = "Precnik tocka:";
                        comboBox3.Items.Add(gume.precnikTocka.GetValue(x));
                    }
                    comboBox2.Visible = false;
                    label4.Visible = false;
                    comboBox4.Visible = false;
                    label10.Visible = false;
                    comboBox5.Visible = false;
                    label11.Visible = false;
                    comboBox6.Visible = false;
                    label12.Visible = false;
                    comboBox7.Visible = false;
                    label13.Visible = false;
                    break;



                case 4:
                    comboBox3.Items.Clear();
                    for (int x = 0; x < kaseta.BrojBrz().Length; x++)
                    {
                        label3.Text = "Broj brzina:";
                        comboBox3.Items.Add(kaseta.brojBrzina.GetValue(x));
                    }
                    comboBox2.Visible = false;
                    label4.Visible = false;
                    comboBox4.Visible = false;
                    label10.Visible = false;
                    comboBox5.Visible = false;
                    label11.Visible = false;
                    comboBox6.Visible = false;
                    label12.Visible = false;
                    comboBox7.Visible = false;
                    label13.Visible = false;
                    break;




                case 5:
                    comboBox3.Items.Clear();
                    for (int x = 0; x < kaseta.BrojBrz().Length; x++)
                    {
                        label3.Text = "Broj brzina:";
                        comboBox3.Items.Add(kaseta.brojBrzina.GetValue(x));
                    }
                    break;


                case 6:
                    comboBox3.Items.Clear();
                    for (int x = 0; x < korman.SirinaKormana().Length; x++)
                    {
                        label3.Text = "Sirina kormana:";
                        comboBox3.Items.Add(korman.sirinaKorman.GetValue(x));
                    }
                    comboBox2.Items.Clear();
                    for (int x = 0; x < korman.Debljina().Length; x++)
                    {
                        label4.Text = "Debljina kormana:";
                        comboBox2.Items.Add(korman.debljinaKormana.GetValue(x));
                    }
                    comboBox4.Items.Clear();
                    for (int x = 0; x < korman.Materijal().Length; x++)
                    {
                        label10.Text = "Material:";
                        comboBox4.Items.Add(korman.materijal.GetValue(x));
                    }
                    comboBox5.Visible = false;
                    label11.Visible = false;
                    comboBox6.Visible = false;
                    label12.Visible = false;
                    comboBox7.Visible = false;
                    label13.Visible = false;
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
