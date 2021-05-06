using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число: ");
            string number= Console.ReadLine();
            int iNumber = Convert.ToInt32(number);

            if (iNumber%2==0)
            {
                Console.WriteLine("Число чётное!");
            }
            else
            {
                Console.WriteLine("Число не чётное!");
            }

        }
    }
}
