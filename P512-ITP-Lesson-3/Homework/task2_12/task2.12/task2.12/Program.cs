using System;

namespace task2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;
            int multiply = 1;
            int result;


            Console.Write("Birinci ededi daxil edin: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            int firstDigit = NumberOne % 10;
            Console.Write("Ikinci ededi daxil edin: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());
            if (NumberOne>= 10000 && NumberOne <= 99999)
            {
                while (NumberOne != 0)
                {
                    sum += NumberOne % 10;
                    NumberOne /= 10;

                }
                Console.WriteLine("Daxil etdiyiniz birinci ededin reqemleri cemi : " + sum);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil");
            }
            if (NumberTwo >= 10000 && NumberTwo <= 99999)
            {
                while (NumberTwo != 0)
                {
                    multiply *= NumberTwo % 10;
                    NumberTwo /= 10;

                }
                Console.WriteLine("Daxil etdiyiniz ikinci  ededin reqemleri hasili : " + multiply);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil");
            }
            
            Console.WriteLine( "Regemlerin ceminin uzerine hasilini gelib sonuna birinci ededin axrinci reqemini gelmekle alinan eded:");
            result = (sum + multiply) * 10+firstDigit;
            Console.WriteLine(result);
        }
}
}
