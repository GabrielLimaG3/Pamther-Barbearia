namespace Barbearia.Pages.MainPages;

public partial class QuimicaPage : ContentPage
{
	public QuimicaPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        btn.Background = Color.FromArgb("#8257E6");
        btn1.Background = Color.FromArgb("#37343F");
        btn2.Background = Color.FromArgb("#37343F");

        Navigation.PushAsync(new MainPage());

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        btn.Background = Color.FromArgb("#37343F");
        btn1.Background = Color.FromArgb("#8257E6");
        btn2.Background = Color.FromArgb("#37343F");
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        btn.Background = Color.FromArgb("#37343F");
        btn1.Background = Color.FromArgb("#37343F");
        btn2.Background = Color.FromArgb("#8257E6");

        Navigation.PushAsync(new PromoçoesPage());
    }
}