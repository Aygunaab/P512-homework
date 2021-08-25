using System;

namespace task1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            int result1;
            int result2;
            int result3;

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(" Evvel 20%-ni ,  sonra ise cavabin 10% .  Alinan  cavabin kvadratini tapacaginiz 4 reqemli eded daxil edin. .");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 1000 && Number <= 9999)
                {
                    result1 = Number * 20 / 100;
                    result2 = result1 * 10 / 100;
                    result3 = result2 * result2;
                    Console.WriteLine(" Daxil etdiyiniz ededin 20 %-i:");
                    Console.WriteLine(result1);
                    Console.WriteLine("Alinan cavabin 10 faiz neticesi:");
                    Console.WriteLine(result2);
                    Console.WriteLine("cavabin 10 faiz neticesinden alinan cavabin kvadrati ");
                    Console.WriteLine(result3);

                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil");
                }
            }
        }
    }
}
