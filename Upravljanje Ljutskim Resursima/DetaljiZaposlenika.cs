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
    public partial class DetaljiZaposlenika : Form
    {
        public DetaljiZaposlenika()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetaljiZaposlenika.ActiveForm.Hide();
            GlavnaRadnaPloca glavnaradnaploca = new GlavnaRadnaPloca();
            glavnaradnaploca.Show();
        }

        private void DetaljiZaposlenika_Load(object sender, EventArgs e)
        {

        }
    }
}
