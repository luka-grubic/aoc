using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;



namespace aoc2024_CS_3
{



    public static class aoc2024_CS_3_a
    {



        public static void Solution(string[] args)
        {
            int totalSum = 0;

            string text = File.ReadAllText(args[0]);
            Shared.s_text = text;

            string pattern = @"mul\(\d+,\d+\)";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                totalSum += Shared.Multiply(match.ToString());
            }

            Console.WriteLine($"SOLUTION aoc2024-CS-3-a: {totalSum}");
        }



    } // !class aoc2024_CS_3_a



} // !namespace aoc2024_CS_3
