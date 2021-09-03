using System;

namespace task1._7
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap");

            int numberOne = 12345;
            int numberTwo = 98765;
            int sum;
            int NewNumber;
            int result;
            sum = numberOne + numberTwo;
            Console.WriteLine();
            Console.WriteLine( "Verilmis ededlerin cemi" +"   "+sum);
            NewNumber = (sum + 5000000) * 10 + 5;
            Console.WriteLine("Evveline ve sonuna 5 artirmaqla alinan yeni eded"+" "+NewNumber);
            result = NewNumber * 5 / 100;
            Console.WriteLine( "Yeni ededin 5 faizinin tapilmasi "+" "+result);

            



        }
    }
}
