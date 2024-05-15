using PillMe.Models;
using PillMe.ViewModels;

namespace PillMe.Views;

public partial class PillPage : ContentPage
{
    public PillViewModel ViewModel { get; private set; }
    public PillPage()
    {
        InitializeComponent();
    }
    public PillPage(PillViewModel pm)
    {
        InitializeComponent();
        ViewModel = pm;
        BindingContext = ViewModel;
    }

    private void SavePill(object sender, EventArgs e)
    {
        Pill Pill = (Pill)BindingContext;
        if (new string[] { Pill.Name, Pill.Description, Pill.Amount == 0 ? "" : "fill", Pill.Price == 0 ? "" : "fill" }.All(x => !string.IsNullOrEmpty(x)))
            App.Database.SaveItem(Pill);
        Navigation.PopAsync();
    }

    private void DeletePill(object sender, EventArgs e)
    {
        Pill Pill = (Pill)BindingContext;
        App.Database.DeleteItem(Pill.Id);
        Navigation.PopAsync();
    }

    private void Cancel(object sender, EventArgs e) =>
        Navigation.PopAsync();
}