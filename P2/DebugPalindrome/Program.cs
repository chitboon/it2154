using System;

namespace DebugPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) {
                Console.WriteLine("Usage: DebugPalindrome <string to be tested>");
            } else {
                if (IsPalindrome(args[0])) {
                    Console.WriteLine($"{args[0]} is a palindrome.");
                } else {
                    Console.WriteLine($"{args[0]} is not a palindrome.");
                }
            }
        }

        static bool IsPalindrome(string s) {
            char [] cs = s.ToCharArray();
            bool result = true;
            int l = cs.Length;
            for (var i = 0; i < l/2; i++ ) {
                if (cs[i] != cs[cs.Length - 1 - i]) {
                    result = false;
                } 
            }
            return result;
        }
    }
}
