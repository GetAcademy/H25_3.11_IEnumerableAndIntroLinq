using System;
using System.Collections.Generic;
using System.Text;

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

            var somePeople = people.Where(p => p.City == "Oslo");

        }
    }
}
