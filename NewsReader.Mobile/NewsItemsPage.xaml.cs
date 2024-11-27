using NewsReader.Mobile.Util;
using Newtonsoft.Json;

namespace NewsReader.Mobile;

public partial class NewsItemsPage : ContentPage
{
	string category;
	string categoryUrl = "https://10.0.2.2:7134/api/NewsItems/";
    public NewsItemsPage(string _category)
	{
		InitializeComponent();
		this.category = _category;
		this.Title = category;
		categoryUrl += category;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		try
		{
			// Load news items&
			var newsItems = new List<NewsReader.Mobile.Models.NewsItem>();
			var client = new HttpClient(new HttpsClientHandlerService().GetPlatformMessageHandler());
			var response = client.GetStringAsync(categoryUrl).Result;
			var _newsItems = JsonConvert.DeserializeObject<List<NewsReader.Mobile.Models.NewsItem>>(response);
			_newsItems.ForEach(x => x.title = x.title.Length > 60 ? x.title.Substring(0, 59) + "..." : x.title);
			cNewsItemsListView.ItemsSource = _newsItems;
		}
		catch (Exception ex)
		{
			Console.Write(ex.ToString());
		}

    }

    private async void cNewsItemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		var newsItem = e.CurrentSelection.FirstOrDefault() as Models.NewsItem;
        await Navigation.PushModalAsync(new NewsArticlePage(newsItem.shortLink, newsItem.thumbUrl,
			newsItem.title));
    }
}