using System;

namespace task1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 dene 4 reqemli eded verilib.  I ededin 1%-ni, II ededin 2% , III ededin 3 % tap. Neticeleri bir birinden cix.Alinan cavabin ustune III ededin 7 % faizini gel");
            Console.WriteLine("Birinci ededi daxil edin");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Birinci eded: " +a);
            Console.WriteLine("Ikinci ededi daxil edin");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ikinci eded: " + b);

            Console.WriteLine(" Ucuncu ededi daxil edin");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ucuncu  eded: " + c);

            if (a>=1000&&a<=9999&b>=1000&&b<=9999&&c>=1000&&c<=9999)
            {
                Console.WriteLine("I ededin 1%-ni tap");
                double result1 = a * 1 / 100;
                Console.WriteLine("Cavab: " + result1);

                Console.WriteLine("II ededin 2%-ni tap");
                double result2 = b * 2 / 100;
                Console.WriteLine("Cavab:  " + result2);

                Console.WriteLine("III ededin 3%-ni tap");
                double result3 = c * 3 / 100;
                Console.WriteLine("Cavab:  " + result3);
                Console.WriteLine("Neticeleri bir birinden cix");
                double minus = result1 - result2 - result3;
                Console.WriteLine("Cavab:" + minus);
                Console.WriteLine("Alinan cavabin ustune III ededin 7 % faizini gel");
                double Result = minus + (c * 7 / 100);
                Console.WriteLine("Netice:" + Result);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz eded 4reqemli deyil");
            }
        }
    }
}
