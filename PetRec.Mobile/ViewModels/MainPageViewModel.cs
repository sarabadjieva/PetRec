using PetRec.Domain;
using PetRec.Infrastructure;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PetRec.Mobile.ViewModels;

public class MainPageViewModel : INotifyPropertyChanged
{
    private readonly PetRepository _repo;
    
    public ObservableCollection<PetViewModel> Pets { get; } = new();
    public ICommand AddPetCommand { get; }
    public ICommand SelectPetCommand { get; }
    public string AddPetBtnText => $"Add pet {Pets.Count + 1}";

    public event PropertyChangedEventHandler? PropertyChanged;

    public MainPageViewModel(PetRepository repo)
    {
        _repo = repo;
        AddPetCommand = new Command(async () => await AddPetCommandImpl());
        SelectPetCommand = new Command<uint>(SelectPetCommandImpl);
    }

    public async Task AddPetCommandImpl()
    {
        await _repo.AddAsync(new Pet
        {
            Name = $"Pet {DateTime.Now.Ticks % 100}"
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
    }

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
