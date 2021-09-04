using System;

namespace task1._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meselenin serti");
            Console.WriteLine("7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.3 reqemli ededleri topla, sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi. Sonra neticenin axirina 7 reqemini artir.Sonra cavabin ustune gel 5 reqemli ededlerin cemini.Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini Sonra alinan cavabin ustune gel 6 reqemli ededi.Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini. Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.");
            Console.WriteLine("Iki dene 3 reqemli eded daxil edin");
            double Number1 = Convert.ToDouble(Console.ReadLine());
            double Number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iki dene 4 reqemli eded daxil edin");
            double Number3 = Convert.ToDouble(Console.ReadLine());
            double Number4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iki dene 5 reqemli eded daxil edin");
            double Number5 = Convert.ToDouble(Console.ReadLine());
            double Number6 = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Bir dene 6 reqemli eded daxil edin");
            double Number7 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3 reqemli ededleri topla");
            double sum = Number1 + Number2;
            Console.WriteLine("Cavab: "+sum);
            Console.WriteLine("sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.");
            double result1 = sum + Number3 * Number4;
            Console.WriteLine("Cavab: " +result1);
            Console.WriteLine(" Sonra neticenin axirina 7 reqemini artir.");
            double newNumber = result1 * 10 + 7;
            Console.WriteLine("Cavab: "+newNumber);
            Console.WriteLine("Sonra cavabin ustune gel 5 reqemli ededlerin cemini.");
            double sum2 = newNumber + Number5 + Number6;
            Console.WriteLine("Cavab: "+sum2);
            Console.WriteLine("Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.");
            double result2 = sum2 - ((Number1 * Number2) * 10 + 1);
            Console.WriteLine("Cavab: "+result2);
            Console.WriteLine("Sonra alinan cavabin ustune gel 6 reqemli ededi.");
            double result3 = result2 + Number7;
            Console.WriteLine("Cavab: "+result3);
            Console.WriteLine(" Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.");
            double result4 = result3 - (sum + Number3 + Number4);
            Console.WriteLine("Cavab: " +result4);
            Console.WriteLine("Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.");
            double result5 = ((result4 * 18 / 100) * 3 / 100) * 1 / 100;
            Console.WriteLine("Cavab: "+result5);
            Console.WriteLine("Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.");
            double Result = result5 + Number5 + Number6;
            Console.WriteLine("Cavab: " +Result);
        }
    }
    }

