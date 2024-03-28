# Evaluation

## Question 1

Si l'utilisateur entre 3 pour le nombre de notes et 10, 20, 30 pour les notes, le programme ressort ceci:

- La moyenne des notes est : 20
- Les notes supérieures à la moyenne sont : 30

## Question 2

Si on entrait accidentellement une chaîne de caractères au lieu d'un nombre lors de la saisie des notes, cela afficherait une erreur expliquant que le format n'est pas bon et le code serait alors stoppé.
Pour gérer cette erreur, on pourrait améliorer le code en rajoutant un try - catch au niveau de la saisie des notes, comme ceci:

static void Main(string[] args)
    {
        Console.WriteLine("Combien de notes souhaitez-vous entrer ?");
        
        int nombreDeNotes = Convert.ToInt32(Console.ReadLine());

        double[] notes = new double[nombreDeNotes];

        for (int i = 0; i < nombreDeNotes; i++)
        {
            Console.WriteLine($"Entrez la note {i + 1}:");

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
        AfficherNotesSupérieures(notes, moyenne);
    }

## Question 3

J'ai modifié la fonction afin qu'elle retourne le nombre de notes supérieures a la moyenne:

static void AfficherNotesSupérieures(double[] notes, double moyenne)
    {
        int nombreDeNotes = 0;
        foreach (double note in notes)
        {
            
            if (note > moyenne)
            {
                nombreDeNotes++;
                Console.WriteLine(note);
            }
        }
        Console.WriteLine($"Le nombre de notes supérieures a la moyenne est: {nombreDeNotes}");
    }

## Question 4

En programmation, on peut créer des fonctions pour éviter la redondance de code, et la plupart des langages ont des fonctions déjà créées, qu'on peut trouver dans la documentation qui servent a convertir les entrées utilisateurs en nombres

## Question 5

J'ai ajouté un tableau prénom, ou je vais stocker les prénoms des étudiants, puis j'ai modifié la méthode AfficherNotesSupérieures() afin d'y ajouter le code nécéssaire pour récupérer l'étudiant lié a la note et l'afficher dans le terminal.

static void Main(string[] args)
    {
        Console.WriteLine("Combien de notes souhaitez-vous entrer ?");

        int nombreDeNotes = Convert.ToInt32(Console.ReadLine());
        // nouveau tableau qui va stocker les prénoms des étudiants dans le meme ordre que leur note
        string[] prenoms = new string[nombreDeNotes];
        double[] notes = new double[nombreDeNotes];

        for (int i = 0; i < nombreDeNotes; i++)
        {
            // Message pour entrer le nom de l'étudiant 1
            Console.WriteLine($"Entrez le prénom de l'étudiant {i + 1}: ");

            // ajout du prénom de l'etudiant dans le tableau dédié (il aura le meme index que sa note)
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
        int nombreDeNotes = 0;
        //i correspondra a l'index de la note et du prénom
        int i = 0;
        foreach (double note in notes)
        {
            
            if (note > moyenne)
            {
                nombreDeNotes++;
                // on affiche le bon prénom qui a le meme index que la note en face de la bonne note 
                Console.WriteLine($"{prenoms[i]}: {note}");
            }
            //on rajoute 1 a i pour rajouter 1 index au fur et a mesure du tableau
            i++;
        }
        Console.WriteLine($"Le nombre de notes supérieures a la moyenne est: {nombreDeNotes}");
    }

## Question 6

Si on entrait un nombre négatif pour NombreDeNotes, cela afficherait une erreur et stopperait le programme.
J'ai alors ajouté une boucle while au debut du code, juste après la saisie de nombreDeNotes afin de remettre le message tant que le nombre de notes est inférieur a 0.
Le code passera alors a la suite si le nombre saisi est 0 ou supérieur a 0:

static void Main(string[] args)
    {
        Console.WriteLine("Combien de notes souhaitez-vous entrer ?");

        int nombreDeNotes = Convert.ToInt32(Console.ReadLine());

        // Ajout d'une boucle while: tant que la note entrée est inférieure a 0 on repose la question et on affiche un message d'erreur
        while (nombreDeNotes < 0) {
            // On affiche un message d'erreur
            Console.WriteLine("Merci d'entrer un nombre supérieur a 0");
            // On repose la question
            Console.WriteLine("Combien de notes souhaitez-vous entrer ?");
            On récupère la réponse dans la variable de la condition
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
    }

## Question 7

J'ai crée ma nouvelle fonction pour afficher la note la plus basse :

    // Nouvelle méthode pour afficher la note la plus basse
    static void AfficherNotePlusBasse(double[] notes)
    {
        // ajout d'une variable qui stockera la note précedente (par défaut elle a la premiere valeur du tableau de notes afin
        // de comparer directement a une valeur existante)
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
