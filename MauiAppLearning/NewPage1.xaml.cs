namespace MauiApp2;

public partial class NewPage1 : ContentPage
{
    private int _count;
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_OnClicked(object sender, EventArgs e)
    {
        _count++;
        LblCounter.Text = $"yoU did it {_count} Times";
    }
}