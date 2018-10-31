using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.Business;


namespace Interface
{
    public partial class Form1 : Form
    {
        public List<Kategori> kategorier = new Kategorier();
        public Validering validering = new Validering();

        public Form1()
        {
            InitializeComponent();

            cbTidInt.Items.Add("5 minuter");
            cbTidInt.Items.Add("10 minuter");
            cbTidInt.Items.Add("15 minuter");
            cbTidInt.Items.Add("30 minuter");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTaBortKat_Click(object sender, EventArgs e)
        {  
                removeFromLista();
                
        }

        private void btnAndraKat_Click(object sender, EventArgs e)
        {
            try
            {
                validering.check_Input(tbKategori.Text);
                changeInLista();
            }
            catch (textBoxNull t) { lblInfoPodd.Text = t.Message; }
            
        }


        private void btnLaggTillKat_Click(object sender, EventArgs e)
        {

            try
            {
                validering.check_Input(tbKategori.Text);
                createLista();
            }
             catch (textBoxNull t) { lblInfoPodd.Text = t.Message; }
            
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createLista()
        {     
                var newItem = new Kategori { KategoriNamn = tbKategori.Text };
                kategorier.Add(newItem);
                uppdateKategorier();
        }

        private void removeFromLista()
        {
            if (lbKategori.SelectedIndex == -1) {
                var taBort = lbKategori.SelectedItem;
                kategorier.RemoveAll(k => k.KategoriNamn == taBort.ToString());
                uppdateKategorier();
            }
            else { throw (new textBoxNull()); }              
        }

        private void changeInLista()
        {
            var kat = lbKategori.SelectedItem;
            string newName = tbKategori.Text;

             foreach (var k in kategorier)
                {
                    if (k.KategoriNamn.Equals(kat))
                    {
                        k.KategoriNamn = newName;
                    }
                }
                uppdateKategorier();
                  
        }

        private void uppdateKategorier()
        {
            lbKategori.Items.Clear();
            cbKategori.Items.Clear();

            foreach (var k in kategorier)
            {
                lbKategori.Items.Add(k.KategoriNamn);
                cbKategori.Items.Add(k.KategoriNamn);
            }

            tbKategori.Text = "";
        }

        private void lblInfoPodd_Click(object sender, EventArgs e)
        {

        }

        private void cbTidInt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPodcast.View = View.Details;
            lvPodcast.FullRowSelect = true;
        }

        private void lvPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}