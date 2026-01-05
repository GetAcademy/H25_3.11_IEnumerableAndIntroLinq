namespace IEnumerableAndIntroLinq.LINQ
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }
        public string City { get; }

        public string Description => $"{Name} {Age}år - bor i {City}";

        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }
    }
}
