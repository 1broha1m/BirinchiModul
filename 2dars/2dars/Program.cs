using System.Collections.Concurrent;

namespace BirinchiDars;

internal class Program
{
    static void Main(string[] args)
    {

        //1.3-Mashqla//

        /*Console.Write("Sonni kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());

        if (firstIntValue > 10 && firstIntValue < 99)
        {
            Console.Write(firstIntValue % 10);
        }
        else
        {
            Console.WriteLine("Bu son 2 xonali emas");
        }

        Console.Write("Sonni kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());

        if (firstIntValue > 100 && firstIntValue < 999)
        {
            Console.Write((firstIntValue / 10) % 10);
        }
        else
        {
            Console.WriteLine("Bu son 3 xonali emas");
        }


        Console.Write("Sonni kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());

        if (firstIntValue > 100 && firstIntValue < 999)
        {
            Console.Write((firstIntValue / 100) % 10);
        }
        else
        {
            Console.WriteLine("Bu son 3 xonali emas");
        }


        Console.Write("Sonni kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());

        if (firstIntValue > 10000 && firstIntValue < 99999)
        {
            Console.Write((firstIntValue / 1000) % 10);
        }
        else
        {
            Console.WriteLine("Bu son 5 xonali emas");
        }

        Console.Write("Sonni kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());

        if (firstIntValue > 1000 && firstIntValue < 9999)
        {
            Console.Write((firstIntValue / 10) % 10);
        }
        else
        {
            Console.WriteLine("Bu son 5 xonali emas");
        }


        Console.Write("Sonni kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());

        if (firstIntValue > 100 && firstIntValue < 999)
        {
            int Yuzliklar = (firstIntValue / 100) % 10;
            int Onliklar = (firstIntValue / 10) % 10;
            int Birliklar = firstIntValue % 10;
            Console.Write(Yuzliklar + Onliklar + Birliklar);
        }
        else
        {
            Console.WriteLine("Bu son 3 xonali emas !!!");
        }


        Console.Write("Sonni kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());
        if (firstIntValue > 100 && firstIntValue < 999)
        {
            int Yuzliklar = (firstIntValue / 100) % 10;
            int Onliklar = (firstIntValue / 10) % 10;
            int Birliklar = firstIntValue % 10;
            Console.Write(Yuzliklar * Onliklar * Birliklar);
        }
        else
        {
            Console.WriteLine("Bu son 3 xonali emas !!!");
        }


        Console.Write("Sonni kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());
        if (firstIntValue > 10 && firstIntValue < 99)
        {
            int Onliklar = (firstIntValue / 10) % 10;
            int Birliklar = firstIntValue % 10;
            Console.Write(Onliklar * Birliklar);
        }
        else
        {
            Console.WriteLine("Bu son 2 xonali emas !!!");
        }


        Console.Write("Sonni kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());
        if (firstIntValue > 10000 && firstIntValue < 99999)
        {
            int OnMinglar = (firstIntValue / 10000) % 10;
            int Minglar = (firstIntValue / 1000) % 10;
            int Yuzliklar = (firstIntValue / 100) % 10;
            int Onliklar = (firstIntValue / 10) % 10;
            int Birliklar = (firstIntValue / 1) % 10;

            Console.Write(OnMinglar + Minglar + Yuzliklar + Onliklar + Birliklar );
        }
        else
        {
            Console.WriteLine("Bu son 5 xonali emas !!!");
        }


        Console.Write("Sizda necha GB bor : ");
        int firstIntValue = int.Parse(Console.ReadLine());

        Console.Write("Sizda jami : "); Console.Write(firstIntValue * 1024); Console.Write(" Mb bor");


        Console.Write("Sizda necha GB bor : ");
        int firstIntValue = int.Parse(Console.ReadLine());

        Console.Write("Sizda jami : "); Console.Write(firstIntValue / 1024); Console.Write(" TB bor");


        Console.Write("Sizning fleshkangiz necha GB li : ");
        int firstIntValue = int.Parse(Console.ReadLine());

        Console.Write("Sizda jami 2 GB lik kinodan : "); Console.Write(firstIntValue / 2); Console.Write(" ta sigadi");


        Console.Write("Sizning fleshkangiz necha GB li : ");
        int firstIntValue = int.Parse(Console.ReadLine());

        Console.Write("Sizda jami 5 GB lik kinodan : "); Console.Write(firstIntValue / 5); Console.Write(" ta sigadi");
























        //1.4-Mashqla

        Console.Write("Son kiriting : ");
        int firstIntValue = int .Parse(Console.ReadLine());

        int Kvadrat = firstIntValue * firstIntValue;
        int Kub = Kvadrat * Kvadrat;

        Console.WriteLine(Kub);*/


        Console.Write("Son kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());

        int Kvadrat = firstIntValue * firstIntValue;
        int Kub = Kvadrat * firstIntValue;
        int KubM = Kub * Kub;

        Console.Write(KubM);

    }
}
