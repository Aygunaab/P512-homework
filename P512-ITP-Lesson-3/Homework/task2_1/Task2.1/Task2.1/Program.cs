using System;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int sum = 0;
          
                Console.Write("Ededi daxil edin: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n >= 1000 && n <= 9999)
                {
                    while (n != 0)
                    {
                        sum += n % 10;
                        n /= 10;

                    }
                    Console.WriteLine("Daxil etdiyiniz ededin cemi : " + sum);
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil");
                }
            }

           
           
        }

    }
    
