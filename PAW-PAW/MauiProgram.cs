using Microsoft.Extensions.DependencyInjection;
using PAW_PAW.View;
using PAW_PAW.ViewModel;

namespace PAW_PAW;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


		//register the pages in our program

		//builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddTransient<Dashboard>();
		builder.Services.AddTransient<DashboardVM>();

        //associate the transient so that the page is created and destroyed each time
        builder.Services.AddTransient<DogBreeds>();
        builder.Services.AddTransient<DogBreedsVM>();

        builder.Services.AddTransient<UserReg>();
        builder.Services.AddTransient<UserRegistrationVM>();

		builder.Services.AddSingleton<Journal>();
		builder.Services.AddTransient<JournalVM>();

		builder.Services.AddSingleton<TrainingSection>();
		builder.Services.AddTransient<TrainingSectionVM>();


        return builder.Build();
	}
}

