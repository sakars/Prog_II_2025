// Praktiski identiska programma, kas izvada "Hello, World!" konsolē,
// taču izmantota klasiskā C# programmas struktūra ar Program klasi un Main metodi.

// Definē Program klasi
// C# neļauj definēt funkcijas ārpus klases,
// tāpēc mums ir jādefinē klase, kas simbolizē mūsu programmu kopumā
class Program
{
    // Program klasei definējam statisku metodi Main
    // Metode, ko sauc Main, tiks izmantota kā programmas sākumpunkts
    // Statiskas metodes izsauc klases kontekstā, nevis konkrētas
    // klases instances (objekta) kontekstā

    // static - norāda, ka metode pieder klasei, nevis tās instancēm
    //
    // void - norāda, ka metode neatgriež vērtību
    //
    // Main - metodes nosaukums
    //
    // () - nepieciešams, lai kompilators atpazītu to kā metodi,
    // apzīmē, ka metodei nav parametru
    //
    // { } - norāda metodes saturu

    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
