using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hazi5WPF_CRUD
{
    /// <summary>
    /// Interaction logic for AddOrUpdateWindow.xaml
    /// </summary>
    public partial class AddOrUpdateWindow : Window
    {
        public Person Person { get; set; }

        public AddOrUpdateWindow()
        {
            InitializeComponent();
            Person = new Person();
            DataContext = this;
        }

        public AddOrUpdateWindow(Person person) : this()
        {
            Person = new Person()
            {
                ID = person.ID,
                Name = person.Name,
                Age = person.Age,
            };
            DataContext = this;
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
