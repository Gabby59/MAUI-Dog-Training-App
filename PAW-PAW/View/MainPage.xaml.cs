using PAW_PAW.ViewModel;

namespace PAW_PAW;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

        BindingContext = new MainViewModel(Navigation);
    }


}


