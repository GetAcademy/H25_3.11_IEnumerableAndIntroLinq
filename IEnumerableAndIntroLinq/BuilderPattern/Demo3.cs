namespace IEnumerableAndIntroLinq.BuilderPattern
{
    internal class Demo3
    {
        public static void Run()
        {
            //var terje = new PersonBuilder()
            //.WithName("Terje")
            //.WithAge(50)
            //.LivesIn("Stavern")
            //.Build();


            //var builder = new PersonBuilder();
            //builder.WithName("Terje");
            //builder.WithAge(50);
            //builder.LivesIn("Stavern");
            //var terje = builder.Build();

            var names = new[] { "Ole", "Kari", "Alexander", "Ida" };

            var result =
                new StringQuery(names)
                    .WhereLengthGreaterThan(3)
                    .ToUpper()
                    .Reverse()
                    .ToArray();

            //var query =
            //    new StringQuery(names)
            //        .WhereLengthGreaterThan(3)
            //        .ToUpper()
            //        .Reverse();
            //var result = query.ToArray();
        }
    }
}
