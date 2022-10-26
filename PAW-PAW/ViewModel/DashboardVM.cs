//using Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PAW.ViewModel
{
    public partial class DashboardVM : ObservableObject
    { 

        [RelayCommand]
        async Task DogSocializingTap(string s)
        {
            await Shell.Current.GoToAsync(nameof(DogBreeds));
        }

        [RelayCommand]
        async Task Journal(string s)
        {
            await Shell.Current.GoToAsync(nameof(View.Journal));
        }

        [RelayCommand]
        async Task Weeks(string s)
        {
            await Shell.Current.GoToAsync(nameof(DogBreeds));
        }


        [RelayCommand]
        async Task Weeks8_10(string s)
        {
            await Shell.Current.GoToAsync(nameof(DogBreeds));
        }


        [RelayCommand]
        async Task Weeks10_12(string s)
        {
            await Shell.Current.GoToAsync(nameof(DogBreeds));
        }


        private void MenuJournal_Clicked(object sender, EventArgs e)
        {
            // await Shell.Current.GoToAsync(nameof(View.Journal));
           // DisplayAlert
          //  Display("Hola", "This is a ttrial", "Vale");
        }


    }
}
