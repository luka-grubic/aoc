using System;



namespace aoc2024_CS_3
{
    public static class Shared
    {
        public static string s_text;

        public static int Multiply(string input)
        {
            int leftPos = input.IndexOf('(');
            int commaPos = input.IndexOf(',');
            int rightPos = input.IndexOf(')');

            int x = Convert.ToInt32(input.Substring(leftPos + 1, commaPos - leftPos - 1));
            int y = Convert.ToInt32(input.Substring(commaPos + 1, rightPos - commaPos - 1));

            return (x*y);
        }
    } // !class Shared



    internal class Program
    {
        static void Main(string[] args)
        {
            aoc2024_CS_3_a.Solution(args);

            aoc2024_CS_3_b.Solution();

            Console.ReadLine();
        }
    } // !class Program



} // !namespace aoc2024_CS_3
