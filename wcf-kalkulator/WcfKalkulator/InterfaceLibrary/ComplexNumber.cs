using System;
using System.Runtime.Serialization;

namespace InterfaceLibrary
{
    [DataContract]
    public class ComplexNumber
    {
        [DataMember]
        public double Real { get; set; }

        [DataMember]
        public double Imaginary { get; set; }

        public ComplexNumber()
        {
            this.Real = 0;
            this.Imaginary = 0;
        }

        public ComplexNumber(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
        
        public static ComplexNumber operator +(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.Real + number2.Real, number1.Imaginary + number2.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.Real - number2.Real, number1.Imaginary - number2.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber number1, ComplexNumber number2)
        {
            var real = ((number1.Real * number2.Real) - (number1.Imaginary * number2.Imaginary));
            var imag = ((number1.Real * number2.Imaginary) - (number1.Imaginary * number2.Real));
            return new ComplexNumber();
        }

        public static ComplexNumber operator /(ComplexNumber number1, ComplexNumber number2)
        {
            var divider = Math.Pow(number1.Imaginary, 2) + Math.Pow(number2.Imaginary, 2);
            var real = ((number1.Real * number2.Real) + (number1.Imaginary * number2.Imaginary));
            var imag = ((number1.Imaginary * number2.Real) - (number1.Real * number2.Imaginary));
            return new ComplexNumber(real / divider, imag / divider);
        }
    }
}