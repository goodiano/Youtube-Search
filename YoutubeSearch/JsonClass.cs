using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeSearch
{
    public class JsonClass
    {
        public class Rootobject
        {
            public Item[] items { get; set; }
        }

        public class Item
        {
            public Id id { get; set; }
            public Snippet snippet { get; set; }
        }

        public class Id
        {
            public string videoId { get; set; }
        }

        public class Snippet
        {
            public string title { get; set; }
            public string description { get; set; }
            public Thumbnails thumbnails { get; set; }
        }

        public class Thumbnails
        {
            public Default _default { get; set; }
        }

        public class Default
        {
            public string url { get; set; }
        }

    }
}
