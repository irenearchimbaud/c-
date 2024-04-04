namespace justePrix;

class Program
{
    static void Main(string[] args) {
        bool isInGame = true;
        
        while (isInGame) {

            int maxTry;
            int numberTries;
            bool isGameWin = false;

            while (true) {
                Console.WriteLine(" ");
                Console.Write(" 👉 Veuillez choisir un nombre de tours: ");

                string? numberReadLine = Console.ReadLine();

                if (int.TryParse(numberReadLine, out int number)) {
                    numberTries = Convert.ToInt32(number);
                    maxTry = Convert.ToInt32(number);
                    break;
                } else if(numberReadLine != null && numberReadLine.ToLower() == "q") {
                    return;
                } else {
                    Console.WriteLine("Veuillez entrer un nombre valide !");
                }
            }


            int tries = 0;
            Random random = new Random();
            int randomNumber = random.Next(1, 10000);

            for(int i = 0; i < maxTry; i++) {

                Console.WriteLine(" ");
                Console.Write($"Il vous reste {numberTries} tentatives. Devinez le nombre (entre 1 et 10 000) 😁😁😁 : ");
                string? userType = Console.ReadLine();

                if (int.TryParse(userType, out int userNumber)) {
                    if (userNumber < randomNumber) {
                        Console.WriteLine("                ----- 🔼 C'est plus ! :D-----");
                        Console.WriteLine(" ");
                        numberTries--;
                        tries++;
                    } else if (userNumber > randomNumber) {
                        Console.WriteLine("              ----- 🔽 C'est moins ! :D-----");
                        Console.WriteLine(" ");
                        numberTries--;
                        tries++;
                    } else if (userNumber == randomNumber) {
                        numberTries--;
                        tries++;
                        Console.WriteLine(" ");
                        Console.WriteLine($"🎉 Bravo !! Vous avez gagné. Le nombre choisi par l'ordinateur était {randomNumber}. Vous avez effectué {tries} tentatives. 🎉💪");
                        Console.WriteLine(" ");
                        isGameWin = true;
                        break;
                    }
                } else if(userType != null && userType.ToLower() == "q") {
                    return;
                } else {
                    i--;
                    Console.WriteLine("Veuillez entrer un nombre valide !");
                }

            }

            if(tries == maxTry && !isGameWin) {
                Console.WriteLine(" ");
                Console.WriteLine($"❌❌❌ Vous avez effectué {maxTry} tentatives. Vous avez perdu. Le nombre de l'ordinateur était {randomNumber} ❌❌❌");
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            Console.Write($"Voulez vous rejouer (tapez oui pour rejouer et n'importe quelle autre touches pour quitter): ");

            string? retry = Console.ReadLine();

            if(retry.ToLower() != "oui") {
                isInGame = false;
                Console.WriteLine("");
                Console.WriteLine("Vous avez quitté le jeu.");
            }

        }
    }
        
}
