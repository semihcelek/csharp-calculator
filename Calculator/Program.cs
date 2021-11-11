using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator.");
            Console.WriteLine("Please enter 2 number to continue calculation.");
            Calculator calcInstance = new Calculator();
            UserInput inputInstace = new UserInput();

            bool app = false;


            while (!app)
            {
                double num1;
                double num2;
                double result = 0;

                num1 = inputInstace.getUserInput();
                num2 = inputInstace.getUserInput();

                Console.WriteLine("Choose an operator:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = inputInstace.getOperatorInput();

                result = calcInstance.Operate(num1, num2, op);


                Console.WriteLine("Result of calculation is");
                Console.WriteLine(result);
                app = true;
                //end application.
            }
            return;

        }
    }
}
