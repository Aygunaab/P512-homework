using System;

namespace task2._9
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


                Console.WriteLine("Doqquz reqemli ededdin tek yerde dayanan reqemlerinden bir eded duzlet ");

                Console.WriteLine("Ededi daxil edin");
                int number = Convert.ToInt32(Console.ReadLine());
                
                if (number >= 100000000 && number<=999999999)
                {
                   int newNumber;
                    Console.WriteLine("Verilmis ededdin tek yerde duran reqemlerinden ainan eded ");
                    newNumber=(((GetDigit(number,9)*10+GetDigit(number,7))*10+GetDigit(number,5))*10+GetDigit(number,3))*10+GetDigit(number,1
                    );
                    Console.WriteLine(newNumber);


                }

                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 9 reqemli deyil");
                }

            }
        }
    }
    }

