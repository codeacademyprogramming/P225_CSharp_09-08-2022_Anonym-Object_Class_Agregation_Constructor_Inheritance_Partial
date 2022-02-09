using System;

namespace P225AnonymObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a

            //var student = new 
            //{
            //    name = "Hamid",
            //    surname = "Mammadov",
            //    age = 31,
            //    isMarred = true
            //};

            //Console.WriteLine(student.name);

            //Student student1 = new Student();

            //student1.Name = "Hamid";
            //student1.SurName = "Mammadov";
            //student1.Age = 31;
            //student1.IsMarred = true;

            //string fullName = student1.FullName();
            //Console.WriteLine(fullName);
            //Console.WriteLine(student1.FullName());
            //Console.WriteLine(student1.FullInfo());

            //Student student2 = new Student();
            //student2.Name = "Tural";
            //student2.SurName = "Aliyev";
            //student2.Age = 26;
            //student2.IsMarred = false;
            //Console.WriteLine(student2.FullName());
            //Console.WriteLine(student2.FullInfo());

            //Student student2 = new Student();
            //student2.Name = "";


            //string name = "Filankes";

            //Student student2 = student1;
            Address address = new Address();
            address.Country = "Azerbaijan";
            address.City = "Baki";
            address.Street = "28 May";
            address.PostalSeria = "Az";
            address.PostalCode = 1111;
            //student2.Name = name;

            //Console.WriteLine(student2.Name);
            //Console.WriteLine(student1.Name);

            //student2.Name = name;
            //string surname = "Mammadov";

            //Student stu1 = new Student("Hamid", surname);
            //stu1.Age = 31;
            //stu1.IsMarred = true;
            //stu1.Address.Country = "Azerbaijan";
            //stu1.Address.City = "Baki";
            //stu1.Address.Street = "28 May";
            //stu1.Address.PostalSeria = "Az";
            //stu1.Address.PostalCode = 1111;

            //stu1.Address = address;
            //stu1.Address.City = "Zerdab";


            //Console.WriteLine(stu1.GetAddress());
            //Console.WriteLine(stu1.FullName());
            //Console.WriteLine(address.City);
            //Console.WriteLine(stu1.Name);

            //Student stu2 = new Student();

            //Student stu1 = new Student();
            //stu1.Name = "";
            //Student stu2 = new Student("Hamid","mammadov");
            //stu2.Name = "";
            //Student stu3 = new Student("Hamid", "Mammadov", 31);
            //stu3.Age = 0;

            Student stu1 = new Student();
            Student stu2 = new Student("Hamid", "Mammadov");

            Human human = new Human();
        }
    }
}
