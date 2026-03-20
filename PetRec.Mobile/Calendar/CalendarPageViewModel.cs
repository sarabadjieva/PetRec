using PetRec.Infrastructure.Repositories;
using PetRec.Mobile.Main;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Microsoft.VisualBasic;

namespace PetRec.Mobile.Calendar
{
    internal class CalendarPageViewModel : INotifyPropertyChanged
    {
        private readonly ICalendarRepository _repo;

        public ObservableCollection<CalendarEntryViewModel> CalendarEntries { get; } = [];
        public ICommand AddEntryCommand { get; }
        //public ICommand SelectPetCommand { get; }
        public string AddPetBtnText => $"Add pet {CalendarEntries.Count + 1}";

        public event PropertyChangedEventHandler? PropertyChanged;

        public CalendarPageViewModel(ICalendarRepository repo)
        {
            _repo = repo;

            AddEntryCommand = new Command(async () => await AddEntryCommandImpl());
            //SelectPetCommand = new Command<uint>(SelectPetCommandImpl);
        }

        public async Task AddEntryCommandImpl()
        {
            await _repo.AddAsync(new CalendarEntry()
            {
                DateAndTime = DateAndTime.Now,
                Description = $"Calendar entry {DateTime.Now.Ticks % 1000}"
            });

            await LoadEntriesAsync();
        }

        public async Task LoadEntriesAsync()
        {
            CalendarEntries.Clear();

            var entries = await _repo.GetAllAsync();

            foreach (var entry in entries)
                CalendarEntries.Add(new CalendarEntryViewModel(entry));

            OnPropertyChanged(nameof(AddPetBtnText));
        }

        //private void SelectPetCommandImpl(uint id)
        //{
        //    Shell.Current.Navigation.PushAsync(new CalendarPage());
        //}

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
