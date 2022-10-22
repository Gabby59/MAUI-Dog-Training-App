using Microsoft.Extensions.DependencyInjection;

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


		//register the pages in our program (similar to Manifest?)

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();

        //associate the transient so that the page is created and destroyed each time
        builder.Services.AddTransient<DogBreeds>();
        builder.Services.AddTransient<DogBreedsVM>();

        builder.Services.AddSingleton<UserReg>();
        builder.Services.AddSingleton<UserRegistrationVM>();


        return builder.Build();
	}
}

