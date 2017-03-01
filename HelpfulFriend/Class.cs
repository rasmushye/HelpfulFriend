using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpfulFriend
{
    public class Users
    {
        private int UserId;
        private String Username;
        private String FirstName;
        private String LastName;
        private DateTime BirthDate;
        private String Email;

        public Users(string username, string fn, string ln, DateTime bd, string mail)
        {
            Username = username;
            FirstName = fn;
            LastName = ln;
            BirthDate = bd;
            Email = mail;
        }

    
    }
}
