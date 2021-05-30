using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Biciklino
{
    public partial class Form1 : Form
    {
        
        SqlConnection con = new SqlConnection("Integrated Security=true; Initial Catalog=Biciklino; Data Source=.\\SQLExpress");

        private readonly BiciklinoEntities1 biciklino;
        public Form1()
        {
            InitializeComponent();
            biciklino = new BiciklinoEntities1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var vrsta = biciklino.Delovis.ToList();
            comboBoxKategorija.DisplayMember = "Deo";
            comboBoxKategorija.ValueMember = "id";
            comboBoxKategorija.DataSource = vrsta;
            UpdateBase();
        }

        private void kalkulatorPP_Click(object sender, EventArgs e)
        {
            PopupCalc popup = new PopupCalc();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void buttonDodajDeo_Click(object sender, EventArgs e)
        {
            PopUpDodaj oglas = new PopUpDodaj();
            oglas.Show();
        }

        #region 
        private void labelKategorija_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
              Color.DimGray, 1, ButtonBorderStyle.Solid, // left
              Color.DimGray, 1, ButtonBorderStyle.Solid, // top
              Color.DimGray, 1, ButtonBorderStyle.Solid, // right
              Color.DimGray, 1, ButtonBorderStyle.Solid);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void labelNazivOglasa_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateBase()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select NazivOglasa from NoviDeo", con);
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
