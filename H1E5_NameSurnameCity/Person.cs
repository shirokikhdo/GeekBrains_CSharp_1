namespace H1E5_NameSurnameCity
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }

        public Person(string name, string surname, string city)
        {
            Name = name;
            Surname = surname;
            City = city;
        }

        public override string ToString()
        {
            var line = $"{Name} {Surname} {City}";
            return line;
        }
    }
}