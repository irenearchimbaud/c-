using System;

namespace _01td {
    class Program
    {
        static void Main(string[] args)
        {
            // Exercice 1
            int[] myArray = [1, 2, 3, 4, 5, 6, 7];
            Console.WriteLine(Exercice1.Search(myArray, 1));

            // Exercice 2
            Console.WriteLine(Exercice2.InversedString("hello ça va ?"));

            // Exercice 3
            Console.WriteLine(Exercice3.CountVowels("aaaiiihhhgggiiie"));

            // Exercice 4
            Console.WriteLine(Exercice4.AddNumbers(myArray));

            // Exercice 5
            Console.WriteLine(Exercice5.IsBiggerNumber(myArray));
        }
    }
}