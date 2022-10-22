namespace PAW_PAW;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Register the DogBreeds Page with the routing system of MAUIShell;
		//takes 2 parameters: first, the route itself, as string (nameof property because in c# if we refactor it will also cascade down)
		//second, associate it with a type of page 
        Routing.RegisterRoute(nameof(DogBreeds), typeof(DogBreeds));
		Routing.RegisterRoute(nameof(UserReg), typeof(UserReg));
	}
}

