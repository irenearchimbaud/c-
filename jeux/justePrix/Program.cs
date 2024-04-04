namespace justePrix;

class Program
{
    static void Main(string[] args) {
        bool isInGame = true; // Variable pour déterminer si le joueur est dans le jeu
        
        while (isInGame) { // Boucle principale du jeu

            int maxTry; // Nombre maximum d'essais
            int numberTries; // Nombre d'essais restants
            bool isGameWin = false; // Indique si le joueur a gagné la partie

            while (true) { // Boucle pour choisir le nombre de tentatives
                // message pour choisir le nombre de tours
                Console.WriteLine(" ");
                Console.Write(" 👉 Veuillez choisir un nombre de tours: ");

                string? numberReadLine = Console.ReadLine(); // enregistre lka réponse dans une variable

                if (int.TryParse(numberReadLine, out int number)) { // Vérifie si l'entrée peut être convertie en nombre
                    numberTries = Convert.ToInt32(number);  // Initialise le nombre d'essais restants
                    maxTry = Convert.ToInt32(number); // Initialise le nombre maximum d'essais
                    break; // Sort de la boucle
                } else if(numberReadLine != null && numberReadLine.ToLower() == "q") {
                    return; // Quitte le jeu si l'utilisateur entre "q"
                } else {
                    // message d'erreur indiquant que l'entrée utilisateur n'est pas valide
                    Console.WriteLine("Veuillez entrer un nombre valide !");
                }
            }


            int tries = 0; // Compteur d'essais
            Random random = new Random(); // Générateur de nombres aléatoires
            int randomNumber = random.Next(1, 10000); // Génère un nombre aléatoire entre 1 et 10000

            for(int i = 0; i < maxTry; i++) { // Boucle pour permettre au joueur de deviner le nombre

                // message pour deviner le nombre choisi par l'ordinateur
                Console.WriteLine(" ");
                Console.Write($"Il vous reste {numberTries} tentatives. Devinez le nombre (entre 1 et 10 000) 😁😁😁 : ");
                string? userType = Console.ReadLine(); // on enregistre la réponse dans une variable

                if (int.TryParse(userType, out int userNumber)) { // Vérifie si l'entrée peut être convertie en nombre
                    // Compare le nombre deviné avec le nombre aléatoire
                    if (userNumber < randomNumber) {
                        // si le nombre entré est plus petit, message comme quoi c'est moins
                        Console.WriteLine("                ----- 🔼 C'est plus ! :D-----");
                        Console.WriteLine(" ");
                        numberTries--; // nombre d'essais restants - 1 
                        tries++; // essais en cours + 1 
                    } else if (userNumber > randomNumber) {
                        // si le nombre entré est plus grand, message comme quoi c'est plus
                        Console.WriteLine("              ----- 🔽 C'est moins ! :D-----");
                        Console.WriteLine(" ");
                        numberTries--; // nombre d'essais restants - 1 
                        tries++; // essais en cours + 1 
                    } else if (userNumber == randomNumber) {
                        numberTries--; // nombre d'essais restants - 1 
                        tries++; // essais en cours + 1 
                        // si le nombre entré est le meme, message de victoire
                        Console.WriteLine(" ");
                        Console.WriteLine($"🎉 Bravo !! Vous avez gagné. Le nombre choisi par l'ordinateur était {randomNumber}. Vous avez effectué {tries} tentatives. 🎉💪");
                        Console.WriteLine(" ");
                        isGameWin = true; // Définit que le joueur a gagné la partie
                        break; // Sort de la boucle
                    }
                } else if(userType != null && userType.ToLower() == "q") { // si l'utilisateur entre q
                    return; // Quitte le jeu si l'utilisateur entre q
                } else {
                    i--; // i - 1 pour permettre a l'utilisateur de réesayer
                    Console.WriteLine("Veuillez entrer un nombre valide !"); // Message d'erreur si l'entrée n'est pas valide
                }

            }

            // Vérifie si le joueur a épuisé tous ses essais sans gagner
            if(tries == maxTry && !isGameWin) {
                // message de défaite
                Console.WriteLine(" ");
                Console.WriteLine($"❌❌❌ Vous avez effectué {maxTry} tentatives. Vous avez perdu. Le nombre de l'ordinateur était {randomNumber} ❌❌❌");
                Console.WriteLine(" ");
            }

            // message pour rejouer
            Console.WriteLine(" ");
            Console.Write($"Voulez vous rejouer (tapez oui pour rejouer et n'importe quelle autre touches pour quitter): ");

            string? retry = Console.ReadLine(); // on enregistre la réponse dans une variable

            if(retry.ToLower() != "oui") { // si la réponse n'est pas oui
                isInGame = false; // Définit que le joueur a quitté le jeu
                Console.WriteLine("");
                Console.WriteLine("Vous avez quitté le jeu."); // message indiquant que le joueur a quitté le jeu 
            }
        }
    }
}
