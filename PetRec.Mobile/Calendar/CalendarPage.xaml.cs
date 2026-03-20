using PetRec.Infrastructure.Repositories;

namespace PetRec.Mobile.Calendar;

public partial class CalendarPage : ContentPage
{
	public CalendarPage(ICalendarRepository repository)
	{
		InitializeComponent();
        BindingContext = new CalendarPageViewModel(repository);
    }
}