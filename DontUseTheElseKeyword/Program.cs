using System;

namespace DontUseTheElseKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Console.WriteLine(GetResponseValue_Bad("Second"));

            Console.WriteLine(GetResponseValue_Good("Second"));

            Console.WriteLine();
            Console.WriteLine("Start");
        }

        private static string GetResponseValue_Bad(string condition )
        {
            if (condition == "first")
                return "FIRST passed.";
            else
                return "FIRST not passed.";

        }

        private static string GetResponseValue_Good(string condition)
        {
            if (condition == "first")
                return "FIRST passed.";
            
            return "FIRST not passed.";

        }
    }
}
