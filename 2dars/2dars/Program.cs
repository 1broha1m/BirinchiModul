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

        Console.WriteLine(Kub);


        Console.Write("Kunni kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());
        Console.Write("Soatni kiriting : ");
        int secondIntValue = int.Parse(Console.ReadLine());

        string result = $"Jami : {firstIntValue * 24 + secondIntValue} sogot";

        Console.Write(result);



        Console.Write("Daqiqani kiriting : ");
        int firstIntValue = int.Parse(Console.ReadLine());
        Console.Write("Soatni kiriting : ");
        int secondIntValue = int.Parse(Console.ReadLine());

        string result = $"Jami : {firstIntValue * 60 + secondIntValue * 60 * 60} soniya";

        Console.Write(result);
















        //1.5-Mashqlaaa


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural > 0 && Natural % 2 != 1)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }



        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural > 0 && Natural % 2 == 1)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }

        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural > 10 && Natural < 99)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural > 1000 && Natural < 9999)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }

        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural > 10 && Natural < 99 && Natural % 2 != 1)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural > 100 && Natural < 999 && Natural % 2 == 1)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural > 1000 && Natural < 9999 && Natural % 2 != 1)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());

        if (Natural % 2 == 1 && FirstNatural % 2 == 1)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());

        if (Natural % 2 != 1 && FirstNatural % 2 != 1)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }



        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());

        if (Natural % 2 == 1 && FirstNatural % 2 == 1 && Natural > 10 && Natural < 99 && FirstNatural > 10 && FirstNatural < 99)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        int resultOne = (Natural / 1) % 10;
        int resultTwo = (Natural / 10) % 10;

        if (Natural > 10 && Natural < 99 && resultOne + resultTwo > 10)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }

        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        int resultOne = (Natural / 1) % 10;
        int resultTwo = (Natural / 10) % 10;

        if ( Natural > 10 && Natural < 99 && resultOne * resultTwo > 20)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        int resultOne = (Natural / 1) % 10;
        int resultTwo = (Natural / 10) % 10;

        if (Natural > 10 && Natural < 99 && resultOne % 2 == 1 && resultTwo % 2 == 1)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        int resultOne = (Natural / 1) % 10;
        int resultTwo = (Natural / 10) % 10;

        if (Natural > 10 && Natural < 99 && resultOne > 5 && resultTwo > 5)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        } 


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural / 3 == 0)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural / 7 == 0)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural / 3 == 0 && Natural / 8 == 0)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural % 5 != 0)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());

        if (Natural % 4 == 0 && Natural % 3 != 0)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }



        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());

        if (Natural > FirstNatural)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());

        if (Natural == FirstNatural)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }

        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int SecondNatural = int.Parse(Console.ReadLine());

        if (Natural > FirstNatural && Natural > SecondNatural)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }




        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int SecondNatural = int.Parse(Console.ReadLine());

        if (SecondNatural > FirstNatural && SecondNatural > Natural)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int SecondNatural = int.Parse(Console.ReadLine());

        if (FirstNatural < Natural && FirstNatural < SecondNatural)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());

       

        if (FirstNatural * 2 * 2 < Natural)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());



        if (FirstNatural * 5 * 5 < Natural)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }*/


        /* Console.Write("Son kiriting : ");
         int Natural = int.Parse(Console.ReadLine());
         Console.Write("Son kiriting : ");
         int FirstNatural = int.Parse(Console.ReadLine());



         if (FirstNatural - 30  < Natural)
         {
             Console.Write("True");
         }
         else
         {
             Console.Write("False");
         }


        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int SecondNatural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int ThreeNatural = int.Parse(Console.ReadLine());

        if (FirstNatural > Natural && FirstNatural > SecondNatural && FirstNatural > ThreeNatural && FirstNatural % 2 != 1)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }*/




        Console.Write("Son kiriting : ");
        int Natural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int FirstNatural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int SecondNatural = int.Parse(Console.ReadLine());
        Console.Write("Son kiriting : ");
        int ThreeNatural = int.Parse(Console.ReadLine());

        if (ThreeNatural < Natural && ThreeNatural < FirstNatural && ThreeNatural < SecondNatural && ThreeNatural % 2 != 1)
        {
            Console.Write("True");
        }
        else
        {
            Console.Write("False");
        }







    }
}
