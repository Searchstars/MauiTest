namespace MauiTest;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		if (DeviceInfo.Current.Platform == DevicePlatform.Android && DeviceInfo.Current.Platform == DevicePlatform.iOS)
		{
			ShellContent.ContentTemplate = new DataTemplate(typeof(MainPageMobile));
		}
		else
		{
            ShellContent.ContentTemplate = new DataTemplate(typeof(MainPage));
        }
	}
}
