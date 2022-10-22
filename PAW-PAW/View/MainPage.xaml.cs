using PAW_PAW.ViewModel;

namespace PAW_PAW;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();

        BindingContext = vm;
    }


}


