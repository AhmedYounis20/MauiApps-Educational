namespace SecondApp;

public partial class ThemePage : ContentPage
{
	public ThemePage()
	{
		InitializeComponent();
	}


	private void OnThemeToggled(object Sender,EventArgs args)
	{
		var temp =this.Resources["Back"];
		this.Resources["Back"] = this.Resources["FrameColor"];
		this.Resources["FrameColor"] =temp;
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {

    }
}