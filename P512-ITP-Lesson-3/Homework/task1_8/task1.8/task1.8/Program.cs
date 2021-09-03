using System;

namespace task1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir. I ededin 4 % -ni tap.Sonra II ededin 9 % ni tap.Sonra Cavalari toplayib 10 % ni tap.");
            double NumberOne = 2345;
            double NumberTwo = 9876543;
            double result = ((NumberOne * 4 / 100) + (NumberTwo * 9 / 100)) * 10 / 100;
            Console.WriteLine( "Cavab: "+result+"-dir");
        }
    }
}
