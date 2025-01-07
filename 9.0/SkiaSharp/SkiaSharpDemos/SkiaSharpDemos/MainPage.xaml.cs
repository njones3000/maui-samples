namespace SkiaSharpDemos;

public partial class MainPage : BasePage
{
	public MainPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        BindingContext = null;
        BindingContext = this;
    }
}
