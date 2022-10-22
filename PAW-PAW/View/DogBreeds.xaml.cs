using PAW_PAW.ViewModel;

namespace PAW_PAW;

public partial class DogBreeds : ContentPage
{
	public DogBreeds(DogBreedsVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
