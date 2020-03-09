using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // C# program to illustrate how 
    // get topmost elements of the queue 
    using System;
    using System.Collections;

    public class Node
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GFG
    {
        static public void Main2()
        {
            Queue queue1 = new Queue();

            queue1.Enqueue(new Node { Id = 1, Name = "Sam" });
            queue1.Enqueue(new Node { Id = 2, Name = "Ian" });
            queue1.Enqueue(new Node { Id = 3, Name = "David" });

            var top = queue1.Peek() as Node;

            Console.WriteLine($"{top.Name}");
        }

        static public void Main3()
        {

            // Create a queue 
            // Using Queue class 
            Queue my_queue = new Queue();

            // Adding elements in Queue 
            // Using Enqueue() method 
            my_queue.Enqueue("GFG");
            my_queue.Enqueue("Geeks");
            my_queue.Enqueue("GeeksforGeeks");
            my_queue.Enqueue("geeks");
            my_queue.Enqueue("Geeks123");

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Obtain the topmost element of my_queue 
            // Using Dequeue method 
            Console.WriteLine("Topmost element of my_queue"
                         + " is: {0}", my_queue.Dequeue());


            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Obtain the topmost element of my_queue 
            // Using Peek method 
            Console.WriteLine("Topmost element of my_queue is: {0}",
                                                   my_queue.Peek());

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);
        }
    }
}
