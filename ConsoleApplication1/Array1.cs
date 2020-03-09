using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Array1
    {
        public void GetJaggedArrayOfArrays()
        {
            double[][] x = new double[5][];

            x[0] = new double[10];
            x[1] = new double[5];
            x[2] = new double[3];
            x[3] = new double[100];
            x[4] = new double[1];

            int[][][] buildingCost = new int[2][][];

            int[,] intarr = new int[3, 2] {

                                             { 4, 5 },

                                             { 5, 0 },

                                             { 3, 1 }

                                         };


        }

        // Rectangular array
        public void TwoDimensionalArray()
        {
            double[,] ServicePoint = new double[10, 9];

            int[,,] array3D = new int[3, 3, 3];

        }

        public void AccessArraryItems()
        {
            // Two Dimensional Array

            int[,] array2D = new int[3, 2] { { 4, 5 }, { 5, 0 }, { 3, 1 } };

            // Three Dimensional Array

            int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            Console.WriteLine("---Two Dimensional Array Elements---");

            for (int i = 0; i < 3; i++)

            {

                for (int j = 0; j < 2; j++)

                {

                    Console.WriteLine("a[{0},{1}] = {2}", i, j, array2D[i, j]);

                }

            }

            Console.WriteLine("---Three Dimensional Array Elements---");

            for (int i = 0; i < 2; i++)

            {

                for (int j = 0; j < 2; j++)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        Console.WriteLine("a[{0},{1},{2}] = {3}", i, j, k, array3D[i, j, k]);

                    }

                }

            }

            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();
        }

    }
}
