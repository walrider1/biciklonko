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
    public partial class DodajNovogProizv : Form
    {

        SqlConnection con = new SqlConnection("Integrated Security=true; Initial Catalog=Biciklino; Data Source=.\\SQLExpress");

        public DodajNovogProizv()
        {
            InitializeComponent();
        }

        private void DodajNovogProizv_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Proizvodjac (Proizvodjac)Values('" + textBox1.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
