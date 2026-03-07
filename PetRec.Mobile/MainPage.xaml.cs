using PetRec.Infrastructure;
using PetRec.Infrastructure.Repositories;
using PetRec.Mobile.ViewModels;

namespace PetRec.Mobile;

public partial class MainPage : ContentPage
{
    
    public MainPage(IPetRepository repo)
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel(repo);
    }
}
