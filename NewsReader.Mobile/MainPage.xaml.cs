namespace NewsReader.Mobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        List<NewsReader.Mobile.Models.Catergory> categories;

        public MainPage()
        {
            InitializeComponent();

        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}