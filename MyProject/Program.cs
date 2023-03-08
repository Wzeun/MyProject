using System;
using System.Linq;
using System.Collections.Generic;


namespace MyProject
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть дату в форматі '28 липня':");
            string Day = Console.ReadLine();
            string[] SplitData = Day.Split(' ');
            int DayToInt;
            int year = DateTime.Now.Year;
            try
            {
                DayToInt = Convert.ToInt32(SplitData[0]);
            }
            catch
            {
                Console.WriteLine("Ви ввели не число");
                Environment.Exit(0);
                DayToInt = 0;
            }

            try
            {
                Dictionary<string, int> NumberOFMonthsInYear = new Dictionary<string, int>
                {
                    {"null", 0 },
                    {"січня", 1 },
                    {"лютого", 2 },
                    {"березня" ,3},
                    {"квітня", 4},
                    {"травня" , 5},
                    {"червня" , 6},
                    {"липня", 7},
                    {"серпня", 8},
                    {"вересня", 9},
                    {"жовтня" ,10},
                    {"листопада", 11},
                    {"грудня", 12},
                };
                
                string Month = SplitData[1];
                int AmountDayInSelectedMonth;

                
                int  FinallyMonth ;

                switch (Month)
                {
                    case "січня":
                    case "1":
                        AmountDayInSelectedMonth = 31;
                        FinallyMonth = 1;
                        break;
                    case "лютого":
                    case "2":
                         AmountDayInSelectedMonth = DateTime.IsLeapYear(year) ? 29 : 28;
                        FinallyMonth = 2;
                        break;
                    case "березня":
                    case "3":
                        AmountDayInSelectedMonth = 31;
                        FinallyMonth = 3;
                        break;
                    case "квітня":
                    case "4":
                        AmountDayInSelectedMonth = 30;
                        FinallyMonth = 4;
                        break;
                    case "травня":
                    case "5":
                        AmountDayInSelectedMonth = 31;
                        FinallyMonth = 5;
                        break;
                    case "червня":
                    case "6":
                        AmountDayInSelectedMonth = 30;
                        FinallyMonth = 6;
                        break;
                    case "липня":
                    case "7":
                        AmountDayInSelectedMonth = 31;
                        FinallyMonth = 7;
                        break;
                    case "серпня":
                    case "8":
                        AmountDayInSelectedMonth = 31;
                        FinallyMonth = 8;
                        break;
                    case "вересня":
                    case "9":
                        AmountDayInSelectedMonth = 30;
                        FinallyMonth = 9;
                        break;
                    case "жовтня":
                    case "10":
                        AmountDayInSelectedMonth = 31;
                        FinallyMonth = 10;
                        break;
                    case "листопад":
                    case "11":
                        AmountDayInSelectedMonth = 30;
                        FinallyMonth = 11;
                        break;
                    case "грудня":
                    case "12":
                        AmountDayInSelectedMonth = 31;
                        FinallyMonth = 12;
                        break;
                    default:
                        Console.WriteLine("Такого місяця не знайдено!");
                        Environment.Exit(0);
                        AmountDayInSelectedMonth = 0;
                        break;
                }
                
                if (DayToInt > AmountDayInSelectedMonth)
                {
                    Console.WriteLine("Ви ввели день який більше ніж кількість днів в місяці який ви ввели!");
                    Environment.Exit(0);
                }

                try
                {
                    FinallyMonth = NumberOFMonthsInYear[Month];
                }
                catch
                {
                    FinallyMonth = NumberOFMonthsInYear.ElementAt(Convert.ToInt32(Month)).Value;
                }

                
                int NewYearMonth = 12;
                Console.WriteLine($"До нового року залишилось {AmountDayInSelectedMonth - DayToInt} днів, і {NewYearMonth - FinallyMonth} місяців!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            catch
            {
                Console.WriteLine("Введіть місяць типу 'липень':");
                var Month = Console.ReadLine();
                string MonthToLower = Month.ToLower();
                int MonthToInt;
                int FinallyMonth;
                int AmountDayInSelectedMonth;

                Dictionary<string, int> NumberOFMonthsInYear = new Dictionary<string, int>
                {
                    {"null", 0 },
                    {"січня", 1 },
                    {"лютого", 2 },
                    {"березня" ,3},
                    {"квітня", 4},
                    {"травня" , 5},
                    {"червня" , 6},
                    {"липня", 7},
                    {"серпня", 8},
                    {"вересня", 9},
                    {"жовтня" ,10},
                    {"листопада", 11},
                    {"грудня", 12},
                };

                try
                {
                    MonthToInt = Convert.ToInt32(Month);
                    FinallyMonth = MonthToInt;
                }
                catch
                {
                    MonthToLower = Month.ToLower();
                    FinallyMonth = NumberOFMonthsInYear[MonthToLower];
                }
                
                switch (Month)
                {
                    case "січня":
                    case "1":
                        AmountDayInSelectedMonth = 31;
                        break;
                    case "лютого":
                    case "2":
                        AmountDayInSelectedMonth = DateTime.IsLeapYear(year) ? 29 : 28;
                        break;
                    case "березня":
                    case "3":
                        AmountDayInSelectedMonth = 31;
                        break;
                    case "квітня":
                    case "4":
                        AmountDayInSelectedMonth = 30;
                        break;
                    case "травня":
                    case "5":
                        AmountDayInSelectedMonth = 31;
                        break;
                    case "червня":
                    case "6":
                        AmountDayInSelectedMonth = 30;
                        break;
                    case "липня":
                    case "7":
                        AmountDayInSelectedMonth = 31;
                        break;
                    case "серпня":
                    case "8":
                        AmountDayInSelectedMonth = 31;
                        break;
                    case "вересня":
                    case "9":
                        AmountDayInSelectedMonth = 30;
                        break;
                    case "жовтня":
                    case "10":
                        AmountDayInSelectedMonth = 31;
                        break;
                    case "листопада":
                    case "11":
                        AmountDayInSelectedMonth = 30;
                        break;
                    case "грудня":
                    case "12":
                        AmountDayInSelectedMonth = 31;
                        break;
                    default:
                        Console.WriteLine("Такого місяця не знайдено!");
                        AmountDayInSelectedMonth = 0;
                        Environment.Exit(0);
                        break;
                }
                if (DayToInt > AmountDayInSelectedMonth)
                {
                    Console.WriteLine("Ви ввели день який більше ніж кількість днів в місяці який ви ввели!");
                    Environment.Exit(0);
                }

                int NewYearMonth = 12;
                Console.WriteLine($"До нового року залишилось {AmountDayInSelectedMonth - DayToInt} днів, і {NewYearMonth - FinallyMonth} місяців!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}