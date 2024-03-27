using System;

namespace _01td {
    public static class Exercice1
    {
        // Exercices 1
        public static bool Search(int[] array, int myNumber)
        {
            bool myBoolean = false;
            foreach(int number in array ) {
                if (number == myNumber) {
                    myBoolean = true;
                }
            }
            return myBoolean;
        }
    }
}