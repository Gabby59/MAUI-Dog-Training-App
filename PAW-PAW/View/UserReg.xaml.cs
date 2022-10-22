using PAW_PAW.ViewModel;

namespace PAW_PAW;

public partial class UserReg : ContentPage
{
	public UserReg(UserRegistrationVM vm)
	{
		InitializeComponent();
		BindingContext = vm;	
	}
}