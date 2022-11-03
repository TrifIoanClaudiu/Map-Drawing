using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrifIonut_MapDrawing
{
    internal class Graph
    {
        private int vertices;
        private LinkedList<int>[] adj;
        private string[] color;
        private static string[] countries = new string[8]
        {
            "Romania","Hungary","Ukraine","Slovakia","Austria","Germany","France","Italy"
        };
        public Graph(int v)
        {
            vertices = v;
            adj = new LinkedList<int>[v];
            color = new string[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new LinkedList<int>();
                color[i] = "";
            }

        }

        public void addEdge(int c, int v)
        {
            adj[c].AddLast(v);
            adj[v].AddFirst(c);
        }

        public void DyeMap(int s)
        {
            bool[] visited = new bool[vertices];
            for (int i = 0; i < vertices; i++)
            {
                visited[i] = false;
            }

            LinkedList<int> queue = new LinkedList<int>();

            visited[s] = true;
            color[s] = "blue";
            queue.AddLast(s);

            while (queue.Any())
            {
                s = queue.First();



                queue.RemoveFirst();

                LinkedList<int> list = adj[s];

                void visitor()
                {
                    List<string> possibleColors = new List<string>{"blue", "green", "yellow", "red" };
                    foreach (var val in list)
                    {
                        if (visited[val])
                        {
                            for(int i=0; i<possibleColors.Count; i++)
                            {
                                if (color[val] == possibleColors[i])
                                {
                                    possibleColors.RemoveAt(i);
                                }
                            }
                        }
                    }

                    color[s] = possibleColors[0];
                }

                visitor();

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }
        public void Neighbours(int s) {
            LinkedList<int> list = adj[s];
            foreach(var val in list)
            {
                Console.Write(countries[val] + " ");
            }
        }
        public void showGraph(int s)
        {
            DyeMap(s);
            for (int i = 0; i < vertices; i++)
            {
                Console.WriteLine(countries[i]);
                Console.Write("Neigbours: "); Neighbours(i);
                Console.WriteLine();
                Console.WriteLine("Color: " + color[i]);
                Console.WriteLine();
            }
        }

    }
}
