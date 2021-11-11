using System;
namespace Calculator
{
    public class UserInput
    {
        private string numInput = "";

        public UserInput()
        {

        }

        public double getUserInput()
        {
            string input = Console.ReadLine();
            double cleanNum = 0;
            while (!double.TryParse(input, out cleanNum))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                input = Console.ReadLine();
            }
            return cleanNum;
        }

        public string getOperatorInput()
        {
            return Console.ReadLine();

        }

    }
}
