using System;

namespace _03td {
    class Program
    {
        static void Main(string[] args)
        {
            // Exercice 1
            Exercice1.FirstAndLastCharacter("coucou");

            // Exercice 2
            int[] arrayExo2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            Exercice2.ShuffleArray(arrayExo2);

            foreach (var item in arrayExo2)
            {
                Console.Write($" {item}");
            };

            // Exercice 3
            Console.WriteLine(" ");
            Exercice3.isNumber(-6);

            // Exercice 4
            Console.WriteLine(Exercice4.ManyTimeNumber([5, 3, 8, 7], 5));
            
        }
    }
}