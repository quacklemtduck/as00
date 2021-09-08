using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a year:");
            string answer = Console.ReadLine();
            try{
                int answerInt = int.Parse(answer);
                Console.WriteLine(IsLeapYear(answerInt) ? "yay" : "nay");
            }catch(FormatException e){
                Console.WriteLine("The input is not a number");
            }catch(Exception e){
                Console.WriteLine("Something went wrong");
            }
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
