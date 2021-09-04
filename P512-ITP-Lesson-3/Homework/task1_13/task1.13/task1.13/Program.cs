using System;

namespace task1._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine. Sonra 3 reqemli ededlerin 3 % tap, neticeleri topla.Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla");
            Console.WriteLine("3 dene 5 reqemli ededi daxil edin");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2 dene 3 reqemli ededi daxil edin");
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Birinci eded:"+a);
            Console.WriteLine("Ikinci eded:" + b);
            Console.WriteLine("Ucuncu eded:" + c);
            Console.WriteLine("Dorduncu eded:" + d);
            Console.WriteLine("Besinci eded:" + e);
            double multiply;
            double sum;
            
                double result1 = a * 5 / 100;
                double result2 = b * 5 / 100;
                double result3 = c * 5 / 100;
                multiply = result1 * result2 * result3;
                Console.WriteLine("5reqemli ededlerin 5 faizinin hasili: " + multiply);
            
                double result4 = d * 3 / 100;
                double result5 = e * 3 / 100;

                sum = result4 + result5;
                Console.WriteLine("3reqemli ededlerin 10 faizinin cemi: " + sum);

            double Result = (multiply * 10 / 100) + (sum * 10 / 100);
            Console.WriteLine("Netice : "+Result);
           
           


        }
    }
}
