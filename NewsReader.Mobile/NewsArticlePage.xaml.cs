using NewsReader.Mobile.Models;
using NewsReader.Mobile.Util;
using Newtonsoft.Json;

namespace NewsReader.Mobile;

public partial class NewsArticlePage : ContentPage
{
    private readonly string shortUrl;
    private string articleUrl = "https://10.0.2.2:7134/api/NewsArticle/";
    private NewsArticle article;

    public NewsArticlePage(string shortUrl)
	{
		InitializeComponent();
        this.shortUrl = shortUrl;
        articleUrl += shortUrl.Replace("/","%2F");
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        // Load news article
        var client = new HttpClient(new HttpsClientHandlerService().GetPlatformMessageHandler());
        var response = client.GetStringAsync(articleUrl).Result;
        article = JsonConvert.DeserializeObject<NewsArticle>(response);
        lblTitle.Text = article.Title;
        lblArticle.Text = article.Article;
        //imgArticle.Source = ImageSource.FromUri(new Uri( article.ThumbUrl));
    }
}