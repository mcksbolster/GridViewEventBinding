using GridViewEventBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace GridViewEventBinding.Controls
{
    /// <summary>
    /// Interaction logic for People.xaml
    /// </summary>
    public partial class People : UserControl
    {
        ObservableCollection<Person> people = new ObservableCollection<Person>();

        public People()
        {
            InitializeComponent();
            people.Add(new Person { UserName = "sshmoo", Name = "Shelly Shmoo", Birthday = DateTime.Now, Email = "sshmoo@gmail.com", Id = 1, Phone = "666-555-8888" });
            people.Add(new Person { UserName = "LGraham", Name = "Leanne Graham", Birthday = DateTime.Now, Email = "LGraham@april.biz", Id = 2, Phone = "666-555-8888" });


            PeopleGrid.ItemsSource = people;
        }

        private void RadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            var gridView = sender as RadGridView;
            var person = gridView.SelectedItem as Person;
            MessageBox.Show($"Selection Changed {person.Name}");
        }
    }
}
