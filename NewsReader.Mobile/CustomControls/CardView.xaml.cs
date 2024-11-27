namespace NewsReader.Mobile.CustomControls;

public partial class CardView : ContentView
{

	public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);
	public string CardTitle
	{
        get => (string)GetValue(CardView.CardTitleProperty);
        set => SetValue(CardView.CardTitleProperty, value);
    }

	public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);
	public string CardDescription
	{
        get => (string)GetValue(CardView.CardDescriptionProperty);
        set => SetValue(CardView.CardDescriptionProperty, value);
    }

	public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(string), typeof(CardView), string.Empty);
	public string IconImageSource
	{
        get => (string)GetValue(CardView.IconImageSourceProperty);
        set => SetValue(CardView.IconImageSourceProperty, value);
    }

	//public static readonly BindableProperty IconBackgroundColorProperty = BindableProperty.Create(nameof(IconBackgroundColor), typeof(Color), typeof(CardView), Color.FromArgb("#fff"));
	//public Color IconBackgroundColor
	//{
 //       get => (Color)GetValue(CardView.IconBackgroundColorProperty);
 //       set => SetValue(CardView.IconBackgroundColorProperty, value);
 //   }

	//public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CardView), Color.FromArgb("#000"));
	//public Color BorderColor
	//{
 //       get => (Color)GetValue(CardView.BorderColorProperty);
 //       set => SetValue(CardView.BorderColorProperty, value);
 //   }

	//public static readonly BindableProperty CardColorProperty = BindableProperty.Create(nameof(CardColor), typeof(Color), typeof(CardView), Color.FromArgb("#fff"));
	//public Color CardColor
	//{
 //       get => (Color)GetValue(CardView.CardColorProperty);
 //       set => SetValue(CardView.CardColorProperty, value);
 //   }
    public CardView()
	{
		InitializeComponent();
	}
}