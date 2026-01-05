namespace IEnumerableAndIntroLinq.Enumerating
{
    internal class Demo1
    {
        public static void Run()
        {
            // 1 - 2 - 4 - 8 - 16 - 32 - 64
            var numbers = new TerjesNumberSequence(50);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
