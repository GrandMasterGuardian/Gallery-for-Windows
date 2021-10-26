using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Manager : Person
    {
        public Manager(string name, string password, bool manager = true)
        {
            this.name = name;
            this.password = password;
            this.manager = manager;
        }
    }
}
