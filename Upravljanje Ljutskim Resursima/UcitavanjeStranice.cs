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
    public partial class UcitavanjeStranice : Form
    {
        public UcitavanjeStranice()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Ucitavanje.Increment(1);
            if(Ucitavanje.Value == 100)
            {
                
                Form Prijava = new Prijava();
                Prijava.Show();
                timer1.Enabled = false;
            }
        }

        private void UcitavanjeStranice_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
