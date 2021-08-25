using System;

namespace task1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            int Number2;
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Sonuna 7 reqemi elave edib alinan neticenin 7 faizini tapacaginiz 3 reqemli ededi daxil edin");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 100 && Number <= 999)
                {
                    Number2 = Number * 10 + 7;
                    int result = Number2 * 7 / 100;
                    Console.WriteLine("Sonuna 7 reqemi elave edilerek alinan eded:");
                    Console.WriteLine(Number2);
                    Console.WriteLine("Alinan ededin 7 faiz neticesi:");
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 3 reqemli deyil");
                }
            }
        }
    }
}
