using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class User : Person
    {
        public User(string name, string password, bool manager = false)
        {
            this.name = name;
            this.password = password;
            this.manager = manager;
        }
    }
}
