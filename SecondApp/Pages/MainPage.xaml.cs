namespace SecondApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		StaticResouce.FontSizeNumber++;
		Vertical.Resources["DynamicSize"]= (double)Vertical.Resources["DynamicSize"]+1;
	}
}

