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
using System.Configuration;

namespace Upravljanje_Ljutskim_Resursima
{

    
    public partial class Zaposlenici : Form
    {
        
        public Zaposlenici()
        {
            InitializeComponent();
        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zAPOSLENICIDBDataSet.ZaposlenikTable' table. You can move, or remove it, as needed.
            this.zaposlenikTableTableAdapter.Fill(this.zAPOSLENICIDBDataSet.ZaposlenikTable);
            Greska.Visible = false;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zaposlenici.ActiveForm.Hide();
            GlavnaRadnaPloca glavnaradnaploca = new GlavnaRadnaPloca();
            glavnaradnaploca.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrEmpty(BrojMobitelaZaposlenika.Text) || String.IsNullOrEmpty(ImeZaposlenika.Text) || String.IsNullOrEmpty(PrezimeZaposlenika.Text)|| SoplZaposlenika.SelectedIndex == 0
                || ObrazovanjeZaposlenika.SelectedIndex == 0 || PozicijaZaposlenika.SelectedIndex == 0 || String.IsNullOrEmpty(AdresaZaposlenika.Text))
            {              
               Greska.Visible = true;
            }
            else
            {
               
                this.zaposlenikTableBindingSource.AddNew();
                this.dataGridView1.DataSource = this.zaposlenikTableBindingSource;
                Greska.Visible = false;
            }
            
        }

       
    }
}
