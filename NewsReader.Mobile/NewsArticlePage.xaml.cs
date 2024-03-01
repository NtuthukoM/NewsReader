using NewsReader.Mobile.Models;
using NewsReader.Mobile.Util;
using Newtonsoft.Json;

namespace NewsReader.Mobile;

public partial class NewsArticlePage : ContentPage
{
    private readonly string imgUrl;
    private readonly string title;
    private string articleUrl = "https://10.0.2.2:7134/api/NewsArticle/";
    private NewsArticle article;

    public NewsArticlePage(string shortUrl, string imgUrl, string title)
	{
		InitializeComponent();
        this.imgUrl = imgUrl;
        this.title = title;
        articleUrl += shortUrl.Replace("/","%2F");        
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        // Load news article
        var client = new HttpClient(new HttpsClientHandlerService().GetPlatformMessageHandler());
        var response = client.GetStringAsync(articleUrl).Result;
        article = JsonConvert.DeserializeObject<NewsArticle>(response);
        imgArticle.Source = ImageSource.FromUri(new Uri(imgUrl));
        lblArticle.Text = article.Article;
        //set title to article title and substring article to 1000 characters with ...
        Title = title?.Substring(0, 20) + "..." ?? "";
    }
}