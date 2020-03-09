using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Stack1
    {
        static void Main1(string[] args)
        {
            Stack st = new Stack();


            st.Push(1);
            st.Push(2);
            st.Push(3);

            st.Push(new MyNode { Id = 1, Name = "xMan" });

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the stack " + st.Count);
            Console.WriteLine("Does the stack contain the elements 3 " + st.Contains(3));
            Console.ReadKey();
        }
    }
}
