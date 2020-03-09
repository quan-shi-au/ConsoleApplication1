using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class TreeNode<T>
    {
        private readonly T _value;
        private readonly List<TreeNode<T>> _children = new List<TreeNode<T>>();

        public TreeNode(T value)
        {
            _value = value;
        }

        public TreeNode<T> this[int i]
        {
            get { return _children[i]; }
        }

        public TreeNode<T> Parent { get; private set; }

        public T Value { get { return _value; } }

        public ReadOnlyCollection<TreeNode<T>> Children
        {
            get { return _children.AsReadOnly(); }
        }

        public TreeNode<T> AddChild(T value)
        {
            var node = new TreeNode<T>(value) { Parent = this };
            _children.Add(node);
            return node;
        }

        public TreeNode<T>[] AddChildren(params T[] values)
        {
            return values.Select(AddChild).ToArray();
        }

        public bool RemoveChild(TreeNode<T> node)
        {
            return _children.Remove(node);
        }

        public void Traverse(Action<T> action)
        {
            action(Value);

            foreach (var child in _children)
                child.Traverse(action);
        }

        /*
         * Select is used to select value from a collection whereas 
         * SelectMany is used to select values from a collection of collection i.e. nested collection.
         * Select and SelectMany both are projection operators. In below example we will return a list of courses, each containing a list of subjects. You will see that Select will return a list of lists of subjects while SelectMany will flatten the lists into a single list of subjects.
         */

        public IEnumerable<T> Flatten()
        {
            return new[] { Value }.Concat(_children.SelectMany(x => x.Flatten()));
        }

    }

    public class Tree1Main
    {
        static void Main1(string[] args)
        {
            var root = new TreeNode<MyNode>(new MyNode { Id = 1, Name="Sam"});

            var children = root.AddChildren(new MyNode { Id = 1, Name = "Sam1" }, new MyNode { Id = 1, Name = "Sam2" }, new MyNode { Id = 1, Name = "Sam3" });

            children[0].AddChildren(new MyNode { Id = 1, Name = "Sam11" }, new MyNode { Id = 1, Name = "Sam12" }, new MyNode { Id = 1, Name = "Sam13" });

            root.Traverse((x) => { Console.WriteLine(x.Name); });

            Console.Read();

        }
    }
}
