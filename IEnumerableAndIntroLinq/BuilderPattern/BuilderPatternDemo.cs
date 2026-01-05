namespace IEnumerableAndIntroLinq.BuilderPattern
{
    internal class BuilderPatternDemo
    {
        public static void Run()
        {
            var names = new[] { "Ole", "Kari", "Alexander", "Ida" };

            var result =
                new StringQuery(names)
                    .WhereLengthGreaterThan(3)
                    .ToUpper()
                    .Reverse()
                    .ToArray();

        }
    }
}
