using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Configuration;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using static YoutubeSearch.JsonClass;

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
            try
            {
                var items = GetSearchList(txtSearch.Text).Result;
                List<Video> list = new List<Video>();

                foreach (var item in items)
                {
                    Video video = new Video();
                    Snippet snippet = new Snippet();
                    Id id = new Id();
                    video.Title = snippet?.title;
                    //video.Url = id?.videoId;
                    if (string.IsNullOrEmpty(snippet?.thumbnails?._default?.url))
                    {
                        video.Thumbnail = null;
                    }
                    else
                    {
                        byte[] imageBytes = new WebClient().DownloadData(snippet?.thumbnails?._default?.url);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            video.Thumbnail = Image.FromStream(ms);
                        }

                    }
                    video.Description = snippet?.description;
                    list.Add(video);
                }
                // var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(list);
                videoBindingSource.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async static Task<dynamic> GetSearchList(string querySearch)
        {
            var parameter = new Dictionary<string, string>()
            {
                ["key"] = ConfigurationManager.AppSettings["ApiKey"],
                ["q"] = querySearch,
                ["part"] = "snippet",
                ["fields"] = "items/snippet(title,description,thumbnails(default(url)))",
                //["videoId"] = "items/id(videoId)",
                ["maxResults"] = "200"
            };

            string baseUrl = "https://www.googleapis.com/youtube/v3/search?";
            string fullUrl = MakeUrlFromQuery(baseUrl, parameter);
            var result = new HttpClient().GetStringAsync(fullUrl);

            if (result != null)
            {
                return JsonConvert.DeserializeObject<JsonClass>(result.Result);
            }
            return null;
        }

        private static string MakeUrlFromQuery(string baseUrl, Dictionary<string, string> parameter)
        {
            if (string.IsNullOrEmpty(baseUrl))
            {
                throw new ArgumentNullException(nameof(baseUrl));
            }

            if (parameter == null || parameter.Count() == 0)
            {
                return baseUrl;
            }

            return parameter.Aggregate(baseUrl, (accumulated, kvp) => string.Format($"{accumulated}{kvp.Key}={kvp.Value}&"));
        }
    }
}