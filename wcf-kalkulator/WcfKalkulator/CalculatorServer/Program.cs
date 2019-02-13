using System;
using System.ServiceModel;
using InterfaceLibrary;

namespace CalculatorServer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var host = "net.tcp://localhost:8080/api/calculator";
            var serviceHost = new ServiceHost(typeof(CalculatorService));
            serviceHost.AddServiceEndpoint(typeof(ICalculatorService), new NetTcpBinding(), new Uri(host));

            serviceHost.Open();
            Console.WriteLine("Server initialized on port 8080.");
        }
    }
}