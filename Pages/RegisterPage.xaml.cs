using MauiXtream.Models;

namespace MauiXtream.Pages;

public partial class RegisterPage : ContentPage
{
    private readonly User _user;

	public RegisterPage()
	{
        InitializeComponent();
        _user = new();

        this.BindingContext = _user;
	}

	public async void OnRegisterClicked(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(_user.UserName) || string.IsNullOrEmpty(_user.Password) || string.IsNullOrEmpty(_user.Server))
        {
            await DisplayAlert("Error", "Please fill all fields", "OK");
            return;
        }

        var register = await App.Database.UserDataTable.SaveUserAsync(_user);

        if(register == 1)
        {
            await DisplayAlert("Success", "User registered successfully", "OK");
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlert("Error", "User registration failed", "OK");
        }
    }

	public async void OnBackClicked(object sender, EventArgs e)
    {
         await Navigation.PopAsync();
    }
}