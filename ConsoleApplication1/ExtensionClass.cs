using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConsole1
{
    public static class ExtensionClass
    {
        public static void WriteOutput(this int[] input)
        {
            foreach (var item in input)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine("");
        }

        public static void WriteOutput(this int[] input, int leftIndex, int righIndex)
        {
            for (int i = leftIndex; i <= righIndex; i++)
            {
                Console.Write($" {input[i]}");
            }
            Console.WriteLine("");
        }
    }
}
