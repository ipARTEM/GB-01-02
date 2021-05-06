using System;

namespace Task06
{
    class Program
    {
        [Flags]
        public enum DayWeek
        {  /*
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,

            
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
            */
            Monday =    0b_0000_0001,
            Tuesday =   0b_0000_0010,
            Wednesday = 0b_0000_0100,
            Thursday =  0b_0000_1000,
            Friday =    0b_0001_0000,
            Saturday =  0b_0010_0000,
            Sunday =    0b_0100_0000,
            
        }

        static void Main(string[] args)
        {
            DayWeek office1 = DayWeek.Monday & DayWeek.Tuesday & DayWeek.Wednesday & DayWeek.Thursday & DayWeek.Friday;
            DayWeek office2 = DayWeek.Saturday | DayWeek.Sunday;
            DayWeek office3 = DayWeek.Monday | DayWeek.Wednesday | DayWeek.Friday;
            DayWeek office4 = DayWeek.Tuesday | DayWeek.Thursday | DayWeek.Saturday | DayWeek.Sunday;
            DayWeek office5 = DayWeek.Wednesday | DayWeek.Thursday | DayWeek.Friday | DayWeek.Saturday;

            DayWeek day = ((DayWeek)DateTime.Now.DayOfWeek)-1;

            Console.WriteLine($"У нас есть 5 офисов. Сегодня день недели {day}");

            bool isOffice1 = day == office1;


            Console.WriteLine("В данный день недели работают офисы: ");
        }




    }
}

