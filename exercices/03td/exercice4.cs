using System;

namespace _03td {
    public static class Exercice4
    {
        // Exercices 4
        public static int ManyTimeNumber(int[] array, int myNumber)
        {
            int howManyTime = 0;
            foreach (int number in array) {
                if (number == myNumber) {
                    howManyTime++;
                }
            }
            return howManyTime;
        }
    }
}