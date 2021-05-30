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
    public partial class PopupCalc : Form
    {
        public PopupCalc()
        {
            InitializeComponent();
        }

        private void PopupForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonRacunanje_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = Int32.Parse(textBox1.Text);
                double y = ((x * 1.055 + 1.5) * 1.02);
                listBox1.Items.Clear();
                if (checkBoxDovoz.Checked)
                {
                    y += 10;
                }
                listBox1.Items.Add(y);
            }
            catch(Exception s)
            {
                MessageBox.Show("Ne moze");
                textBox1.Focus();
                textBox1.SelectAll();
            }

            
            
        }

        private void checkBoxDovoz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
