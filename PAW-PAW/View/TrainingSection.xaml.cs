namespace PAW_PAW.View;

public partial class TrainingSection : ContentPage
{
	public TrainingSection( TrainingSectionVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}