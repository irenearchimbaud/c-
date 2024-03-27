using System;

namespace _01td {
    public static class Exercice4
    {
        // Exercices 4
        public static int AddNumbers(int[] array)
        {
            int previousNumber = 0;
            foreach(int number in array ) {
                previousNumber = previousNumber + number;
            }
            return previousNumber;
        }
    }
}