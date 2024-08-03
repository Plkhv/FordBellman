
namespace FordBellmanServer
{
    public class Graph
    {
        public int VerticesCount;
        public int EdgesCount;
        public Edge[] edge;

        public static Graph CreateGraph(int verticesCount, int edgesCount)
        {
            Graph graph = new Graph();
            graph.VerticesCount = verticesCount;
            graph.EdgesCount = edgesCount;
            graph.edge = new Edge[graph.EdgesCount];

            return graph;
        }
    }
}
