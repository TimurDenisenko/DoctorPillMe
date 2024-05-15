using PillMe.Models;
using PillMe.ViewModels;

namespace PillMe.Views;

public partial class UserPage : ContentPage
{
    public UserViewModel ViewModel { get; private set; }
    public UserPage()
    {
        InitializeComponent();
    }
    public UserPage(UserViewModel pm)
    {
        InitializeComponent();
        ViewModel = pm;
        BindingContext = ViewModel;
    }

    private void SaveUser(object sender, EventArgs e)
    {
        User User = (User)BindingContext;
        if (new string[] { User.Name, User.HashPassword }.All(x => !string.IsNullOrEmpty(x)))
            App.Database.SaveItem(User);
        Navigation.PopAsync();
    }

    private void DeleteUser(object sender, EventArgs e)
    {
        User User = (User)BindingContext;
        App.Database.DeleteItem(User.Id);
        Navigation.PopAsync();
    }

    private void Cancel(object sender, EventArgs e) =>
        Navigation.PopAsync();
}