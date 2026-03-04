using PetRec.Domain;
using PetRec.Infrastructure;
using PetRec.Mobile.ViewModels;
using System.Collections.ObjectModel;

namespace PetRec.Mobile
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
