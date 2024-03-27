using System;

namespace _03td {
    public static class Exercice3
    {
        // Exercices 3
        public static void isNumber(int myNumber)
        {
            if (myNumber == 0) {
                Console.WriteLine("Votre nombre est zero.");
            } else if (myNumber < 0) {
                Console.WriteLine("Votre nombre est négatif.");
            } else if (myNumber > 0) {
                Console.WriteLine("Votre nombre est positif.");
            }
        }
    }
}