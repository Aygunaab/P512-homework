using System;

namespace task1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.  Sonra yekunda alinanlar iki cavabi vur biri birine.Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap");

            Console.WriteLine("Birinci ededi daxil edin:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Birinci eded: " + a);
            Console.WriteLine("Ikinci ededi daxil edin:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ikinci eded: " + b);
            Console.WriteLine("Ucuncu ededi daxil edin:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ucuncu eded: " + c);
            Console.WriteLine("Dorduncu ededi daxil edin:");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dorduncu eded: " + d);
            if (a >= 100000 & a <= 999999 && b >= 100000 && b <= 999999 && c >= 100000 & c <= 999999 && d >= 100000 && d <= 999999)
            {
                Console.WriteLine("Her 1 ededin 10 faizin tap ve topla");
                double result1 = a * 10 / 100;
                double result2 = b * 10 / 100;
                double result3 = c * 10 / 100;
                double result4 = d * 10 / 100;
                double sum = result1 + result2 + result3 + result4;
                Console.WriteLine( "Cavab: " +sum);
                Console.WriteLine("Sonra hamisinin 15 faizini tap ve topla. ");
                double result5 = a * 15 / 100;
                double result6 = b * 15 / 100;
                double result7 = c * 15 / 100;
                double result8 = d * 15 / 100;
                double sum2 = result5 + result6 + result7 + result8;
                Console.WriteLine("Cavab: " + sum2);
                Console.WriteLine("Sonra yekunda alinanlar iki cavabi vur biri birine");
                double multiply = sum * sum2;
                Console.WriteLine("Cavab: "+multiply);
                Console.WriteLine("Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap");
                double Result = (multiply * 10 / 100) * 11 / 100;
                Console.WriteLine("Netice: "+Result);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz eded 6reqemli deyil");
            }
        }
    }
}
