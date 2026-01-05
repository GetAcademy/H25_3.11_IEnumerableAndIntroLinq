namespace IEnumerableAndIntroLinq.BuilderPattern
{
    public class Person
    {
        public string Name { get; } // NB! Merk read only => ingen setters
        public int Age { get; }
        public string City { get; }

        internal Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }
    }

}
