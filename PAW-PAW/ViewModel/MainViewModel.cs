using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace PAW_PAW.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        public MainViewModel()
        {
        }

        [RelayCommand]
        async Task SignInButton(string s)
        {

        }

        [RelayCommand]
        async Task ButtonTap(string s)
        {
            await Shell.Current.GoToAsync(nameof(DogBreeds));
        }

        [RelayCommand]
        async Task DogSocializingTap(string s)
        {
            await Shell.Current.GoToAsync(nameof(DogBreeds));
        }

        [RelayCommand]
        async Task SignUpButton(string s)
        {
         await Shell.Current.GoToAsync(nameof(UserReg));
        }

    }
}

