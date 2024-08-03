using System;
using System.ServiceModel;

namespace FordBellmanHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(FordBellmanServer.Service1)))
            {
                host.Open();
                Console.WriteLine("Host Started");
                Console.ReadLine();
            }
        }
    }
}
