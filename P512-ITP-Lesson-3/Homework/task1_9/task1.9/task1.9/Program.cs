using System;

namespace task1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.");
            double a = 123456;
            double b = 987654;
            double c = 567843;
            Console.WriteLine( "Birinci eded:  "+a);
            Console.WriteLine("Ikinci eded:  " + b);
            Console.WriteLine("ucuncu eded:  " + c);
            Console.WriteLine();
            double result;
            result = ((a * 10 / 100) + (b * 10 / 100) + (c * 10 / 100)) * 10 / 100;
            Console.WriteLine("Serte uygun alinan cavab:  "+result+"-dir");

        }
    }
}
