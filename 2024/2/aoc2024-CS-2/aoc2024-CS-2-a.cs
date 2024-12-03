using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace aoc2024_CS_2
{



    public static class aoc2024_CS_2_a
    {



        public static void Solution(string[] args)
        {
            List<List<UInt16>> list = new List<List<UInt16>>();
            UInt16 safeCount = 0;

            foreach (string line in File.ReadAllLines(args[0]))
            {
                list.Add(new List<UInt16>(line.Split(' ').ToList<string>().ConvertAll(UInt16.Parse)));
            }

            Shared.s_list = list;

            foreach (List<UInt16> l in list)
            {
                bool isDecreasing = false;
                bool isIncreasing = false;
                bool status = false;

                for (int i = 1; i < l.Count; i++)
                {
                    if (l[i] > l[i-1]) { isIncreasing = status = true; }
                    else { isIncreasing = status = false; break; }
                }

                if (!isIncreasing)
                {
                    for (int i = 1; i < l.Count; i++)
                    {
                        if (l[i] < l[i - 1]) { isDecreasing = status = true; }
                        else { isDecreasing = status = false; break; }
                    }
                }

                if (isIncreasing)
                {
                    for (int i = 1; i < l.Count; i++)
                    {
                        UInt16 result = (UInt16)(l[i] - l[i - 1]);

                        if (result < 0 || result > 3) { status = false; break; }
                    }
                }
                else if (isDecreasing)
                {
                    for (int i = 1; i < l.Count; i++)
                    {
                        UInt16 result = (UInt16)(l[i - 1] - l[i]);

                        if (result < 0 || result > 3) { status = false; break; }
                    }
                }

                if (status)
                {
                    safeCount++;
                }
            }

            Console.WriteLine($"SOLUTION aoc2024-2-a: {safeCount}");
        }



    } // !class aoc2024_CS_2_a



} // !namespace aoc2024_CS_2
