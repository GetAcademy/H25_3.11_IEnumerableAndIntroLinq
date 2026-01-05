namespace IEnumerableAndIntroLinq.ExtensionMethods
{
    internal class Demo2
    {
        public static void Run()
        {
            string t = "Hallo";

            var t2 = t.Terje();
            //var t2 = StringExtensions.Terje(t);
            Console.WriteLine(t2); // TerjeHalloTerje
        }
    }
}
