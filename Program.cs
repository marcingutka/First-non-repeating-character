using System;
using System.Linq;

namespace First_non_repeating_character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatingLetter(""));
            Console.WriteLine(FirstNonRepeatingLetter("Hello World"));
            Console.WriteLine(FirstNonRepeatingLetter("a"));
            Console.WriteLine(FirstNonRepeatingLetter("stress"));
        }

        public static string FirstNonRepeatingLetter(string s)
        {                       
            return new string(s.Select(c => s.Count(x => c.ToString().ToLower() == x.ToString().ToLower()) == 1 ? c.ToString() : "").ToArray().FirstOrDefault(q => q != "")) ?? "";
        }
    }
}
