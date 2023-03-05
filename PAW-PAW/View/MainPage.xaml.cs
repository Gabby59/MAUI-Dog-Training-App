using PAW_PAW.ViewModel;

namespace PAW_PAW;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		 InitializeComponent();

      BindingContext = new MainViewModel(Navigation);
    }

	private async void NewAccount_Button_Clicked(object sender, EventArgs e)
	{
       // await Shell.Current.Navigation.PushAsync(new UserReg());

       await Shell.Current.GoToAsync(nameof(UserReg));

    }

    private async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
     await  Shell.Current.Navigation.PushAsync(new Dashboard());

    }
}


