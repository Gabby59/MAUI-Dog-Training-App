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