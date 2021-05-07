using System;

namespace Task06
{
    class Program
    {
        [Flags]
        public enum DayWeek
        {  
            Понедельник= 0b_0000_0001,
            Вторник=     0b_0000_0011,
            Среда =      0b_0000_0100,
            Четверг =    0b_0000_1000, 
            Пятница=     0b_0001_0000,
            Суббота =    0b_0010_0000,
            Воскресенье =0b_0100_0000,
        }

        //public enum DayWeekRus
        //{
        //    Понедельник = Monday,
        //    Вторник = Tuesday,
        //    Среда = 0b_0000_0100,
        //    Четверг = 0b_0000_1000,
        //    Пятница = 0b_0001_0000,
        //    Суббота = 0b_0010_0000,
        //    Воскресенье = 0b_0100_0000,


        //}

        static void Main(string[] args)
        {
            DayWeek office1 = DayWeek.Вторник | DayWeek.Среда | DayWeek.Четверг | DayWeek.Пятница;
            DayWeek office2 = DayWeek.Понедельник | DayWeek.Вторник | DayWeek.Среда | DayWeek.Четверг | DayWeek.Пятница|DayWeek.Суббота | DayWeek.Воскресенье;
            DayWeek office3 = DayWeek.Понедельник | DayWeek.Среда | DayWeek.Пятница;
            DayWeek office4 = DayWeek.Вторник | DayWeek.Четверг | DayWeek.Суббота | DayWeek.Воскресенье;
            DayWeek office5 = DayWeek.Среда | DayWeek.Четверг | DayWeek.Пятница | DayWeek.Суббота;

            var day = DateTime.Now.DayOfWeek;

            DayWeek dayRu;


            

            Console.WriteLine();
            Console.WriteLine("Наши офисы работают по дням недели: ");
            Console.WriteLine($" Офис №1 " +office1);
            Console.WriteLine($" Офис №2 " + office2);
            Console.WriteLine($" Офис №3 " + office3);
            Console.WriteLine($" Офис №4 " + office4);
            Console.WriteLine($" Офис №5 " + office5);
            Console.WriteLine();
            Console.WriteLine($" Сегодня день недели {day}, а это значит, что сегодня работают офисы: ");

            if (day.ToString() ==office1.ToString())
            {
                Console.WriteLine(" Офис №1 ");
            }
        }


    }
}

