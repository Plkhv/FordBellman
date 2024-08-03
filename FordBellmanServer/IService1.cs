using System.ServiceModel;

namespace FordBellmanServer
{
    [ServiceContract(CallbackContract = typeof(IService1CallBack))]
    public interface IService1
    {
        [OperationContract (IsOneWay = true)]
        void BellmanFord(int verticesCount, int edgesCount, int source, string edges);
    }

    public interface IService1CallBack
    {
        [OperationContract(IsOneWay = true)]
        void sendAnswer(string answer);
    }
}
