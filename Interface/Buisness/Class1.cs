using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness
{
    public class XMLParse
    {
        private Databas.XMLOpenCreate saveOpen = new Databas.XMLOpenCreate();

        public void save(Kategorier kategorier, FeedList feedList)
        {

            var xmlFeed = new System.Xml.Serialization.XmlSerializer(typeof(FeedList));
            saveOpen.saveXML(feedList, xmlFeed, false);

            var xmlCategory = new System.Xml.Serialization.XmlSerializer(typeof(Kategorier));
            saveOpen.saveXML(kategorier, xmlCategory, true);
        }

        public Kategorier openCategoryList()
        {
            var xmlFeed = new System.Xml.Serialization.XmlSerializer(typeof(Kategorier));
            var a = saveOpen.loadCategories(xmlFeed);
            if (a != null)
            {
                return a as Kategorier;
            }
            return null;
        }


        public FeedList openFeedList()
        {
            var xmlFeed = new System.Xml.Serialization.XmlSerializer(typeof(FeedList));
            var a = saveOpen.loadFeed(xmlFeed);
            if (a != null)
            {
                return a as FeedList;
            }
            return null;
        }


    }
}
