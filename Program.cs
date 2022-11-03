using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrifIonut_MapDrawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(8);

            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(1, 2);
            g.addEdge(1, 3);
            g.addEdge(1, 4);
            g.addEdge(2, 3);
            g.addEdge(3, 4);
            g.addEdge(4, 5);
            g.addEdge(4, 7);
            g.addEdge(6, 5);
            g.addEdge(6, 7);
            g.showGraph(0);

        }

        /*The countries are 
         * 0 - Romania
         * 1- Hungary
         * 2 - Ukraine
         * 3 - Slovakia
         * 4 - Austria
         * 5 - Germany
         * 6 - France
         * 7 - Italy
         */
    }
}
