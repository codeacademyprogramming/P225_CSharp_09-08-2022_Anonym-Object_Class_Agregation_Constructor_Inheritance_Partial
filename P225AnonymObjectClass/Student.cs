using System;
namespace P225AnonymObjectClass
{
    class Student : Human
    {
        public Address Address;
        public string GroupName;

        public Student()
        {
            Console.WriteLine("Student Obyekti Yarandi");
        }

        public Student(string name, string surname) : base(name,surname)
        {
            Console.WriteLine(FullName());
        }

        public Student(string name, string surname, int age) : this(name, surname)
        {
            Age = age;
        }

        public string GetAddress()
        {
            return $"{Address.Country} {Address.City} {Address.Street} {Address.PostalSeria}{Address.PostalCode}";
        }
    }
}
