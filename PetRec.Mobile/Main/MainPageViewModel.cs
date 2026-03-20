using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PetRec.Infrastructure.Repositories;
using PetRec.Mobile.Calendar;

namespace PetRec.Mobile.Main;

public class MainPageViewModel : INotifyPropertyChanged
{
    private readonly IPetRepository _repo;
    private readonly ICalendarRepository _calendarRepo;
    
    public ObservableCollection<PetViewModel> Pets { get; } = [];
    public ICommand AddPetCommand { get; }
    public ICommand SelectPetCommand { get; }
    public string AddPetBtnText => $"Add pet {Pets.Count + 1}";

    public event PropertyChangedEventHandler? PropertyChanged;

    public MainPageViewModel(IPetRepository repo, ICalendarRepository calendarRepository)
    {
        _repo = repo;
        _calendarRepo = calendarRepository;

        AddPetCommand = new Command(async () => await AddPetCommandImpl());
        SelectPetCommand = new Command<uint>(SelectPetCommandImpl);
    }

    public async Task AddPetCommandImpl()
    {
        await _repo.AddAsync(new Pet()
        {
            Name = $"Pet {DateTime.Now.Ticks % 1000}"
        });

        await LoadPetsAsync();
    }

    public async Task LoadPetsAsync()
    {
        Pets.Clear();

        var pets = await _repo.GetAllAsync();

        foreach (var pet in pets)
            Pets.Add(new PetViewModel(pet));

        OnPropertyChanged(nameof(AddPetBtnText));
    }

    private void SelectPetCommandImpl(uint id)
    {
        Shell.Current.Navigation.PushAsync(new CalendarPage(_calendarRepo));
    }

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
