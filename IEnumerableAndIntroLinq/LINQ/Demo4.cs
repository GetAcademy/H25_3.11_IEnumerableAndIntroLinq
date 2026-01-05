namespace IEnumerableAndIntroLinq.LINQ
{
    internal class Demo4
    {
        public static void Run()
        {
            var people = new List<Person>
            {
                new Person("Ole", 28, "Oslo"),
                new Person("Kari", 34, "Bergen"),
                new Person("Per", 42, "Stavanger"),
                new Person("Anne", 25, "Oslo"),
                new Person("Lars", 37, "Trondheim"),
                new Person("Ida", 19, "Stavern"),
                new Person("Marius", 45, "Oslo"),
                new Person("Nina", 31, "Bergen"),
                new Person("Thomas", 52, "Kristiansand"),
                new Person("Eva", 29, "Trondheim"),
                new Person("Jon", 41, "Stavern")
            };

            var someDescriptions = people
                .Where(p => p.City == "Oslo")
                .OrderBy(p => p.Name)
                .Reverse()
                .Select(p => p.Description);

            var firstPersonA = people.First(); // gir den første - når du vet at det er minst 1
            var firstPersonB = people.FirstOrDefault(); // gir den første - når du IKKE vet at det er minst 1
            var firstInLarvik = people.FirstOrDefault(p => p.City == "Larvik");
            


            //var someDescriptions2 = 
            //    from p in people
            //    where p.City == "oslo"
            //    select p.Description;

            //var somePeople = people.Where(p => p.City == "Oslo");
            //var someDescriptions = somePeople.Select(p => p.Description);

            foreach (var description in someDescriptions)
            {
                Console.WriteLine(description);
            }


            //var peopleArray = people.ToArray();
            //var somePeople2 = peopleArray.Where(p => p.City == "Oslo");


        }
    }
}
