namespace pendu;

class Program {
    static void Main(string[] args) {

        int maxTries = 12;
        int tries = 0;
        string[] wordsList = { "coucou", "maquillage", "mouette", "photographie", "ananas", "aurevoir", "paris" };
        int wordsListLength = wordsList.Length;
        Random random = new Random();
        string selectedWord = wordsList[random.Next(wordsListLength)];
        bool[] guessedLetters = new bool[selectedWord.Length];
        List<string> foundedLetters = new List<string>();

        Console.WriteLine(" ");
        Console.WriteLine("Bienvenue dans le pendu. Vous pouvez taper ! à tout moment pour quitter le jeu.");
        Console.WriteLine(" ");
        Console.Write("Veuillez selectionner votre niveau de difficulté (1 = facile; 2 = moyen; 3 = difficile) OU quittez le jeu en cliquant sur !: ");

        string? difficultLevel = Console.ReadLine();

        while(difficultLevel != "1" && difficultLevel != "2" && difficultLevel != "3")
        {
            if(difficultLevel == "!")
            {
                Console.WriteLine("êtes-vous sûrs de vouloir quitter le jeu ? (Tapez oui pour quiter)");

                string? exitJeux = Console.ReadLine();

                if(exitJeux != null && exitJeux.ToLower() == "oui")
                {
                    Console.WriteLine("Vous avez quitté le jeu.");
                    return;
                }
                else
                {
                    Console.WriteLine("Vous avez décidé de ne pas quitter le jeux");
                }
                
            }
            else
            {
                Console.WriteLine("Merci de selecctionner un chiffre entre 1 et 3");
            }

            Console.WriteLine(" ");
            Console.Write($"$Veuillez selectionner votre niveau de difficulté (1 = facile; 2 = moyen; 3 = difficile) OU quittez le jeu en cliquant sur !: ");
            

            difficultLevel = Console.ReadLine();
        }

        switch (difficultLevel) {
            case "1":
                maxTries = 14;
                break;
            case "2":
                maxTries = 12;
                break;
            case "3":
                maxTries = 10;
                break;

        }

        while (tries < maxTries) {
            Console.WriteLine(" ");
            Console.WriteLine($"Essais restants : {maxTries - tries}");
            Console.WriteLine(" ");
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine(" ");
            Console.Write("Choisissez votre lettre : ");
            string? userInput = Console.ReadLine();
            bool isFoundedLetter = false;
            char userLetter;
            bool letterFound = false;
            bool wordGuessed = true;

            if (userInput == "!") {
                Console.WriteLine("Etes-vous sur de vouloir quitter le jeu ? (Tapper oui pour quiter)");

                string? exitJeux = Console.ReadLine();

                if(exitJeux != null && exitJeux.ToLower() == "oui")
                {
                    Console.WriteLine("Vous avez quitté le jeu.");
                    return;
                }
                else
                {
                    Console.WriteLine("Vous avez décidé de ne pas quitter le jeux");
                }
            }

            if (string.IsNullOrEmpty(userInput) || userInput.Length != 1 || !Char.IsLetter(userInput[0])) {
                Console.WriteLine("Veuillez entrer une lettre !");
                continue;
            } else {
                userLetter = Char.ToLower(userInput[0]);
            }

            for (int i = 0; i < selectedWord.Length; i++) {
                if (selectedWord[i] == userLetter)
                {
                    guessedLetters[i] = true;
                    letterFound = true;
                }
            }

            if (!letterFound) {
                foreach (string letter in foundedLetters) {
                    if (letter.ToString() == userLetter.ToString()) {
                        isFoundedLetter = true;
                        
                    }
                }

                if (!isFoundedLetter) {
                    tries++;

                    if (maxTries == 10) {
                        DrawPenduLvl3(tries);
                    } else if (maxTries == 12) {
                        DrawPenduLvl2(tries);
                    } else if (maxTries == 14) {
                        DrawPenduLvl1(tries);
                    }

                    Console.WriteLine($"La lettre '{userLetter}' n'est pas dans le mot.");
                    Console.WriteLine(" ");
                    foundedLetters.Add(userLetter.ToString());

                } else if (isFoundedLetter) {

                    Console.WriteLine($"La lettre '{userLetter}' a déja été entrée");
                    Console.WriteLine(" ");

                    if (maxTries == 10) {
                        DrawPenduLvl3(tries);
                    } else if (maxTries == 12) {
                        DrawPenduLvl2(tries);
                    } else if (maxTries == 14) {
                        DrawPenduLvl1(tries);
                    }

                    Console.WriteLine(" ");
                }
            } else {
                if (maxTries == 10) {
                    DrawPenduLvl3(tries);
                } else if (maxTries == 12) {
                    DrawPenduLvl2(tries);
                } else if (maxTries == 14) {
                    DrawPenduLvl1(tries);
                }

                Console.WriteLine($"La lettre '{userLetter}' est dans le mot !");
                Console.WriteLine(" ");
            }
            Console.WriteLine("Mot actuel: ");

            for (int i = 0; i < selectedWord.Length; i++) {
                if (guessedLetters[i])
                {
                    Console.Write(selectedWord[i]);
                } else
                {
                    Console.Write("_");
                }
            }

            Console.WriteLine();

            foreach (bool found in guessedLetters) {
                if (!found)
                {
                    wordGuessed = false;
                    break;
                }
            }

            if (wordGuessed) {
                Console.WriteLine(" ");
                Console.WriteLine($"BRAVO ! Vous avez trouvé le mot ! Le mot était : {selectedWord}");
                Console.WriteLine(" ");
                break;
            }
            
        }
        if (tries == maxTries) {
            Console.WriteLine($"Vous êtes pendus... Le mot était : {selectedWord}");
        }
    }

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