using System;

namespace task1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int Number;
            int x = 70000;
            int y = 8;
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Evveline 7 sonuna 8 elave etmek istediyiniz 4 reqemli ededi daxil edin");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 1000 && Number <= 9999)
                {
                    int result = (Number + x) * 10 + y;
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
