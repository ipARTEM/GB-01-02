using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название товара: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите стоимость за еденицу: ");
            string cost = Console.ReadLine();

            Console.WriteLine("Введите количество товара: ");
            string quantity = Console.ReadLine();

            string upName = name.ToUpper();
            int iCost = Convert.ToInt32(cost);
            int iQuantity = Convert.ToInt32(quantity);
            int summ = iCost * iQuantity;

            Console.WriteLine("**************************************");
            Console.WriteLine("**************ООО  ПРИВЕТ*************");
            Console.WriteLine("**************************************");
            Console.WriteLine("              Чек №001                ");
            Console.WriteLine("ККМ 999888             ИНН 12345678900");
            Console.WriteLine(DateTime.Now+"  Кассир: Пупкин ВВ");
            Console.WriteLine("**************************************");
            Console.WriteLine("|                 товар:             |");
            Console.WriteLine("    "+upName);
            Console.WriteLine("|           стоимость за еденицу:    |");
            Console.WriteLine("    "+iCost);
            Console.WriteLine("|            количество товара:      |");
            Console.WriteLine("    "+iQuantity);
            Console.WriteLine("Сумма: "+summ);
            Console.WriteLine("**************************************");
            Console.WriteLine("***********СПАСИБО ЗА ПОКУПКУ*********");
            Console.WriteLine("**************************************");
        }
    }
}
