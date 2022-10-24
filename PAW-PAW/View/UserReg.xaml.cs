using PAW_PAW.ViewModel;

namespace PAW_PAW;

public partial class UserReg : ContentPage
{
	public UserReg()
	{
		InitializeComponent();
        BindingContext = new UserRegistrationVM(Navigation);

    }
}