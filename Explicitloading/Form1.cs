using Explicitloading.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace Explicitloading
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MarkalariListele();

        }

        private void MarkalariListele()
        {
            using (UygulamaDbContext db = new UygulamaDbContext())
            {
                cmbMarkalar.DataSource = db.Markalar.ToList();
                cmbMarkalar.DisplayMember = "Ad";
                cmbMarkalar.SelectedIndex = -1;

            }
        }

        private void cmbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarkalar.SelectedIndex == -1)
            {
                lstModeller.DataSource = null;
                return;
            }

            using (UygulamaDbContext db = new UygulamaDbContext())
            {
                Marka marka = (Marka)cmbMarkalar.SelectedItem;
                db.Entry(marka).State = EntityState.Unchanged; //using seklinde db kullandýgýmýz için bu satýr gerekti.
                marka.Modeller.Clear();
                db.Entry(marka).Collection(m => m.Modeller).Load();  //excplicit loading önce yükleniyor.
                lstModeller.DataSource = marka.Modeller;
                lstModeller.DisplayMember = "Ad";
            }

        }
    }
}
