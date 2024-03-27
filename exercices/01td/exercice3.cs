using System;

namespace _01td {
    public static class Exercice3
    {
        // Exercices 3
        public static int CountVowels(string message)
        {
            char[] myMessage = message.ToCharArray();
            int i = 0;
            foreach(char character in myMessage ) {
                switch (character) 
                {
                    case 'a':
                        i++;
                        break;
                    case 'e':
                        i++;
                        break;
                    case 'i':
                        i++;
                        break;
                    case 'o':
                        i++;
                        break;
                    case 'u':
                        i++;
                        break;
                    case 'y':
                        i++;
                        break;
                    case 'A':
                        i++;
                        break;
                    case 'E':
                        i++;
                        break;
                    case 'I':
                        i++;
                        break;
                    case 'O':
                        i++;
                        break;
                    case 'U':
                        i++;
                        break;
                    case 'Y':
                        i++;
                        break;
                }
            }
            return i;
        }
    }
}