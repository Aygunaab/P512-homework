using System;

namespace task1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir ve bir eded al.  I neticeden II neticeni cix.Alinan cavabin 10 % tap.Neticenin uzerine V ve VI ededleri gel.Yekunda alinan cavabin 11 % tap.");
            Console.WriteLine("6 dene 6 reqemli eded daxil et.");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double v = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Eded 1:" +a);
            Console.WriteLine("Eded 2:" + b);
            Console.WriteLine("Eded 3:" + v);
            Console.WriteLine("Eded 4:" + c);
            Console.WriteLine("Eded 5:" + d);
            Console.WriteLine("Eded 6:" + e);

            if (a>=100000&&a<=999999 &&b>=100000&&b<=999999&&v>=100000&&v<=999999 && c >= 100000 && c <= 999999 && d >= 100000 && d <= 999999 && e >= 100000 && e <= 999999 )          {
                Console.WriteLine("Evvel hamisini topla ");
                double sum = a + b + v + c + d + e;
                Console.WriteLine("Cavab: "+sum);
                Console.WriteLine(" Sonra I ve III ededi bir birine yapishdir ve bir eded al.");
                double NewNumber = a * 1000000 + v;
                Console.WriteLine("Birlesmis eded:" +NewNumber);
                Console.WriteLine(" I neticeden II neticeni cix.");
                double minus = sum - NewNumber;
                Console.WriteLine(minus);
                Console.WriteLine("Alinan cavabin 10% tap. Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap.");
                double Result = ((minus * 10 / 100) + d + e) * 11 / 100;
                Console.WriteLine("Netice: " +Result);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz eded 6 reqemli deyil");
            }

        }
    }
}
