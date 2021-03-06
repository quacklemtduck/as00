using System;

namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Write a year:");
            string answer = Console.ReadLine();
            try{
                int answerInt = int.Parse(answer);
                Console.WriteLine(IsLeapYear(answerInt) ? "yay" : "nay");
            }catch(FormatException e){
                Console.WriteLine("The input is not a number");
            }catch(InputYearTooLowException e){
                Console.WriteLine("The input must be 1582 or higher");
            }catch(Exception e){
                Console.WriteLine("Something went wrong");
            }
        }

        public static bool IsLeapYear(int year){
            if(year < 1582) throw new InputYearTooLowException();
            if(year % 4 == 0){
                if(year % 100 == 0 && year % 400 != 0) return false;
                return true;
            }
            return false;
        }

        [System.Serializable]
        public class InputYearTooLowException : System.Exception
        {
            public InputYearTooLowException() { }
            public InputYearTooLowException(string message) : base(message) { }
            public InputYearTooLowException(string message, System.Exception inner) : base(message, inner) { }
            protected InputYearTooLowException(
                System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}
