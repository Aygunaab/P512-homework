using System;

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                int sum = 0;
                int NewNumber;
                int mediumThreeNumber;

                Console.Write("Ortadaki uc reqeminin cemini hesablayacaginiz 9 reqemli ededi daxil edin: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n >= 100000000 && n <= 999999999)
                {

                    NewNumber = n / 1000;
                    mediumThreeNumber = NewNumber % 1000;
                    while (mediumThreeNumber != 0)
                    {
                        sum += mediumThreeNumber % 10;
                        mediumThreeNumber /= 10;

                    }
                    Console.WriteLine("9 reqemli ededin ortadaki 3 reqeminin cemi: " + sum + "dir");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 9 reqemli deyil");
                }

            }
        }
    }
}
