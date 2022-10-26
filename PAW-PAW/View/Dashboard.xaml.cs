using Newtonsoft.Json;
using PAW_PAW.ViewModel;

namespace PAW_PAW;

public partial class Dashboard : ContentPage
{
    public Dashboard (DashboardVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    private async void MenuFlyoutItem_7_8Weeks_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(View.Journal));
    }

    private async void MenuFlyoutItem_8_10Weeks_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(View.Journal));
    }
    private async void MenuFlyoutItem_10_12Weeks_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(View.Journal));
    }
    private async void MenuFlyoutItem_12_16Weeks_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(View.Journal));
    }
    private async void MenuFlyoutItem_6Months_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(View.Journal));
    }

    private async void MenuFlyoutItem_Journal_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(View.Journal));
    }

    private async void MenuFlyoutItem_Tips_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DogBreeds));
    }



    //  if using Navigation to pass the user 
    /*
    public Dashboard()
	{
        InitializeComponent();
        GetUserInfo();
    }

    //display user info
    private void GetUserInfo()
    {
        var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("FreshFirebaseToken", ""));
        UserEmail.Text = userInfo.User.Email;
    }
    */
}