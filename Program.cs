namespace ListsAndStackAdnQueueAndCompoundedTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 50, 10, 50, 12, 10, 30, 50, 20, 12 };
            int N = 3;
            var topNFrequent = numbers
             .GroupBy(x => x)
            .Select(g => new { number = g.Key, Count = g.Count() })
            .OrderByDescending(g => g.Count)
            .Take(N)
            .ToList();

            Console.WriteLine($"Top {N} frequent numbers:");
            foreach (var item in topNFrequent)
            {
                Console.WriteLine($"Number: {item.number}, Count: {item.Count}");
            }
        }
    }
}
