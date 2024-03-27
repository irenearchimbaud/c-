namespace justePrix;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");
        Console.Write(" 👉 Veuillez choisir un nombre de tours: ");
        int numberTries = Convert.ToInt32(Console.ReadLine());
        int maxTry = numberTries;
        int tries = 0;
        Random random = new Random();
        int randomNumber = random.Next(1, 10000);

        for(int i = 0; i < maxTry; i++) {
        Console.WriteLine(" ");
        Console.Write($"Il vous reste {numberTries} tentatives. Devinez le nombre (entre 1 et 10 000) 😁😁😁 : ");
        string? userType = Console.ReadLine();

            if (userType == null)
            {
                Console.WriteLine("Veuillez selectionner un nombre.");
                return;
            }

            if (userType == "q") {
                break;
            } else {
                int userNumber = int.Parse(userType);
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
                    break;
                }
            }
        }

        if(tries == maxTry) {
            Console.WriteLine(" ");
            Console.WriteLine($"❌❌❌ Vous avez effectué {maxTry} tentatives. Vous avez perdu. Le nombre de l'ordinateur était {randomNumber} ❌❌❌");
            Console.WriteLine(" ");
        }
    }
        
}
