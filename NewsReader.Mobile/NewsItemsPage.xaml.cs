namespace NewsReader.Mobile;

public partial class NewsItemsPage : ContentPage
{
	string category;
	public NewsItemsPage(string _category)
	{
		InitializeComponent();
		this.category = _category;
	}
}