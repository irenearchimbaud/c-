using System;

namespace _02td {
    public static class Exercice4
    {
        // Exercices 4
        public static void CalculateMultiples(int myNumber){
            for (int i = 1; i <= 10; i++){
                int multiple = myNumber * i;
                Console.Write("{0} ", multiple);
            }
            Console.WriteLine();
        }
    }
}