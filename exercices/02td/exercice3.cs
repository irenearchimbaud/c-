using System;

namespace _02td {
    public static class Exercice3
    {
        // Exercices 3
        public static void IsPeer(int myNumber)
        {
            int modulo = myNumber % 2;
            if(modulo == 1){
                Console.WriteLine(myNumber + " est un nombre impaire");
            } else if(modulo == 0) {
                Console.WriteLine(myNumber + " est un nombre paire");
            }
        }
    }
}