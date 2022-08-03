class Parser
{
    public static void Add(double value1, double value2)
    {

        Console.WriteLine(value1 + value2);
    }

    public static void Div(double value1, double value2)
    {
        if (value2 == 0)
            throw new DivideByZeroException("Divide by zero isn't possible");
        else
            Console.WriteLine(value1 / value2);
    }

    public static void Mult(double value1, double value2)
    {
        Console.WriteLine(value1 * value2);
    }

    public static void Sub(double value1, double value2)
    {
        Console.WriteLine(value1 - value2);
    }
}

class testParser
{
    public static void Main()
    {
        try
        {
            Parser.Add(4, 2);
            Parser.Sub(-235.26, 945);
            Parser.Mult(2, 7);
            Parser.Div(9, 0);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Division by zero isn't possible");
        }
        catch
        {
            Console.WriteLine("invalid data format");
        }
        
        
    }
}