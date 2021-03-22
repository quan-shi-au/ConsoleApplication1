using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class MyNode1
    {
        public int Id { get; set; }
        public MyNode1 Left { get; set; }
        public MyNode1 Right { get; set; }

    }

    class BreathFirstClass
    {
        private MyNode1 root;

        public void search()
        {
            Queue<MyNode1> q = new Queue<MyNode1>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                MyNode1 current = q.Dequeue();
                if (current == null)
                    continue;
                q.Enqueue(current.Left);
                q.Enqueue(current.Right);

                Console.WriteLine(current);
            }
        }
    }
}
