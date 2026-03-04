using PetRec.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace PetRec.Mobile.ViewModels
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        private readonly PetRepository petRepository = new();
        
        public ObservableCollection<PetViewModel> Pets { get; } = new();
        public ICommand AddPetCommand { get; }
        public ICommand SelectPetCommand { get; }
        public string AddPetBtnText => $"Add pet {Pets.Count + 1}";

        private int count = 0;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainPageViewModel()
        {
            petRepository.ClearAll();
            AddPetCommand = new Command(AddPetCommandImpl);
            SelectPetCommand = new Command<uint>(SelectPetCommandImpl);
        }

        private void AddPetCommandImpl()
        {
            //SemanticScreenReader.Announce(AddPetBtn.Text);
            petRepository.AddAsync(new() { Id = (uint)count++, Name = $"Test{count}" });
            Pets.Clear();
            var newPets = petRepository.GetAllAsync().Select(x => new PetViewModel(x));

            foreach (var pet in newPets)
            {
                Pets.Add(pet);
            }

            OnPropertyChanged(nameof(AddPetBtnText));
        }

        private void SelectPetCommandImpl(uint id)
        {
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
