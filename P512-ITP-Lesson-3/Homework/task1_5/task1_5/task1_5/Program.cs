using System;

namespace task1_5
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
                Console.WriteLine("Evveline 4 sonuna 44 reqemi elave edeceyiniz  alinan neticenin 44 faizini tapacaginiz 4 reqemli ededi daxil edin");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 1000 && Number <= 9999)
                {
                    Number2 = (Number +40000)*100+44;
                    int result = Number2 * 44 / 100;
                    Console.WriteLine(" evveline 4 Sonuna 44 reqemi elave edilerek alinan eded:");
                    Console.WriteLine(Number2);
                    Console.WriteLine("Alinan ededin 44 faiz neticesi:");
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil");
                }
            }
        }
    }
}
