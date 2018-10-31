using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interface.Database
{
    class XMLOpenCreate
    {
        private XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(string));
        private static string pathCategory
        {
            get
            {
                var folder = Environment.GetFolderPath(
                   Environment.SpecialFolder.MyDocuments);
                var full_path = System.IO.Path.Combine(folder, "listCategory.xml");
                return full_path;
            }
        }

        private static string pathFeed
        {
            get
            {
                var folder = Environment.GetFolderPath(
                   Environment.SpecialFolder.MyDocuments);
                var full_path = System.IO.Path.Combine(folder, "listFeed.xml");
                return full_path;
            }
        }

        public void saveXML(object Data, XmlSerializer xml, bool a)
        {
            var Path = pathFeed;
            if (a == true)
            {
                Path = pathCategory;
            }

            using (var s = System.IO.File.Open(Path, System.IO.FileMode.OpenOrCreate))
            {
                xml.Serialize(s, Data);
                s.Flush();
                s.Close();
            }
        }

        public object loadCategories(XmlSerializer xml)
        {

            if (System.IO.File.Exists(pathCategory))
            {
                object ret;
                using (var s = System.IO.File.Open(pathCategory, System.IO.FileMode.Open))
                {
                    ret = xml.Deserialize(s) as object;
                    s.Flush();
                    s.Close();
                }
                return ret;
            }
            return null;
        }

        public object loadFeed(XmlSerializer xml)
        {
            if (System.IO.File.Exists(pathFeed))
            {
                object ret;

                using (var s = System.IO.File.Open(pathFeed, System.IO.FileMode.Open))
                {
                    ret = xml.Deserialize(s) as object;
                    s.Flush();
                    s.Close();
                }
                return ret;
            }
            return null;
        }
    }
}

