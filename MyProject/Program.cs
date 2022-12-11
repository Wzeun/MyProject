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

            if (Convert.ToInt32(Day) > 31)
            {

                Console.WriteLine("Введено не коректну дату");
                Environment.Exit(ExitCode);
            }
            //else { //Environment.Exit(ExitCode); }

            Console.WriteLine("Введите месяц:");
            string Month = Console.ReadLine();
            string MonthToLower = Month.ToLower();
            //int MonthConvertToInt = Convert.ToInt32(Month);
            int FinallyMonth = 0;

            if (Month == "Січень") { FinallyMonth = FinallyMonth + 1; }

            if (Month == "Лютий") { FinallyMonth = FinallyMonth + 2; }

            if (Month == "Березень") { FinallyMonth = FinallyMonth + 3; }

            if (Month == "Квітень") { FinallyMonth = FinallyMonth + 4; }

            if (Month == "Травень") { FinallyMonth = FinallyMonth + 5; }

            if (Month == "Червень") { FinallyMonth = FinallyMonth + 6; }

            if (Month == "Липень") { FinallyMonth = FinallyMonth + 7; }

            if (Month == "Серпень") { FinallyMonth = FinallyMonth + 8; }

            if (Month == "Вересень") { FinallyMonth = FinallyMonth + 9; }

            if (Month == "Жовтень") { FinallyMonth = FinallyMonth + 10; }

            if (Month == "Листопад") { FinallyMonth = FinallyMonth + 11; }

            if (Month == "Грудень") { FinallyMonth = FinallyMonth + 12; }

            else if (FinallyMonth > 12) {
                Console.WriteLine("Введено некоректний місяць");
                
            }




            Console.WriteLine(FinallyMonth);
            int NewYearDay = 31;
            int NewYearMonth = 12;


            Console.WriteLine($"Новий рік буде через {NewYearDay - DayConvertToInt} днів і {NewYearMonth - FinallyMonth} місяців. ");

        }
        
    }
}