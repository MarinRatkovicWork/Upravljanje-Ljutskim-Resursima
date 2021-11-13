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
    public partial class GlavnaRadnaPloca : Form
    {
        Zaposlenici zaposlenici = new Zaposlenici();
        DetaljiZaposlenika detaljizaposlenika = new DetaljiZaposlenika();
        Placa placa = new Placa();
        Prijava prijava = new Prijava();

        public GlavnaRadnaPloca()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GlavnaRadnaPloca.ActiveForm.Hide();
            zaposlenici.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            GlavnaRadnaPloca.ActiveForm.Hide();
            zaposlenici.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GlavnaRadnaPloca.ActiveForm.Hide();
            detaljizaposlenika.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            GlavnaRadnaPloca.ActiveForm.Hide();
            detaljizaposlenika.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GlavnaRadnaPloca.ActiveForm.Hide();
            placa.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            GlavnaRadnaPloca.ActiveForm.Hide();
            placa.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GlavnaRadnaPloca.ActiveForm.Hide();
            prijava.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GlavnaRadnaPloca.ActiveForm.Hide();
            prijava.Show();
        }
    }
}
