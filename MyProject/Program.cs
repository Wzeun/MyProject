using System;

namespace MyProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Введите дату:");
            string Day = Console.ReadLine();
            int DayConvertToInt = Convert.ToInt32(Day);

            if (DayConvertToInt > 531){

                Console.WriteLine("Введено не коректну дату");
            }

            Console.WriteLine("Введите месяц:");
            string Month = Console.ReadLine();
            int MonthConvertToInt = Convert.ToInt32(Month);

            if (MonthConvertToInt > 12) {
                Console.WriteLine("Введено некоректний місяць");
            }

            int NewYearDay = 31;
            int NewYearMonth = 12;


            Console.WriteLine($"Новий рік буде через {NewYearDay - DayConvertToInt} днів і {NewYearMonth - MonthConvertToInt} місяців. ");

        }

    }
}
