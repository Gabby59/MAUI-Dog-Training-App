using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Firebase.Auth;

namespace PAW_PAW.ViewModel
{
    public partial class UserRegistrationVM : ObservableObject
    {
        //Navigatio interface
        private INavigation Navigation;

        //firebase api key
        public string firebaseWebAPI = "\r\nAIzaSyCp22DLkkhFk8Z7YmI8bLOFyGX7eXSkyMk";

        public string Email { get; set; }
        public string Password { get; set; }

        public Command RegisterUser { get; }

        public UserRegistrationVM(INavigation navigation)
        {
            this.Navigation = navigation;

           RegisterUser = new (CreateAccount);
        }


        [RelayCommand]
        private async void CreateAccount(object obj)
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(firebaseWebAPI));
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(Email, Password);
                string token = auth.FirebaseToken;
                if (token != null)
                await App.Current.MainPage.DisplayAlert("Success", "New account created. Welcome!", "OK");
                await this.Navigation.PopAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                await Shell.Current.DisplayAlert("Error", $"Alert: {e.Message}", "OK");

            }
        }

    }
}
