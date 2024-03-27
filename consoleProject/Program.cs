namespace consoleProject;

//La classe main est la classe principale de notre projet
//Elle représente notre programme

class Program
{
    //La methode main est la methode principale de notre projet.
    // c'est son point d'entrée
    // Une methode est représentée par sa signature
    // <modificateur> <type de retour> <nom de la methode> (<parametres>)
    //                                          y               (x)
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        try {
            Console.Write("Entrez un nombre : ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Le nombre est: {nombre}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Format incorrect, veuillez entrer un nombre entier.");
        }
    }
}
