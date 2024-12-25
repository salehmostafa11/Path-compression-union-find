using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_Compression_Union_Find
{
    public class Edge : IComparable<Edge> //defined it ICombareable to allow me sorting edges by weight
    {
        public int Start { get; }
        public int End { get; }
        public int Weight { get; }

        public Edge(int start ,int end, int weight)
        {
            this.Start = start;
            this.End = end;
            this.Weight = weight;
        }
        public int CompareTo(Edge anotherEdge)
        {
            return Weight.CompareTo(anotherEdge.Weight); // 1 if this is greater, -1 less, 0 same
        }
    }
}
