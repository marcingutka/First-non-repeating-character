using System;
using System.Linq;

namespace First_non_repeating_character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(default(string));
            Console.WriteLine(FirstNonRepeatingLetter(""));
            Console.WriteLine(FirstNonRepeatingLetter("Hello World"));
            Console.WriteLine(FirstNonRepeatingLetter("a"));
            Console.WriteLine(FirstNonRepeatingLetter("stress"));
            Console.WriteLine(FirstNonRepeatingLetter("seeess"));
        }

        public static string FirstNonRepeatingLetter(string s)
        {
            string result = (s.FirstOrDefault(c => s.Count(x => c.ToString().ToLower() == x.ToString().ToLower()) == 1).ToString());
            return result != default(string) ? result : string.Empty;
        }
    }
}

