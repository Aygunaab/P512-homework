using System;
using System.Linq;

namespace task2._10
{
    class Program
    {
        public static int GetDigit(int number, int digit)
        {
            for (var i = 0; i < digit - 1; i++)
                number /= 10;
            return number % 10;
        }

        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {


                Console.WriteLine("9 reqemli ededdi tek yerde dayananlardan bir eded duzlet, sonra cut yerde dayanlarinda bir eded duzlet,sonra onlari topla ");

                Console.WriteLine("Ededi daxil edin");
                int number = Convert.ToInt32(Console.ReadLine());
                int sum;

                if (number >= 100000000 && number <= 999999999)
                {
                    int newNumberOne;
                    Console.WriteLine("Verilmis ededdin tek yerde duran reqemlerinden ainan eded ");
                    newNumberOne = (((GetDigit(number, 9) * 10 + GetDigit(number, 7)) * 10 + GetDigit(number, 5)) * 10 + GetDigit(number, 3)) * 10 + GetDigit(number, 1
                    );
                    Console.WriteLine(newNumberOne);

                    int newNumberTwo;
                    Console.WriteLine("Verilmis ededdin cut yerde duran reqemlerinden alinan eded ");
                    newNumberTwo = (((GetDigit(number, 8) * 10 + GetDigit(number, 6)) * 10 + GetDigit(number, 4)) * 10 + GetDigit(number, 2));
                    Console.WriteLine(newNumberTwo);
                    sum = newNumberOne + newNumberTwo;
                    Console.WriteLine("9 reqemli daxil etdiyiniz ededden alinan yeni ededlerin cemi");
                    Console.WriteLine(sum);


                }



                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 9 reqemli deyil");
                }

            }
        }

    }
}
