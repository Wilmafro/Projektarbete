using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Business
{
    public class Kategori
    {
        public string kategoriNamn { get; set; }
        public delegate void KategoriHandler(string newKategori);
        public event KategoriHandler KategoriChanged;

        public void ChangeKategori(string newKat)
        {
            kategoriNamn = newKat;
            if (KategoriChanged != null)
            {
                KategoriChanged(kategoriNamn);
            }
        }
    }

    public class Kategorier : List<Kategori>
    {
        List<Kategori> kategoriLista = new Kategorier { };

        public void addToKategoriLista()
        {
            var kat = new Kategori();
            kat.KategoriChanged += delegate (string newKat)
            {
                kategoriLista.Add(newKat);
            };
            kat.ChangeKategori("Ny kategori tillagd");
        }

        public void uppdateKategoriLista()
        {
            var kat = new Kategori();
            kat.KategoriChanged += delegate (string newKat)
            {
                kategoriLista.add(newKat);
            };
            kat.ChangeKategori("Kategorin är ändrad");
        }


    }
}
}
