namespace PAW_PAW.View;

public partial class TrainingSection : ContentPage
{
	public TrainingSection( TrainingSectionVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private async void MenuFlyoutItem_7_8Weeks_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(View.TrainingSection));
    }

    private async void MenuFlyoutItem_8_10Weeks_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(View.TrainingSection));
    }
    private async void MenuFlyoutItem_10_12Weeks_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(View.TrainingSection));
    }
    private async void MenuFlyoutItem_12_16Weeks_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(View.TrainingSection));
    }
    private async void MenuFlyoutItem_6Months_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(View.TrainingSection));
    }

    private async void MenuFlyoutItem_Journal_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Journal));
    }

    private async void MenuFlyoutItem_Tips_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DogBreeds));
    }
    private async void MenuFlyoutItem_Dashboard_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Dashboard));
    }
}