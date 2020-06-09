using System;
using System.Collections.Generic;
using System.Text;

namespace p4lab8
{
    class UserAccount
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime? TermsAcceptedDate { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime AccountCreationDate { get; set; }
    }
}
