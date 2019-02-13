using InterfaceLibrary;

namespace CalculatorServer
{   
    public class CalculatorService : ICalculatorService
    {
        private ComplexNumber internalMethod(Operations operation, params ComplexNumber[] numbers)
        {
            if (numbers.Length == 1)
            {
                return numbers[0];
            }
            else if (numbers.Length < 1)
            {
                return null;
            }
            else
            {
                var result = numbers[0];
                for (var i = 1; i < numbers.Length; i++)
                {
                    switch (operation)
                    {
                        case Operations.Addition:
                            result += numbers[i];
                            break;
                        case Operations.Subtraction:
                            result -= numbers[i];
                            break;
                        case Operations.Multiplication:
                            result *= numbers[i];
                            break;
                        case Operations.Division:
                            result /= numbers[i];
                            break;
                    }
                }
                return result;
            }
        }
        
        public ComplexNumber Addition(params ComplexNumber[] numbers)
        {
            return internalMethod(Operations.Addition, numbers);
        }

        public ComplexNumber Subtraction(params ComplexNumber[] numbers)
        {
            return internalMethod(Operations.Subtraction, numbers);
        }

        public ComplexNumber Multiplication(params ComplexNumber[] numbers)
        {
            return internalMethod(Operations.Multiplication, numbers);
        }

        public ComplexNumber Division(params ComplexNumber[] numbers)
        {
            return internalMethod(Operations.Division, numbers);
        }
    }
}