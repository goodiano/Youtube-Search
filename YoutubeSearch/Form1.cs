using System.Net;

namespace YoutubeSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            VideoSearch items = new VideoSearch();
            List<Video> list = new List<Video>();

            foreach(var item in items.SearchQuery(txtSearch.Text , 1))
            {
                Video video = new Video();
                video.Title = item.Title;
                video.Url = item.Url;
                byte[] imageBytes = new WebClient().DownloadData(item.Thumbnail);
                video.Author = item.Author;

                using(MemoryStream ms = new MemoryStream(imageBytes))
                {
                    video.Thumbnail = Image.FromStream(ms);
                }

                list.Add(video);
            }

            videoBindingSource.DataSource = list;
        }
    }
}