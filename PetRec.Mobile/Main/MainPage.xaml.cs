using PetRec.Infrastructure.Repositories;

namespace PetRec.Mobile.Main;

public partial class MainPage : ContentPage
{
    
    public MainPage(IPetRepository repo, ICalendarRepository calendarRepository)
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel(repo, calendarRepository);
    }
}
