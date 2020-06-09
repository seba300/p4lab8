using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace p4lab8
{
    class FakeDb
    {
        public bool AddUser(UserAccount userAccount)
        {
            MessageBox.Show("User has been added to Db", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            return true;
        }
    }
}
