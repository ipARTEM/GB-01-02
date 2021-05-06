using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер текущего месяца: ");
            string number = Console.ReadLine();
            int iNumber = Convert.ToInt32(number);

            Console.WriteLine("Введите минимальную температуру за сутки в Цельсиях : ");
            string min = Console.ReadLine();

            Console.WriteLine("Введите максимальную температуру за сутки в Цельсиях : ");
            string max = Console.ReadLine();

            int iMin = Convert.ToInt32(min);
            int iMax = Convert.ToInt32(max);

            int average = (iMin + iMax) / 2;

            Month(iNumber);
            Console.WriteLine($"Среднесуточная температура: {average}");

            Test(iNumber, average);
        }

        private static void Test(int iNumber, int average)
        {
            if(iNumber==1||iNumber == 2||iNumber == 12)
            {
                if (average>0)
                {
                    Console.WriteLine("Дождливая зима!");
                }
            }
        }

        private static void Month(int iNumber)
        {
            switch (iNumber)
            {
                case 1:
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine("February");
                    break;

                case 3:
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("June");
                    break;

                case 7:
                    Console.WriteLine("July");
                    break;

                case 8:
                    Console.WriteLine("August");
                    break;

                case 9:
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine("October");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Надо ввести значение от 1 до 12");
                    break;
            }
        }
    }
}
