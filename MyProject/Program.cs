using System;

namespace MyProject
{
    class MainClass
    {
        private const int ExitCode = 0;

        public static void Main(string[] args)
        {
            
            Console.WriteLine("Введите дату:");
            string Day = Console.ReadLine();
            int DayConvertToInt = Convert.ToInt32(Day);

            if (DayConvertToInt > 31){

                Console.WriteLine("Введено не коректну дату");
                Environment.Exit(ExitCode);
                    }

            Console.WriteLine("Введите месяц:");
            string Month = Console.ReadLine();
            int MonthConvertToInt = Convert.ToInt32(Month);

            if (MonthConvertToInt > 12) {
                Console.WriteLine("Введено некоректний місяць");
                Environment.Exit(ExitCode);
            }

            int NewYearDay = 31;
            int NewYearMonth = 12;


            Console.WriteLine($"Новий рік буде через {NewYearDay - DayConvertToInt} днів і {NewYearMonth - MonthConvertToInt} місяців. ");

        }

    }
}
