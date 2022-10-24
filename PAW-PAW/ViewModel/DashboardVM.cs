using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PAW.ViewModel
{
    public partial class DashboardVM : ObservableObject
    { 

        [RelayCommand]
        async Task DogSocializingTap(string s)
        {
            await Shell.Current.GoToAsync(nameof(DogBreeds));
        }

    }
}
