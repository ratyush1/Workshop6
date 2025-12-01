namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object of Rectangle
            Rectangle rect = new Rectangle();

            // Assign values
            rect.Length = 10.5;
            rect.Breadth = 5.2;

            // Display details
            Console.WriteLine(rect.ShowDetails());

            // Display area
            Console.WriteLine("Area: " + rect.GetArea());
        }
    }
}
