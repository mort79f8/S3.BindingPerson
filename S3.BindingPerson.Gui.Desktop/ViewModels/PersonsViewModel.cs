using S3.BindingPerson.DataAcess;
using S3.BindingPerson.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3.BindingPerson.Gui.Desktop.ViewModels
{
    class PersonsViewModel : INotifyPropertyChanged
    {
        private List<Person> people;
        private Person selectedPerson;
        
        public Person SelectedPerson
        {
            get => selectedPerson;
            set
            {
                selectedPerson = value;
                OnPropertyChanged(nameof(SelectedPerson));
            }
        }

        public List<Person> People
        {
            get
            {
                return new Repository().GetAllPersons();
            }
            set
            {
                people = value;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
