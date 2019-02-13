using System;
using System.ServiceModel;
using InterfaceLibrary;

namespace CalculatorClient
{
    internal class Program
    {
        public static void PrintComplex(params ComplexNumber[] numbers)
        {
            foreach (var n in numbers)
            {
                Console.WriteLine("Complex number {0} + ({1}) * i", n.Real, n.Imaginary);
            }
        }
        
        public static void Main(string[] args)
        {
            const string host = "net.tcp://localhost:8080/api/calculator";
            var factory = new ChannelFactory<ICalculatorService>(
                new NetTcpBinding(),
                new EndpointAddress(host));

            var service = factory.CreateChannel();
            
            // work with service
            
            var number1 = new ComplexNumber(3, 5);
            var number2 = new ComplexNumber(2, 4);
            
            PrintComplex(number1, number2);

            PrintComplex(service.Addition(number1, number2));
            PrintComplex(service.Subtraction(number1, number2));
        }
    }
}