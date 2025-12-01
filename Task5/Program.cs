namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Aggregation Operators (Supermarket Sales) ");

            var sales = new List<CashierSales>()
        {
            new CashierSales { Name = "pratyush", Sales = 1200 },
            new CashierSales { Name = "niya", Sales = 900 },
            new CashierSales { Name = "priyanshu", Sales = 1500 },
            new CashierSales { Name = "aaryan", Sales = 700 }
        };

            int totalCashiers = sales.Count();
            double totalSales = sales.Sum(s => s.Sales);
            double highestSale = sales.Max(s => s.Sales);
            double lowestSale = sales.Min(s => s.Sales);
            double averageSale = sales.Average(s => s.Sales);

            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: {totalSales}");
            Console.WriteLine($"Highest Sale: {highestSale}");
            Console.WriteLine($"Lowest Sale: {lowestSale}");
            Console.WriteLine($"Average Sale: {averageSale}");
            Console.WriteLine();


            Console.WriteLine(" Quantifier Operators (Election Applicants) ");

            var applicants = new List<Applicant>()
        {
            new Applicant { Name = "Sita", Age = 19 },
            new Applicant { Name = "Gita", Age = 22 },
            new Applicant { Name = "Rita", Age = 17 },
            new Applicant { Name = "Nita", Age = 25 }
        };

            bool anyUnder18 = applicants.Any(a => a.Age < 18);
            bool allAbove16 = applicants.All(a => a.Age > 16);

            Console.WriteLine($"Any applicant under 18: {anyUnder18}");
            Console.WriteLine($"All applicants above 16: {allAbove16}");
            Console.WriteLine();


            Console.WriteLine("Element Operators (Music App) ");

            var songs = new List<Music>()
        {
            new Music { SongName = "Song1", DurationSec = 150 },
            new Music { SongName = "Song2", DurationSec = 260 },
            new Music { SongName = "Song3", DurationSec = 400 },
            new Music { SongName = "Song4", DurationSec = 620 }
        };

            var firstSong = songs.First();
            var lastSong = songs.Last();
            var firstAbove4min = songs.First(s => s.DurationSec > 240);
            var safeResult = songs.FirstOrDefault(s => s.DurationSec > 600);  // safe result

            Console.WriteLine($"First Song: {firstSong.SongName}");
            Console.WriteLine($"Last Song: {lastSong.SongName}");
            Console.WriteLine($"First song above 4 minutes: {firstAbove4min.SongName}");

            if (safeResult != null)
                Console.WriteLine($"First song longer than 10 minutes: {safeResult.SongName}");
            else
                Console.WriteLine("No song longer than 10 minutes found (safe result = null)");
        }
    }
}
