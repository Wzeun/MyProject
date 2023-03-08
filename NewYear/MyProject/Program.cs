using System;
using System.Linq;
using System.Collections.Generic;


namespace MyProject
{
    class MainClass
    {
        private const int ExitCode = 0;

        public static void Main(string[] args)
        {

            Dictionary<string, int> NumberOfDaysInMonths = new Dictionary<string, int>()
            {
                { "", 0 },
                { "січень", 31 },
                { "лютий", 28 },
                { "березень", 31 },
                { "квітень", 30 },
                { "травень", 31 },
                { "червень", 30 },
                { "липень", 31 },
                { "серпень", 31 },
                { "вересень", 30 },
                { "жовтень", 31 },
                { "листопад", 30 },
                { "грудень", 31 },
            };

            Dictionary<string, int> NumberOfMonthInYear = new Dictionary<string, int>()
            {
                { "січень", 1 },
                { "лютий", 2 },
                { "березень", 3 },
                { "квітень", 4 },
                { "травень", 5 },
                { "червень", 6 },
                { "липень", 7 },
                { "серпень", 8 },
                { "вересень", 9 },
                { "жовтень", 10 },
                { "листопад", 11 },
                { "грудень", 12 },
            };

            Console.WriteLine("Введіть дату:");
            string Day = Console.ReadLine();
            int DayConvertToInt;
            try
            {
                DayConvertToInt = Convert.ToInt32(Day);
            }
            catch
            {
                Console.WriteLine("Ви Ввели не число!");
                Environment.Exit(0);
                DayConvertToInt = Convert.ToInt32(Day);
            }

            if (Convert.ToInt32(Day) <= 0)
            {
                Console.WriteLine("Ви ввели дату яка мешне або яка дорівнює 0");
                Environment.Exit(0);
            }
            
            Console.WriteLine("Введіть місяць:");
            string Month = Console.ReadLine();
            var MonthToLower = Month.ToLower();

            Console.WriteLine("Введіть наявний рік:");
            string Year = Console.ReadLine();

            int FinallyMonth;
            int DaysInMonths;
            try
            {
                FinallyMonth = Convert.ToInt32(Month);
                DaysInMonths = NumberOfDaysInMonths.ElementAt(Convert.ToInt32(Month)).Value;
            }
            catch
            {

                FinallyMonth = NumberOfMonthInYear[MonthToLower];
                DaysInMonths = NumberOfDaysInMonths[MonthToLower];
            }
            

            if (Convert.ToInt32(Year) % 4 == 0)
            {
                NumberOfDaysInMonths["лютий"] = NumberOfDaysInMonths["лютий"] + 1;
                DaysInMonths = NumberOfDaysInMonths["лютий"];
            }

            if (DayConvertToInt > DaysInMonths)
            {
                Console.WriteLine("Ви ввели  дату яка більша ніж в місяці який ви ввели!");
                Environment.Exit(0);
            }


            int NewYearDay = 31;
            int NewYearMonth = 12;
            int NewYearDayFinally = NewYearDay - DayConvertToInt;
            int NewYearMonthFinally = NewYearMonth - FinallyMonth;
            if (NewYearDayFinally < 0)
            {
                Console.WriteLine("Ви Ввели день, який більший ніж кількість днів в місяці який ви ввели!)");
                Environment.Exit(0);
            }

            Console.WriteLine($"Новий рік буде через {NewYearDayFinally} днів і {NewYearMonthFinally} місяців. ");
            Console.WriteLine("Слава Україні!");
        }

    }
}