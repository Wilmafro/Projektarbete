using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Business
{
   public class Feed : Entiter
    {
        public string Url { get; set; }
        public Kategori Kategori { get; set; }
        public int UpdateInterval { get; set; } //Göra om till timespan??
        //public DateTime nextUpdate { get; set; } fixa seeennn
        private List<Business.Poddcast> podcastLista = new List<Business.Poddcast>();

        public Feed(string title, string url, Kategori kategori, int updateinterval)
        {
            Title = title;
            Url = url;
            Kategori = kategori;
            UpdateInterval = updateinterval;
        }

        public Feed() { }

        public List<Business.Poddcast> returnPodcasts()
        {
            return podcastLista;
        }

        public override string Title
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("{0}", Title);
        }
    }

   public class FeedList : List<Feed>
    {

    }
}



