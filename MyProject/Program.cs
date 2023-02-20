using System;
using System.Linq;
using System.Collections.Generic;


namespace MyProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть день:");
            string Day = Console.ReadLine();

            try
            {
                string[] SplitData = Day.Split(' ');

                Dictionary<string, int> NumberOFDayInMonths = new Dictionary<string, int>
                {
                    {"null", 0 },
                    {"січня", 31 },
                    {"лютого", 28 },
                    {"березня" ,31},
                    {"квітня", 30},
                    {"травня" ,31},
                    {"червня" ,30},
                    {"липня", 31},
                    {"серпня", 31},
                    {"вересня", 30},
                    {"жовтня" ,31},
                    {"листопада", 30},
                    {"грудня", 31},
                };

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
                int DayToInt;
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


                string Month = SplitData[1];
                int AmountDayInSelectedMonth;
                int MonthToInt;
                int FinallyMonth;
                try
                {
                    MonthToInt = Convert.ToInt32(Month);
                    if (MonthToInt > 12)
                    {
                        Console.WriteLine("Ви ввели неіснуючий місяць!");
                        Environment.Exit(0);
                    }
                    AmountDayInSelectedMonth = NumberOFDayInMonths.ElementAt(MonthToInt).Value;
                    FinallyMonth = MonthToInt;
                }
                catch
                {
                    string MonthToLower = Month.ToLower();
                    AmountDayInSelectedMonth = NumberOFDayInMonths[MonthToLower];
                    FinallyMonth = NumberOFMonthsInYear[MonthToLower];
                }
                if (DayToInt > AmountDayInSelectedMonth)
                {
                    Console.WriteLine("Ви ввели день який більше ніж кількість днів в місяці який ви ввели!");
                    Environment.Exit(0);
                }

                Console.WriteLine("Введіть рік:");
                string Year = Console.ReadLine();

                int YearToInt;
                try
                {
                    YearToInt = Convert.ToInt32(Year);
                }
                catch
                {
                    Console.WriteLine("Ви ввели не рік");
                    Environment.Exit(0);
                    YearToInt = 0;
                }

                if (YearToInt % 4 == 0)
                {
                    NumberOFDayInMonths["лютий"] = 29;
                    Console.WriteLine(NumberOFDayInMonths["лютий"]);
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

                int NewYearDay = 31;
                int NewYearMonth = 12;
                Console.WriteLine($"До нового року залишилось {AmountDayInSelectedMonth - DayToInt} днів, і {NewYearMonth - FinallyMonth} місяців!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            catch
            {
                int DayToInt = Convert.ToInt32(Day);
                Console.WriteLine("Введіть місяць:");
                string Month = Console.ReadLine();
                string MonthToLower = Month.ToLower();
                int MonthToInt;
                int FinallyMonth;
                int AmountDayInSelectedMonth;



                Dictionary<string, int> NumberOFDayInMonths = new Dictionary<string, int>
                {
                    {"null", 0 },
                    {"січень", 31 },
                    {"лютий", 28 },
                    {"березень" ,31},
                    {"квітень", 30},
                    {"травень" ,31},
                    {"червень" ,30},
                    {"липень", 31},
                    {"серпень", 31},
                    {"вересень", 30},
                    {"жовтень" ,31},
                    {"листопад", 30},
                    {"грудень", 31},
                };
                Dictionary<string, int> NumberOFMonthsInYear = new Dictionary<string, int>
                {
                    {"null", 0 },
                    {"січень", 1 },
                    {"лютий", 2 },
                    {"березень" ,3},
                    {"квітень", 4},
                    {"травень" , 5},
                    {"червень" , 6},
                    {"липень", 7},
                    {"серпень", 8},
                    {"вересень", 9},
                    {"жовтень" ,10},
                    {"листопад", 11},
                    {"грудень", 12},
                };

                try
                {
                    MonthToInt = Convert.ToInt32(Month);
                    if (MonthToInt > 12)
                    {
                        Console.WriteLine("Ви ввели неіснуючий місяць!");
                        Environment.Exit(0);
                    }
                    AmountDayInSelectedMonth = NumberOFDayInMonths.ElementAt(MonthToInt).Value;
                    FinallyMonth = MonthToInt;
                }
                catch
                {
                    MonthToLower = Month.ToLower();
                    AmountDayInSelectedMonth = NumberOFDayInMonths[MonthToLower];
                    FinallyMonth = NumberOFMonthsInYear[MonthToLower];
                }
                Console.WriteLine("Введіть рік:");
                string Year = Console.ReadLine();
                int YearToInt;
                try
                {
                    YearToInt = Convert.ToInt32(Year);
                }
                catch
                {
                    Console.WriteLine("Ви ввели не число!");
                    Environment.Exit(0);
                    YearToInt = 0;

                }
                int HightQualityYear = 4;
                if (YearToInt % HightQualityYear == 0)
                {
                    NumberOFDayInMonths["лютий"] = 29;
                }
                if (DayToInt > AmountDayInSelectedMonth)
                {
                    Console.WriteLine("Ви ввели день який більше ніж у місяці який ви ввели!");
                    Environment.Exit(0);
                }
                int NewYearDay = 31;
                int NewYearMonth = 12;
                Console.WriteLine($"До нового року залишилось {AmountDayInSelectedMonth - DayToInt} днів, і {NewYearMonth - FinallyMonth} місяців!");
                Console.ReadLine();
                Environment.Exit(0);
                Console.WriteLine("Complete!");
            }
        }
    }
}