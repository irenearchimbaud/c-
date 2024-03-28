using System;
using System.Net;

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
        Console.WriteLine("Combien de notes souhaitez-vous entrer ?");

        int nombreDeNotes = Convert.ToInt32(Console.ReadLine());

        // Ajout d'une boucle while: tant que la note entrée est inférieure a 0 on repose la question et on affiche un message d'erreur
        while (nombreDeNotes < 0) {
            Console.WriteLine("Merci d'entrer un nombre supérieur a 0");
            Console.WriteLine("Combien de notes souhaitez-vous entrer ?");
            nombreDeNotes = Convert.ToInt32(Console.ReadLine());
        }
        // nouveau tableau qui va stocker les prénoms des étudiants dans le meme ordre que leur note
        string[] prenoms = new string[nombreDeNotes];
        double[] notes = new double[nombreDeNotes];

        for (int i = 0; i < nombreDeNotes; i++)
        {

            Console.WriteLine($"Entrez le prénom de l'étudiant {i + 1}: ");

            // ajout du prénom de l'etudiant dans le tableau dédié
            prenoms[i] = Console.ReadLine();

            Console.WriteLine($"Entrez sa note {i + 1}:");

            // Ajout du bloc if afin de rajouter une condition try catch pour verifier que notes[i] est un double sinon afficher un message d'erreur
            try {
                notes[i] = Convert.ToDouble(Console.ReadLine());
            } catch {
                i--;
                Console.WriteLine("Merci d'entrer un nombre ou en chiffre");
            }

        }

        double moyenne = CalculerMoyenne(notes);
        Console.WriteLine($"La moyenne des notes est : {moyenne}");

        Console.WriteLine("Les notes supérieures à la moyenne sont : ");
        AfficherNotesSupérieures(notes, prenoms, moyenne);
        // on appelle la méthode pour afficher la note la plus basse
        AfficherNotePlusBasse(notes);
    }

    static double CalculerMoyenne(double[] notes)
    {
        double somme = 0;
        foreach (double note in notes)
        {
            somme += note;
        }
        return somme / notes.Length;
    }

    static void AfficherNotesSupérieures(double[] notes, string[] prenoms, double moyenne)
    {
        int nombreNotes = 0;
        //i correspondra a l'index
        int i = 0;
        foreach (double note in notes)
        {
            
            if (note > moyenne)
            {
                nombreNotes++;
                // on affiche le bon prénom en face de la bonne note 
                Console.WriteLine($"{prenoms[i]}: {note}");
            }
            //on rajoute 1 a i pour rajouter 1 index au fur et a mesure du tableau
            i++;
        }
        Console.WriteLine($"Le nombre de notes supérieures a la moyenne est: {nombreNotes}");
    }

// Nouvelle méthode qui affiche la note la plus basse
    static void AfficherNotePlusBasse(double[] notes)
    {
        // ajout d'une variable qui stockera la note précedente (par défaut elle a la premiere valeur du tableau de notes afin
        // de comparer directement a une valeur existante
        double notePrecedente = notes[0];
        // on parcours le tableau de notes, et pour chaque note on la compare avec la note précédente
        foreach (double note in notes)
        {
            // Pour chaque note, on la compare à la note précédente, si elle est plus petite, on ajoute cette nouvelle valeur à la place
            // de l'ancienne valeur de notePrecedente
            if (note < notePrecedente)
            {
                notePrecedente = note;
            }
        }
        // On affiche la note la plus basse dans la console
        Console.WriteLine($"La note la plus basse est: {notePrecedente}");
    }
}
