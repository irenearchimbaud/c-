using System;

namespace _01td {
    public static class Exercice5
    {
        // Exercices 5
        public static int IsBiggerNumber(int[] array)
        {
            int biggerNumber = 0;
            foreach(int number in array ) {
                if (number > biggerNumber) {
                    biggerNumber = number;
                }
            }
            return biggerNumber;
        }
    }
}