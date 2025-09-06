class Program
{
    static void Main()
    {
        // while (<nosacījums>) { <darbības> }
        // while cikls izpilda darbības iekš {} kamēr <nosacījums> ir patiess (true)

        // Kad <nosacījums> kļūst aplams (false),
        // cikls beidzas un izpilde turpinās ar nākamo rindu pēc {}

        // Ja <nosacījums> ir vienmēr patiess (true),
        // cikls nekad nebeidzas un programma turpina izpildīties mūžīgi

        while (true)
        {
            Console.WriteLine("Enter first number:");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            Console.WriteLine("Enter second number:");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            Console.WriteLine("Enter operation (+, -, *, /):");
            string operation = Console.ReadLine();

            int result = 0;

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
                Console.WriteLine("Invalid operation");
                return;
            }
            Console.WriteLine("Result: " + result);

            // Izveidojam atkārtotus vaicājumus, lai lietotājs varētu izlemt,
            // vai viņš vēlas iziet no programmas vai turpināt.
            bool shouldExit = false;
            while (true)
            {
                Console.WriteLine("Do you want to exit? (y/n):");
                string exitInput = Console.ReadLine();
                if (exitInput == "y")
                {
                    // Ja lietotājs ievada 'y', mainīgais shouldExit tiek iestatīts uz true,
                    // un iekšējais while cikls tiek pārtraukts ar break.
                    shouldExit = true;
                    break;
                }
                else if (exitInput == "n")
                {
                    // Ja lietotājs ievada 'n', mainīgais shouldExit tiek iestatīts uz false,
                    // un iekšējais while cikls tiek pārtraukts ar break.
                    shouldExit = false;
                    break;
                }
                else
                {
                    // Ja ievade nav ne 'y', ne 'n', paziņojam par nepareizu ievadi,
                    // tad cikls turpinās un tiks uzdots jautājums vēlreiz.
                    Console.WriteLine("Invalid input, please enter 'y' or 'n'.");
                }
            }
            if (shouldExit)
            {
                // Ja shouldExit ir true, ārējais while cikls tiek pārtraukts ar return,
                // un programma beidzas.
                return;

                // Piezīme: varētu izmantot arī break, lai izietu no ārējā cikla, jo
                // pēc ārējā cikla nav nekā cita, bet return šeit skaidri norāda,
                // ka programma beidzas.
            }
        }
    }
}

