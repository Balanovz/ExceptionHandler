namespace WorkWithExceptions
{
    public class Parser
    {
        private static double CalculateExpression(double firstOperand, char operation, double secondOperand)
        {
            double result;
            switch (operation)
            {
                case '+':
                    result = Add(firstOperand, secondOperand);
                    break;
                case '-':
                    result = Sub(firstOperand, secondOperand);
                    break;
                case '*':
                    result = Mult(firstOperand, secondOperand);
                    break;
                case '/':
                    result = Div(firstOperand, secondOperand);
                    break;
                default:
                    throw new Exception("Invalid input data");
            }
            return result;
        }

        public static double LineProcessing(string line)
        {
            string firstOperand = "";
            string secondOperand = "";
            char operation = default;
            char[] operationSymbols = { '+', '-', '/', '*' };

            for(int i = 0; i < line.Length / 2; ++i)
            {
                if (char.IsNumber(line[i]))
                    firstOperand += line[i];
                if (char.IsNumber(line[line.Length - i - 1]))
                    secondOperand += line[line.Length - i - 1];
            }

            foreach (var i in line)
                if (operationSymbols.Contains(i))
                {
                    operation = i;
                    break;
                }
                
            secondOperand.Reverse();

            return CalculateExpression(int.Parse(firstOperand), operation, int.Parse(secondOperand));
        }

        private static double Add(double firstOperand, double secondOperand)
        {
            return firstOperand + secondOperand; 
        }

        private static double Div(double firstOperand, double secondOperand)
        {
            if (secondOperand == 0)
                throw new DivideByZeroException("Divide by zero isn't possible");
            else
                return firstOperand / secondOperand;
        }

        private static double Mult(double firstOperand, double secondOperand)
        {
            return firstOperand * secondOperand;
        }

        private static double Sub(double firstOperand, double secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
