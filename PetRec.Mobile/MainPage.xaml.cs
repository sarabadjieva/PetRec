using PetRec.Mobile.ViewModels;

namespace PetRec.Mobile;

public partial class MainPage : ContentPage
{
    
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
