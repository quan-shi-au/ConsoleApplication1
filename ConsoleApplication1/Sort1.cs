using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sort1
    {
        public static void GetSorted()
        {
            string[] colors = new string[]
            {
            "orange",
            "blue",
            "yellow",
            "aqua",
            "red"
            };

            Array.Sort(colors);

            foreach (string color in colors)
                Console.WriteLine(color);

        }

        static void Mainy(string[] args)
        {
            GetSorted();
        }

    }
}
