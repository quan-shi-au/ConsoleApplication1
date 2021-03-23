using AlgorithmConsole1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MergeSort1
    {
        private static void MergeSort(int[] inputArray, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
                return;

            Console.Write("MergeSort input: ");
            inputArray.WriteOutput(startIndex, endIndex);

            var middleIndex = (startIndex + endIndex) / 2;

            MergeSort(inputArray, startIndex, middleIndex);
            MergeSort(inputArray, middleIndex + 1, endIndex);

            MergeHalves(inputArray, startIndex, middleIndex, endIndex);
        }

        private static void MergeHalves(int[] inputArray, int startIndex, int middleIndex, int endIndex)
        {
            var tempArray = new int[inputArray.Length];
            var leftIndex = startIndex;
            var rightIndex = middleIndex + 1;
            var tempIndex = startIndex;

            Console.Write("MergeHalves left: ");
            inputArray.WriteOutput(startIndex, middleIndex);
            Console.Write("MergeHalves right: ");
            inputArray.WriteOutput(middleIndex + 1, endIndex);

            while (leftIndex <= middleIndex && rightIndex <= endIndex)
            {
                if (inputArray[leftIndex] < inputArray[rightIndex])
                {
                    tempArray[tempIndex++] = inputArray[leftIndex++];
                }
                else
                {
                    tempArray[tempIndex++] = inputArray[rightIndex++];
                }
            }

            if (leftIndex <= middleIndex)
                Array.Copy(inputArray, leftIndex, tempArray, tempIndex, middleIndex - leftIndex + 1);

            if (rightIndex <= endIndex)
                Array.Copy(inputArray, rightIndex, tempArray, tempIndex, endIndex - rightIndex + 1);

            Array.Copy(tempArray, startIndex,  inputArray, startIndex, endIndex - startIndex + 1);

            Console.Write("After MergeHalves");
            inputArray.WriteOutput(startIndex, endIndex);

        }


        public static void Main(string[] args)
        {
            var inputArray = new int[] { 1, 2, 8, 5, 6, 3, 9, 4, 7 };

            Console.Write("Main input Array");
            inputArray.WriteOutput();

            MergeSort(inputArray, 0, inputArray.Length - 1);

            inputArray.WriteOutput();

            Console.Read();
        }
    }
}
