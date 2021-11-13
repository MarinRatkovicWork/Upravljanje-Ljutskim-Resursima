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
    public partial class Prijava : Form
    {
        
        public Prijava()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KorisnikIdTB.Clear();
            LozinkaIdTB.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
