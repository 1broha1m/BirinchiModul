namespace _4dars;

internal class Program
{

    static int TotalInt (int firstValue, int secondValue)
    {
        int Total = 0;
        Total += firstValue + secondValue;

        return Total;
    }

    static void Main(string[] args)
    {
        Console.Write("1-sonni kiriting : ");
        var firstValue = int.Parse(Console.ReadLine());
        Console.Write("2-sonni kiriting : ");
        var secondValue = int.Parse(Console.ReadLine());

        Console.Write(TotalInt(firstValue, secondValue));

    }
}
