using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
        }

        public static bool IsLeapYear(int year){
            if(year % 4 == 0){
                if(year % 100 == 0 && year % 400 != 0) return false;
                return true;
            }
            return false;
        }
    }
}
