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
		// Load news items&
		var newsItems = new List<NewsReader.Mobile.Models.NewsItem>();
		var client = new HttpClient(new HttpsClientHandlerService().GetPlatformMessageHandler());
		var response = client.GetStringAsync(categoryUrl).Result;
		var _newsItems = JsonConvert.DeserializeObject<List<NewsReader.Mobile.Models.NewsItem>>(response);
        NewsItemsListView.ItemsSource = _newsItems;

    }
	async void NewsItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
	{
        var newsItem = (NewsReader.Mobile.Models.NewsItem)e.Item;
        await Navigation.PushAsync(new NewsArticlePage(newsItem.shortLink, newsItem.thumbUrl,
			newsItem.title));
    }
}