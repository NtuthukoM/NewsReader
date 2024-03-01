using NewsReader.Mobile.Util;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace NewsReader.Mobile
{
    public partial class MainPage : ContentPage
    {
        private string categoriesUrl;
        ObservableCollection<NewsReader.Mobile.Models.Catergory> categories = new ObservableCollection<Models.Catergory>();

        public MainPage()
        {
            InitializeComponent();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            // Load categories
            categoriesUrl = "https://10.0.2.2:7134/api/Categories";
            await LoadCategories();
        }

        private async Task LoadCategories()
        {
            // Load categories
            var client = new HttpClient(new HttpsClientHandlerService().GetPlatformMessageHandler());
            var response = await client.GetStringAsync(categoriesUrl);
           var _categories = JsonConvert.DeserializeObject<List<NewsReader.Mobile.Models.Catergory>>(response);
            foreach (var category in _categories)
            {
                categories.Add(category);
            }
            lstCategories.ItemsSource = _categories;
        }


        private async void OnCategoryClickedClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var category = (NewsReader.Mobile.Models.Catergory)btn.BindingContext;
            await Navigation.PushAsync(new NewsItemsPage(category.Title));
        }

    }
}