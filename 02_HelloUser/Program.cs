
class Program
{
    static void Main()
    {
        // Console.ReadLine() - nolasa lietotāja ievadi no konsoles
        // un atgriež to kā tekstu (string)
        // Šī funkcija mazliet atšķiras no Python input() funkcijas,
        // jo tā neatļauj parādīt uzvedni (prompt) tieši funkcijas izsaukumā

        Console.WriteLine("Enter your name:");

        // Saglabājam lietotāja ievadi mainīgajā 'name'
        // Mainīgos definējam šādi:
        // <datu tips> <mainīgā nosaukums> = <vērtība>;
        // Datu tips 'string' apzīmē tekstu jeb simbolu virkni
        //
        // Mainīgā nosaukums 'name' ir izvēlēts, lai atspoguļotu,
        // ka šis mainīgais glabās lietotāja vārdu
        // 
        // = - piešķiršanas operators, kas piešķir labajā pusē esošo vērtību
        // mainīgajam kreisajā pusē
        //
        // ; - norāda izteikuma beigas
        string name = Console.ReadLine();

        // Valodā Python uzvedni un ielasīšanu mainīgajā varētu izdarīt ar vienu izteikumu:
        // name = input("Enter your name: ")

        Console.WriteLine("Hello, " + name + "!");
    }
}

