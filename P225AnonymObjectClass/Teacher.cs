namespace P225AnonymObjectClass
{
    class Teacher : Human
    {
        
        public Address TeacherAddress;

        public Teacher(string name, string surname):base(name,surname)
        {
            //Name = name;
            //SurName = surname;
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
