using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Encapsulation_Abstraction.Models
{
    internal class Animal
    {
        public string Name { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
}
