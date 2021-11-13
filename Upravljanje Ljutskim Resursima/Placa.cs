using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upravljanje_Ljutskim_Resursima
{
    public partial class Placa : Form
    {
        public Placa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Placa.ActiveForm.Hide();
            GlavnaRadnaPloca glavnaradnaploca = new GlavnaRadnaPloca();
            glavnaradnaploca.Show();
        }
    }
}
