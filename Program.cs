using WorkWithExceptions;

class testParser
{
    public static void Main()
    {
        string expression = Console.ReadLine();
        double result = Parser.LineProcessing(expression);

        Console.WriteLine($"= {result}");
    }
}
