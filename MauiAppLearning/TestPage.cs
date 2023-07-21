using Android.Widget;
using Button = Microsoft.Maui.Controls.Button;
using ScrollView = Microsoft.Maui.Controls.ScrollView;

namespace MauiApp2;

public class TestPage : ContentPage
{
    int _count = 0;

    Label _lblCounter;
    public TestPage()
    {
        var scrolllView = new ScrollView();

        var stackLayout = new StackLayout();

        scrolllView.Content = stackLayout;

        _lblCounter =new Label
        {
            Text = "Hi David Count : 0",
            
            FontSize = 32,

            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center

        };

        stackLayout.Children.Add( _lblCounter );

        var btnCounter = new Button
        {
            Text = "Click Me",
            FontSize = 15,
            HorizontalOptions = LayoutOptions.Center,


        };
        stackLayout.Children.Add( btnCounter );
        btnCounter.Clicked += BtnCounter_Clicked;

        this.Content = scrolllView;


    }

    private void BtnCounter_Clicked(object sender, EventArgs e)
    {
        _count++;
        _lblCounter.Text = $"You Clicked {_count} Times";

        SemanticScreenReader.Announce(_lblCounter.Text);



    }
}