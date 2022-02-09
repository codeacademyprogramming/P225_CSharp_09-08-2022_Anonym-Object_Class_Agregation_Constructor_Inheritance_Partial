using System;
using System.Collections.Generic;
using System.Text;

namespace P225AnonymObjectClass
{
    partial class Human
    {
        

        public Human()
        {

        }

        public Human(string name, string surname)
        {
            Name = name;
            SurName = surname;
        }

        public string FullName()
        {
            return Name + " " + SurName;
        }

        public string FullInfo()
        {
            return $"{Name} {SurName} {Age} {IsMarred}";
        }

        
    }
}
