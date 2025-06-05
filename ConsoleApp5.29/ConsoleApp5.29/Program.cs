namespace ConsoleApp5._29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> 
            { "Satoshi", "Yuki", "Hana", "Ken", "Haruka", "Yuka" };

            List<string> result = names
                .Where(n => n.Length >= 4)
                .OrderBy(n => n)
                .Select(n => n.ToUpper())
                .ToList();

            foreach(string name in result)
            {
                Console.WriteLine(name);
            }

        }
    }
}

