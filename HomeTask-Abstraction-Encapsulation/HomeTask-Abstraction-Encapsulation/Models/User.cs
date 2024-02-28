using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_Abstraction_Encapsulation.Models
{
    internal class User
    {
        private string Name;
        private string Surename;
        private int Age;
        private string _password;

        public User(string name, string surename, int age, string password)
        {
            Name = name;
            Surename = surename;
            Age = age;
            Password = password;


        }
        public string Password
        { 
        get { return _password; }
        set { _password = value; Console.WriteLine(value); }
            
        }
        public void SetPassword(string newPassword)
        { 
        Password = newPassword;
            
        }
    }
}
