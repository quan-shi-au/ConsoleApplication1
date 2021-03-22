using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmConsole1
{
    public static class QuickSort
    {
        public static void PivotSort(int[] input, int initialLeft, int initialRight)
        {
            Console.Write($"received input for PivotSort initialLeft = {initialLeft}; initialRight = {initialRight} Input array is: ");
            input.WriteOutput(initialLeft, initialRight);

            if (initialLeft == initialRight)
                return;

            var pivot = input[initialLeft + (initialRight - initialLeft) / 2];
            Console.WriteLine($"pivot value = {pivot}");

            var leftIndex = initialLeft;
            var rightIndex = initialRight;

            while (rightIndex > leftIndex)
            {
                while (leftIndex <= initialRight - initialLeft - 1 && input[leftIndex] < pivot)
                    leftIndex++;

                while (rightIndex > initialLeft && input[rightIndex] > pivot)
                    rightIndex--;

                if (leftIndex < rightIndex)
                {
                    var temp = input[leftIndex];
                    input[leftIndex] = input[rightIndex];
                    input[rightIndex] = temp;
                }
            }

            if (leftIndex > initialLeft)
            {
                Console.Write($"recursive call left ");
                input.WriteOutput(initialLeft, leftIndex - 1);
            }

            if (rightIndex < initialRight)
            {
                Console.Write($"recursive call right ");
                input.WriteOutput(rightIndex + 1, initialRight);
            }

            if (leftIndex - 1 > initialLeft) 
            {
                PivotSort(input, initialLeft, leftIndex - 1);
            }

            if (rightIndex + 1< initialRight)
            {
                PivotSort(input, rightIndex + 1, initialRight);
            }

        }
    }
}
