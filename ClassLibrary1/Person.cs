using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Person
    {
        protected string name;
        protected string password;
        protected bool manager;

        public string GetName()
        {
            return this.name;
        }
        public string GetPassword()
        {
            return this.password;
        }
    }
}
