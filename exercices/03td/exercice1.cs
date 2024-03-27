using System;

namespace _03td {
    public static class Exercice1
    {
        // Exercices 1
        public static void FirstAndLastCharacter(string word)
        {
            int lastIndex = word.Length - 1;
            Console.WriteLine($"{word[0]}{word[lastIndex]}");
        }
    }
}