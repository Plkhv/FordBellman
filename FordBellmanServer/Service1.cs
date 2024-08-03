using System;
using System.ServiceModel;

namespace FordBellmanServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, IncludeExceptionDetailInFaults = true)]
    public class Service1 : IService1
    {
        public void BellmanFord(int verticesCount, int edgesCount, int source, string edges)
        {
            OperationContext oc = OperationContext.Current;
            string output = "";
            Graph graph = Graph.CreateGraph(verticesCount, edgesCount);

            Edge[] edge = new Edge[edgesCount];
            string[] input = edges.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            for (int i = 0; i < edgesCount; i++)
            {
                string[] sdw = input[i].Split(' ');
                int[] ints = new int[sdw.Length];
                for (int j = 0; j < sdw.Length; j++)
                {
                    ints[j] = Convert.ToInt32(sdw[j]);
                }
                edge[i] = new Edge()
                {
                    Source = ints[0] - 1,
                    Destination = ints[1] - 1,
                    Weight = ints[2]
                };
            }
            graph.edge = edge;
            int[] distance = new int[verticesCount];

            for (int i = 0; i < verticesCount; i++)
                distance[i] = int.MaxValue;

            distance[source] = 0;

            for (int i = 1; i < verticesCount; ++i)
            {
                for (int j = 0; j < edgesCount; ++j)
                {
                    int u = graph.edge[j].Source;
                    int v = graph.edge[j].Destination;
                    int weight = graph.edge[j].Weight;

                    if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                        distance[v] = distance[u] + weight;
                }
            }

            for (int i = 0; i < edgesCount; ++i)
            {
                int u = graph.edge[i].Source;
                int v = graph.edge[i].Destination;
                int weight = graph.edge[i].Weight;

                if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                {
                    output = "Граф содержит цикл отрицательного веса.";
                    break;
                }
            }


            if (output == "")
                for (int i = 0; i < verticesCount; ++i)
                    output += $"Расстояние от вершины {i+1} до источника = {distance[i]}\n";

            
            oc.GetCallbackChannel<IService1CallBack>().sendAnswer(output);
        }
    }
}
