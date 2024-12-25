namespace Path_Compression_Union_Find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            // قائمة الحواف (from, to, weight)
            List<Edge> edges = new List<Edge>
        {
            new Edge(0, 1, 4), 
            new Edge(0, 2, 4),  
            new Edge(1, 2, 2), 
            new Edge(1, 3, 6), 
            new Edge(2, 3, 8), 
            new Edge(3, 4, 9), 
            new Edge(4, 5, 10),
            new Edge(3, 5, 7)  
        };

            List<Edge> mst = KruksalAlg.Kruksal(n, edges);

            Console.WriteLine("Edges in the Minimum Spanning Tree:");
            foreach (var edge in mst)
            {
                Console.WriteLine($"From: {edge.Start}, To: {edge.End}, Weight: {edge.Weight}");


            }
        }
    }
}


    

