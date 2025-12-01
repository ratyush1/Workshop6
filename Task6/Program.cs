namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookings = new List<TourBooking>()
        {
             new TourBooking { CustomerName="Pratyush", Destination="Pokhara", Price=8000, DurationInDays=3, IsInternational=false },
            new TourBooking { CustomerName="Priyanshu", Destination="Thailand", Price=35000, DurationInDays=5, IsInternational=true },
            new TourBooking { CustomerName="Niya", Destination="Chitwan", Price=12000, DurationInDays=4, IsInternational=false },
            new TourBooking { CustomerName="Sima", Destination="Dubai", Price=50000, DurationInDays=7, IsInternational=true },
            new TourBooking { CustomerName="Aaryan", Destination="Mustang", Price=15000, DurationInDays=6, IsInternational=false }
        };

            // STEP 1: FILTER
            var filteredTours = bookings
                .Where(t => t.Price > 10000 && t.DurationInDays > 4);

            // STEP 2: TRANSFORMATION (Projection using SELECT)
            var projectedTours = filteredTours
                .Select(t => new
                {
                    CustomerName = t.CustomerName,
                    Destination = t.Destination,
                    Category = t.IsInternational ? "International" : "Domestic",
                    Price = t.Price
                });

            // STEP 3: SORTING
            var finalList = projectedTours
                .OrderBy(t => t.Category)          // Domestic first (comes alphabetically before International)
                .ThenBy(t => t.Price);             // Then sort by Price

            // STEP 4: DISPLAY
            Console.WriteLine("FINAL TOUR SUMMARY REPORT");
            foreach (var t in finalList)
            {
                Console.WriteLine($"Customer: {t.CustomerName}");
                Console.WriteLine($"Destination: {t.Destination}");
                Console.WriteLine($"Category: {t.Category}");
                Console.WriteLine($"Price: Rs. {t.Price}");
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
