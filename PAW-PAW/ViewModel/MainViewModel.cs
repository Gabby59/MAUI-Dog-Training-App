using System;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Newtonsoft.Json;

namespace PAW_PAW.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        string userEmail;

        [ObservableProperty]
        string userPassword;

        //firebase api key
        public string firebaseWebAPI = "\r\nAIzaSyCp22DLkkhFk8Z7YmI8bLOFyGX7eXSkyMk";


        private INavigation Navigation;

        public MainViewModel(INavigation navigation)
        {
              this.Navigation = navigation;
 
        }



        [RelayCommand]
        async Task SignInButton(object obj)
        {

                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(firebaseWebAPI));
            try
            {
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(UserEmail, UserPassword);
                var content = await auth.GetFreshAuthAsync();
                var serializedContent = JsonConvert.SerializeObject(content);
                Preferences.Set("FreshFirebaseToken", serializedContent);
            //  await Shell.Current.Navigation.PushAsync(new Dashboard()); //use Navigation to pass the user 
                await Shell.Current.GoToAsync(nameof(Dashboard)); 
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                await Shell.Current.DisplayAlert("Error", $"Alert: {e.Message}", "OK");
            }
            
        }
        

        [RelayCommand]
        async Task SignUpButton(string s)
        {
          await Shell.Current.GoToAsync(nameof(UserReg));
      //      await Shell.Current.Navigation.PushAsync(new UserReg());
        }




        [RelayCommand]
        async Task ButtonTap(string s)
        {
         //  await Shell.Current.Navigation.PushAsync(new Dashboard());

         await Shell.Current.GoToAsync(nameof(Dashboard));
        }
    }
}

