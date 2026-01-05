namespace IEnumerableAndIntroLinq.BuilderPattern
{
    public class PersonBuilder
    {
        private string _name = "Ukjent";
        private int _age = 0;
        private string _city = "Ukjent";

        public PersonBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public PersonBuilder WithAge(int age)
        {
            _age = age;
            return this;
        }

        public PersonBuilder LivesIn(string city)
        {
            _city = city;
            return this;
        }

        public Person Build()
        {
            return new Person(_name, _age, _city);
        }
    }

}
