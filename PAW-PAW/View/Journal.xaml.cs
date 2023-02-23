namespace PAW_PAW;

public partial class Journal : ContentPage
{
	public Journal(JournalVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}