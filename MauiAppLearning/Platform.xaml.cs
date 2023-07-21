namespace MauiApp2;

public partial class Platform : ContentPage
{
	public Platform()
	{
		InitializeComponent();

        VStackLayout.Padding =
            DeviceInfo.Platform == DevicePlatform.iOS ?
                 new Thickness(30, 10, 30, 10) : new Thickness(25);
    }
}