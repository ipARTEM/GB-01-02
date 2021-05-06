using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки в Цельсиях : ");
            string min= Console.ReadLine();

            Console.WriteLine("Введите максимальную температуру за сутки в Цельсиях : ");
            string max = Console.ReadLine();

            int iMin = Convert.ToInt32(min);
            int iMax = Convert.ToInt32(max);

            int average = (iMin + iMax) / 2;

            Console.WriteLine($"Среднесуточная температура: {average}");

        }
    }
}
