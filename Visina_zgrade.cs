using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visina_zgrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Neboder neboder = new Neboder();
                neboder.BrojKatova1 = Convert.ToInt32(txtBrojKatova.Text);  //Prebacujemo broj katova u int
                textBox1.Text = neboder.IzracunajVisinu(neboder.BrojKatova1).ToString();
            }
            catch 
            {
                MessageBox.Show("Upisali ste pogrešan format!", "Greška unosa!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);    //Ako upišemo slovo ili ako ostavimo prazno izbacuje nam grešku
            }
        }
    }
}