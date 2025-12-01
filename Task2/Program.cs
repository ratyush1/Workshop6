namespace Task2
{
    internal class Program

    {
        // 1. Define delegate
        public delegate double DiscountStrategy(double price);

        // 2. Discount Methods
        public static double FestivalDiscount(double price)
        {
            return price - (price * 0.20);   // 20% off
        }

        public static double SeasonalDiscount(double price)
        {
            return price - (price * 0.10);   // 10% off
        }

        public static double NoDiscount(double price)
        {
            return price;                    // No discount
        }

        public static double CalculateFinalPrice(double originalPrice,
                                         DiscountStrategy strategy)
        {
            return strategy(originalPrice);  // call the delegate
        }

        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;

        static void Main(string[] args)
        {
            double price = 1000;

            // 2.2 Call with each discount method
            Console.WriteLine("Festival Discount: " +
                CalculateFinalPrice(price, FestivalDiscount));

            Console.WriteLine("Seasonal Discount: " +
                CalculateFinalPrice(price, SeasonalDiscount));

            Console.WriteLine("No Discount: " +
                CalculateFinalPrice(price, NoDiscount));

            // 2.3 Call again using Lambda Expression (30% off)
            Console.WriteLine("Lambda 30% Discount: " +
                CalculateFinalPrice(price, p => p - (p * 0.30)));

            // assign Add() to the delegate
            Calculate calc = Add;
            Console.WriteLine("Addition: " + calc(10, 5));

            // assign Subtract() to the same delegate
            calc = Subtract;
            Console.WriteLine("Subtraction: " + calc(10, 3));



        }
    }
}
