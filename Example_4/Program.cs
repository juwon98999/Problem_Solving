using System;

namespace Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2022,9,08);

            DateTime first_Day = date.AddDays(1 - date.Day);
            Console.WriteLine("첫번째 날 "+ first_Day);

            DateTime Last_Day = date.AddMonths(1).AddDays(0 - date.Day);
            Console.WriteLine("마지막 날 " + Last_Day);

            DayOfWeek dw = first_Day.DayOfWeek;
            DateTime first_Weeks = first_Day.AddDays(7 - (int)dw);
            Console.WriteLine("첫번째 주 일요일 " + first_Weeks);

            DayOfWeek dw2 = Last_Day.DayOfWeek;
            DateTime Last_Weeks = Last_Day.AddDays(0 - (int)dw2);
            Console.WriteLine("마지막 주 일요일 " + Last_Weeks);

            int Answer = ((Last_Weeks.DayOfYear - first_Weeks.DayOfYear)/7) + 1;
            Console.WriteLine(Last_Weeks.DayOfYear);
            Console.WriteLine(first_Weeks.DayOfYear);
            Console.WriteLine(Last_Weeks.DayOfYear - first_Weeks.DayOfYear);
            Console.WriteLine(Answer);
            Console.WriteLine("이번달에는 일요일이 " + Answer + " 번 있네..");
        }
    }
}
