using System;
namespace Calculator
{
    public class Calculator
    {
        private double result;

        public Calculator()
        {
            result = 0;
        }

        public double getResult()
        {
            return result;
        }

        public double Add(double param1, double param2)
        {
            result = param1 + param2;
            return result;
        }
        public double Subtract(double param1, double param2)
        {
            result = param1 - param2;
            return result;
        }

        public double Product(double param1, double param2)
        {
            result = param1 * param2;
            return result;
        }

        public double Divide(double param1, double param2)
        {
            if (param2 == 0)
            {
                Console.WriteLine("Cannot devide to 0");
                return 0;
            }

            result = param1 / param2;
            return result;
        }
        public double Operate(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Product(num1, num2);
                    break;
                case "d":
                    result = Divide(num1, num2);
                    break;
                default:
                    break;
            }
            return result;
        }

    }
}
