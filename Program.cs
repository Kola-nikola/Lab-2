using System;

namespace Lab06
{
    struct MyDate
    {
        public int Year;
        public int Month;
        public int Day;

        public MyDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введіть рік: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Введіть місяць (1-12): ");
                int month = int.Parse(Console.ReadLine());

                Console.Write("Введіть день: ");
                int day = int.Parse(Console.ReadLine());

                MyDate date = new MyDate(year, month, day);

                string dayOfWeek = GetDayOfWeek(date);
                Console.WriteLine($"Дата: {date.Day}.{date.Month}.{date.Year} → {dayOfWeek}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        static string GetDayOfWeek(MyDate date)
        {
            // Перше січня вважається понеділком
            DateTime start = new DateTime(date.Year, 1, 1);
            DateTime current = new DateTime(date.Year, date.Month, date.Day);

            int daysPassed = (current - start).Days;

            string[] days = { "Понеділок", "Вівторок", "Середа", "Четвер", "П’ятниця", "Субота", "Неділя" };

            return days[daysPassed % 7];
        }
    }
}
