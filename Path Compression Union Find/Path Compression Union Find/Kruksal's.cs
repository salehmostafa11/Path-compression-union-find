using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_Compression_Union_Find
{
    public class KruksalAlg
    {
        public static List<Edge> Kruksal(int n, List<Edge> edges)
        {
            edges.Sort(); //ascending sorting by weight

            PathCompressionUnionFindAlg uf = new PathCompressionUnionFindAlg(n);

            List<Edge> MST = new List<Edge>(); //This is the result MINIMUM SPANNIG TREE

            foreach (Edge e in edges) {
                if (uf.unify(e.Start, e.End)) 
                { 
                    MST.Add(e);
                    if (MST.Count() == n - 1)
                        break;
                }
            }
            return MST;
        }

    }
}
