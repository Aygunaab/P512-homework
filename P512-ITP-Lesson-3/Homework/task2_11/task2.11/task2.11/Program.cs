using System;

namespace task2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8 reqemli ededin reqemlerini iki -iki qruplashdir. Qruplarin cemini tap.Alinan cavabin axirina 99 artir.Sonra cavabin ozunden onun 18 % ni cix; ");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Ededi daxil edin");
                int number = Convert.ToInt32(Console.ReadLine());
               

                if (number >= 10000000 && number <= 99999999)
                {
                    int newNumberOne;
                    int newNumberTwo;
                    int newNumberThree;
                    int newNumberFour;
                    int sum;
                    int newNumber;
                    int result;
                    Console.WriteLine("Verilmis ededdin iki iki qruplasmasindan  alinan eded ");
                    newNumberOne = number %100;
                    newNumberTwo = (number % 10000 - newNumberOne)/100;
                    newNumberThree = ((number % 1000000 - newNumberOne)/100-newNumberTwo)/100;
                    newNumberFour = (((number % 100000000 - newNumberOne) / 100 - newNumberTwo )/ 100 - newNumberThree)/100;
                    Console.WriteLine("8 reqemli ededin iki iki qruplasmasindan alinan ededlerin siyahisi:");
                    Console.WriteLine(newNumberOne);
                    Console.WriteLine(newNumberTwo);
                    Console.WriteLine(newNumberThree);
                    Console.WriteLine(newNumberFour);

                    
                    sum = newNumberOne + newNumberTwo+newNumberThree+newNumberFour;
                    Console.WriteLine("Yuxaridaki ededlerin cemi");
                    Console.WriteLine(sum);
                    newNumber = sum * 100 + 99;
                    Console.WriteLine( "cemin axrina 99 elave etmekle alinan eded");
                    Console.WriteLine(newNumber);
                    result = newNumber - newNumber * 18 / 100;
                    Console.WriteLine("cavabin ozunden onun 18% ni cixmaqla alinan cavab");
                    Console.WriteLine(result);

   
                   
                }



                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 9 reqemli deyil");
                }

            }
        }
    }
}
