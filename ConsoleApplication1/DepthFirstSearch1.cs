using System.Collections.Generic;

namespace KoderDojo.Examples
{
    public class Graph<T>
    {
        public T ObjValue;
        public Dictionary<T, Graph<T>> AdjacencyList;
    }

    public class Algorithms
    {
        public HashSet<T> DFS<T>(Graph<T> graph, T start)
        {
            var visited = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var stack = new Stack<T>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                T vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList)
                    if (!visited.Contains(neighbor.Value.ObjValue))
                        stack.Push(neighbor.Value.ObjValue);
            }

            return visited;
        }
    }
}
