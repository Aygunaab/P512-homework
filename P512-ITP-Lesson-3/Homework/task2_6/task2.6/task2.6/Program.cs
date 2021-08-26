using System;

namespace task2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {


                Console.Write(" Verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et  ");
                Console.Write("Ededi daxil edin");
                int n = Convert.ToInt32(Console.ReadLine());
                int RemovLastDigit;
                int RemovFirstDigit;
                int newNumber;
  
                if (n >= 10000000 && n <= 99999999)
                {
                    RemovLastDigit = n / 10;
                    RemovFirstDigit = RemovLastDigit % 1000000;
                   


                    Console.WriteLine("1 ci ve sonuncu reqemin legv etmekle alinan eded " + RemovFirstDigit + " dir");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 8 reqemli deyil");
                }

            }
        }
    }
}
