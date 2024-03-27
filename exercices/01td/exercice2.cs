using System;

namespace _01td {
    public static class Exercice2
    {
        // Exercices 2
        public static string InversedString(string message)
        {
            char[] myMessage = message.ToCharArray();
            Array.Reverse(myMessage);
            return new string(myMessage);
        }
    }
}