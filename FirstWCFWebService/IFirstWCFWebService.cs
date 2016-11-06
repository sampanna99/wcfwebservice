using System.ServiceModel;

namespace FirstWCFWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFirstWCFWebService" in both code and config file together.
    [ServiceContract]
    public interface IFirstWCFWebService
    {
        [OperationContract]
        string Message();
        [OperationContract]
        int add(int x, int y);
    }
}
