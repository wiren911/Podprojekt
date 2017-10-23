using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
        public class Podcast
        {
            public string Name { get; set; }
            public string Url { get; set; }
            public List<Episode> Episodes { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }

        public class Episode
        {
            public string Name { get; set; }
            public string Mp3Path { get; set; }
        }

        public class Category
        {
            public string Name { get; set; }
            public string Path { get; set; }
            public List<Podcast> Podcasts { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }
    }

