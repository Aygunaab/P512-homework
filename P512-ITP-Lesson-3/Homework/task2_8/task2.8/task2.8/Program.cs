using System;

namespace task2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {


                Console.WriteLine(" Verilmihs ededin axirdan 3cu reqemi ile sonuncu reqeminin cemini hesabla ");

                Console.WriteLine("Ededi daxil edin");
                int n = Convert.ToInt32(Console.ReadLine());
                int LastDigit;
                int newNumber;
                int LastThreeDigit;
                int sum;

                

                if (n >= 100)
                {
                    LastDigit = n % 10;
                   newNumber = n / 100;
                    LastThreeDigit = newNumber % 10;
                    sum = LastDigit + LastThreeDigit;
                    
                    Console.WriteLine("Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemi: " + sum+"dir");
                }



                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 3 reqemden  az oldugu ucun serte uygun hesablama aparila bilmez");
                }

            }
        }
    }
}
