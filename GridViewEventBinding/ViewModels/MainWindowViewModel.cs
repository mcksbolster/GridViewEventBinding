using GridViewEventBinding.Models;
using MvvmHelpers;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GridViewEventBinding.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public ObservableRangeCollection<Person> People { get; set; }
        public DelegateCommand AddCommand { get; private set; }
        public DelegateCommand UpdateCommand { get; set; }
        public DelegateCommand DeleteCommand { get; set; }
        public DelegateCommand InsertCommand { get; set; }

        public MainWindowViewModel()
        {
            People = GetPeople();
            AddCommand = new DelegateCommand(Add);
            UpdateCommand = new DelegateCommand(Update);
            DeleteCommand = new DelegateCommand(Delete);
            InsertCommand = new DelegateCommand(Insert);
        }

        private void Add()
        {
            MessageBox.Show("add Command");
        }

        private void Update()
        {
            MessageBox.Show("update Command");

        }

        private void Delete()
        {
            MessageBox.Show("delete Command");

        }

        private void Insert()
        {
            MessageBox.Show("insert Command");

        }

        private ObservableRangeCollection<Person> GetPeople()
        {
            ObservableRangeCollection<Person> people = new ObservableRangeCollection<Person>();
            people.Add(new Person { UserName = "sshmoo", Name = "Shelly Shmoo", Birthday = DateTime.Now, Email = "sshmoo@gmail.com", Id = 1, Phone = "666-555-8888" });
            people.Add(new Person { UserName = "LGraham", Name = "Leanne Graham", Birthday = DateTime.Now, Email = "LGraham@april.biz", Id = 2, Phone = "666-555-8888" });

            return people;
        }
    }
}
