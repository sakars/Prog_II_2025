class Program
{
    static void Main()
    {
        // Paprasam 1. skaitli
        Console.WriteLine("Enter first number:");
        string input1 = Console.ReadLine();
        int number1 = int.Parse(input1);

        // Paprasam 2. skaitli
        Console.WriteLine("Enter second number:");
        string input2 = Console.ReadLine();
        int number2 = int.Parse(input2);

        // Paprasam darbību
        Console.WriteLine("Enter operation (+, -, *, /):");
        string operation = Console.ReadLine();

        // Definējam result mainīgo pirms if-else blokiem,
        // lai tas būtu pieejams ārpus if-else blokiem
        int result = 0;

        // Veicam darbību atkarībā no lietotāja ievades
        if (operation == "+")
        {
            result = number1 + number2;
        }
        else if (operation == "-")
        {
            result = number1 - number2;
        }
        else if (operation == "*")
        {
            result = number1 * number2;
        }
        else if (operation == "/")
        {
            result = number1 / number2;
        }
        else
        {
            // Ja darbība nav atpazīta, izvadām kļūdas paziņojumu un beidzam programmu
            Console.WriteLine("Invalid operation");
            // Return izbeidz Main metodes izpildi
            return;
        }
        Console.WriteLine("Result: " + result);
    }
}

