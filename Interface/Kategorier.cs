using System;

namespace KategoriKlasser
{
    public class Kategori
    {
        string kategoriNamn { get; set; }
        delegate void KategoriHandler(string newKategori);
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
        var kategoriLista = new Kategorier { };

        public void addToKategoriLista()
        {
            var kat = new Kategori();
            kat.KategoriChanged += delegate (string newKat)
            {
                kategoriLista.add(newKat);
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

        public void removeFromKategoriLista()
        {
            var kat = new Kategori();
            kat.KategoriChanged += delegate (string newKat)
            {
                kategoriLista.remove(newKat);
            };
            kat.ChangeKategori("Ny kategori tillagd");
        }
    }
}
