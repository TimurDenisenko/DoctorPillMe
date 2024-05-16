using PillMe.Models;

namespace PillMe.Views;

public partial class DoctorListPage : ContentPage
{
	public DoctorListPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        UsersList.ItemsSource = App.Database.GetUsers().Where(x => x.Role == "Doctor");
        base.OnAppearing();
    }
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        User selectedUser = e.SelectedItem as User;
        UserPage UserPage = new UserPage();
        UserPage.BindingContext = selectedUser;
        await Navigation.PushAsync(UserPage);
    }
    private async void CreateUser(object sender, EventArgs e)
    {
        User User = new User();
        UserPage UserPage = new UserPage();
        UserPage.BindingContext = User;
        await Navigation.PushAsync(UserPage);
    }
}