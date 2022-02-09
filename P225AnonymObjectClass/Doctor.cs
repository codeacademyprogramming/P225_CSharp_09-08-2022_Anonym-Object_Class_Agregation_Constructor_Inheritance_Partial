using System;
using System.Collections.Generic;
using System.Text;

namespace P225AnonymObjectClass
{
    class Doctor : Human
    {
        public Address Address;

        public Doctor(string name, string surname) : base(name,surname)
        {
        }
    }
}
