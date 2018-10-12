using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfValidationDemo
{
    public class MainViewModel : ViewModelBase
    {
        private readonly Person person;
        public MainViewModel(Person p)
        {
            person = p;
        }

        public string UserName
        {
            get { return person.UserName; }
            set
            {
                person.UserName = value;
                OnPropertyChanged("UserName");
            }
        }

        public string Password
        {
            get { return person.Password; }
            set
            {
                person.Password = value;
                OnPropertyChanged("Password");
            }
        }
    }
}
