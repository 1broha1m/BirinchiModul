namespace _5_dars;

internal class Program
{
    static void Main(string[] args)
    {

        //1.5.1.1-Mashq
        //Console.Write("Son kiriting : ");
        //var nums = int.Parse(Console.ReadLine());
        //List<int> threeDigitNumbers = new List<int>();
        //var count = 0;
        //for ( var i = 1; i <= nums; i++)
        //{
        //    Console.Write($"Listdagi {i} - sonni kiriting :");
        //    var num = int.Parse(Console.ReadLine());
        //    threeDigitNumbers.Add(num);
        //    if(num > 100 && num < 999)
        //    {
        //        count++;
        //    }
        //}
        //Console.Write($"Listdagi barcha uch xonali sonlar {count} ta");


        //1.5.1.2-Mashq
        //Console.Write("Son kiriting : ");
        //var nums = int.Parse(Console.ReadLine());
        //List<int> threeDigitNumbers = new List<int>();
        //var count = 0;
        //for (var i = 1; i <= nums; i++)
        //{
        //    Console.Write($"Listdagi {i} - sonni kiriting :");
        //    var num = int.Parse(Console.ReadLine());
        //    threeDigitNumbers.Add(num);
        //    if (num % 2 == 0)
        //    {
        //        count++;
        //    }
        //}
        //Console.Write($"Listdagi barcha juft sonlar {count} ta");


        //1.5.1.3-Mashq
        //Console.Write("Son kiriting : ");
        //var nums = int.Parse(Console.ReadLine());
        //List<int> threeDigitNumbers = new List<int>();
        //var count = 0;
        //for (var i = 1; i <= nums; i++)
        //{
        //    Console.Write($"Listdagi {i} - sonni kiriting :");
        //    var num = int.Parse(Console.ReadLine());
        //    threeDigitNumbers.Add(num);
        //    if (num % 2 != 0)
        //    {
        //        count++;
        //    }
        //}
        //Console.Write($"Listdagi barcha toq sonlar {count} ta");


        //1.5.1.4-Mashq
        //Console.Write("Son kiriting : ");
        //var nums = int.Parse(Console.ReadLine());
        //List<int> threeDigitNumbers = new List<int>();
        //var count = 0;
        //for (var i = 1; i <= nums; i++)
        //{
        //    Console.Write($"Listdagi {i} - sonni kiriting :");
        //    var num = int.Parse(Console.ReadLine());
        //    threeDigitNumbers.Add(num);
        //    if (num % 3 == 0 || num % 7 == 0)
        //    {
        //        count++;
        //    }
        //}
        //Console.Write($"Listdagi barcha toq sonlar {count} ta");


        //1.5.1.5-Mashq
        //Console.Write("Son kiriting : ");
        //var nums = int.Parse(Console.ReadLine());
        //List<int> threeDigitNumbers = new List<int>();
        //var count = 0;
        //var total = 0;
        //for (var i = 1; i <= nums; i++)
        //{
        //    Console.Write($"Listdagi {i} - sonni kiriting :");
        //    var num = int.Parse(Console.ReadLine());
        //    threeDigitNumbers.Add(num);
        //    if (num > 10 && num < 100 && num % 2 != 0)
        //    {
        //        count++;
        //        total += num;
        //    }
        //}
        //Console.Write($"Listdagi barcha toq sonlar {count} ta Ularning jami yigindi {total}");


        //1.5.1.7 - Mashq
        //Console.Write("Son kiriting : ");
        //var nums = int.Parse(Console.ReadLine());
        //List<int> threeDigitNumbers = new List<int>();
        //var total = 0;

        //for (var i = 1; i <= nums; i++)
        //{
        //    Console.Write($"Listdagi {i} - sonni kiriting :");
        //    var num = int.Parse(Console.ReadLine());
        //    threeDigitNumbers.Add(num);
        //    if(num <= 3)
        //    {
        //        total+= num;
        //    }
        //}
        //Console.Write($"Jami {total}");


        //1.5.1.9 - Mashq
        //Console.Write("Son kiriting : ");
        //var nums = int.Parse(Console.ReadLine());
        //List<int> threeDigitNumbers = new List<int>();
        //var odd = 0;
        //var couple = 0;

        //for (var i = 1; i <= nums; i++)
        //{
        //    Console.Write($"Listdagi {i} - sonni kiriting :");
        //    var num = int.Parse(Console.ReadLine());
        //    threeDigitNumbers.Add(num);
        //    if (num % 2 == 0)
        //    {
        //        odd++;
        //    }
        //    else
        //    {
        //        couple++;
        //    }
        //}
        //if (odd < couple)
        //{
        //    Console.Write("True");
        //}
        //else if (odd > couple || odd == couple)
        //{
        //    Console.Write("False");
        //}


        Console.Write("Son kiriting : ");
        var nums = int.Parse(Console.ReadLine());
        List<int> threeDigitNumbers = new List<int>();
        var couple = 0;

        for (var i = 1; i <= nums; i++)
        {
            Console.Write($"Listdagi {i} - sonni kiriting :");
            var num = int.Parse(Console.ReadLine());
            threeDigitNumbers.Add(num);
            if (num % 2 == 0)
            {
            nums *= 3;
        }
    }

        foreach (var num in threeDigitNumbers)
        {
            Console.Write(num);
        }





    }
}
