using System;

namespace task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            int x = 1001;
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Sonuna ozunu elave etmek istediyiniz 3 reqemli ededi daxil edin");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 100 && Number <= 999)
                {
                    int result = Number*x;
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
