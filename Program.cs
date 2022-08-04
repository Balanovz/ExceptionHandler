using WorkWithExceptions;

class testParser
{
    public static void Main()
    {
        double firstOperand = 35;
        double secondOperand = 0;
        string operation = "9";
        double result = Parser.CalculateExpression(firstOperand, operation, secondOperand);

        Console.WriteLine(result);
    }
}
