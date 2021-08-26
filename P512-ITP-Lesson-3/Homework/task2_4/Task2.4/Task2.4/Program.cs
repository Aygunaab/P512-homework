using System;

namespace Task2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<5)
            {
                int firstDigit;
                int LastDigit;
                int sum;
                int result;

                Console.Write("1 ci ve sonuncu reqemlerinin cemlerinin kvadratini hesablayacaginiz 5 reqemli ededi daxil edin: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n >= 10000 && n <= 99999)
                {
                    firstDigit = n % 10;
                    LastDigit = n / 10000;
                    sum = firstDigit + LastDigit;
                    result = sum * sum;


                    Console.WriteLine("5reqemli ededin 1ci ve sonuncu reqemlerinin kvadrati: " + result + " dir");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 5 reqemli deyil");
                }
            
        }
        }
    
    }
}

