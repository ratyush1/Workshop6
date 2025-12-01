using System;

public class NumberProcessor
{
    public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (var n in numbers)
        {
            if (condition(n))
            {
                Console.WriteLine(n);
            }
        }
    }
}
