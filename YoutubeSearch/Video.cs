using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeSearch
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Image Thumbnail { get; set; }
        public string Url { get; set; }
    }
}
