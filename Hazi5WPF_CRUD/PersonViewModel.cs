using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hazi5WPF_CRUD
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private readonly PersonRepository _repository = new PersonRepository();
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        private Person _selectedPerson;

        public Person SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddCommand { get; }
        public RelayCommand UpdateCommand { get; }
        public RelayCommand DeleteCommand { get; }

        public PersonViewModel()
        {
            LoadPeople();
            AddCommand = new RelayCommand(_ => OpenAddWindow());
            UpdateCommand = new RelayCommand(_ => OpenUpdateWindow(), _ => SelectedPerson != null);
            DeleteCommand = new RelayCommand(_ => DeletePerson(), _ => SelectedPerson != null);
        }

        public void LoadPeople()
        {
            People.Clear();
            foreach (var person in _repository.GetAll())
            {
                People.Add(person);
            }
        }

        private void OpenAddWindow()
        {
            var addWindow = new AddOrUpdateWindow();
            if (addWindow.ShowDialog() == true)
            {
                if (!_repository.GetAll().Any(p => p.Equals(addWindow.Person)))
                {
                    _repository.Add(addWindow.Person);
                    LoadPeople();
                }
            }
        }

        private void OpenUpdateWindow()
        {
            var updateWindow = new AddOrUpdateWindow(SelectedPerson);
            if (updateWindow.ShowDialog() == true)
            {
                _repository.Update(updateWindow.Person);
                LoadPeople();
            }
        }

        private void DeletePerson()
        {
            if (MessageBox.Show("Are you sure you want to delete this person?", "Confirm Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                _repository.Delete(SelectedPerson.ID);
                LoadPeople();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
