using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows;
using WMPLib;
using System.IO;


namespace Interface.Business
{
    class RSSreader
    {
        public void playPodcast(string path)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.windowlessVideo = true;
            wplayer.URL = path;
            wplayer.openPlayer(path);
        }

        public Feed skapaFeed(string title, string url, Kategori kategori, int updateInterval)
        {
            // Skapar ett nytt Feed och skapar en ny podcast för varje item.
            //***************
            //*******
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            Feed theFeed = new Feed(title, url, kategori, updateInterval);
            string mp3Url = "";

            foreach (SyndicationItem item in feed.Items)
            {
                var hej = item.Links;
                foreach (var link in hej)
                {
                    if (link.Uri.ToString().Contains("mp3"))
                    {
                        mp3Url = link.Uri.ToString();
                        break;
                    }
                }

                Business.Poddcast thePodcast = new Business.Poddcast();
                thePodcast.Title = item.Title.Text;
                thePodcast.Url = mp3Url;
                thePodcast.Description = item.Summary.Text;
                thePodcast.Played = false;
                theFeed.returnPodcasts().Add(thePodcast);

                // Skapar en MP3 fil för varje podcast och tilldelar propertyn Podcast.FilePath sökvägen till filen.
                //****
                //**
                int i = 0;
                var folder = Environment.GetFolderPath(
                       Environment.SpecialFolder.MyDocuments);
                var filePath = System.IO.Path.Combine(folder, "podcast" + i + ".mp3");
                if (File.Exists(filePath) == false)
                {
                    i++;
                }
                new WebClient().DownloadFileTaskAsync(new Uri(mp3Url), filePath);

                thePodcast.FilePath = filePath;
            }
            return theFeed;
        }
    }
}

