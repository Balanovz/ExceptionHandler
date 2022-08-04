namespace WorkWithExceptions
{
    public class Parser
    {
        public static double CalculateExpression(double firstOperand, string operation, double secondOperand)
        {
            double result = default;
            switch (operation)
            {
                case "+":
                    result = Add(firstOperand, secondOperand);
                    break;
                case "-":
                    result = Sub(firstOperand, secondOperand);
                    break;
                case "*":
                    result = Mult(firstOperand, secondOperand);
                    break;
                case "/":
                    result = Div(firstOperand, secondOperand);
                    break;
                default:
                    throw new Exception("Invalid input data");
            }
            return result;
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
