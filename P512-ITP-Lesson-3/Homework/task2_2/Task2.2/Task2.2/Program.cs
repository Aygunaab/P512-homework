using System;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<5)
            {
                int sum = 0;
                int NewNumber;

                Console.Write("Ilk uc reqeminin cemini hesablayacaginiz 6 reqemli ededi daxil edin: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n >= 100000 && n <= 999999)
                {

                    NewNumber = n / 1000;
                    while (NewNumber != 0)
                    {
                        sum += NewNumber % 10;
                        NewNumber /= 10;

                    }
                    Console.WriteLine("6 reqemli ededin ilk 3 reqeminin cemi: " + sum +"dir");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 6 reqemli deyil");
                }

            }
        }



    }
}

