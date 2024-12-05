using System;
using System.Text.RegularExpressions;



namespace aoc2024_CS_3
{



    public static class aoc2024_CS_3_b
    {



        public static void Solution()
        {
            int totalSum = 0;

            string pattern = @"mul\(\d+,\d+\)|\bdo\(\)|don't\(\)";
            MatchCollection matches = Regex.Matches(Shared.s_text, pattern);

            bool enabled = true;

            foreach (Match match in matches)
            {
                string matchStr = match.ToString();

                if (matchStr == "do()")
                {
                    enabled = true;
                }
                else if (matchStr == "don't()")
                {
                    enabled = false;
                }
                else
                {
                    if (enabled)
                    {
                        totalSum += Shared.Multiply(matchStr);
                    }
                }
            }

            Console.WriteLine($"SOLUTION aoc2024-CS-3-b: {totalSum}");
        }



    } // !class aoc2024_CS_3_b



} // !namespace aoc2024_CS_3
