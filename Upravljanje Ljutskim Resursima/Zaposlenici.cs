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
            this.zaposlenikTableTableAdapter.Fill(this.zAPOSLENICIDBDataSet.ZaposlenikTable);
            Greska.Visible = false;
            DatuRođenjaZaposlenika.CustomFormat = " ";
            DatuRođenjaZaposlenika.Format = DateTimePickerFormat.Custom;
        }    

        private void button4_Click(object sender, EventArgs e)
        {
            Zaposlenici.ActiveForm.Hide();
            GlavnaRadnaPloca glavnaradnaploca = new GlavnaRadnaPloca();
            glavnaradnaploca.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                
                if (String.IsNullOrEmpty(BrojMobitelaZaposlenika.Text) || String.IsNullOrEmpty(ImeZaposlenika.Text) || String.IsNullOrEmpty(PrezimeZaposlenika.Text) || SoplZaposlenika.SelectedIndex == null
                    || ObrazovanjeZaposlenika.SelectedIndex == null || PozicijaZaposlenika.SelectedIndex == null || String.IsNullOrEmpty(AdresaZaposlenika.Text) || DatuRođenjaZaposlenika.CustomFormat == " ")
                {
                    Greska.Visible = true;
                }
                else
                {
                this.zaposlenikTableBindingSource.AddNew();
                this.zaposlenikTableBindingSource.EndEdit();
                this.zaposlenikTableTableAdapter.Update(this.zAPOSLENICIDBDataSet.ZaposlenikTable);
               
                    Greska.Visible = false;
                    DatuRođenjaZaposlenika.CustomFormat = " ";
                    DatuRođenjaZaposlenika.Format = DateTimePickerFormat.Custom;
                
            }
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.zaposlenikTableBindingSource.RemoveCurrent();             
            }
            catch 
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.zaposlenikTableBindingSource.EndEdit();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatuRođenjaZaposlenika_ValueChanged(object sender, EventArgs e)
        {
            DatuRođenjaZaposlenika.CustomFormat = "dd/MM/yyyy";
            DatuRođenjaZaposlenika.Format = DateTimePickerFormat.Custom;
        }
    }
}
