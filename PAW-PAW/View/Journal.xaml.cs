namespace PAW_PAW.View;

public partial class Journal : ContentPage
{
	public Journal(JournalVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}