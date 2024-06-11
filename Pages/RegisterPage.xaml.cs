namespace MauiXtream.Pages;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

	public void OnRegisterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

	public void OnBackClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }
}