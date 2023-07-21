namespace MauiApp2;

public class GlobalFontSize:IMarkupExtension
{
     public const double FontSize = 50;
    public object ProvideValue(IServiceProvider serviceProvider)
    {
       
            return MainPage.FontSize;
        
    }
}