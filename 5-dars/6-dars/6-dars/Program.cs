namespace _6_dars;

internal class Program
{
    static void Main(string[] args)
    {

        //----------------1-funksiyala-----------
        Console.WriteLine(Add(75, 23));
        Console.WriteLine(Add(34, 56, 12));
        Console.WriteLine(Add("Salom", "Salom dunyo"));


        //--------------2-funksiya-------------
        Console.WriteLine(Numbers(4,10));


        //------------------3-funksiya----------
        Console.WriteLine(calculate(3,5));
        Console.WriteLine(calculate(4,5,6));
    }


    static float Add(float firstValue, float secondValue)
    {
        return firstValue + secondValue;
    }

    static float Add(float firstValue, float secondValue, float threeValue)
    {
        return secondValue + firstValue + threeValue;
    }

    static string Add(string firstTetx, string secondTetx)
    {
        return firstTetx + secondTetx;
    }


    static int Numbers(int firstValue, int secondValue)
    {
        for(var  i = 0; i < secondValue; i++) 
        {
            Console.Write($"{firstValue}, ");
        }

        return firstValue;
    }


    static float calculate(float firstValue, float secondValue)
    {
        return firstValue + secondValue;
    }

    static float calculate(float firstValue, float secondValue, float threeValue)
    {
        return firstValue * secondValue * threeValue;
    }
}
