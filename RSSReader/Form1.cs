using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using DataHandler;
using System.IO;
using WMPLib;

namespace RSSReader
{


    public partial class Form1 : Form
    {
        private Xmlhandler data;
        private List<Category> _categories;
        private List<Podcast> _podcasts;
        WebClient laddaNerMusik = new WebClient();
        WMPLib.WindowsMediaPlayer startaMusik = new WMPLib.WindowsMediaPlayer();
        string url;
        string xml = "";
        List<string> musikLankar = new List<string>();
        public Form1()
        {
            InitializeComponent();
            data = new Xmlhandler();
            _categories = data.GetAllCategories();
            _podcasts = data.GetAllFeedsInCategory("");
            fillPodcastList();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
        class feed
        {
            public List<string> avsnitt = new List<string>();
        }
        public class podInfo
        {
            public List<string> info = new List<string>();
        }
        */

        string[,] rssData;
        private String[,] GetRssData(String channel)
        {

            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(channel);

            }
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            const string Path = @"G:\xmlfil";
            //const string filePath = @"G:";
            if (Directory.Exists(Path) == false)
            {
                Directory.CreateDirectory(Path);
            }
            var dirs = Directory.EnumerateDirectories(Path);
            var files = Directory.EnumerateFiles(Path);

            //Directory.Delete(Path);

            var dir = new DirectoryInfo(@"C:\Users\david\Desktop\test2");
            if (dir.Exists == false)
            {
                dir.Create();
            }
            using (var stream = new FileStream(@"G:\xmlfil.xml", FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write(xml);
                }
            }
            //dir.Delete();

            /*            using (var stream = new FileStream(@"G:\xml.xml", FileMode.Open))
                        {
                            using (var reader = new StreamReader(stream))
                            {
                                var readXml = reader.ReadToEnd();
                                //Assert.AreEqual(xml, readXml);
                            }
                        }
            */
            //var f = new feed();

            foreach (System.Xml.XmlNode item in dom.DocumentElement.SelectSingleNode("channel/title"))
            {
                var title = item.InnerText;
                displayPod.Items.Add(title);
            }

            foreach (System.Xml.XmlNode item in dom.DocumentElement.SelectNodes("item/title"))
            {
                var titleName = item.InnerText;
                displayPodCasts.Items.Add(titleName);
            }
            return rssData;
        }

        void load_Click(object sender, EventArgs e)
        {
            displayPodCategory.Items.Clear();
            rssData = GetRssData(dtextfild.Text);
            /*                for (int i = 0; i > rssData.GetLength(0); i++)
                            {
                                if (rssData[i, 0] != null)
                                {
                                    combtitle.Items.Add(rssData[i, 0]);
                                }

                            }*/
        }

        private void fillPodcastList()
        {
            foreach (var podcast in _podcasts)
            {
                displayPodCasts.Items.Add(_podcasts);
                var item = displayPodCasts.SelectedItem;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                       url = displayPod.Text;
                         xml = "";
                      // listTitlar.Items.Clear();
                       //listMinaPods.Items.Clear();

                         using (var client = new System.Net.WebClient())
                         {
                             client.Encoding = Encoding.UTF8;

                             xml = client.DownloadString(url);

                         }

                             var dom = new System.Xml.XmlDocument();

                             dom.LoadXml(xml);


                        foreach (System.Xml.XmlNode item in dom.DocumentElement.SelectNodes("channel/title"))
                        {
                            var title = item.InnerText;
                            displayPod.Items.Add(title);
                        }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void displayPodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPodCasts.Items.Clear();
            string url = dtextfild.Text;
            var xml = "";
            var client = new System.Net.WebClient();
            var dom = new System.Xml.XmlDocument();
            client.Encoding = Encoding.UTF8;
            xml = client.DownloadString(url);
            dom.LoadXml(xml);



            
            foreach (System.Xml.XmlNode item in dom.DocumentElement.SelectNodes("channel/item/title"))
            {
                var title = item.InnerText;
                displayPodCasts.Items.Add(title);

            }

            foreach (System.Xml.XmlNode item in dom.DocumentElement.SelectNodes("channel/item/link"))
            {
                string tradar = item.InnerText;
                musikLankar.Add(tradar);
            }


            dom.Save(@"C:\Users\david\source\repos\RSSReader\RSSReader\bin\Debug\xmlfil\data.xml");
        }

        private void downloadMusic_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                
                laddaNerMusik.DownloadFile(musikLankar[i], @"C:\Users\david\source\repos\RSSReader\RSSReader\bin\Debug\xmlfil\podmusik\" + 1 + ".mp3");
            }
            // laddaNerMusik.DownloadFile("http://ads-e-bauerse-pods.sharp-stream.com/40/2013-05-29_stift.mp3?awCollectionId=40&awEpisodeId=1593", @"C:\Users\Abdullah\Desktop\KarlBeast\musik.mp3");
        }

        private void displayPodCasts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playMusic_Click(object sender, EventArgs e)
        {
            int latnr = 2;
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            axWindowsMediaPlayer1.URL = (@"C:\Users\david\source\repos\RSSReader\RSSReader\bin\Debug\xmlfil\podmusik" + latnr + ".mp3"); //lokal musikfil i lokal mapp
            startaMusik.controls.play();
           
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.URL = (); //lokal musikfil i lokal mapp

        }
    }


}


