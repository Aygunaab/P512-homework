using System;

namespace task2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {


                Console.WriteLine(" Verilmihs 4 reqemli ededi tersine duzub evveline  ve axirina 8 elave et  ");

                Console.WriteLine("Ededi daxil edin");
                int n = Convert.ToInt32(Console.ReadLine());
                int reverse=0;
                int rem;
                int result;

                if (n >= 1000 && n <= 9999)
                {
                    while (n != 0)
                    {
                        rem = n % 10;
                        reverse = reverse * 10 + rem;
                        n /= 10;
                    }
                    result = (reverse + 80000) * 10 + 8;
                    Console.WriteLine("Cevrilmis evveline  ve sonuna 8 elave edilmis reqem: " + result);
                }


            
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 8 reqemli deyil");
                }

            }
        }
    }
}
