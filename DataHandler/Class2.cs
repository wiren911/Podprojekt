using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace DataHandler
{
    public class Xmlhandler
    {

        public void SaveFeed(string name, string categoryName, string url)
        {
            //var path = Directory.GetCurrentDirectory() + @"\category\";
            //Directory.CreateDirectory(path);
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\categories\" + categoryName);
            var path = Directory.GetCurrentDirectory() + @"\categories\" + categoryName + @"\" + name + ".xml";
            using (var client = new WebClient())
            {
                client.DownloadFile(url, path);
                client.Dispose();
            }
        }

        public List<Category> GetAllCategories()
        {
            var path = Directory.GetCurrentDirectory() + @"\categories\";
            var categories = Directory.GetDirectories(path);
            List<Category> categoriesInFolder = new List<Category>();
            foreach (var category in categories)
            {
                var dirInfo = new DirectoryInfo(category);
                var name = dirInfo.Name;
                categoriesInFolder.Add(new Category() { Name = name, Path = category });
            }
            return categoriesInFolder;
        }

        public List<Podcast> GetAllFeedsInCategory(string category)
        {
            var path = Directory.GetCurrentDirectory() + @"\categories\" + category;
            var podcasts = Directory.GetFiles(path);
            List<Podcast> pods = new List<Podcast>();
            foreach (var podcast in podcasts)
            {
                var file = Path.GetFileName(podcast);
                pods.Add(new Podcast() { Name = file, Url = podcast });
            }
            return pods;
        }
    }
}
