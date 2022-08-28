using System.ServiceModel;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        string GetData(int value);
    }
}
