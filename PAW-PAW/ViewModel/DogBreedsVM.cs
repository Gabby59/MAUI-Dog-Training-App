using System;
using System.Diagnostics;
using System.Net.Http.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using PAW_PAW.Model;

namespace PAW_PAW.ViewModel
{
    public partial class DogBreedsVM : ObservableObject //inherits from Observable Object from MVVM toolkit
    {
        //
        HttpClient httpClient; 

        //create a constructor for our dog breed model
        public DogBreedsVM()
        {
            httpClient = new HttpClient();
           
        }

        //use a list for the dog breed, using a Dog data model object
        List<Dog> dogList = new List<Dog>();

        public async Task<List<Dog>>GetDogs()
        {
            if (dogList?.Count > 0)

                return dogList;

            // Online request
            var url = "https://raw.githubusercontent.com/Gabby59/PAW-PAW/main/dogbreeds.json";

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                //automatically deserialize
                dogList = await response.Content.ReadFromJsonAsync<List<Dog>>();
            }

            return dogList; 
        }

        //refer to the collection view XAML counterpart
        public ObservableCollection<Dog> Dogs { get; } = new();

        [RelayCommand]
        async Task GetDogsAsync()
        {
            try
            {
                var dogs = await GetDogs();

                foreach (var dog in dogs)
                    Dogs.Add(dog);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                await Shell.Current.DisplayAlert("Error", $"Unable to get dogs right now: {e.Message}", "OK");
;            }
        }

    } 
}

