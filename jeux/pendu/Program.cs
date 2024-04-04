namespace pendu;

class Program {
    static void Main(string[] args) {

        int maxTries = 12; // nombre d'essais maximum
        int tries = 0; // nombre d'essais en cours
         // tableau des mots pouvant être choisis par l'ordinateur
        string[] wordsList = { "coucou", "maquillage", "mouette", "photographie", "ananas", "aurevoir", "paris" };
        int wordsListLength = wordsList.Length; // taille du tableau de mots
        Random random = new Random(); // instance de la classe Random pour générer des nombres aléatoires
        string selectedWord = wordsList[random.Next(wordsListLength)]; // séléction aléatoire d'un mot parmi le tableau
        bool[] guessedLetters = new bool[selectedWord.Length]; // Initialisation d'un tableau de booléens pour suivre quelles lettres ont été devinées dans le mot
        List<string> foundedLetters = new List<string>(); // Initialisation d'une liste pour stocker les lettres déjà devinées

        // Affichage d'un message de bienvenue
        Console.WriteLine(" ");
        Console.WriteLine("Bienvenue dans le pendu. Vous pouvez taper ! à tout moment pour quitter le jeu.");
        Console.WriteLine(" ");
        Console.Write("Veuillez séléctionner votre niveau de difficulté (1 = facile; 2 = moyen; 3 = difficile) OU quittez le jeu en cliquant sur !: ");

        string? difficultLevel = Console.ReadLine(); // on enregistre la reponse dans une variable


        while(difficultLevel != "1" && difficultLevel != "2" && difficultLevel != "3") { // Boucle pour vérifier si la difficulté est valide
            if(difficultLevel == "!") { // Si l'utilisateur a entré '!'
                // message de confirmation pour quitter le jeu
                Console.WriteLine("Êtes-vous sûrs de vouloir quitter le jeu ? (taper: oui pour quitter)");

                string? exitJeux = Console.ReadLine(); // on enregistre la réponse dans une variable

                if(exitJeux != null && exitJeux.ToLower() == "oui") { // Si l'utilisateur confirme qu'il veut quitter
                    Console.WriteLine("Vous avez quitté le jeu."); // Message indiquant que le joueur a quitté le jeu
                    return; // sortie de la méthode main
                } else {
                    // sinon message indiquand que le joueur a décidé de ne pas quitter le jeu
                    Console.WriteLine("Vous avez décidé de ne pas quitter le jeu.");
                }
            } else {
                // message d'erreur si la difficulté choisie n'est pas valide
                Console.WriteLine("Merci de selecctionner un chiffre entre 1 et 3");
            }

            // on re affiche le message de séléction de difficulté
            Console.WriteLine(" ");
            Console.Write($"$Veuillez selectionner votre niveau de difficulté (1 = facile; 2 = moyen; 3 = difficile) OU quittez le jeu en cliquant sur !: ");

            difficultLevel = Console.ReadLine();
        }

        // Switch pour déterminer le nombre maximum d'essais en fonction de la difficulté choisie
        switch (difficultLevel) {
            case "1": // si 1
                maxTries = 14; // nombre d'essais max = 14
                break; 
            case "2": // si 2
                maxTries = 12; // nombre d'essais max = 12
                break;
            case "3": // si 3
                maxTries = 10; // nombre d'essais max = 10
                break;
        }

        // Boucle principale du jeu, continue tant que le nombre d'essais effectués est inférieur au nombre maximal d'essais
        while (tries < maxTries) {
             // Affichage du nombre d'essais restants
            Console.WriteLine(" ");
            Console.WriteLine($"Essais restants : {maxTries - tries}");
            Console.WriteLine(" ");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine(" ");
            Console.Write("Choisissez votre lettre : ");
            string? userInput = Console.ReadLine(); // on enregistre la lettre entrée dans une variable
            bool isFoundedLetter = false; // Indique si la lettre entrée par l'utilisateur a déjà été trouvée dans le mot
            char userLetter; // La lettre devinée par l'utilisateur en char
            bool letterFound = false; // Indique si la lettre devinée par l'utilisateur est présente dans le mot
            bool wordGuessed = true; // Indique si toutes les lettres du mot ont été devinées

            if (userInput == "!") { // Si la lettre '!' est entrée
                // message de confirmation pour quitter le jeu
                Console.WriteLine("Êtes-vous sûrs de vouloir quitter le jeu ? (taper: oui pour quitter)");
                string? exitJeux = Console.ReadLine(); // on enregistre la réponse dans une variable

                // si l'utilisateur a entré 'oui'
                if(exitJeux != null && exitJeux.ToLower() == "oui") {
                    // message qui indique que le joueur a quitté le jeu
                    Console.WriteLine("Vous avez quitté le jeu.");
                    return; // quitte le jeu
                } else { // sinon
                    Console.WriteLine("Vous avez décidé de ne pas quitter le jeu."); // affiche un message pour dire que le joueur n'a pas quitté le jeu
                }
            }

            // si la saisie utilisateur est vide OU n'est pas une lettre unique OU n'est pas une lettre
            if (string.IsNullOrEmpty(userInput) || userInput.Length != 1 || !Char.IsLetter(userInput[0])) {
                Console.WriteLine("Veuillez entrer une lettre !"); // message d'erreur pour indiquer d'entrer une lettre
                continue; // passe à la suite
            } else {
                userLetter = Char.ToLower(userInput[0]); // convertit la lettre saisie en minuscule et l'enregistre dans une variable
            }

            // Parcourt chaque lettre du mot sélectionné pour voir si la lettre entrée par l'utilisateur est présente
            for (int i = 0; i < selectedWord.Length; i++) {
                if (selectedWord[i] == userLetter) {  // Si la lettre est trouvée, marque la lettre correspondante dans guessedLetters
                    guessedLetters[i] = true;
                    letterFound = true;
                }
            }

            if (!letterFound) { // Si la lettre n'est pas trouvée dans le mot
                 // Parcourt chaque lettre déjà essayée pour vérifier si la lettre a déjà été tentée
                foreach (string letter in foundedLetters) {
                    if (letter.ToString() == userLetter.ToString()) {
                        isFoundedLetter = true; // Marque que la lettre a déjà été entrée
                    }
                }

                if (!isFoundedLetter) { // Si la lettre n'a pas déjà été tentée
                    tries++; // nombre d'essais + 1

                    // Dessine la partie du pendu correspondant au nombre d'essais restants selon le niveau de difficulté
                    if (maxTries == 10) { 
                        DrawPenduLvl3(tries);
                    } else if (maxTries == 12) {
                        DrawPenduLvl2(tries);
                    } else if (maxTries == 14) {
                        DrawPenduLvl1(tries);
                    }

                    // message comme quoi la lettre n'est pas dans le mot
                    Console.WriteLine($"La lettre '{userLetter}' n'est pas dans le mot.");
                    Console.WriteLine(" ");
                    foundedLetters.Add(userLetter.ToString()); // Ajoute la lettre à la liste des lettres essayées

                } else if (isFoundedLetter) { // Si la lettre a déjà été tentée

                    // message comme quoi la lettre a déja été entrée
                    Console.WriteLine($"La lettre '{userLetter}' a déjà été entrée");
                    Console.WriteLine(" ");

                     // Dessine la partie du pendu correspondant au nombre d'essais restants selon le niveau de difficulté
                    if (maxTries == 10) {
                        DrawPenduLvl3(tries);
                    } else if (maxTries == 12) {
                        DrawPenduLvl2(tries);
                    } else if (maxTries == 14) {
                        DrawPenduLvl1(tries);
                    }

                    Console.WriteLine(" ");
                }
            } else { // Si la lettre est trouvée dans le mot
                // Dessine la partie du pendu correspondant au nombre d'essais restants selon le niveau de difficulté
                if (maxTries == 10) {
                    DrawPenduLvl3(tries);
                } else if (maxTries == 12) {
                    DrawPenduLvl2(tries);
                } else if (maxTries == 14) {
                    DrawPenduLvl1(tries);
                }

                // message indiquand que la lettre est dans le mot 
                Console.WriteLine($"La lettre '{userLetter}' est dans le mot !");
                Console.WriteLine(" ");
            }
            // etat du mot actuel
            Console.WriteLine("Mot actuel: ");

            // Affiche le mot partiellement deviné, remplaçant les lettres non devinées par des tirets
            for (int i = 0; i < selectedWord.Length; i++) {
                if (guessedLetters[i]) {
                    Console.Write(selectedWord[i]); // Si la lettre a été devinée, l'affiche
                } else {
                    Console.Write("_");  // Sinon, affiche un tiret
                } 
            }

            Console.WriteLine();

            foreach (bool found in guessedLetters) { // Vérifie si toutes les lettres du mot ont été devinées
                if (!found) {
                    wordGuessed = false; // S'il reste au moins une lettre non devinée: marque que le mot n'a pas été entièrement deviné
                    break;
                }
            }

            if (wordGuessed) { // Si toutes les lettres du mot ont été devinées, affiche un message de victoire
                // message de bravo
                Console.WriteLine(" ");
                Console.WriteLine($"BRAVO ! Vous avez trouvé le mot ! Le mot était : {selectedWord}");
                Console.WriteLine(" ");
                break;
            }
            
        }
        if (tries == maxTries) { // Si le nombre d'essais est épuisé, affiche un message de défaite avec le mot correct
            Console.WriteLine($"Vous êtes pendus... Le mot était : {selectedWord}"); // message de défaite
        }
    }

