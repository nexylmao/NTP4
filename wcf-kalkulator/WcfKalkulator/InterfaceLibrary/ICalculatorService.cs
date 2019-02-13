using System.ServiceModel;

namespace InterfaceLibrary
{
    public enum Operations
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    };

    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        ComplexNumber Addition(params ComplexNumber[] numbers);

        [OperationContract]
        ComplexNumber Subtraction(params ComplexNumber[] numbers);

        [OperationContract]
        ComplexNumber Multiplication(params ComplexNumber[] numbers);

        [OperationContract]
        ComplexNumber Division(params ComplexNumber[] numbers);
    }
}