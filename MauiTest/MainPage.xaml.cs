namespace MauiTest;

public partial class MainPage : ContentPage
{
	public void WindowActivated(object sender, EventArgs e)
	{
		WinActiLab.Text = "Hey!";
		this.Window.Title = "MAUI TEST DESKTOP";
    }

	public MainPage()
	{
		InitializeComponent();
		this.Title = ""; //Hide the title bar
		this.Appearing += WindowActivated;
	}

    private void TestBtn_Clicked(object sender, EventArgs e)
    {
        WinActiLab.Text = "Uhhhhh";
    }
}