        // mes 3 fonctions de dessin de pendu selon le niveau de difficulté choisi
        static void DrawPenduLvl3(int attempts)
        {
            switch (attempts)
            {
                case 1:
                    Console.WriteLine("__|__");
                    break;
                case 2:
                    Console.WriteLine("  | ");
                    Console.WriteLine("  |");
                    Console.WriteLine("__|__");
                    break;
                case 3:
                    Console.WriteLine("  |");
                    Console.WriteLine("  | ");
                    Console.WriteLine("  | ");
                    Console.WriteLine("  |");
                    Console.WriteLine("__|__");
                    break;
                case 4:
                    Console.WriteLine("   ___");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("  |    ");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("  |");
                    Console.WriteLine("__|__");
                    break;
                case 5:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("__|__");
                    break;
                case 6:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("__|__");
                    break;
                case 7:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("__|__");
                    break;
                case 8:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|\\");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("__|__");
                    break;
                case 9:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|\\");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("__|__ /");
                    break;
                case 10:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|\\");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("__|__ / \\");
                    break;
                default:
                    Console.WriteLine(" ");
                    break;
            }
            Console.WriteLine();
        }
        static void DrawPenduLvl2(int attempts)
        {
            switch (attempts)
            {
                case 1:
                    Console.WriteLine("__|__");
                    break;
                case 2:
                    Console.WriteLine("  | ");
                    Console.WriteLine("  |");
                    Console.WriteLine("__|__");
                    break;
                case 3:
                    Console.WriteLine("  |");
                    Console.WriteLine("  | ");
                    Console.WriteLine("  | ");
                    Console.WriteLine("  |");
                    Console.WriteLine("__|__");
                    break;
                case 4:
                    Console.WriteLine("   ___");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("  |    ");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("  |");
                    Console.WriteLine("__|__");
                    break;
                case 5:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("__|__");
                    break;
                case 6:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("__|__");
                    break;
                case 7:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("__|__");
                    break;
                case 8:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("__|__");
                    break;
                case 9:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|\\");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("__|__");
                    break;
                case 10:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|\\");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("__|__");
                    break;
                case 11:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|\\");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("__|__ /");
                    break;
                case 12:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|\\");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("__|__ / \\");
                    break;
                default:
                    Console.WriteLine(" ");
                    break;
            }
            Console.WriteLine();
        }
        static void DrawPenduLvl1(int attempts)
        {
            switch (attempts)
            {
                case 1:
                    Console.WriteLine("____");
                    break;
                case 2:
                    Console.WriteLine("__|__");
                    break;
                case 3:
                    Console.WriteLine("  | ");
                    Console.WriteLine("  |");
                    Console.WriteLine("__|__");
                    break;
                case 4:
                    Console.WriteLine("  |    ");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("  |");
                    Console.WriteLine("__|__");
                    break;
                case 5:
                    Console.WriteLine("  |    ");
                    Console.WriteLine("  |    ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("  |  ");
                    Console.WriteLine("__|__");
                    break;
                case 6:
                    Console.WriteLine("   ___");
                    Console.WriteLine("  |    ");
                    Console.WriteLine("  |    ");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("__|__");
                    break;
                case 7:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    ");
                    Console.WriteLine("  |    ");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("__|__");
                    break;
                case 8:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("__|__");
                    break;
                case 9:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |   ");
                    Console.WriteLine("__|__");
                    break;
                case 10:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|");
                    Console.WriteLine("  |    ");
                    Console.WriteLine("__|__");
                    break;
                case 11:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|\\");
                    Console.WriteLine("  |    ");
                    Console.WriteLine("__|__ ");
                    break;
                case 12:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|\\");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("__|__  ");
                    break;
                case 13:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|\\");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("__|__ / ");
                    break;
                case 14:
                    Console.WriteLine("   ____");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("  |    O");
                    Console.WriteLine("  |   /|\\");
                    Console.WriteLine("  |    |");
                    Console.WriteLine("__|__ / \\");
                    break;
                default:
                    Console.WriteLine(" ");
                    break;
            }
            Console.WriteLine();
        }
}