using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PAW.ViewModel
{
    public partial class JournalVM :ObservableObject
    {
        [ObservableProperty]
        string note;

        [ObservableProperty]
        ObservableCollection<string> notes;   // the notes observabe collection of types string

        public JournalVM()
        {
            Notes = new ObservableCollection<string>(); //constructor to hold the collection
        }

        [RelayCommand]
        void Add()
        {
            if(string.IsNullOrWhiteSpace(Note))
                return;

            Notes.Add(Note);
            //add note 
            Note = string.Empty;

        }
    }
}
