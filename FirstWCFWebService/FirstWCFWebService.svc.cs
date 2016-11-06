namespace FirstWCFWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FirstWCFWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FirstWCFWebService.svc or FirstWCFWebService.svc.cs at the Solution Explorer and start debugging.
    public class FirstWCFWebService : IFirstWCFWebService
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public string Message()
        {
            return "Hello World";
        }
    }
}
