namespace MauiXtream.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	public void OnLoginClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

	public void OnRegisterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegisterPage());
    }
}