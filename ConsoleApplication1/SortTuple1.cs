using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Tuple<int, int>> GetData()
    {
        var data = new List<Tuple<int, int>>();
        data.Add(new Tuple<int, int>(10, 5));
        data.Add(new Tuple<int, int>(10, 4));
        data.Add(new Tuple<int, int>(1, 6));
        data.Add(new Tuple<int, int>(1, 100));
        return data;
    }

    static int ComparisonTwoTuples(Tuple<int, int> a, Tuple<int, int> b)
    {
        // Here we sort two times at once, first one the first item, then on the second.
        // ... Compare the first items of each element.
        var part1 = a.Item1;
        var part2 = b.Item1;
        var compareResult = part1.CompareTo(part2);
        // If the first items are equal (have a CompareTo result of 0) then compare on the second item.
        if (compareResult == 0)
        {
            return b.Item2.CompareTo(a.Item2);
        }
        // Return the result of the first CompareTo.
        return compareResult;
    }

    /*
     * objListOrder.OrderBy(o=>o.OrderDate).ToList();
     * 
     */
    static void Main6()
    {
        // Use comparison.
        var data = GetData();
        data.Sort(ComparisonTwoTuples);
        Console.WriteLine("::COMPARISON::");
        foreach (var tuple in data)
        {
            Console.WriteLine(tuple);
        }

        // Use LINQ orderby.
        var data2 = GetData();
        var sorted = from tuple in data2
                     orderby tuple.Item1 ascending, tuple.Item2 descending
                     select tuple;
        Console.WriteLine("::ORDERBY::");
        foreach (var tuple in sorted)
        {
            Console.WriteLine(tuple);
        }
    }
}