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
            this.zaposlenikTableTableAdapter.ClearBeforeFill = false;
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
                /*
                ZAPOSLENICIDBDataSet.ZaposlenikTableRow novizaposlenikTableRow;
                novizaposlenikTableRow = zaposlenicidbDataSet1.ZaposlenikTable.NewZaposlenikTableRow();

                novizaposlenikTableRow.BrojMobZaposlenikaDB = BrojMobitelaZaposlenika.Text;
                novizaposlenikTableRow.ImeZaposlenikaDB = ImeZaposlenika.Text;
                novizaposlenikTableRow.PrezimeZaposlenikaDB = PrezimeZaposlenika.Text;
                novizaposlenikTableRow.SpolZaposlenikaDB = SoplZaposlenika.Text;
                novizaposlenikTableRow.ObrazovanjeZaposlenikaDB= ObrazovanjeZaposlenika.Text;
                novizaposlenikTableRow.PozicijaZaposlenikaDB = PozicijaZaposlenika.Text;
                novizaposlenikTableRow.AdresaZaposlenikaDB = AdresaZaposlenika.Text;
                novizaposlenikTableRow.GodRodZaposlenikaDB = DatuRođenjaZaposlenika.Value;

                this.zaposlenicidbDataSet1.ZaposlenikTable.Rows.Add(novizaposlenikTableRow);*/

                try
                {              
                    this.zaposlenikTableTableAdapter.Insert(brojZaposlenikaDBDataGridViewTextBoxColumn.Index, ImeZaposlenika.Text,
                        PrezimeZaposlenika.Text, AdresaZaposlenika.Text, BrojMobitelaZaposlenika.Text, SoplZaposlenika.Text, 
                        PozicijaZaposlenika.Text, ObrazovanjeZaposlenika.Text, DatuRođenjaZaposlenika.Value);
                    MessageBox.Show("Update successful");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update failed");
                }

                
                
               
               
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
            Uredi(true);
            this.zaposlenikTableBindingSource.EndEdit();

        }


        private void DatuRođenjaZaposlenika_ValueChanged(object sender, EventArgs e)
        {
            DatuRođenjaZaposlenika.CustomFormat = "dd/MM/yyyy";
            DatuRođenjaZaposlenika.Format = DateTimePickerFormat.Custom;
        }
        private void Uredi(bool uredi)
        {
            BrojMobitelaZaposlenika.Enabled = uredi;
            ImeZaposlenika.Enabled = uredi;
            PrezimeZaposlenika.Enabled = uredi;
            SoplZaposlenika.Enabled = uredi;
            ObrazovanjeZaposlenika.Enabled = uredi;
            PozicijaZaposlenika.Enabled = uredi;
            AdresaZaposlenika.Enabled = uredi;
            DatuRođenjaZaposlenika.Enabled = uredi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Uredi(false);          
        }
    }
}
