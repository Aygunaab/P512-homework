using System;

namespace task1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV ededi gel.  Sonra cavablari vur birbirine.Alinan neticeden III ededin 3 % -ni cix.");
            Console.WriteLine("Birinci ededi daxil edin:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Birinci eded: "+a);
            Console.WriteLine("Ikinci ededi daxil edin:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ikinci eded: " + b);
            Console.WriteLine("Ucuncu ededi daxil edin:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ucuncu eded: " + c);
            Console.WriteLine("Dorduncu ededi daxil edin:");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dorduncu eded: " + d);
            if (a>=10000&a<=99999&&b>=10000&&b<=99999&& c >= 10000 & c <= 99999 && d >= 10000 && d <= 99999)
            {
                Console.WriteLine("Her I ededin ustune III ededi gel");
                double result1 = a + c;
                Console.WriteLine("Cavab: " + result1);
                Console.WriteLine(" II ededin usutune IV ededi gel");
                double result2 = b + d;
                Console.WriteLine("Cavab: " + result2);
                Console.WriteLine("cavablari vur birbirine");
                double multiply = result1 * result2;
                Console.WriteLine("Cavab: " + multiply);
                Console.WriteLine("Alinan neticeden III ededin 3 % -ni cix.");
                double result = multiply - (c * 3 / 100);
                Console.WriteLine("Netice: " + result);

            }

        }
    }
}
