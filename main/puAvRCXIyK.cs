using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace UtilityNamespace {
    public class FileUtility {
        public static void WriteToFile(string path, List<string> lines) {
            File.WriteAllLines(path, lines);
        }
        public static List<string> ReadFromFile(string path) {
            return File.ReadAllLines(path).ToList();
        }
    }
    public class MathUtility {
        public static int Factorial(int n) {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
        public static int Fibonacci(int n) {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
    public class StringUtility {
        public static string Reverse(string input) {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static bool IsPalindrome(string input) {
            string reversed = Reverse(input);
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
    public class Program {
        public static void Main(string[] args) {
            List<string> lines = new List<string> { "Line 1", "Line 2", "Line 3" };
            FileUtility.WriteToFile("output.txt", lines);
            List<string> readLines = FileUtility.ReadFromFile("output.txt");
            foreach (var line in readLines) {
                Console.WriteLine(line);
            }
            Console.WriteLine(MathUtility.Factorial(5));
            Console.WriteLine(MathUtility.Fibonacci(6));
            Console.WriteLine(StringUtility.Reverse("hello"));
            Console.WriteLine(StringUtility.IsPalindrome("racecar"));
        }
    }
}
