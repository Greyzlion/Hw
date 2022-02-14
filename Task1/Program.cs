using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double exam1 = 0, exam2 = 0;
            double average = (exam1 + exam2) / 2;
            Console.WriteLine("Birinci imtahani daxil edin");
        first:

         exam1 = Convert.ToDouble(Console.ReadLine());
        second:
            Console.WriteLine("Ikinci imtahan neticesini daxil edin:");

            exam2 = Convert.ToDouble(Console.ReadLine());
            CalcAvg(average);
        }
        static void CalcAvg(double average)
        {
            if (average >= 60)
            {
                Console.WriteLine("Mezun oldunuz");
            }
            else
            {
                Console.WriteLine("Mezun ola bilmediniz");
            }


        }
    }
        
}
