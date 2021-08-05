using System;

namespace Hardermethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //negative1000topositive1000();
            //by3to999();
            Console.WriteLine(AreTheyEqual(9,9));
            Console.WriteLine(IsEvenOrOdd(10));
            Console.WriteLine(isNegativeorPositive(-10));
            CanYouVote();
            BetweenNeg10To10();
            MultplicationTable(10);
            
        }
    
        public static void negative1000topositive1000()
        {
            for (int i = -1001; i < 1001; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void by3to999()
        {
            for (int i = 0; i < 1000; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        public static bool AreTheyEqual(int a, int b)
        {
            return (a == b) ? true : false;
        }
        public static string IsEvenOrOdd(int a)
        {
            return (a % 2 == 0) ? $"{a} is even." : $"{a} is odd.";
        }
        public static string isNegativeorPositive(int a)
        {
            return (a > 0) ? $"{a} is positive." : $"{a} is negative.";
        }
    
        public static void CanYouVote()
        {
            Console.WriteLine("How old are you?");
            
            
            int.TryParse(Console.ReadLine(), out int useranswer );
            Console.WriteLine( (useranswer > 18) ? "You can vote!" : "Come  back you are older, kid");
        }
        public static void BetweenNeg10To10()
        {
            Console.WriteLine("Please enter a number");
            int.TryParse(Console.ReadLine(), out int usernumber);
            Console.WriteLine((usernumber <= 10 && usernumber >= -10) ? "your number is within the range of -10 to 10" : "you number is outside the range of -10 to 10");


        }
        public static void MultplicationTable(int a)
        {
            Console.WriteLine("Here is your Table!");
            for (int i = 1; i <= 7; i++)
            {
                var multiplaction = i * a;
                Console.WriteLine($"{i} * {a} = {multiplaction}");
            }
        }
    
    
    }
}
