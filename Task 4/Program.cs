namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1️⃣ SELECTING / PROJECTION (Select)
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var squaredNumbers = numbers.Select(n => n * n);

            Console.WriteLine("Squared Numbers:");
            foreach (var s in squaredNumbers)
            {
                Console.WriteLine(s);
            }

            // 2️⃣ FILTERING (Where)          
            List<Book> books = new List<Book>
        {
            new Book { Title = "Science", Price = 850 },
            new Book { Title = "Maths", Price = 1500 },
            new Book { Title = "Social", Price = 2000 },
            new Book { Title = "Nepali", Price = 950 }
        };

            var premiumBooks = books.Where(b => b.Price > 1000);

            Console.WriteLine("\nPremium Books (Price > Rs. 1000):");
            foreach (var book in premiumBooks)
            {
                Console.WriteLine($"{book.Title} - Rs. {book.Price}");
            }


            // 3️⃣ SORTING (OrderBy)
       
            List<Student> students = new List<Student>
        {
            new Student { Name = "Pratyush" },
            new Student { Name = "Priyanshu" },
            new Student { Name = "Niya" },
            new Student { Name = "Aaryan" },
            new Student { Name = "Amit" },
            new Student { Name = "Mahima" },
            new Student { Name = "Bhoj" },
            new Student { Name = "Sima" },
            new Student { Name = "Anish" },
            new Student { Name = "Gita" }
        };

            var sortedStudents = students.OrderBy(s => s.Name);

            Console.WriteLine("\nSorted Student Names:");
            foreach (var s in sortedStudents)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
