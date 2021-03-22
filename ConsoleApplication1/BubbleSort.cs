using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConsole1
{
    public static class BubbleSort
    {
        public static int[] Run(int[] array)
        {
            for (int i= 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;

        }
    }
}
