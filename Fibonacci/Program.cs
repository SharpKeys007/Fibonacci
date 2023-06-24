public class Fibonacci
{
    public static int GetFibonacci(int num)
    {
        if (num < 0)
        {
            throw new InvalidDataException("Value cannot be negative");
        }

        if (num == 0) { return 0; }

        if (num == 1) { return 1; }

        return GetFibonacci(num - 1) + GetFibonacci(num - 2);
    }

    public static int GetWrongFibonacci(int num)
    {
        return -1;
    }

    public static void Main()
    {
        Console.WriteLine("Enter number to calculate Fibonacci");

        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine($"Fibonacci of {n} = " + GetFibonacci(n));
        }
        else
        {
            throw new InvalidDataException("Value should be an integer");
        }

    }
}