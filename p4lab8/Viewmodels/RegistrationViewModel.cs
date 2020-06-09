using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace p4lab8
{
    class RegistrationViewModel:INotifyPropertyChanged
    {
        public RegistrationViewModel()
        {
            BirthDate = new DateTime(2000, 1, 1);
        }

        private string _login;
        public string Login { 
            get 
            {
                return _login;
            }
            set 
            {
                if (_login != value)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Login"));
                    _login = value;
                }
            }
        }
        public string Password { get; set; }
        public string RepeatedPassword { get; set; }
        public bool TermsAccepted { get; set; }
        public DateTime BirthDate { get; set; }

      

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
