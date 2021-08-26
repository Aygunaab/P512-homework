using System;

namespace task2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<5)
            {
              
                
                Console.Write("1 ci reqemini sonuna elave edeceyiniz 6 reqemli ededi daxil edin: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int firstDigit;
                int newNumber;
                int result;
                if (n >= 100000 && n <= 999999)
                {
                    firstDigit = n / 100000;
                    newNumber = n % 100000;
                    result = newNumber * 10 + firstDigit;


                    Console.WriteLine("1ci ededi sonuna elave ederek aldigimiz 6 reqemli eded " + result + " dir");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 6 reqemli deyil");
                }

            

        }

        }
    }
}
