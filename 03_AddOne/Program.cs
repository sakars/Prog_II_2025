
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        // Lai pārveidotu tekstu par skaitli, izmantojam int.Parse funkciju
        // int.Parse - funkcija, kas pārveido tekstu par veselu skaitli (int)
        int number = int.Parse(input);
        int result = number + 1;
        // WriteLine var izvadīt arī skaitli
        Console.WriteLine(result);
    }
}
