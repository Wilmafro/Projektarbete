using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Business
{
    public class Kategori
    {
        public string KategoriNamn { get; set; }  
    }

    public class Kategorier : List<Kategori>
    {
    }
}

