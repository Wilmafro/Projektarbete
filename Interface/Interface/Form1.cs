using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KategoriKlasser;

namespace Interface
{
    public partial class Form1 : Form
    {
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
          
            var lista = new Kategorier();
            if (tbKategori.Text != "")
            {
                int i = 0;
                while (i <= lbKategori.Items.Count)
                {
                    var removeKat = tbKategori.Text;
                    var kat = new Kategori();
                    kat.KategoriChanged += delegate (string newKat)
                    {
                        lista.remove(newKat);
                    };
                    kat.ChangeKategori("Ny kategori tillagd");


                }
            }
        }

        private void btnAndraKat_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form2 settingsForm = new Form2();

            // Show the settings form
            settingsForm.Show();
        }
    }
}