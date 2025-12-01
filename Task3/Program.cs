using System;

class Program
{
    static void Main()
    {
        int[] nums = { 2, 5, 8, 12, 19, 20, 7 };

        Console.WriteLine("Even Numbers:");
        NumberProcessor.ProcessNumbers(nums, n => n % 2 == 0);

        Console.WriteLine("\nNumbers Greater Than 10:");
        NumberProcessor.ProcessNumbers(nums, n => n > 10);
    }
}
