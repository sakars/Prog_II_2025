class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        string input1 = Console.ReadLine();
        int number1 = int.Parse(input1);
        Console.WriteLine("Enter second number:");
        string input2 = Console.ReadLine();
        int number2 = int.Parse(input2);

        int result = number1 + number2;
        Console.WriteLine("Result: " + result);
    }
}
