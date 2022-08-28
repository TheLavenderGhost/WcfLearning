using System;

namespace HelloClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ServiceReference1.HelloServiceClient();
            var msg = proxy.GetData(101);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
