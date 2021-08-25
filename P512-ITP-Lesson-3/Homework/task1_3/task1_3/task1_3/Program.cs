using System;

namespace task1_3
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
                Console.WriteLine("5 reqemli ededin evvel  18 % sonra ise 3 % -in tapmaq ucun ededi daxil edin.");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 10000 && Number <= 99999)
                {
                    int result1 = Number *18/100;
                    int result2 = result1 * 3/100;
                    Console.WriteLine(result1);
                    Console.WriteLine(result2);
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 5 reqemli deyil");
                }
            }
        }
    }
}
