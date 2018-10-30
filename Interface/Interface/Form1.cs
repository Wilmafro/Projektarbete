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

        public Form1()
        {
            InitializeComponent();
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
            changeInLista();
            lbKategori.Items.Clear();

            foreach(var k in kategorier)
            {
                lbKategori.Items.Add(k.KategoriNamn);
            }
            tbKategori.Text = "";

            // Create a new instance of the Form2 class
            // Form2 settingsForm = new Form2();

            // Show the settings form
            // settingsForm.Show();
        }

       
        private void btnLaggTillKat_Click(object sender, EventArgs e)
        {
            createLista();
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void createLista()
        {
            if (!string.IsNullOrEmpty(tbKategori.Text))
            {
                var newItem = new Kategori { KategoriNamn = tbKategori.Text };
                kategorier.Add(newItem);
                tbKategori.Text = "";
                lbKategori.Items.Add(newItem.KategoriNamn);
                cbKategori.Items.Add(newItem.KategoriNamn);
            }
        }

        private void removeFromLista()
        {
            var taBort = lbKategori.SelectedItem;
            kategorier.RemoveAll(k => k.KategoriNamn == taBort.ToString());
            lbKategori.Items.Remove(taBort);
            cbKategori.Items.Remove(taBort);
        }

        private void changeInLista()
        {
            var kat = lbKategori.SelectedItem;
            string newName = tbKategori.Text;

            foreach(var k in kategorier)
            {
                if(k.KategoriNamn.Equals(kat))
                {
                    k.KategoriNamn = newName;
                }            
             }          
           
        }

    }
}